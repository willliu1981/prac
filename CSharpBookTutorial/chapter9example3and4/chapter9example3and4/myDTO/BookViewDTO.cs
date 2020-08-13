using chapter9example3and4.myDTO;
using System.Windows.Forms;

namespace chapter9example3and4
{
    class BookViewDTO : DTOFactory, IDTO
    {
        public TextBox TxtNo { get; private set; }
        public TextBox TxtTitle { get; private set; }
        public TextBox TxtPrice { get; private set; }


        public BookViewDTO(TextBox txtIndex, TextBox txtNo, TextBox txtTitle, TextBox txtPrice) : base(txtIndex)
        {
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            TxtNo = txtNo;
            TxtTitle = txtTitle;
            TxtPrice = txtPrice;
        }
        public void ArrayIndexTextBoxAutoResize(short offset)
        {
            short targetIdx;
            if ((targetIdx = ArrayIndexTextBoxAutoResize(offset, Book.Max)) != -1)
            {
                SetTextBoxDataInfo();
            }
        }

        public void SetData()
        {
            Author author = Author.GetAuthor(1);//for debug
            Book.SetBook(TransformIndex(TxtIndex), TxtNo.Text.ToString(), TxtTitle.Text.ToString(), author, TxtPrice.Text.ToString());
        }

        public void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtNo.Text = Book.GetBook(index).No;
            TxtTitle.Text = Book.GetBook(index).Title;
            //lstAuthor.Text = Book.GetBook(index).Author.Name;
            TxtPrice.Text = Book.GetBook(index).Price.ToString();
        }
    }

}
