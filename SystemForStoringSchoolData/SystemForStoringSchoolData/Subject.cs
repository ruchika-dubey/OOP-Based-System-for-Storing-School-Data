using System;
using System.Collections.Generic;
using System.Text;

namespace SystemForStoringSchoolData
{
    class Subject : Teacher
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher;
        public override string GetInfo()
        {
            return ("Name:" + this.Name + " Class and Section:" + this.ClassAndSection+ " Subject Name: " + this.SubjectName+ " Subject Code: " +this.SubjectCode);
        }


    }
}
