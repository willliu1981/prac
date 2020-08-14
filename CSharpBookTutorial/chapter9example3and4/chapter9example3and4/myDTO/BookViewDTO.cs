using chapter9example3and4.myDTO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace chapter9example3and4
{
    class BookViewDTO : DTOFactory, IDTO
    {
        public TextBox TxtNo { get; private set; }
        public TextBox TxtTitle { get; private set; }
        public ListBox LstAuthor { get; private set; }
        public TextBox TxtPrice { get; private set; }


        public BookViewDTO(TextBox txtIndex, TextBox txtNo, TextBox txtTitle, ListBox lstAuthor, TextBox txtPrice) : base(txtIndex)
        {
            ArrayIndexTextBoxAutoResizeHandle += ArrayIndexTextBoxAutoResize;
            SetDefaultTxtIndexHandle += SetDefaultTxtIndex;
            SetDefaultTextBoxDataInfoHandle += SetTextBoxDataInfo;
            TxtNo = txtNo;
            TxtTitle = txtTitle;
            LstAuthor = lstAuthor;
            TxtPrice = txtPrice;
        }
        public void ArrayIndexTextBoxAutoResize(short offset)
        {
            if (ArrayIndexTextBoxAutoResize(offset, Book.Max) != -1)
            {
                SetTextBoxDataInfo();
            }
        }

        public void SetData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Author author =((KeyValuePair<short,Author>) LstAuthor.SelectedItem).Value;
                Book.SetBook(index, TxtNo.Text.ToString(), TxtTitle.Text.ToString(), author, TxtPrice.Text.ToString());
            }
        }
        public void RemoveData()
        {
            short index = TransformIndex(TxtIndex, true);
            if (index != -1)
            {
                Book.RemoveBook(index);
            }
        }

        public void SetTextBoxDataInfo()
        {
            short index = TransformIndex(TxtIndex);
            TxtNo.Text = Book.GetBook(index).No;
            TxtTitle.Text = Book.GetBook(index).Title;
            LstAuthor.Text = Book.GetBook(index).Author.Name;
            TxtPrice.Text = Book.GetBook(index).Price.ToString();
        }
    }
}
