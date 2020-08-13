using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter9example3and4
{
    class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    class MyList: BindingList<Author>
    {
        public string Msg { get; set; }

        public bool RaisesItemChangedEvents
        {
            get;set;
        }

        public MyList(string msg)
        {
            this.Msg = msg;
        }
    }
}
