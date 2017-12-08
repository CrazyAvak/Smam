using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class saveUserSettings
    {
        string name;
        string city;
        string street;
        string school;
        string education;
        string rentDay;


        public void getUserSettings()
        {

        }
        public void saveUser(string name, string city, string street, string school, string education, string dayrent) {
            Properties.Settings.Default.Name = name;
            Properties.Settings.Default.City = city;
            Properties.Settings.Default.Street = street;
            Properties.Settings.Default.School = school;
            Properties.Settings.Default.Education = education;
            Properties.Settings.Default.dayRent = dayrent;            
            Properties.Settings.Default.Save();


        }
    }
}
