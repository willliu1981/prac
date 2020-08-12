using System;
using System.Collections.Generic;

namespace chapter9example3and4
{
    public class Phone
    {
        public static int Max
        {
            get { return Instance.Count; }
        }
        private static Dictionary<Int16, Phone> _instance;
        private static Dictionary<Int16, Phone> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dictionary<Int16, Phone>();
                    CreateNewDefaultPhoneInstance();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public string Tag { get; private set; }

        public string HomrPhone { get; private set; }
        public string OfficePhone { get;private set; }

        public string CellPhone { get; private set; }

        private Phone()
        {
        }

        public static Phone GetPhone(short index)
        {
            Phone phone;
            if (!Instance.TryGetValue(index, out phone))
            {
                phone = new Phone();
            }
            return phone;
        }

        private static void CreateNewDefaultPhoneInstance()
        {
            Phone p = new Phone();
            p.Tag = "David";
            p.HomrPhone = "03-778899";
            p.OfficePhone = "02-12125656";
            p.CellPhone = "0988116688";
            Instance.Add(1, p);
            p = new Phone();
            p.Tag = "Mary";
            p.HomrPhone = "06-232323";
            p.OfficePhone = "04-876543";
            p.CellPhone = "0911223344";
            Instance.Add(2, p);
            p = new Phone();
            p.Tag = "John";
            p.HomrPhone = "038-543211";
            p.OfficePhone = "03-969696";
            p.CellPhone = "0932565656";
            Instance.Add(3, p);
        }

        public static void SetPhone(short index,string tag, string home, string office, string cellphone)
        {
            Phone phone;
            if (!Instance.TryGetValue(index, out phone))
            {
                phone = new Phone();
            }
            phone.Tag = tag;
            phone.HomrPhone = home;
            phone.OfficePhone = office;
            phone.CellPhone = cellphone;
            Instance.Add(index, phone);
        }

        public static void RemovePhone(short index)
        {
            if (Instance.ContainsKey(index))
            {
                Instance.Remove(index);
            }
        }

        public static Phone CreateEmptyInstance()
        {
            return new Phone();
        }
    }
}