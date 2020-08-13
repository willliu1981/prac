using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class PhoneViewDTO : DTOFactory,IDTO
    {
        public BindingList<KeyValuePair<short, Phone>> BindingList { get; protected set; }
        public TextBox TxtTag { get; private set; }
        public TextBox TxtHomePhone { get; private set; }
        public TextBox TxtOfficePhone { get; private set; }

        public TextBox TxtCellPhone { get; private set; }


        public PhoneViewDTO(TextBox txtIndex, TextBox txtTag, TextBox txtHomePhone,TextBox txtOfficePhone,
            TextBox txtCellPhone,BindingList<KeyValuePair<short, Phone>> bindingList) : base(txtIndex)
        {
            BindingList = bindingList;
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            TxtTag = txtTag;
            TxtHomePhone = txtHomePhone;
            TxtOfficePhone = txtOfficePhone;
            TxtCellPhone = txtCellPhone;
        }
        public void SetData()
        {
            Phone.SetPhone(TransformIndex(TxtIndex), TxtTag.Text.ToString(), TxtHomePhone.Text.ToString(),
                TxtOfficePhone.Text.ToString(), TxtCellPhone.Text.ToString());
            BindingList.ResetBindings();
        }
        public void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtTag.Text = Phone.GetPhone(index).Tag;
            TxtHomePhone.Text = Phone.GetPhone(index).HomrPhone;
            TxtOfficePhone.Text = Phone.GetPhone(index).OfficePhone;
            TxtCellPhone.Text = Phone.GetPhone(index).CellPhone;
        }

        public void ArrayIndexTextBoxAutoResize(short offset)
        {
            short targetIdx;
            if ((targetIdx = ArrayIndexTextBoxAutoResize(offset, Phone.Max)) != -1)
            {
                SetTextBoxDataInfo();
            }
        }
    }
}
