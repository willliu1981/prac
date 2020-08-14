using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class PhoneViewDTO : DTOFactory
    {
        public BindingList<KeyValuePair<short, Phone>> BindingList { get; protected set; }
        public TextBox TxtTag { get; private set; }
        public TextBox TxtHomePhone { get; private set; }
        public TextBox TxtOfficePhone { get; private set; }

        public TextBox TxtCellPhone { get; private set; }


        public PhoneViewDTO(TextBox txtIndex, TextBox txtTag, TextBox txtHomePhone, TextBox txtOfficePhone,
            TextBox txtCellPhone, BindingList<KeyValuePair<short, Phone>> bindingList) : base(txtIndex)
        {
            SetDefaultTextBoxDataHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataHandle += SetTextBoxDataInfo;
            SetDataInfoHandle += SetTextBoxDataInfo;
            ShowHandle += Show;
            BindingList = bindingList;
            TxtTag = txtTag;
            TxtHomePhone = txtHomePhone;
            TxtOfficePhone = txtOfficePhone;
            TxtCellPhone = txtCellPhone;
        }
        public override DTOFactory SetOffset(short offset)
        {
            DataIndexResize(offset, Phone.Max);
            return this;
        }
        public override void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone.SetPhone(TransformIndex(TxtIndex), TxtTag.Text.ToString(), TxtHomePhone.Text.ToString(),
                    TxtOfficePhone.Text.ToString(), TxtCellPhone.Text.ToString());
                BindingList.ResetBindings();
                base.SetData();
            }
        }
        public override void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone.RemovePhone(index);
            }
        }

        protected override void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtTag.Text = Phone.GetPhone(index).Tag;
            TxtHomePhone.Text = Phone.GetPhone(index).HomePhone;
            TxtOfficePhone.Text = Phone.GetPhone(index).OfficePhone;
            TxtCellPhone.Text = Phone.GetPhone(index).CellPhone;
        }

        protected override void Show()
        {
            short index = TransformIndex(TxtIndex);
            TxtShow.Text = string.Format("tag: {0} \r\n" +
                "H-Phone: {1} \r\n" +
                "O-Phone: {2} \r\n" +
                "C-Phone:{3}",
                Phone.GetPhone(index).Tag,
                Phone.GetPhone(index).HomePhone,
                Phone.GetPhone(index).OfficePhone,
                Phone.GetPhone(index).CellPhone);
        }
    }
}
