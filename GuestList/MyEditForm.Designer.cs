namespace GuestList
{
    partial class MyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEditForm));
            this.emplyeeList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addEmployee = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.GuestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emplyeeList
            // 
            this.emplyeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emplyeeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emplyeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.emplyeeList.FullRowSelect = true;
            this.emplyeeList.GridLines = true;
            this.emplyeeList.Location = new System.Drawing.Point(12, 49);
            this.emplyeeList.MultiSelect = false;
            this.emplyeeList.Name = "emplyeeList";
            this.emplyeeList.Size = new System.Drawing.Size(218, 198);
            this.emplyeeList.TabIndex = 0;
            this.emplyeeList.UseCompatibleStateImageBehavior = false;
            this.emplyeeList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Imię i Nazwisko";
            this.columnHeader1.Width = 297;
            // 
            // addEmployee
            // 
            this.addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addEmployee.Location = new System.Drawing.Point(12, 292);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(75, 23);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Dodaj";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // removeEmployee
            // 
            this.removeEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeEmployee.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeEmployee.Location = new System.Drawing.Point(153, 292);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(75, 23);
            this.removeEmployee.TabIndex = 2;
            this.removeEmployee.Text = "Usuń";
            this.removeEmployee.UseVisualStyleBackColor = true;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię i Nazwisko:";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployee.Location = new System.Drawing.Point(12, 266);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(216, 20);
            this.txtEmployee.TabIndex = 4;
            // 
            // GuestLabel
            // 
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestLabel.Location = new System.Drawing.Point(7, 9);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.Size = new System.Drawing.Size(221, 25);
            this.GuestLabel.TabIndex = 11;
            this.GuestLabel.Text = "Dodaj/Usuń Pracownika";
            // 
            // MyEditForm
            // 
            this.AcceptButton = this.addEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 327);
            this.Controls.Add(this.GuestLabel);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.emplyeeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(258, 366);
            this.Name = "MyEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView emplyeeList;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label GuestLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;

    }
}