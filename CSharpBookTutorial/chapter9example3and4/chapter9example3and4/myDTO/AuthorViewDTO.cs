using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace chapter9example3and4.myDTO
{
    class AuthorViewDTO : DTOFactory
    {
        public BindingList<KeyValuePair<short, Author>> BindingList { get; protected set; }
        public TextBox TxtName { get; private set; }
        public ListBox LstPhone { get; private set; }
        public TextBox TxtEmail { get; private set; }

        public AuthorViewDTO(TextBox txtIndex, TextBox txtName, ListBox lstPhone ,TextBox txtEmail, BindingList<KeyValuePair<short, Author>> bindingList) : base(txtIndex)
        {
            SetDefaultTextBoxDataHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataHandle += SetTextBoxDataInfo;
            SetDataInfoHandle += SetTextBoxDataInfo;
            ShowHandle += Show;
            BindingList = bindingList;
            TxtName = txtName;
            LstPhone = lstPhone;
            TxtEmail = txtEmail;
        }
        public override DTOFactory SetOffset(short offset)
        {
            DataIndexResize(offset, Author.Max);
            return this;
        }
        public override void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Phone phone = ((KeyValuePair<short, Phone>)LstPhone.SelectedItem).Value;
                Author.SetAuthor(TransformIndex(TxtIndex), TxtName.Text.ToString(), phone, TxtEmail.Text.ToString());
                BindingList.ResetBindings();
                base.SetData();
            } 
        }
        public override void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Author.RemoveAuthor(index);
            }
        }
        protected override void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtName.Text = Author.GetAuthor(index).Name;
            LstPhone.Text = Author.GetAuthor(index).Phone.Tag;
            TxtEmail.Text = Author.GetAuthor(index).Email;
        }

        protected override void Show()
        {
            short index = TransformIndex(TxtIndex);
            TxtShow.Text = string.Format("name: {0,-10}\temail: {1} \r\n" +
                "H-Phone: {2} \r\n" +
                "O-Phone: {3} \r\n" +
                "C-Phone:{4}",
                Author.GetAuthor(index).Name, Author.GetAuthor(index).Email,
                Author.GetAuthor(index).Phone.HomePhone,
                Author.GetAuthor(index).Phone.OfficePhone,
                Author.GetAuthor(index).Phone.CellPhone);
        }
    }
}
