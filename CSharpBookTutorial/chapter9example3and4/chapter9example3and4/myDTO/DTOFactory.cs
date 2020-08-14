using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    abstract class DTOFactory : Event, IDTO
    {

        protected static event OverrideHandle2 SetDefaultTextBoxDataHandle;
        protected event OverrideHandle2 SetDataInfoHandle;
        protected event OverrideHandle2 ShowHandle;

        protected TextBox TxtIndex { get; set; }
        protected short DataIndexMax { get; set; }

        protected static TextBox _txtShow;
        protected static TextBox TxtShow
        {
            get
            {
                if (_txtShow == null)
                {
                    _txtShow = new TextBox();
                }
                return _txtShow;
            }
            private set { _txtShow = value; }
        }
        protected DTOFactory(TextBox txtIndex)
        {
            TxtIndex = txtIndex;
        }

        public static void CreateTxtShow(TextBox txtShow)
        {
            TxtShow = txtShow;
        }
        private static Dictionary<View, IDTO> dtoPattern;
        public static void CreateDTO(params KeyValuePair<View, IDTO>[] pairs)
        {
            dtoPattern = new Dictionary<View, IDTO>();
            foreach (KeyValuePair<View, IDTO> pair in pairs)
            {
                dtoPattern.Add(pair.Key, pair.Value);
            }
        }

        public static IDTO GetDTO(View view)
        {
            return dtoPattern[view];
        }

        protected static short TransformIndex(TextBox value, bool verify)
        {
            return TransformIndex(value.Text.ToString(), 0, verify);
        }
        protected static short TransformIndex(TextBox value)
        {
            return TransformIndex(value.Text.ToString(), 0, false);
        }
        protected static short TransformIndex(TextBox value, short increase)
        {
            return TransformIndex(value.Text.ToString(), increase, false);
        }
        protected static short TransformIndex(string value, short increase, bool verify)
        {
            short myValue = TransformIndex(value, increase);
            if (verify)
            {
                if (myValue == -1)
                {
                    myValue = Convert.ToInt16(-1);
                }
            }
            else
            {
                if (myValue == -1)
                {
                    myValue = Convert.ToInt16(1);
                }
            }
            return myValue;
        }
        protected static short TransformIndex(string value, short increase)
        {
            Int16 index;
            try
            {
                index = Convert.ToInt16(value);
                index += increase;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                index = -1;
            }
            return index;
        }

        public static void SetDefaultTextBoxDataInfos()
        {
            SetDefaultTextBoxDataHandle?.Invoke();
        }
        protected void SetDefaultTxtIndex()
        {
            TxtIndex.Text = "1";
        }

        abstract protected void SetTextBoxDataInfo();
        abstract protected void Show();
        public void Flip()
        {
            SetDataInfoHandle?.Invoke();
            ShowHandle?.Invoke();
        }
        protected void DataIndexResize(short offset, int max)
        {
            Int16 targetIdx = -1;
            if (TxtIndex != null)
            {
                targetIdx = TransformIndex(TxtIndex, offset);
                if (targetIdx < 1)
                {
                    targetIdx = 1;
                }
                if (targetIdx > max)
                {
                    targetIdx = Convert.ToInt16(max + 1);
                }
                TxtIndex.Text = targetIdx.ToString();
            }
        }

        public virtual void SetData() { ShowHandle?.Invoke(); }
        abstract public void RemoveData();
        abstract public DTOFactory SetOffset(short offset);

        public void Focus()
        {
        }
    }
}
