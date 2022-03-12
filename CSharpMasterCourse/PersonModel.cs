using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get { 
                return _age; 
            }

            set { 
                if(value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in valid range.");
                }
            }
        }



        private string _ssn;

        public string SSN
        {
            get {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set { _ssn = value; }
        }


        private string _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public PersonModel()
        {

        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }


    }
}
