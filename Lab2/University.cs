﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
   public class University
    {

        public string name {  get; set; }
        public int faculty { get; set; }
        public int laboratoriesNumber { get; set; }
        public int lecturesNumber { get; set; }
        public int numberOfStudent { get; set; }
        public List<string> students { get; set; }
        public int staffNumber { get; set; }
        public List<string> staff { get; set; }
        public int laborantNumbers { get; set; }

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
            laborantNumbers = checkLaborantNumbers();
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
                    staff.Remove(nameStaff);
                    staffNumber--;
                    break;
                }
            }
        }

        public void updateLaborantNumbers()
        {
            laborantNumbers = checkLaborantNumbers();
        }

        public int checkLaborantNumbers()
        {
            int temp = (lecturesNumber + laboratoriesNumber) / 2;
            if ((lecturesNumber + laboratoriesNumber) % 2 == 1)
            {
                return (temp + 1);
            }
            else
            {
                return temp;
            }
         
        }
        public int indexLec()
        {
            return 0;
        }
        public int indexLab()
        {
            return 0;
        }


        public static University operator +(University obj, University obj2)
        {
            List<string> stud = obj.students;
            foreach(string str in obj2.students.ToArray())
            {
                stud.Add(str);
            }
           
            List<string> staff = obj.staff;
            foreach (string str in obj2.staff.ToArray())
            {
                staff.Add(str);
            }
            University result = new University(obj.name + "+" + obj2.name, obj.faculty + obj2.faculty, obj.laboratoriesNumber + obj2.laboratoriesNumber, obj.lecturesNumber + obj2.lecturesNumber, stud, staff);
            return result;
        }

        public int this[int index]
        {
            get
            {
                if(index == 1)
                {
                    return laboratoriesNumber;
                } 
                else if(index == 2)
                {
                    return lecturesNumber;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (index == 1)
                {
                   laboratoriesNumber = value;
                }
                else if (index == 2)
                {
                    lecturesNumber = value;
                }
                else
                {
                    
                }
            }
        }
    }
}
