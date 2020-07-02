using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GuestList
{
    //public class DBConnection
    //{
    //    private DBConnection()
    //    {

    //    }

    //    private string databaseName = string.Empty;
    //    public string DatabaseName
    //    {
    //        get { return databaseName; }
    //        set { databaseName = value; }
    //    }

    //    public string Password { get; set; }
    //    private MySqlConnection connection = null;
    //    public MySqlConnection Connection
    //    {
    //        get { return connection; }
    //    }

    //    private static DBConnection _instance = null;
    //    public static DBConnection Instance()
    //    {
    //        if (_instance == null)
    //            _instance = new DBConnection();
    //        return _instance;
    //    }

    //    public void Connect()
    //    {
    //        try
    //        {
    //            string connstring = string.Format("Server=localhost; database={0}; UID={1}; password={2};SslMode=none", databaseName, "root", "");
    //            connection = new MySqlConnection(connstring);
    //            connection.Open();
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show("Brak połączenia z bazą danych!");
    //        }
            
    //    }

    //    public bool IsConnect()
    //    {
    //        if (connection.State == ConnectionState.Open)
    //            return true;
    //        else
    //            return false;

    //    }

    //    public void Command1(Guest guest)
    //    {
    //        //string query = "Insert into guest (name, firm, personaldoc, carnumber, guardname, getin) values('" + guest.Name + "','" + guest.CompanyName + "','" + guest.PersonalDocumentNumber + "','" + guest.RegisterNumber + "','" + guest.LeaderName + "','" + guest.GetInTime + "')";
    //        string query = "Insert into guest (name, firm, personaldoc, carnumber, guardname, getin) values(@guest.Name" + ", @guest.CompanyName" + ", @guest.PersonalDocumentNumber" + ", @guest.RegisterNumber" + ", @guest.LeaderName" + ", @guest.GetInTime)";

    //        MySqlCommand cmd = new MySqlCommand(query);

    //        cmd.Parameters.AddWithValue("@guest.Name", guest.Name);
    //        cmd.Parameters.AddWithValue("@guest.CompanyName", guest.CompanyName);
    //        cmd.Parameters.AddWithValue("@guest.PersonalDocumentNumber", guest.PersonalDocumentNumber);
    //        cmd.Parameters.AddWithValue("@guest.RegisterNumber", guest.RegisterNumber);
    //        cmd.Parameters.AddWithValue("@guest.LeaderName", guest.LeaderName);
    //        cmd.Parameters.AddWithValue("@guest.GetInTime", guest.GetInTime);

    //        //connection.Open();
    //        cmd.Connection = connection;
    //        cmd.ExecuteNonQuery();
    //        cmd.Dispose();
    //        //command.Connection.Close();
    //        //Close();
    //    }

    //    public void Command2(Guest guest)
    //    {

    //        string query2 = "Update guest set getout='" + guest.GetOutTime + "'where getin='"+ guest.GetInTime +"'and personaldoc='"+ guest.PersonalDocumentNumber +"'";
    //        MySqlCommand command2 = new MySqlCommand(query2);

    //        //connection.Open();
    //        command2.Connection = connection;
    //        command2.ExecuteNonQuery();
    //        command2.Dispose();
    //        //command2.Connection.Close();
    //        //Close();
    //    }

    //    public void CommandOnStart(List<Guest> guests)
    //    {
    //        string sql = @"select name, firm, personaldoc, carnumber, guardname, getin from guest where getout=@getout";

    //        var cmd = new MySqlCommand(sql);
    //        cmd.Connection = connection;
           

    //        cmd.Parameters.Add("@getout", MySqlDbType.VarChar).Value = "";

    //        MySqlDataReader reader = cmd.ExecuteReader();

    //        while (reader.Read())
    //        {
    //            guests.Add(new Guest(reader["name"].ToString(), reader["firm"].ToString(), reader["personaldoc"].ToString(), reader["carnumber"].ToString(), reader["guardname"].ToString(), reader["getin"].ToString()));
    //        }

    //        reader.Close();
    //    }

    //    public void Close()
    //    {
    //        connection.Close();
    //    }
    //}
}
