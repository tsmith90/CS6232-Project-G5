using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSupport.Model
{
    public class States
    {
        Dictionary<string, string> statesList;

        public States()
        {
            statesList = new Dictionary<string, string>();
            SetStates();
        }

        public Dictionary<string, string> SetStates()
        {
            statesList = new Dictionary<string, string>();


            statesList.Add("Alabama", "AL");
            statesList.Add("Alaska", "AK");
            statesList.Add("America Samoa", "AS");
            statesList.Add("Arizona", "AZ");
            statesList.Add("Arkansas", "AR");
            statesList.Add("California", "CA");
            statesList.Add("Colorado", "CO");
            statesList.Add("Connecticut", "CT");
            statesList.Add("Delaware", "DE");
            statesList.Add("District of Columbia", "DC");
            statesList.Add("Florida", "FL");
            statesList.Add("Georgia", "GA");
            statesList.Add("Guam", "GU");
            statesList.Add("Hawaii", "HI");
            statesList.Add("Idaho", "NurseID");
            statesList.Add("Illinois", "IL");
            statesList.Add("Indiana", "IN");
            statesList.Add("Iowa", "IA");
            statesList.Add("Kansas", "KS");
            statesList.Add("Kentucky", "KY");
            statesList.Add("Louisiana", "LA");
            statesList.Add("Maine", "ME");
            statesList.Add("Maryland", "MD");
            statesList.Add("Massachusetts", "MA");
            statesList.Add("Michigan", "MI");
            statesList.Add("Minnesota", "MN");
            statesList.Add("Mississippi", "MS");
            statesList.Add("Missouri", "MO");
            statesList.Add("Montana", "MT");
            statesList.Add("Nebraska", "NE");
            statesList.Add("Nevada", "NV");
            statesList.Add("New Hampshire", "NH");
            statesList.Add("New Jersey", "NJ");
            statesList.Add("New Mexico", "NM");
            statesList.Add("New York", "NY");
            statesList.Add("North Carolina", "NC");
            statesList.Add("North Dakota", "ND");
            statesList.Add("Northern Mariana Islands", "MP");
            statesList.Add("Ohio", "OH");
            statesList.Add("Oklahoma", "OK");
            statesList.Add("Oregon", "OR");
            statesList.Add("Pennsylvania", "PA");
            statesList.Add("Puerto Rico", "PR");
            statesList.Add("Rhode Island", "RI");
            statesList.Add("South Carolina", "SC");
            statesList.Add("South Dakota", "SD");
            statesList.Add("Tennessee", "TN");
            statesList.Add("Texas", "TX");
            statesList.Add("Utah", "UT");
            statesList.Add("Vermont", "VT");
            statesList.Add("Virginia", "VA");
            statesList.Add("Virgin Islands", "VI");
            statesList.Add("Washington", "WA");
            statesList.Add("West Virginia", "WV");
            statesList.Add("Wisconsin", "WI");
            statesList.Add("Wyoming", "WY");

            return statesList;
        }
    }
}
