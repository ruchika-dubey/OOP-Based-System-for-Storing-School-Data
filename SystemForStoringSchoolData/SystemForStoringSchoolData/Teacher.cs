using System;
using System.Collections.Generic;
using System.Text;

namespace SystemForStoringSchoolData
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }


        public virtual string GetInfo()
        {
            return ("Name:" +this.Name+" Class and Section:" + this.ClassAndSection);
        }

    }
}
