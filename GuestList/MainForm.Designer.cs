namespace GuestList
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.documentLabel = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.txtRegisterNumber = new System.Windows.Forms.TextBox();
            this.GuestLabel = new System.Windows.Forms.Label();
            this.leaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leaderNameLabel = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Deny = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.CarList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersonalDocumentNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegisterNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameLeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardPassNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardPassMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leaderList = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ścieżkaDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsuńPracownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtCardPassNumber = new System.Windows.Forms.TextBox();
            this.txtCardPassMaterial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(12, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię i Nazwisko:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Location = new System.Drawing.Point(12, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 1;
            // 
            // companyLabel
            // 
            this.companyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.companyLabel.Location = new System.Drawing.Point(9, 115);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(92, 17);
            this.companyLabel.TabIndex = 4;
            this.companyLabel.Text = "Nazwa Firmy:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCompanyName.Location = new System.Drawing.Point(12, 135);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(175, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // documentLabel
            // 
            this.documentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.documentLabel.AutoSize = true;
            this.documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.documentLabel.Location = new System.Drawing.Point(12, 158);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(103, 17);
            this.documentLabel.TabIndex = 6;
            this.documentLabel.Text = "Nr Dokumentu:";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDocumentNumber.Location = new System.Drawing.Point(12, 178);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(175, 20);
            this.txtDocumentNumber.TabIndex = 3;
            // 
            // registrationLabel
            // 
            this.registrationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registrationLabel.Location = new System.Drawing.Point(12, 201);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(171, 17);
            this.registrationLabel.TabIndex = 8;
            this.registrationLabel.Text = "Nr Rejestracyjny Pojazdu:";
            // 
            // txtRegisterNumber
            // 
            this.txtRegisterNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegisterNumber.Location = new System.Drawing.Point(12, 221);
            this.txtRegisterNumber.Name = "txtRegisterNumber";
            this.txtRegisterNumber.Size = new System.Drawing.Size(175, 20);
            this.txtRegisterNumber.TabIndex = 4;
            // 
            // GuestLabel
            // 
            this.GuestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestLabel.Location = new System.Drawing.Point(7, 35);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.Size = new System.Drawing.Size(58, 25);
            this.GuestLabel.TabIndex = 10;
            this.GuestLabel.Text = "Gość";
            // 
            // leaderLabel
            // 
            this.leaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leaderLabel.AutoSize = true;
            this.leaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaderLabel.Location = new System.Drawing.Point(4, 393);
            this.leaderLabel.Name = "leaderLabel";
            this.leaderLabel.Size = new System.Drawing.Size(111, 25);
            this.leaderLabel.TabIndex = 11;
            this.leaderLabel.Text = "Użytkownik";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // leaderNameLabel
            // 
            this.leaderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leaderNameLabel.AutoSize = true;
            this.leaderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaderNameLabel.Location = new System.Drawing.Point(9, 429);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(103, 17);
            this.leaderNameLabel.TabIndex = 13;
            this.leaderNameLabel.Text = "Imię i Nazwisko";
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Send.Location = new System.Drawing.Point(12, 515);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 9;
            this.Send.Text = "Wjazd";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Deny
            // 
            this.Deny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Deny.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Deny.Location = new System.Drawing.Point(112, 515);
            this.Deny.Name = "Deny";
            this.Deny.Size = new System.Drawing.Size(75, 23);
            this.Deny.TabIndex = 10;
            this.Deny.Text = "Anuluj";
            this.Deny.UseVisualStyleBackColor = true;
            this.Deny.Click += new System.EventHandler(this.Deny_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.Location = new System.Drawing.Point(215, 515);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Wyjazd";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Close.Location = new System.Drawing.Point(1069, 515);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 12;
            this.Close.Text = "Zamknij";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // CarList
            // 
            this.CarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PersonalDocumentNumber,
            this.CompanyNameColumn,
            this.RegisterNumberColumn,
            this.NameLeaderColumn,
            this.StartTime,
            this.cardPassNumber,
            this.Destination,
            this.cardPassMaterial});
            this.CarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarList.FullRowSelect = true;
            this.CarList.GridLines = true;
            this.CarList.Location = new System.Drawing.Point(215, 22);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(929, 467);
            this.CarList.TabIndex = 22;
            this.CarList.UseCompatibleStateImageBehavior = false;
            this.CarList.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Imię i Nazwisko";
            this.NameColumn.Width = 201;
            // 
            // PersonalDocumentNumber
            // 
            this.PersonalDocumentNumber.DisplayIndex = 2;
            this.PersonalDocumentNumber.Text = "Dokument Tożsamości";
            this.PersonalDocumentNumber.Width = 134;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DisplayIndex = 1;
            this.CompanyNameColumn.Text = "Nazwa Firmy";
            this.CompanyNameColumn.Width = 142;
            // 
            // RegisterNumberColumn
            // 
            this.RegisterNumberColumn.Text = "Numer rej. Pojazdu";
            this.RegisterNumberColumn.Width = 125;
            // 
            // NameLeaderColumn
            // 
            this.NameLeaderColumn.Text = "Imię Opiekuna";
            this.NameLeaderColumn.Width = 63;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Wjazd";
            this.StartTime.Width = 96;
            // 
            // cardPassNumber
            // 
            this.cardPassNumber.Text = "Nr. Przepustki";
            this.cardPassNumber.Width = 41;
            // 
            // Destination
            // 
            this.Destination.Text = "Do Kogo";
            // 
            // cardPassMaterial
            // 
            this.cardPassMaterial.Text = "Przepustka Materiału";
            // 
            // leaderList
            // 
            this.leaderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaderList.FormattingEnabled = true;
            this.leaderList.Location = new System.Drawing.Point(9, 449);
            this.leaderList.Name = "leaderList";
            this.leaderList.Size = new System.Drawing.Size(175, 21);
            this.leaderList.TabIndex = 8;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1156, 24);
            this.menu.TabIndex = 25;
            this.menu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.ścieżkaDoPlikuToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            this.zapiszJakoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click_1);
            // 
            // ścieżkaDoPlikuToolStripMenuItem
            // 
            this.ścieżkaDoPlikuToolStripMenuItem.Name = "ścieżkaDoPlikuToolStripMenuItem";
            this.ścieżkaDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ścieżkaDoPlikuToolStripMenuItem.Text = "Ścieżka do pliku";
            this.ścieżkaDoPlikuToolStripMenuItem.Click += new System.EventHandler(this.ścieżkaDoPlikuToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsuńPracownikaToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // dodajUsuńPracownikaToolStripMenuItem
            // 
            this.dodajUsuńPracownikaToolStripMenuItem.Name = "dodajUsuńPracownikaToolStripMenuItem";
            this.dodajUsuńPracownikaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dodajUsuńPracownikaToolStripMenuItem.Text = "Pracownicy";
            this.dodajUsuńPracownikaToolStripMenuItem.Click += new System.EventHandler(this.dodajUsuńPracownikaToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nr Przepustki:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Do Kogo:";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDestination.Location = new System.Drawing.Point(12, 307);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(175, 20);
            this.txtDestination.TabIndex = 6;
            // 
            // txtCardPassNumber
            // 
            this.txtCardPassNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCardPassNumber.Location = new System.Drawing.Point(12, 264);
            this.txtCardPassNumber.Name = "txtCardPassNumber";
            this.txtCardPassNumber.Size = new System.Drawing.Size(175, 20);
            this.txtCardPassNumber.TabIndex = 5;
            // 
            // txtCardPassMaterial
            // 
            this.txtCardPassMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCardPassMaterial.Location = new System.Drawing.Point(12, 352);
            this.txtCardPassMaterial.Name = "txtCardPassMaterial";
            this.txtCardPassMaterial.Size = new System.Drawing.Size(175, 20);
            this.txtCardPassMaterial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nr Przepustki Materiału:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Deny;
            this.ClientSize = new System.Drawing.Size(1156, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCardPassMaterial);
            this.Controls.Add(this.txtCardPassNumber);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leaderList);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Deny);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.leaderNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderLabel);
            this.Controls.Add(this.GuestLabel);
            this.Controls.Add(this.txtRegisterNumber);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(588, 536);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Gości";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox txtRegisterNumber;
        private System.Windows.Forms.Label GuestLabel;
        private System.Windows.Forms.Label leaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leaderNameLabel;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Deny;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ListView CarList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader CompanyNameColumn;
        private System.Windows.Forms.ColumnHeader RegisterNumberColumn;
        private System.Windows.Forms.ColumnHeader NameLeaderColumn;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader PersonalDocumentNumber;
        public System.Windows.Forms.ComboBox leaderList;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsuńPracownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtCardPassNumber;
        private System.Windows.Forms.ColumnHeader cardPassNumber;
        private System.Windows.Forms.ColumnHeader Destination;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ścieżkaDoPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader cardPassMaterial;
        private System.Windows.Forms.TextBox txtCardPassMaterial;
        private System.Windows.Forms.Label label4;
    }
}

