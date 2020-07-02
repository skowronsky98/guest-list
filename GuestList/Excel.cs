using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;


namespace GuestList
{
    public class Excel
    {
        string path = "";
        //string password = "";


       // _Application excel = new _Excel.Application();
        public  Workbook wb;
        Worksheet ws;


        Application excel = new Microsoft.Office.Interop.Excel.Application();

        public Excel(string path, int Sheet, string password)
        {
            //excel =
            this.path = path;
            object misValue = System.Reflection.Missing.Value;
           // this.password = passwrd;

            wb = excel.Workbooks.Open(path, misValue, misValue, misValue, password);
            ws = excel.Worksheets[Sheet];

           // excel.Visible = true;
            CreateHeaders();
        }

        public Excel(string path, string password)
        {
            //excel = new Microsoft.Office.Interop.Excel.Application();
            this.path = path;
            //excel.Visible = true;
            object misValue = System.Reflection.Missing.Value;

            wb = excel.Workbooks.Add(misValue);
            wb.Password = password;
            ws = excel.Worksheets[1];

            wb.SaveAs(path);

            CreateHeaders();
        }

        //Create Headers in Excel file
        public void CreateHeaders()
        {

            if (ws.Cells[1,1].Value2 == null)
            {
                ws.Cells[1, 1].Value = "Imię i Nazwisko";
                ws.Cells[1, 2].Value = "Nazwa Firmy";
                ws.Cells[1, 3].Value = "Dokument Tożsamości";
                ws.Cells[1, 4].Value = "Nr. Rejestracyjny Pojazdu";
                ws.Cells[1, 5].Value = "Imię Pracownika";
                ws.Cells[1, 6].Value = "Wejście";
                ws.Cells[1, 7].Value = "Nr. Przepustki";
                ws.Cells[1, 8].Value = "Cel";
                ws.Cells[1, 9].Value = "Nr. Przepustki Materiału";
                ws.Cells[1, 10].Value = "Wyjście";

                ws.get_Range("A1", "J1").ColumnWidth = 23f;
                ws.get_Range("A1", "J1").Font.Bold = true;

                Save();
            }
        }

        //Write data to Excell file
        public void WriteToCell(Guest guest)
        {
            int i = 1;
            do
            {
                i++;
            } while (ws.Cells[i,1].Value2 != null);

            ws.Cells[i, 1].Value = guest.Name;
            ws.Cells[i, 2].Value = guest.CompanyName;
            ws.Cells[i, 3].Value = guest.PersonalDocumentNumber;
            ws.Cells[i, 4].Value = guest.RegisterNumber;
            ws.Cells[i, 5].Value = guest.LeaderName;
            ws.Cells[i, 6].Value = guest.GetInTime;
            ws.Cells[i, 7].Value = guest.CardPassNumber;
            ws.Cells[i, 8].Value = guest.Destination;
            ws.Cells[i, 9].Value = guest.CardPassMaterial;
            ws.Cells[i, 10].Value = guest.GetOutTime;

            Save();


        }
        public void Save()
        {
            wb.Save();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void SaveAs(string path, string password)
        {
            object misValue = System.Reflection.Missing.Value;

            wb.SaveAs(path, misValue, password);
        }

        public void Close()
        {
            wb.Close();
            excel.Quit();

        }

    }
}
