using System.Collections.Generic;


namespace ClinicSupport.Model
{
    /// <summary>
    /// Model class for the states list to be used in the views and user controls
    /// </summary>
    public class States
    {
        Dictionary<string, string> statesList;

        /// <summary>
        /// 0-parameter constructor for States
        /// </summary>
        public States()
        {
            SetStates();
        }

        /// <summary>
        /// Method to set a Dictonary to be used across the application
        /// </summary>
        /// <returns>Dictonary of all U.S. States and Commonwealths</returns>
        public Dictionary<string, string> SetStates()
        {
            statesList = new Dictionary<string, string>
            {
                { "Alabama", "AL" },
                { "Alaska", "AK" },
                { "America Samoa", "AS" },
                { "Arizona", "AZ" },
                { "Arkansas", "AR" },
                { "California", "CA" },
                { "Colorado", "CO" },
                { "Connecticut", "CT" },
                { "Delaware", "DE" },
                { "District of Columbia", "DC" },
                { "Florida", "FL" },
                { "Georgia", "GA" },
                { "Guam", "GU" },
                { "Hawaii", "HI" },
                { "Idaho", "NurseID" },
                { "Illinois", "IL" },
                { "Indiana", "IN" },
                { "Iowa", "IA" },
                { "Kansas", "KS" },
                { "Kentucky", "KY" },
                { "Louisiana", "LA" },
                { "Maine", "ME" },
                { "Maryland", "MD" },
                { "Massachusetts", "MA" },
                { "Michigan", "MI" },
                { "Minnesota", "MN" },
                { "Mississippi", "MS" },
                { "Missouri", "MO" },
                { "Montana", "MT" },
                { "Nebraska", "NE" },
                { "Nevada", "NV" },
                { "New Hampshire", "NH" },
                { "New Jersey", "NJ" },
                { "New Mexico", "NM" },
                { "New York", "NY" },
                { "North Carolina", "NC" },
                { "North Dakota", "ND" },
                { "Northern Mariana Islands", "MP" },
                { "Ohio", "OH" },
                { "Oklahoma", "OK" },
                { "Oregon", "OR" },
                { "Pennsylvania", "PA" },
                { "Puerto Rico", "PR" },
                { "Rhode Island", "RI" },
                { "South Carolina", "SC" },
                { "South Dakota", "SD" },
                { "Tennessee", "TN" },
                { "Texas", "TX" },
                { "Utah", "UT" },
                { "Vermont", "VT" },
                { "Virginia", "VA" },
                { "Virgin Islands", "VI" },
                { "Washington", "WA" },
                { "West Virginia", "WV" },
                { "Wisconsin", "WI" },
                { "Wyoming", "WY" }
            };

            return statesList;
        }
    }
}
