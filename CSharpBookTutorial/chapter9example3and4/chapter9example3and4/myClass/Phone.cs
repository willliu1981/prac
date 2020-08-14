using chapter9example3and4.myClass;
using System;
using System.Collections.Generic;

namespace chapter9example3and4
{
    class Phone : Card
    {
        private static Dictionary<Int16, Phone> _instance;
        public static Dictionary<Int16, Phone> Instance
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

        public string HomePhone { get; private set; }
        public string OfficePhone { get; private set; }

        public string CellPhone { get; private set; }

        private Phone()
        {
            HomePhone = "";
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
            p.HomePhone = "03-778899";
            p.OfficePhone = "02-12125656";
            p.CellPhone = "0988116688";
            SetPhone(1, p.Tag, p.HomePhone, p.OfficePhone, p.CellPhone);
            p = new Phone();
            p.Tag = "Mary";
            p.HomePhone = "06-232323";
            p.OfficePhone = "04-876543";
            p.CellPhone = "0911223344";
            SetPhone(2, p.Tag, p.HomePhone, p.OfficePhone, p.CellPhone);
            p = new Phone();
            p.Tag = "John";
            p.HomePhone = "038-543211";
            p.OfficePhone = "03-969696";
            p.CellPhone = "0932565656";
            SetPhone(3, p.Tag, p.HomePhone, p.OfficePhone, p.CellPhone);
        }

        public static void SetPhone(short index, string tag, string home, string office, string cellphone)
        {
            Phone phone;
            if (!Instance.TryGetValue(index, out phone))
            {
                phone = new Phone();
                Instance.Add(index, phone);
            }
            if (index > Max) Max = index;
            phone.Tag = tag;
            phone.HomePhone = home;
            phone.OfficePhone = office;
            phone.CellPhone = cellphone;
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
        public override string ToString()
        {
            return ""+Tag;
        }
    }
}