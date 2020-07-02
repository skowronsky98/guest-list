using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GuestList.Properties;


namespace GuestList
{
    public partial class MainForm : Form
    {
        //Create list of objects
        List<Guest> objGuest = new List<Guest>();

        //public DBConnection dbCon;

        //Create instance of list, it shows objects in listview 
        ListViewItem lvi;


        //Create instance of main form
        public static MainForm Instance;

        //Create instance of Excel class  
        public Excel excel;

        //Previous path of excel file connected to program
        public string prevPath;
       
        // string password = "password";

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

        public MainForm()
        {
            Instance = this;

            InitializeComponent();

            OpenExcel();

            InsertGuestFromFile();

            ReadFileOfEmployee();

        }

        #region Send Button

        
        //Wjazd Button
        private void Send_Click(object sender, EventArgs e)
        {
            //Check if textbox is filled
            if (txtName.TextLength > 0 && txtCompanyName.TextLength > 0 && txtDocumentNumber.TextLength > 0 && txtRegisterNumber.TextLength > 0 && leaderList.Text.Length > 0 && txtCardPassNumber.Text.Length > 0 && txtDestination.Text.Length > 0)
            {
               
                //Generate Get In Time
                string getInTime = DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToLongDateString();

                //Create new object of guest class and add it to list of those objects
                objGuest.Add( new Guest(txtName.Text, txtCompanyName.Text, txtDocumentNumber.Text, txtRegisterNumber.Text, leaderList.Text, getInTime, txtCardPassNumber.Text, txtDestination.Text, txtCardPassMaterial.Text));


                //Create row in list
               lvi = new ListViewItem(txtName.Text);
                lvi.SubItems.Add(txtDocumentNumber.Text);
                lvi.SubItems.Add(txtCompanyName.Text);
                lvi.SubItems.Add(txtRegisterNumber.Text);
                lvi.SubItems.Add(leaderList.Text);
                lvi.SubItems.Add(getInTime);
                lvi.SubItems.Add(txtCardPassNumber.Text);
                lvi.SubItems.Add(txtDestination.Text);
                lvi.SubItems.Add(txtCardPassMaterial.Text);

                //View created row
                CarList.Items.Add(lvi);

                //if (dbCon.IsConnect())
                //    dbCon.Command1(objGuest[objGuest.Count - 1]);
                //else

                //Add object to tmp file of guests 
                AddGuestToFile(objGuest[objGuest.Count - 1]);


                //Clear Text Boxes
                txtName.Clear();
                txtCompanyName.Clear();
                txtDocumentNumber.Clear();
                txtRegisterNumber.Clear();
                txtCardPassNumber.Clear();
                txtDestination.Clear();
                txtCardPassMaterial.Clear();
                //leaderList.Clear();

                leaderList.Text.ToString();

            }
            else
                MessageBox.Show("Uzupełnij brakujące dane!");
           
        }

        #endregion


        #region Deny Button
        private void Deny_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCompanyName.Clear();
            txtDocumentNumber.Clear();
            txtRegisterNumber.Clear();
            txtCardPassNumber.Clear();
            txtDestination.Clear();
            // txtLeaderName.Clear();


        }
        #endregion

        #region Save Click


        //Wyjazd Button
        private void Save_Click(object sender, EventArgs e)
        {
            //Check if user selected item from list
            if (CarList.SelectedItems.Count > 0)
            {
                //Generate GetOutTime
                string getOutTime = DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToLongDateString();

                //Find selected row in list of Guests objects and  insert there get out time
                objGuest.ElementAt(CarList.FocusedItem.Index).GetOut(getOutTime);


                //foreach (var i in objGuest)
                //{
                //    MessageBox.Show(i.Name + " - " + i.GetInTime + "  --- " + i.GetOutTime);
                //}

                //if (dbCon.IsConnect())
                //    dbCon.Command2(objGuest.ElementAt(CarList.FocusedItem.Index));
                //else
                // UpdateGuestFile(objGuest.ElementAt(CarList.FocusedItem.Index));

                try
                {
                    //Insert data to Excel file 
                    excel.WriteToCell(objGuest.ElementAt(CarList.FocusedItem.Index));
                    //Remove object from tmp file
                    RemoveGuestFromFile();
                    //Remove Guest object from List of Guests 
                    objGuest.RemoveAt(CarList.FocusedItem.Index);
                    //Remove row in ListView
                    CarList.FocusedItem.Remove();
                }
                catch (Exception)
                {
                    MessageBox.Show("Brak pliku docelowego!\nStwórz nowy plik: Plik > Nowy");

                }
                
            }
            else
            {
                MessageBox.Show("Nie wybrałeś Obiektu z listy!");
            }

        }

        #endregion


        //Zamknij Button
        #region Close Button
        private void Close_Click(object sender, EventArgs e)
        {

            //Check if objet is on property
            if (CarList.Items.Count != 0)
                MessageBox.Show("Goście znajdują się na terenie zakładu!");


            try
            {
                //Close Excel file
                excel.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Brak pliku docelowego!\nStwórz nowy plik: Plik > Nowy");
              
            }


            //Close Program
            Application.Exit();

        }

        #endregion

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (CarList.SelectedItems.Count > 0)
        //    {
        //        RemoveGuestFromFile();
        //        objGuest.RemoveAt(CarList.FocusedItem.Index);
        //        CarList.FocusedItem.Remove();
        //    }
        //    else
        //        MessageBox.Show("Nie wybrałeś Obiektu z listy!");

        //}

        
        //Pracownicy 
        public void ReadFileOfEmployee()
        {
            //Check if file of LeadersNames exist
            if (File.Exists("LeadersNames.txt"))
            {
                //Create stream of LeadersNames file to read data
                StreamReader file = new StreamReader("LeadersNames.txt");

                string line;
                //Clear ComboBox of Leaders
                leaderList.Items.Clear();

                //Get Leaders from LeadersNames and view them in ComboBox of Leaders
                while ((line = file.ReadLine()) != null)
                {
                    leaderList.Items.Add(line);
                }

                //Close stream of LeadersNames file
                file.Close();
            }
            else
            {
                //If file LeadersNames file doesn't exist create that file
                StreamWriter file = new StreamWriter("LeadersNames.txt");
                file.Close();
            }
        }

        //Check tmp GuestFile
        private void CheckGuestFile(List<Guest> guestList)
        {
            //Check if tmp GuestFile exist and contains some data about guests
            if (File.Exists("GuestFile.txt") && File.ReadLines("GuestFile.txt").Count() > 0)
            {
                //Create stream to read data from GuestFile
                StreamReader file = new StreamReader("GuestFile.txt");

                string line;

                //Check every row of file
                while ((line = file.ReadLine()) != null)
                {
                    //Add object to data array 
                    string[] data = line.Split('\t');

                    //Create new Guest object and add it to List of Guest
                    if (data.Length == 9)
                        guestList.Add(new Guest(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8]));
                    
                }
                //Close stream
                file.Close();

            }
            else //if GuestFile  doesn't exist create it
            {
                StreamWriter file = new StreamWriter("GuestFile.txt");
                file.Close();
            }
        }

        private void InsertGuestFromFile()
        {
            CheckGuestFile(objGuest);

           // int elements = CarList.Items.Count;

            //From Guest List insert every object to ListView 
            foreach (var i in objGuest)
            {
                lvi = new ListViewItem(i.Name);
                lvi.SubItems.Add(i.PersonalDocumentNumber);
                lvi.SubItems.Add(i.CompanyName);
                lvi.SubItems.Add(i.RegisterNumber);
                lvi.SubItems.Add(i.LeaderName);
                lvi.SubItems.Add(i.GetInTime);
                lvi.SubItems.Add(i.CardPassNumber);
                lvi.SubItems.Add(i.Destination);
                lvi.SubItems.Add(i.CardPassMaterial);

                //View created row
                CarList.Items.Add(lvi);
            }

         
        }

        //Write data to GuestFile.txt file
        private void AddGuestToFile(Guest guest)
        {
             using (StreamWriter sw = File.AppendText("GuestFile.txt"))
             {
                sw.WriteLine(guest.Name+ "\t" + guest.CompanyName + "\t" + guest.PersonalDocumentNumber + "\t" + guest.RegisterNumber + "\t" + guest.LeaderName + "\t" + guest.GetInTime + "\t" + guest.CardPassNumber + "\t" + guest.Destination + "\t" + guest.CardPassMaterial);
                sw.Close();
             }
        }

        //private void UpdateGuestFile(Guest guest)
        //{
        //    if (!File.Exists("Guests.txt"))
        //    {
        //        StreamWriter file = new StreamWriter("Guests.txt");

        //        file.Close();
        //    }

        //    using (StreamWriter sw = File.AppendText("Guests.txt"))
        //    {
        //        sw.WriteLine(guest.Name + "\t" + guest.CompanyName + "\t" + guest.PersonalDocumentNumber + "\t" + guest.RegisterNumber + "\t" + guest.LeaderName + "\t" + guest.GetInTime + "\t" + guest.CardPassNumber + "\t" + guest.Destination + "\t" + guest.CardPassMaterial + "\t" + guest.GetOutTime);

        //        sw.Close();
        //    }

        //    RemoveGuestFromFile();

        //}

        //When whola data are collected find object by index and delete it
        private void RemoveGuestFromFile()
        {
            var file = new List<string>(File.ReadAllLines("GuestFile.txt"));

            //Remove guest from file
            file.RemoveAt(CarList.FocusedItem.Index);
            //Save and Close File
            File.WriteAllLines("GuestFile.txt", file.ToArray());
        }


        private void dodajUsuńPracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create instance of Pracownicy form
            MyEditForm form = new MyEditForm();

            //Show created form
            form.Show();
        }


        //Zamknij Button
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (CarList.Items.Count != 0)
                MessageBox.Show("Goście znajdują się na terenie zakładu!");

            try
            {
                excel.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Brak pliku docelowego!\nStwórz nowy plik: Plik > Nowy");
               
            }

            Application.Exit();
        }

        public void OpenExcel()
        {
            //Settings.Default["Password"] = "";
            //Settings.Default.Save();

            //Check if Excel file exist under the Path variable.

            if (File.Exists(Settings.Default["Path"].ToString()))
            {

                try
                {
                    //Create instance of Excel file and open this file
                    excel = new Excel(Settings.Default["Path"].ToString(), 1, Settings.Default["Password"].ToString());
                }
                catch (Exception)
                {

                    MessageBox.Show("Wystąpił błąd podczas otwierania pliku!");
                }

            }
            else
            {
                //if file doesn't exist create new one 
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Stwórz nowy plik";

                MainForm.Instance.Show();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //After creating new Excel file save new path to variable
                    Settings.Default["Path"] = saveFileDialog.FileName;
                    Settings.Default.Save();
                    MainForm.Instance.Enabled = false;


                    //Check if password exist
                    if (Settings.Default["Password"].ToString().Length > 0)
                    {
                        //Create new password to new Excel file
                        //You need to pass prev password it's saved in Settings.Default["Password"] 
                        NewPasswordForm newPass = new NewPasswordForm("New");
                        newPass.Show();
                        MainForm.Instance.Enabled = false;
                    }
                    else
                    {
                        //Create new password
                        PasswordForm passForm = new PasswordForm();
                        passForm.Show();
                        MainForm.Instance.Enabled = false;
                    }

                }
              
            }

        }


        //Save As Excel file
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Assaign Path to variable
            //If something goes wrong with creating new file it will remember previous Excel file path
            prevPath = Settings.Default["Path"].ToString();

            
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default["Path"] = saveFileDialog.FileName;
                Settings.Default.Save();

                MainForm.Instance.Enabled = false;

                ////NewPasswordForm newPass = new NewPasswordForm("SaveAs");
                ////newPass.Show();

                if (Settings.Default["Password"].ToString().Length > 0)
                {
                    if (excel != null)
                    {
                        NewPasswordForm newPass = new NewPasswordForm("SaveAs");
                        newPass.Show();
                    }
                    else
                    {
                        NewPasswordForm newPass = new NewPasswordForm("New");
                        newPass.Show();
                    }
                }
                else
                {
                    PasswordForm passForm = new PasswordForm();
                    passForm.Show();

                }

            }
        }


        //Create new Excel file
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            prevPath = Settings.Default["Path"].ToString();

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Stwórz nowy plik";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                Settings.Default["Path"] = saveFileDialog.FileName;
                Settings.Default.Save();

                MainForm.Instance.Enabled = false;

                if (Settings.Default["Password"].ToString().Length > 0)
                {
                    NewPasswordForm newPass = new NewPasswordForm("New");
                    newPass.Show();
                }
                else
                {
                    PasswordForm passForm = new PasswordForm();
                    passForm.Show();

                }
                MainForm.Instance.Enabled = false;

            }

        }

        //Show path to Excel file
        private void ścieżkaDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (excel == null)
            {
                MessageBox.Show("Brak pliku docelowego!\nStwórz nowy plik: Plik > Nowy");
            }
            else
            {
                MessageBox.Show(Settings.Default["Path"].ToString());
            }
        }

        //You can open existed Excel file
        private void otwórzToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            prevPath = Settings.Default["Path"].ToString();
           // Excel prevExcel = excel;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files| *.xlsx; *.xls; *.xlsm";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Settings.Default["Path"] = openFileDialog.FileName;
                    Settings.Default.Save();

                    PasswordForm passwordForm = new PasswordForm(true);
                    passwordForm.Text = "Otwórz plik";
                    passwordForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }



       
            //Control_KeyDown(object sender, KeyEventArgs e)
            //{
            //    if (e.Alt)
            //    {
            //        e.Handled = false;
            //    }
            //}
         
    }

}
