﻿namespace GUI.User_Control
{
    partial class UCEmployee_Add
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEmployee_Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnComeback = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.errorGender = new System.Windows.Forms.Label();
            this.errorCMND = new System.Windows.Forms.Label();
            this.errorPhone = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.errorAddress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 81);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(328, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(324, 38);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Employee Management";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 186);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.18672F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.69295F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.86307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.37898F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.705394F));
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtClear, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnComeback, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.04949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.49462F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.76344F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(964, 186);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.btnSave.Location = new System.Drawing.Point(536, 38);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtClear
            // 
            this.txtClear.ActiveBorderThickness = 1;
            this.txtClear.ActiveCornerRadius = 20;
            this.txtClear.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.txtClear.ActiveForecolor = System.Drawing.Color.White;
            this.txtClear.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.txtClear.BackColor = System.Drawing.Color.White;
            this.txtClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtClear.BackgroundImage")));
            this.txtClear.ButtonText = "Clear";
            this.txtClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtClear.IdleBorderThickness = 1;
            this.txtClear.IdleCornerRadius = 20;
            this.txtClear.IdleFillColor = System.Drawing.Color.White;
            this.txtClear.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.txtClear.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.txtClear.Location = new System.Drawing.Point(669, 38);
            this.txtClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(114, 42);
            this.txtClear.TabIndex = 1;
            this.txtClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnComeback
            // 
            this.btnComeback.ActiveBorderThickness = 1;
            this.btnComeback.ActiveCornerRadius = 20;
            this.btnComeback.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.btnComeback.ActiveForecolor = System.Drawing.Color.White;
            this.btnComeback.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(85)))), ((int)(((byte)(233)))));
            this.btnComeback.BackColor = System.Drawing.Color.White;
            this.btnComeback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComeback.BackgroundImage")));
            this.btnComeback.ButtonText = "Come back";
            this.btnComeback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComeback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComeback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComeback.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnComeback.IdleBorderThickness = 1;
            this.btnComeback.IdleCornerRadius = 20;
            this.btnComeback.IdleFillColor = System.Drawing.Color.White;
            this.btnComeback.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.btnComeback.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(36)))), ((int)(((byte)(117)))));
            this.btnComeback.Location = new System.Drawing.Point(793, 38);
            this.btnComeback.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnComeback.Name = "btnComeback";
            this.btnComeback.Size = new System.Drawing.Size(109, 42);
            this.btnComeback.TabIndex = 2;
            this.btnComeback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComeback.Click += new System.EventHandler(this.btnComeback_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 417);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.662678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.091287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.29046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4426F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.32227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.588167F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpDOB, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbGender, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.errorGender, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.errorCMND, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.errorPhone, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.errorEmail, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.errorName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.errorUsername, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCMND, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.errorAddress, 5, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.50097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13645F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.89084F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14675F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(964, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(527, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "D.O.B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 49);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(135, 228);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(286, 20);
            this.dtpDOB.TabIndex = 16;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbGender
            // 
            this.cbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(135, 138);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(286, 21);
            this.cbGender.TabIndex = 17;
            this.cbGender.Text = "-select-";
            // 
            // errorGender
            // 
            this.errorGender.AutoSize = true;
            this.errorGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorGender.ForeColor = System.Drawing.Color.DarkRed;
            this.errorGender.Location = new System.Drawing.Point(135, 183);
            this.errorGender.Name = "errorGender";
            this.errorGender.Size = new System.Drawing.Size(286, 42);
            this.errorGender.TabIndex = 24;
            // 
            // errorCMND
            // 
            this.errorCMND.AutoSize = true;
            this.errorCMND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorCMND.ForeColor = System.Drawing.Color.DarkRed;
            this.errorCMND.Location = new System.Drawing.Point(135, 366);
            this.errorCMND.Name = "errorCMND";
            this.errorCMND.Size = new System.Drawing.Size(286, 51);
            this.errorCMND.TabIndex = 26;
            // 
            // errorPhone
            // 
            this.errorPhone.AutoSize = true;
            this.errorPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorPhone.ForeColor = System.Drawing.Color.DarkRed;
            this.errorPhone.Location = new System.Drawing.Point(628, 183);
            this.errorPhone.Name = "errorPhone";
            this.errorPhone.Size = new System.Drawing.Size(276, 42);
            this.errorPhone.TabIndex = 28;
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.errorEmail.Location = new System.Drawing.Point(628, 274);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(276, 46);
            this.errorEmail.TabIndex = 29;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorName.ForeColor = System.Drawing.Color.DarkRed;
            this.errorName.Location = new System.Drawing.Point(134, 92);
            this.errorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(288, 43);
            this.errorName.TabIndex = 30;
            // 
            // errorUsername
            // 
            this.errorUsername.AutoSize = true;
            this.errorUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.errorUsername.Location = new System.Drawing.Point(627, 92);
            this.errorUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorUsername.Name = "errorUsername";
            this.errorUsername.Size = new System.Drawing.Size(278, 43);
            this.errorUsername.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(134, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 31);
            this.txtName.TabIndex = 32;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtCMND
            // 
            this.txtCMND.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(134, 323);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(288, 31);
            this.txtCMND.TabIndex = 33;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            this.txtCMND.Leave += new System.EventHandler(this.txtCMND_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(627, 49);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 31);
            this.txtUsername.TabIndex = 34;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(627, 138);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 31);
            this.txtPhone.TabIndex = 35;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(627, 228);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 33);
            this.txtEmail.TabIndex = 36;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbIsAdmin);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(426, 368);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 47);
            this.panel4.TabIndex = 37;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbIsAdmin.Location = new System.Drawing.Point(79, 0);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(15, 47);
            this.cbIsAdmin.TabIndex = 16;
            this.cbIsAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 47);
            this.label8.TabIndex = 7;
            this.label8.Text = "Is Admin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 46);
            this.label9.TabIndex = 38;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(627, 323);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 31);
            this.txtAddress.TabIndex = 39;
            // 
            // errorAddress
            // 
            this.errorAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorAddress.Location = new System.Drawing.Point(627, 366);
            this.errorAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAddress.Name = "errorAddress";
            this.errorAddress.Size = new System.Drawing.Size(278, 51);
            this.errorAddress.TabIndex = 40;
            this.errorAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCEmployee_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "UCEmployee_Add";
            this.Size = new System.Drawing.Size(964, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label errorGender;
        private System.Windows.Forms.Label errorCMND;
        private System.Windows.Forms.Label errorPhone;
        private System.Windows.Forms.Label errorEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 txtClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnComeback;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label errorAddress;
    }
}
