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

namespace GuestList
{
    public partial class PasswordForm : Form
    {
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

        string prevPassword;

        int i = 1;

        public PasswordForm()
        {
            InitializeComponent();

            //save previous password to variable
            prevPassword = Settings.Default["Password"].ToString();
        }

        public PasswordForm(bool a)
        {
            a = true;
            i = 2;
            InitializeComponent();
            GuestLabel.Text = "Podaj hasło";

            prevPassword = Settings.Default["Password"].ToString();
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.Text.Length > 0 && txtPasswordConfirm.Text == txtPassword.Text)
            {
                Settings.Default["Password"] = txtPassword.Text;

                MainForm.Instance.Enabled = true;
                this.Close();

                if (i == 1)
                {
                    MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), Settings.Default["Password"].ToString());
                    Settings.Default.Save();
                }
                else
                {
                    try
                    {
                        //Excel prevExcel = MainForm.Instance.excel;

                        if (MainForm.Instance.excel != null)
                        {
                            MainForm.Instance.excel.Close();
                        }

                        MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), 1, Settings.Default["Password"].ToString());
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Błędne hasło");
                        Settings.Default["Password"] = prevPassword;
                        Settings.Default["Path"] = MainForm.Instance.prevPath;
                        MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), 1, Settings.Default["Password"].ToString());

                    }
                    Settings.Default.Save();

                }
            }
            else
            {
                txtPassword.Clear();
                txtPasswordConfirm.Clear();
                MessageBox.Show("Błąd spróbuj ponownie!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                Settings.Default["Password"] = prevPassword;
                Settings.Default["Path"] = MainForm.Instance.prevPath;

                if (MainForm.Instance.excel != null)
                {
                    MainForm.Instance.excel.Close();
                }

                MainForm.Instance.excel = new Excel(Settings.Default["Path"].ToString(), 1, Settings.Default["Password"].ToString());
                Settings.Default.Save();
            }

            MainForm.Instance.Enabled = true;
            Close();
        }
    }
}
