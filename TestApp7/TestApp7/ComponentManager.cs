using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

class ComponentManager
/* xml 格式
<?xml version="1.0" encoding="utf-8" ?>
<componentManager>
    <ctrl-name>
        <tag id = "same of Tag" order="order value"></tag>
    </ctrl-name>
</componentManager>
*/

{
    public static XElement xml;
    private static string xmlName;
    private string Id { get; set; }
    private int Order { get; set; }
    private string Tag { get; set; }

    public static void SetXml(string name)
    {
        xml = XElement.Load(name);
        xmlName = name;
    }


    public static T[] CreateComponentArray<T>(Control @base) where T : Control
    {
        return CreateComponentArrayRelay<T>(@base, null, false);
    }
    public static T[] CreateComponentArray<T>(Control @base, string name) where T : Control
    {
        return CreateComponentArrayRelay<T>(@base, name, true);
    }

    private static T[] CreateComponentArrayRelay<T>(Control @base, string name, bool filterByName) where T : Control
    {
        T[] ctrls = FilterAndCreateComponentTag<T>(@base, name, filterByName);
        UpdateComponentTagCheckXML(ctrls, name);
        SortComponentArray(ctrls);
        ResetXML(ctrls, name);
        return ctrls;
    }

    private static void ResetXML<T>(T[] ctrls, string name) where T : Control
    {
        if (name != null)
        {
            xml.Element(name).RemoveAll();
            foreach (Control ctrl in ctrls)
            {
                xml.Element(name).Add(((ComponentTag)ctrl.Tag).GetXElement());
            }
            xml.Save(xmlName);
        }
    }

    private static void SortComponentArray<T>(T[] ctrls) where T : Control
    {
        Array.Sort(ctrls, delegate (Control ctrl1, Control ctrl2)
        {
            return ((ComponentTag)ctrl1.Tag).CompareTo((ComponentTag)ctrl2.Tag);
        });
        int ptr = 0;
        foreach (Control ctrl in ctrls)
        {
            ((ComponentTag)ctrl.Tag).Order = ptr++;
        }
    }

    private static void UpdateComponentTagCheckXML<T>(T[] ctrls, string name) where T : Control
    {
        XElement elem;
        if ((elem = xml.Element(name)) != null)
        {
            XElement[] subElems = elem.Elements("tag").ToArray();
            foreach (Control ctrl in ctrls)
            {
                try
                {
                    XElement subElem = subElems.First(e => e.Attribute("id").Value.Equals(((ComponentTag)ctrl.Tag).Id));
                    ((ComponentTag)ctrl.Tag).Order = Convert.ToInt32(subElem.Attribute("order").Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }

    private static T[] FilterAndCreateComponentTag<T>(Control @base, string name, bool filterByName) where T : Control
    {
        T[] ctrls = null;
        ctrls = @base.Controls.OfType<T>().Where<T>(ctrl =>
        {
            string[] s = ctrl.Tag.ToString().Split(':');
            if (filterByName == true && !s[0].Trim().Equals(name)) return false;
            ComponentTag tag = new ComponentTag();
            string id = null;
            double order = 0;
            try
            {
                string sid = filterByName ? s[1] : s.Length == 1 ? s[0] : s[1];
                id = sid;
                order = Convert.ToDouble(sid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            tag.Id = id;
            tag.Order = order;
            tag.OtherTag = null;
            ctrl.Tag = tag;
            return true;
        }).ToArray();
        return ctrls;
    }

    private static T[] FilterAndCreateComponentTag<T>(Control @base, string name, XElement xml) where T : Control
    {
        T[] ctrls = FilterAndCreateComponentTag<T>(@base, name, true);

        return ctrls;
    }
}

