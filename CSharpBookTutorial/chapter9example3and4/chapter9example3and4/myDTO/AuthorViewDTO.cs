using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class AuthorViewDTO : DTOFactory,IDTO
    {
        public BindingList<KeyValuePair<short, Author>> BindingList { get; protected set; }
        public TextBox TxtName { get; private set; }
        public ListBox LstPhone { get; private set; }
        public TextBox TxtEmail { get; private set; }

        public AuthorViewDTO(TextBox txtIndex, TextBox txtName, ListBox lstPhone ,TextBox txtEmail, BindingList<KeyValuePair<short, Author>> bindingList) : base(txtIndex)
        {
            BindingList = bindingList;
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            SetDefaultTxtIndexHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataInfoHandle += SetTextBoxDataInfo;
            TxtName = txtName;
            LstPhone = lstPhone;
            TxtEmail = txtEmail;
        }
        public void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone phone = ((KeyValuePair<short, Phone>)LstPhone.SelectedItem).Value;
                Author.SetAuthor(TransformIndex(TxtIndex), TxtName.Text.ToString(), phone, TxtEmail.Text.ToString());
                BindingList.ResetBindings();
            } 
        }
        public void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Author.RemoveAuthor(index);
            }
        }
        public void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtName.Text = Author.GetAuthor(index).Name;
            LstPhone.Text = Author.GetAuthor(index).Phone.Tag;
            TxtEmail.Text = Author.GetAuthor(index).Email;
        }

        public void ArrayIndexTextBoxAutoResize( short offset)
        {
            if (ArrayIndexTextBoxAutoResize(offset, Author.Max) != -1)
            {
                SetTextBoxDataInfo();
            }
        }
    }
}
