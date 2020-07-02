using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuestList
{
    public partial class MyEditForm : Form
    {

        public MyEditForm()
        {
            InitializeComponent();

            LoadEmplyee();
        }

        //Creating new employe
        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (File.Exists("LeadersNames.txt"))
            {
                //Write new employe to file
                using (StreamWriter sw = File.AppendText("LeadersNames.txt"))
                {
                    if (txtEmployee.Text.Length > 0)
                        sw.WriteLine(txtEmployee.Text);

                    sw.Close();
                }

                //clear TextBox
                txtEmployee.Clear();
                //Clear emplyee list in program
                emplyeeList.Items.Clear();

                //Load Employees from file
                StreamReader reader = new StreamReader("LeadersNames.txt");

                string line;

                //Show employee to list in program
                while ((line = reader.ReadLine()) != null && line.Length > 0)
                {
                    emplyeeList.Items.Add(line);
                }

                reader.Close();

                MainForm.Instance.ReadFileOfEmployee();

            }
        }

        //Search employee in LeadersNames file
        private void LoadEmplyee()
        {
            //Check if file exist
            if (File.Exists("LeadersNames.txt") && File.ReadLines("LeadersNames.txt").Count() > 0)
            {
                emplyeeList.Items.Clear();

                StreamReader file = new StreamReader("LeadersNames.txt");

                string line;

                //Add employees to list in program
                while ((line = file.ReadLine()) != null)
                {
                    emplyeeList.Items.Add(line);
                }

                file.Close();
            }
        }


        //Remove employee from file and list
        private void removeEmployee_Click(object sender, EventArgs e)
        {
            if (emplyeeList.SelectedItems.Count > 0)
            {
                var file = new List<string>(File.ReadAllLines("LeadersNames.txt"));
                file.RemoveAt(emplyeeList.FocusedItem.Index);
                File.WriteAllLines("LeadersNames.txt", file.ToArray());

                emplyeeList.Items.RemoveAt(emplyeeList.FocusedItem.Index);

                LoadEmplyee();
                MainForm.Instance.ReadFileOfEmployee();
            }
            else
            {
                MessageBox.Show("Nie wybrałeś Obiektu z listy!");
            }
            
        }
    }
}
