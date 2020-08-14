﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class PhoneViewDTO : DTOFactory, IDTO
    {
        public BindingList<KeyValuePair<short, Phone>> BindingList { get; protected set; }
        public TextBox TxtTag { get; private set; }
        public TextBox TxtHomePhone { get; private set; }
        public TextBox TxtOfficePhone { get; private set; }

        public TextBox TxtCellPhone { get; private set; }


        public PhoneViewDTO(TextBox txtIndex, TextBox txtTag, TextBox txtHomePhone, TextBox txtOfficePhone,
            TextBox txtCellPhone, BindingList<KeyValuePair<short, Phone>> bindingList) : base(txtIndex)
        {
            BindingList = bindingList;
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            SetDefaultTxtIndexHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataInfoHandle += SetTextBoxDataInfo;
            TxtTag = txtTag;
            TxtHomePhone = txtHomePhone;
            TxtOfficePhone = txtOfficePhone;
            TxtCellPhone = txtCellPhone;
        }
        public void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone.SetPhone(TransformIndex(TxtIndex), TxtTag.Text.ToString(), TxtHomePhone.Text.ToString(),
                    TxtOfficePhone.Text.ToString(), TxtCellPhone.Text.ToString());
                BindingList.ResetBindings();
            }
        }
        public void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone.RemovePhone(index);
            }
        }

        public void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtTag.Text = Phone.GetPhone(index).Tag;
            TxtHomePhone.Text = Phone.GetPhone(index).HomePhone;
            TxtOfficePhone.Text = Phone.GetPhone(index).OfficePhone;
            TxtCellPhone.Text = Phone.GetPhone(index).CellPhone;
        }

        public void ArrayIndexTextBoxAutoResize(short offset)
        {
            if (ArrayIndexTextBoxAutoResize(offset, Phone.Max) != -1)
            {
                SetTextBoxDataInfo();
            }
        }
    }
}
