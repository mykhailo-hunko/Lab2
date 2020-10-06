using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class University
    {

        public string name {  get; set; }
        private int faculty { get; set; }
        private int laboratoriesNumber { get; set; }
        private int lecturesNumber { get; set; }
        private int numberOfStudent { get; set; }
        private List<String> students { get; set; }
        private int staffNumber { get; set; }
        private List<String> staff { get; set; }
        private int laborantNumbers { get; set; }

        //инициализирующий
        public University(string name, int faculty, int laboratoriesNumber, int lecturesNumber, List<string> students, List<string> staff)
        {
            this.name = name;
            this.faculty = faculty;
            this.laboratoriesNumber = laboratoriesNumber;
            this.lecturesNumber = lecturesNumber;
            numberOfStudent = students.Count;
            this.students = students;
            this.students.Sort();
            staffNumber = staff.Count;
            this.staff = staff;
            this.staff.Sort();
            int temp = (lecturesNumber + laboratoriesNumber) / 2;
            if (temp % 2 == 1)
            {
                laborantNumbers = temp + 1;
            }
            else
            {
                laborantNumbers = temp;
            }
        }
        //копирующий
        public University(University university)
        {
            name = university.name;
            faculty = university.faculty;
            laboratoriesNumber = university.laboratoriesNumber;
            lecturesNumber = university.lecturesNumber;
            numberOfStudent = university.numberOfStudent;
            students = university.students;
            staffNumber = university.staffNumber;
            int temp = (university.lecturesNumber + university.laboratoriesNumber) / 2;
            if (temp % 2 == 1)
            {
                laborantNumbers = temp + 1;
            }
            else
            {
                laborantNumbers = temp;
            }
        }

        public void deleteStud(String nameStud)
        {
            foreach (string student in students)
            {
                if (student.Equals(nameStud))
                {
                    students.Remove(student);
                    numberOfStudent--;
                    break;
                }
            }
        }

        public void addStud(String name)
        {
            students.Add(name);
            numberOfStudent--;
        }

        public void addLec()
        {
            lecturesNumber++;
        }

        public void addLab()
        {
            laboratoriesNumber++;
        }
        public void addStuff(string nameStaff)
        {
            staff.Add(nameStaff);
            staffNumber++;
        }

        public void deleteStaff(string nameStaff)
        {
            foreach (string st in staff)
            {
                if (st.Equals(nameStaff))
                {
                    staff.Remove(st);
                    numberOfStudent--;
                    break;
                }
            }
        }
    }
}
