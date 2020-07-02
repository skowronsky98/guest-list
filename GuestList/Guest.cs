using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuestList
{
    public class Guest
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string PersonalDocumentNumber { get; set; }
        public string RegisterNumber { get; set; }
        public string LeaderName { get; set; }
        public string GetInTime { get; set; }
        public string GetOutTime { get; set; }
        public string CardPassNumber{ get; set; }
        public string CardPassMaterial { get; set; }
        public string Destination { get; set; }



        public Guest(string name, string companyName, string personalDocumentNumber, string registerNumber, string leaderName, string getInTime, string cardPassNumber, string destination, string cardPassMaterial)
        {
            Name = name;
            CompanyName = companyName;
            PersonalDocumentNumber = personalDocumentNumber;
            RegisterNumber = registerNumber;
            LeaderName = leaderName;
            GetInTime = getInTime;
            CardPassNumber = cardPassNumber;
            Destination = destination;
            CardPassMaterial = cardPassMaterial;
        }

        public void GetOut(string getOutTime)
        {
            GetOutTime = getOutTime;
        }


    }//End class


}//End namespace
