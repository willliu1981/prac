using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    abstract class DTOFactory
    {
        protected delegate void OverrideHandle(short offset);
        protected event OverrideHandle ArrayIndexTextBoxAutoResizeHandle;

        public TextBox TxtIndex { get; protected set; }

        public DTOFactory(TextBox txtIndex)
        {
            TxtIndex = txtIndex;
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
        public static short TransformIndex(TextBox value, bool verify)
        {
            return TransformIndex(value.Text.ToString(), 0, verify);
        }
        public static short TransformIndex(TextBox value)
        {
            return TransformIndex(value.Text.ToString(), 0, false);
        }

        public static short TransformIndex(string value)
        {
            return TransformIndex(value, 0, false);
        }
        public static short TransformIndex(TextBox value, short increase)
        {
            return TransformIndex(value.Text.ToString(), increase, false);
        }
        public static short TransformIndex(string value, short increase, bool verify)
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
        public static short TransformIndex(string value, short increase)
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
        public void ArrayIndexTextBoxAutoResize() { ArrayIndexTextBoxAutoResizeHandle?.Invoke(0); }
        public short ArrayIndexTextBoxAutoResize(short offset, int max)
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
            return targetIdx;
        }

    }
}
