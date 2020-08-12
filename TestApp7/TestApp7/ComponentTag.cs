

using System;
using System.Collections;
using System.Xml.Linq;

class ComponentTag : IComparable
{
    public string Id { get; set; }
    public double Order { get; set; }
    public string OtherTag { get; set; }

    public int CompareTo(object obj)
    {
        if (obj is ComponentTag)
        {
            return this.Order.CompareTo((obj as ComponentTag).Order);
        }
        throw new ArgumentException("object is not ComponentTag");
    }

    public XElement GetXElement()
    {
        string data= string.Format(@"<tag id=""{0}"" order=""{1}""></tag>", Id, Order, OtherTag);
        return XElement.Parse(data);
    }

    public override string ToString()
    {
        return string.Format("id={0} order={1} other tag={2}", Id, Order, OtherTag);
    }
}

