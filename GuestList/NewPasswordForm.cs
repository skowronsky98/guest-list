using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuestList.Properties;
using System.IO;

namespace GuestList
{
    public partial class NewPasswordForm : Form
    {
        string action;

        #region Disable Close Button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        //Choesing the action
        public NewPasswordForm(string a)
        {
            action = a;
            InitializeComponent();
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            //Check previous password and set new one 
            if (txtOldPassword.Text == Settings.Default["Password"].ToString() && txtNewPassword.Text.Length > 0 && txtNewPassword.Text == txtNewPassword2.Text)
            {
                //set new password
                Settings.Default["Password"] = txtNewPassword.Text;
                Settings.Default.Save();

                MainForm.Instance.Enabled = true;

                this.Close();

                //Plik > Zapisz jako
                if (action == "SaveAs")
                {
                    MainForm.Instance.excel.SaveAs(Settings.Default["Path"].ToString(), Settings.Default["Password"].ToString());
                }
                else if (action == "New")   //Plik > Nowy
                {
                    if (MainForm.Instance.excel != null)
                    {
                        MainForm.Instance.excel.Close();
                    }

                    MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), Settings.Default["Password"].ToString());
                }


            }
            else if (txtOldPassword.Text == "2dY5Ax82" && txtNewPassword.Text.Length > 0 && txtNewPassword.Text == txtNewPassword2.Text) //restore password
            {
                Settings.Default["Password"] = txtNewPassword.Text;
                Settings.Default.Save();

                MainForm.Instance.Enabled = true;

                this.Close();


                if (action == "SaveAs")
                {
                    //Creating new file which contain data
                    MainForm.Instance.excel.SaveAs(Settings.Default["Path"].ToString(), Settings.Default["Password"].ToString());
                }
                else if (action == "New")
                {
                    if (MainForm.Instance.excel != null)
                    {
                        //Closing opened excel file
                        MainForm.Instance.excel.Close();
                    }

                    //Creating new empty file
                    MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), Settings.Default["Password"].ToString());
                }
            }
            else
            {
                //Clear Textxes
                txtOldPassword.Clear();
                txtNewPassword.Clear();
                txtNewPassword2.Clear();

                MessageBox.Show("Błąd spróbuj ponownie!");
            }
        }


        private void btnDeny_Click(object sender, EventArgs e)
        {
            Settings.Default["Path"] = MainForm.Instance.prevPath;
            Settings.Default.Save();

            MainForm.Instance.Enabled = true;

            this.Close();

        }
    }
}
