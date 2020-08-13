namespace chapter9example3and4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstAuthor = new System.Windows.Forms.ListBox();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookEdit = new System.Windows.Forms.Button();
            this.txtBookIndex = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstPhone = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthorIndex = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.txtPhoneIndex = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblAnchorFormRightBottom = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lstAuthor);
            this.panel1.Controls.Add(this.btnBookDelete);
            this.panel1.Controls.Add(this.btnBookEdit);
            this.panel1.Controls.Add(this.txtBookIndex);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 336);
            this.panel1.TabIndex = 0;
            // 
            // lstAuthor
            // 
            this.lstAuthor.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.ItemHeight = 24;
            this.lstAuthor.Location = new System.Drawing.Point(97, 204);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(152, 28);
            this.lstAuthor.TabIndex = 17;
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBookDelete.Location = new System.Drawing.Point(286, 248);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(150, 39);
            this.btnBookDelete.TabIndex = 16;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // btnBookEdit
            // 
            this.btnBookEdit.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBookEdit.Location = new System.Drawing.Point(286, 190);
            this.btnBookEdit.Name = "btnBookEdit";
            this.btnBookEdit.Size = new System.Drawing.Size(150, 39);
            this.btnBookEdit.TabIndex = 15;
            this.btnBookEdit.Text = "Add";
            this.btnBookEdit.UseVisualStyleBackColor = true;
            this.btnBookEdit.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // txtBookIndex
            // 
            this.txtBookIndex.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBookIndex.Location = new System.Drawing.Point(335, 89);
            this.txtBookIndex.Name = "txtBookIndex";
            this.txtBookIndex.Size = new System.Drawing.Size(52, 36);
            this.txtBookIndex.TabIndex = 14;
            this.txtBookIndex.Tag = "book";
            this.txtBookIndex.Text = "1";
            this.txtBookIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBookIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterDown);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNext.Location = new System.Drawing.Point(393, 86);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 39);
            this.btnNext.TabIndex = 13;
            this.btnNext.Tag = "next";
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnBookScroll_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevious.Location = new System.Drawing.Point(286, 86);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(43, 39);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Tag = "prev";
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnBookScroll_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(42, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 39);
            this.label8.TabIndex = 11;
            this.label8.Tag = "";
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(97, 257);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(152, 30);
            this.txtPrice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(30, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 39);
            this.label7.TabIndex = 9;
            this.label7.Tag = "";
            this.label7.Text = "Author";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(42, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 39);
            this.label6.TabIndex = 7;
            this.label6.Tag = "";
            this.label6.Text = "Title";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTitle.Location = new System.Drawing.Point(97, 139);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(152, 30);
            this.txtTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(42, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 39);
            this.label5.TabIndex = 5;
            this.label5.Tag = "";
            this.label5.Text = "NO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNo.Location = new System.Drawing.Point(97, 82);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(152, 30);
            this.txtNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 43);
            this.label1.TabIndex = 3;
            this.label1.Tag = "book";
            this.label1.Text = "Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBook
            // 
            this.lblBook.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBook.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBook.Location = new System.Drawing.Point(33, 29);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(112, 43);
            this.lblBook.TabIndex = 1;
            this.lblBook.Tag = "book";
            this.lblBook.Text = "Book";
            this.lblBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBook.Click += new System.EventHandler(this.BtnTitle_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAuthor.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(151, 29);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(112, 43);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Tag = "author";
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthor.Click += new System.EventHandler(this.BtnTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lstPhone);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuthorIndex);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(567, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 336);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // lstPhone
            // 
            this.lstPhone.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstPhone.FormattingEnabled = true;
            this.lstPhone.ItemHeight = 24;
            this.lstPhone.Location = new System.Drawing.Point(109, 144);
            this.lstPhone.Name = "lstPhone";
            this.lstPhone.Size = new System.Drawing.Size(152, 28);
            this.lstPhone.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(274, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 39);
            this.button5.TabIndex = 30;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AuthorDelete5_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(42, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 39);
            this.label9.TabIndex = 19;
            this.label9.Tag = "";
            this.label9.Text = "Email";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(274, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 39);
            this.button6.TabIndex = 29;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AuthorAdd_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 43);
            this.label2.TabIndex = 4;
            this.label2.Tag = "book";
            this.label2.Text = "Author";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAuthorIndex
            // 
            this.txtAuthorIndex.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAuthorIndex.Location = new System.Drawing.Point(323, 94);
            this.txtAuthorIndex.Name = "txtAuthorIndex";
            this.txtAuthorIndex.Size = new System.Drawing.Size(52, 30);
            this.txtAuthorIndex.TabIndex = 28;
            this.txtAuthorIndex.Tag = "author";
            this.txtAuthorIndex.Text = "1";
            this.txtAuthorIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuthorIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(109, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 30);
            this.txtEmail.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(381, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 39);
            this.button7.TabIndex = 27;
            this.button7.Tag = "next";
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnAuthorScroll_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(274, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 39);
            this.button8.TabIndex = 26;
            this.button8.Tag = "prev";
            this.button8.Text = "<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnAuthorScroll_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(46, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 39);
            this.label10.TabIndex = 17;
            this.label10.Tag = "";
            this.label10.Text = "Phone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(109, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 30);
            this.txtName.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(46, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 39);
            this.label12.TabIndex = 13;
            this.label12.Tag = "";
            this.label12.Text = "Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPhone.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.Location = new System.Drawing.Point(269, 29);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(112, 43);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Tag = "phone";
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhone.Click += new System.EventHandler(this.BtnTitle_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTag);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txtOfficePhone);
            this.panel3.Controls.Add(this.txtPhoneIndex);
            this.panel3.Controls.Add(this.txtCellPhone);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtHomePhone);
            this.panel3.Location = new System.Drawing.Point(18, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 336);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(48, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 39);
            this.label11.TabIndex = 27;
            this.label11.Tag = "";
            this.label11.Text = "Tag";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTag.Location = new System.Drawing.Point(123, 98);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(152, 30);
            this.txtTag.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(286, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PhoneDelete_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 43);
            this.label3.TabIndex = 4;
            this.label3.Tag = "book";
            this.label3.Text = "Phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(286, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PhoneAdd_Click);
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOfficePhone.Location = new System.Drawing.Point(123, 213);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(152, 30);
            this.txtOfficePhone.TabIndex = 22;
            // 
            // txtPhoneIndex
            // 
            this.txtPhoneIndex.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhoneIndex.Location = new System.Drawing.Point(335, 98);
            this.txtPhoneIndex.Name = "txtPhoneIndex";
            this.txtPhoneIndex.Size = new System.Drawing.Size(52, 30);
            this.txtPhoneIndex.TabIndex = 19;
            this.txtPhoneIndex.Tag = "phone";
            this.txtPhoneIndex.Text = "1";
            this.txtPhoneIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxEnterDown);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCellPhone.Location = new System.Drawing.Point(123, 273);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(152, 30);
            this.txtCellPhone.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(393, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 39);
            this.button3.TabIndex = 18;
            this.button3.Tag = "next";
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnPhoneScroll_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(286, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 39);
            this.button4.TabIndex = 17;
            this.button4.Tag = "prev";
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnPhoneScroll_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(36, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 39);
            this.label16.TabIndex = 23;
            this.label16.Tag = "";
            this.label16.Text = "Office";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label14.Location = new System.Drawing.Point(9, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 39);
            this.label14.TabIndex = 25;
            this.label14.Tag = "";
            this.label14.Text = "Cell Phone";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(48, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 39);
            this.label15.TabIndex = 21;
            this.label15.Tag = "";
            this.label15.Text = "Home";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHomePhone.Location = new System.Drawing.Point(123, 156);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(152, 30);
            this.txtHomePhone.TabIndex = 20;
            // 
            // lblAnchorFormRightBottom
            // 
            this.lblAnchorFormRightBottom.BackColor = System.Drawing.Color.White;
            this.lblAnchorFormRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnchorFormRightBottom.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnchorFormRightBottom.Location = new System.Drawing.Point(1074, 440);
            this.lblAnchorFormRightBottom.Name = "lblAnchorFormRightBottom";
            this.lblAnchorFormRightBottom.Size = new System.Drawing.Size(38, 41);
            this.lblAnchorFormRightBottom.TabIndex = 6;
            this.lblAnchorFormRightBottom.Text = "A1";
            this.lblAnchorFormRightBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnchorFormRightBottom.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(548, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 336);
            this.panel4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(36, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 220);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 43);
            this.label4.TabIndex = 3;
            this.label4.Tag = "book";
            this.label4.Text = "Info";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(809, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 44);
            this.button9.TabIndex = 7;
            this.button9.Text = "Debug";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1210, 836);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblAnchorFormRightBottom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnchorFormRightBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookEdit;
        private System.Windows.Forms.TextBox txtBookIndex;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtAuthorIndex;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.TextBox txtPhoneIndex;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.ListBox lstAuthor;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox lstPhone;
    }
}

