using System;
using System.Collections.Generic;
using System.Text;

namespace Proje
{
    public class CustomerClass
    {
        

        public string Name { get; set; }
        public string PNumber { get; set; }
        public string JobName { get; set; }
        public CustomerClass(string Name, string PNumber, string JobName)
        {
            this.Name = Name;
            this.PNumber = PNumber;
            this.JobName = JobName;
        }
    }
}
