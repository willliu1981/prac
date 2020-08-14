using chapter9example3and4.myDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace chapter9example3and4
{
    public partial class Form1 : Form
    {
        Color backColorFocus;
        Color backColorLostFocus;
        Color foreColorFocus;
        Color foreColorLostFocus;
        Label[] myAnchor;
        Panel[] myPanel;
        Label[] myLabel;


        public Form1()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            BindingList<KeyValuePair<short, Author>> blstAuthor
                = new BindingList<KeyValuePair<short, Author>>(Author.Instance.ToList<KeyValuePair<short, Author>>());
            blstAuthor.Add(new  KeyValuePair<short, Author>(-1,Author.CreateEmptyInstance()));
            lstAuthor.DisplayMember = "Value";
            lstAuthor.DataSource = blstAuthor;
            BindingList<KeyValuePair<short, Phone>> blstPhone
                = new BindingList<KeyValuePair<short, Phone>>(Phone.Instance.ToList<KeyValuePair<short, Phone>>());
            blstPhone.Add(new KeyValuePair<short, Phone>(-1, Phone.CreateEmptyInstance()));
            lstPhone.DisplayMember = "Value";
            lstPhone.DataSource = blstPhone;
            DTOFactory.CreateDTO(
                new KeyValuePair<View, IDTO>(View.Book, new BookViewDTO(txtBookIndex, txtNo, txtTitle,lstAuthor, txtPrice)),
                new KeyValuePair<View, IDTO>(View.Author, new AuthorViewDTO(txtAuthorIndex, txtName,lstPhone, txtEmail, blstAuthor)),
                new KeyValuePair<View, IDTO>(View.Phone, new PhoneViewDTO(txtPhoneIndex, txtTag, txtHomePhone,
                txtOfficePhone, txtCellPhone, blstPhone)));
            DTOFactory.SetDefaultTextBoxDataInfos();
            myAnchor = new[] { lblAnchorFormRightBottom };
            this.SetClientSizeCore(myAnchor[0].Left, myAnchor[0].Top);
            myPanel = new Panel[] { panel1, panel2, panel3 };
            for (int i = 1; i < myPanel.Length; i++)
            {
                myPanel[i].SetBounds(myPanel[0].Left, myPanel[0].Top, myPanel[0].Width, myPanel[0].Height);
            }
            myLabel = new Label[] { lblBook, lblAuthor, lblPhone };
            backColorFocus = myLabel[0].BackColor;
            backColorLostFocus = myLabel[1].BackColor;
            foreColorFocus = myLabel[0].ForeColor;
            foreColorLostFocus = myLabel[1].ForeColor;
            RefreshPanelProperty(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshPanelProperty(int index)
        {
            for (int i = 0; i < myLabel.Length; i++)
            {
                if (i == index)
                {
                    myPanel[i].Visible = true;
                    myLabel[i].BackColor = backColorFocus;
                    myLabel[i].ForeColor = foreColorFocus;
                }
                else
                {
                    myPanel[i].Visible = false;
                    myLabel[i].BackColor = backColorLostFocus;
                    myLabel[i].ForeColor = foreColorLostFocus;
                }
            }
        }

        private void BtnTitle_Click(object sender, EventArgs e)
        {
            string tag = (sender as Label).Tag.ToString();
            switch (tag)
            {
                case "book":
                    RefreshPanelProperty(0);
                    break;
                case "author":
                    RefreshPanelProperty(1);
                    break;
                case "phone":
                    RefreshPanelProperty(2);
                    break;
                default:
                    break;
            }
        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Book).SetData();
        }
        private void AuthorAdd_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Author).SetData();
        }
        private void PhoneAdd_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Phone).SetData();
        }

        private void BookDelete_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Book).RemoveData();
        }
        private void AuthorDelete5_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Author).RemoveData();
        }

        private void PhoneDelete_Click(object sender, EventArgs e)
        {
            DTOFactory.GetDTO(View.Phone).RemoveData();
        }

        private void BtnScroll_Click(object sender, EventArgs e, View view)
        {
            try
            {
                switch ((sender as Button).Tag.ToString())
                {
                    case "prev":
                        DTOFactory.GetDTO(view).ArrayIndexTextBoxAutoResize(-1);
                        break;
                    case "next":
                        DTOFactory.GetDTO(view).ArrayIndexTextBoxAutoResize(1);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                DTOFactory.GetDTO(view).ArrayIndexTextBoxAutoResize();
            }
        }

        private void BtnBookScroll_Click(object sender, EventArgs e)
        {
            BtnScroll_Click(sender, e, View.Book);
        }

        private void BtnAuthorScroll_Click(object sender, EventArgs e)
        {
            BtnScroll_Click(sender, e, View.Author);
        }

        private void BtnPhoneScroll_Click(object sender, EventArgs e)
        {
            BtnScroll_Click(sender, e, View.Phone);
        }

        private void TextBoxEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch ((sender as TextBox).Tag)
                {
                    case "book":
                        DTOFactory.GetDTO(View.Book).SetTextBoxDataInfo();
                        break;
                    case "author":
                        DTOFactory.GetDTO(View.Author).SetTextBoxDataInfo();
                        break;
                    case "phone":
                        DTOFactory.GetDTO(View.Phone).SetTextBoxDataInfo();
                        break;
                    default:
                        break;
                }
            }
        }

        private short TransformIndex(string value)
        {
            return TransformIndex(value, 0);
        }

        private short TransformIndex(string value, int increase)
        {
            Int16 index;
            try
            {
                index = Convert.ToInt16(value);
                index += Convert.ToInt16(increase);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                index = 1;
            }
            return index;
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            //KeyValuePair<short, Author> pair = (KeyValuePair<short, Author>)lstAuthor.SelectedItem ;
            //Debug.WriteLine(pair.Value.Email);
            //DTOFactory.SetDefaultTextBoxDataInfos();
            
            Author author = ((KeyValuePair<short, Author>)lstAuthor.SelectedItem).Value;
            Debug.WriteLine("test: "+ lstAuthor.Text);
        }


    }


}
