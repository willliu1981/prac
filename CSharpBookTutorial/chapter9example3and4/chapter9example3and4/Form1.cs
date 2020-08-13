﻿using chapter9example3and4.myDTO;
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
            TextBoxIndexAutoSize(1, Book.Max, txtBookIndex, View.Book);
            TextBoxIndexAutoSize(1, Author.Max, txtAuthorIndex, View.Author);
            TextBoxIndexAutoSize(1, Phone.Max, txtPhoneIndex, View.Phone);
            BindingList<KeyValuePair<short, Author>> blstAuthor 
                = new BindingList<KeyValuePair<short, Author>>(Author.Instance.ToList<KeyValuePair<short, Author>>());
            lstAuthor.DisplayMember = "Value";
            lstAuthor.DataSource = blstAuthor;
            BindingList<KeyValuePair<short, Phone>> blstPhone 
                = new BindingList<KeyValuePair<short, Phone>>(Phone.Instance.ToList<KeyValuePair<short, Phone>>());
            lstPhone.DisplayMember = "Value";
            lstPhone.DataSource = blstPhone;
            DTOFactory.CreateDTO(
                new KeyValuePair<View, IDTO>(View.Book, new BookViewDTO(txtBookIndex, txtNo, txtTitle, txtPrice)),
                new KeyValuePair<View, IDTO>(View.Author, new AuthorViewDTO(txtAuthorIndex, txtName, txtEmail, blstAuthor)),
                new KeyValuePair<View, IDTO>(View.Phone, new PhoneViewDTO(txtPhoneIndex, txtTag, txtHomePhone, 
                txtOfficePhone, txtCellPhone, blstPhone)));
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
            InitPanelProperty(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitPanelProperty(int index)
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

        private void MyButton_Click(object sender, EventArgs e)
        {
            string tag = (sender as Label).Tag.ToString();
            switch (tag)
            {
                case "book":
                    InitPanelProperty(0);
                    break;
                case "author":
                    InitPanelProperty(1);
                    break;
                case "phone":
                    InitPanelProperty(2);
                    break;
                default:
                    break;
            }
        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            //short index = TransformIndex(txtBookIndex.Text.ToString());
            //Author author = Author.GetAuthor(1);
            //Book.SetBook(index, txtNo.Text.ToString(), txtTitle.Text.ToString(), author, txtPrice.Text.ToString());
            DTOFactory.GetDTO(View.Book).SetData();
        }
        private void AuthorAdd_Click(object sender, EventArgs e)
        {
            //short index = TransformIndex(txtAuthorIndex.Text.ToString());
            //Phone phone = Phone.GetPhone(1);
            //Author.SetAuthor(index, txtName.Text.ToString(), phone, txtEmail.Text.ToString());
            //blstAuthor.ResetBindings();
            DTOFactory.GetDTO(View.Author).SetData();
        }
        private void PhoneAdd_Click(object sender, EventArgs e)
        {
            //short index = TransformIndex(txtPhoneIndex.Text.ToString());
            //Phone.SetPhone(index, txtTag.Text.ToString(), txtHomePhone.Text.ToString(),
            //    txtOfficePhone.Text.ToString(), txtCellPhone.Text.ToString());
            //blstPhone.ResetBindings();
            DTOFactory.GetDTO(View.Phone).SetData();
        }

        private void BookDelete_Click(object sender, EventArgs e)
        {
            short index = TransformIndex(txtBookIndex.Text.ToString());
            Book.RemoveBook(index);
            TextBoxIndexAutoSize(index, Book.Max, txtBookIndex, View.Book);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            short index = TransformIndex(txtAuthorIndex.Text.ToString());
            Author.RemoveAuthor(index);
            TextBoxIndexAutoSize(index, Author.Max, txtAuthorIndex, View.Author);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            short index = TransformIndex(txtPhoneIndex.Text.ToString());
            Phone.RemovePhone(index);
            TextBoxIndexAutoSize(index, Phone.Max, txtPhoneIndex, View.Phone);
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
                switch((sender as TextBox).Tag)
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

        private void TextBoxIndexAutoSize(Int16 targetIdx, int max, TextBox oriTxetBox, View view)
        {
            if (oriTxetBox != null)
            {
                if (targetIdx < 1)
                {
                    targetIdx = 1;
                    oriTxetBox.Text = targetIdx.ToString();
                }
                if (targetIdx > max)
                {
                    targetIdx = Convert.ToInt16(max + 1);
                }
                oriTxetBox.Text = targetIdx.ToString();
                switch (view)
                {
                    case View.Book:
                        SetBookInfo(targetIdx);
                        break;
                    case View.Author:
                        SetAuhtorInfo(targetIdx);
                        break;
                    case View.Phone:
                        SetPhoneInfo(targetIdx);
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetPhoneInfo(short index)
        {
            //txtTag.Text = Phone.GetPhone(index).Tag;
            //txtHomePhone.Text = Phone.GetPhone(index).HomrPhone;
            //txtOfficePhone.Text = Phone.GetPhone(index).OfficePhone;
            //txtCellPhone.Text = Phone.GetPhone(index).CellPhone;
        }

        private void SetAuhtorInfo(short index)
        {
            //txtName.Text = Author.GetAuthor(index).Name;
            //txtPhone.Text = Author.GetAuthor(index).Phone.OfficePhone;
            //txtEmail.Text = Author.GetAuthor(index).Email;
        }

        private void SetBookInfo(Int16 index)
        {
            //txtNo.Text = Book.GetBook(index).No;
            //txtTitle.Text = Book.GetBook(index).Title;
            //txtAuthor.Text = Book.GetBook(index).Author.Name;
            //txtPrice.Text = Book.GetBook(index).Price.ToString();
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            //Author.SetAuthor(1, "Mark", Phone.GetPhone(1), "2222");
            //Debug.WriteLine("test: " + Author.GetAuthor(1).Name);
            //Debug.WriteLine("test: " + blstAuthor[0].Value.Name);
            //blstAuthor.ResetBindings();
        }


    }


}
