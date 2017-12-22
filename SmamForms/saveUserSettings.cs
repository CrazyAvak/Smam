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
            Console.WriteLine(Properties.Settings.Default.Name);
        }
        public void isInstalled()
        {
            Properties.Settings.Default.hasStarted = "1";
        }

        public override string ToString()
        {
            return Properties.Settings.Default.Name.ToString() + " - " + Properties.Settings.Default.City.ToString() + " - " + Properties.Settings.Default.School.ToString() + " - " + Properties.Settings.Default.Education.ToString() + " - " + Properties.Settings.Default.dayRent.ToString();        }
    }
}
