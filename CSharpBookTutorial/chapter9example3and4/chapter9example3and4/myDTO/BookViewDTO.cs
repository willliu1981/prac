using chapter9example3and4.myDTO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter9example3and4
{
    class BookViewDTO : DTOFactory
    {
        public TextBox TxtNo { get; private set; }
        public TextBox TxtTitle { get; private set; }
        public ListBox LstAuthor { get; private set; }
        public TextBox TxtPrice { get; private set; }

        public BookViewDTO(TextBox txtIndex, TextBox txtNo, TextBox txtTitle, ListBox lstAuthor, TextBox txtPrice) : base(txtIndex)
        {
            SetDefaultTextBoxDataHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataHandle += SetTextBoxDataInfo;
            SetDataInfoHandle += SetTextBoxDataInfo;
            ShowHandle += Show;

            TxtNo = txtNo;
            TxtTitle = txtTitle;
            LstAuthor = lstAuthor;
            TxtPrice = txtPrice;
        }

        public override DTOFactory SetOffset(short offset)
        {
            DataIndexResize(offset, Book.Max);
            return this;
        }

        public override void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Author author =((KeyValuePair<short,Author>) LstAuthor.SelectedItem).Value;
                Book.SetBook(index, TxtNo.Text.ToString(), TxtTitle.Text.ToString(), author, TxtPrice.Text.ToString());
                base.SetData();
            }
        }
        public override void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Book.RemoveBook(index);
                Show();
            }
        }

        protected override void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtNo.Text = Book.GetBook(index).No;
            TxtTitle.Text = Book.GetBook(index).Title;
            LstAuthor.Text = Book.GetBook(index).Author.Name;
            TxtPrice.Text = Book.GetBook(index).Price.ToString();
        }

        protected override void Show()
        {
            short index = TransformIndex(TxtIndex);
            TxtShow.Text = string.Format("no: {0,-10}\ttitle: {1,-10}\t$: {2,-10} \r\n" +
                "author: {3} \r\n" +
                "email: {4} \r\n" +
                "H-Phone: {5} \r\n" +
                "O-Phone: {6} \r\n" +
                "C-Phone:{7}" ,
                Book.GetBook(index).No, Book.GetBook(index).Title, Book.GetBook(index).Price,
                Book.GetBook(index).Author.Name,
                Book.GetBook(index).Author.Email,
                Book.GetBook(index).Author.Phone.HomePhone,
                Book.GetBook(index).Author.Phone.OfficePhone,
                Book.GetBook(index).Author.Phone.CellPhone);
        }
    }
}
