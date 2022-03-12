using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    public class Address
    {

        public string Street;
        public string City;
        public string State;
        public string Zip;

        private string _fullAddress;

        public string FullAddress
        {
            get { return $"{Street}, {City}, {State} {Zip}"; }
        }

    }
}
