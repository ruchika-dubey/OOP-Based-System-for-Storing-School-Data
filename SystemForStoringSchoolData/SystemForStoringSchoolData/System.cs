using System;
using System.Collections.Generic;
using System.Text;

namespace SystemForStoringSchoolData
{
    class System
    {
        public static void Do()
        {

            List<Student> students = new List<Student>();
            List<Subject> subjects = new List<Subject>();
            Student s1 = new Student() { Name = "Ruchika", ClassAndSection = "IV C" };
            Student s2 = new Student() { Name = "Prateek", ClassAndSection = "XII A" };
            Student s3 = new Student() { Name = "Pragya", ClassAndSection = "XI D" };
            Student s4 = new Student() { Name = "Mayank", ClassAndSection = "V B" };
            Student s5 = new Student() { Name = "Nidhi", ClassAndSection = "XI C" };
            Student s6 = new Student() { Name = "Pritika", ClassAndSection = "XI D" };
            students.Add(s1); students.Add(s2); students.Add(s3); students.Add(s4); students.Add(s5); students.Add(s6);
            Subject sub1 = new Subject() { Name = "Ms Tiwary", SubjectCode = " Phy-R123", ClassAndSection = "IV C",SubjectName ="Physis" };
            Subject sub2 = new Subject() { Name = "Mr Dubey", SubjectCode = " Sst-M102", ClassAndSection = "XII A" ,SubjectName ="Social Science"};
            Subject sub3 = new Subject() { Name = "Mrs Reddy", SubjectCode = " Mat-U203", ClassAndSection = "XI D",SubjectName="Maths" };
            Subject sub4 = new Subject() { Name = "Ms Mahapatra", SubjectCode = " Che-R123", ClassAndSection = "V B", SubjectName = "Chemistry" };
            Subject sub5 = new Subject() { Name = "Mr Rai", SubjectCode = " Skt-M102", ClassAndSection = "XI C", SubjectName = "Sanskrit" };
            Subject sub6 = new Subject() { Name = "Mrs Manjan", SubjectCode = " Sci-U203", ClassAndSection = "XI D", SubjectName = "Science" };
            subjects.Add(sub1); subjects.Add(sub2); subjects.Add(sub3); subjects.Add(sub4); subjects.Add(sub5); subjects.Add(sub6);
            Console.WriteLine("Displaying the data:");
            Console.WriteLine("*****Students in a class*****");
            foreach (Student s in students)
                Console.WriteLine(s.GetInfo());
            Console.WriteLine("*****Subjects Taught By Teacher*****");
            foreach (Subject s in subjects)
                Console.WriteLine(s.GetInfo());
           
        }
    }
}
