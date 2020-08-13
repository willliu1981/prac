using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class AuthorViewDTO : DTOFactory,IDTO
    {
        public BindingList<KeyValuePair<short, Author>> BindingList { get; protected set; }
        public TextBox TxtName { get; private set; }
        public TextBox TxtEmail { get; private set; }

        public AuthorViewDTO(TextBox txtIndex, TextBox txtName, TextBox txtEmail, BindingList<KeyValuePair<short, Author>> bindingList) : base(txtIndex)
        {
            BindingList = bindingList;
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            TxtName = txtName;
            TxtEmail = txtEmail;
        }
        public void SetData()
        {
            Phone phone = Phone.GetPhone(1);//for debug
            Author.SetAuthor(TransformIndex(TxtIndex), TxtName.Text.ToString(),phone, TxtEmail.Text.ToString());
            BindingList.ResetBindings();
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
            //txtPhone.Text = Author.GetAuthor(index).Phone.OfficePhone;
            TxtEmail.Text = Author.GetAuthor(index).Email;
        }

        public void ArrayIndexTextBoxAutoResize( short offset)
        {
            short targetIdx;
            if ((targetIdx = ArrayIndexTextBoxAutoResize(offset, Author.Max)) != -1)
            {
                SetTextBoxDataInfo();
            }
        }
    }
}
