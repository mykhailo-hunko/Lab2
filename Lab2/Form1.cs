using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{

   
    public partial class Form1 : Form
    {
        static public University selectedUniversity;
        Logics logics;
        public Form1()
        {
            InitializeComponent();
             logics = new Logics();
            logics.inizialaze();
            iniz();

        }

        private void iniz()
        {
                 for (int i = 0; i < logics.universities.Count; i++)
                            {
                                dropUniv.Items.Add(logics.universities[i].name);
                            }
            dropUniv.Text = logics.universities[0].name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteUniv_Click(object sender, EventArgs e)
        {
            if (dropUniv.SelectedIndex > -1)
            {
                logics.universities.Remove(logics.universities[dropUniv.SelectedIndex]);
                dropUniv.Items.Remove(dropUniv.SelectedItem);
                facultyAmount.Text = "0";
                lecAmount.Text = "0";
                labAmount.Text = "0"; 
            }
            else
            {
                messageBox();
            }
        }

        private void dropUniv_SelectedIndexChanged(object sender, EventArgs e)
        {

            update();

        }

        private void addLab_Click(object sender, EventArgs e)
        {
             selectedUniversity.laboratoriesNumber++;
            labAmount.Text = selectedUniversity.laboratoriesNumber.ToString();
            selectedUniversity.updateLaborantNumbers();
            laborantAmount.Text = selectedUniversity.laborantNumbers.ToString();
        }

        private void addLec_Click(object sender, EventArgs e)
        {
            selectedUniversity.lecturesNumber++;
            lecAmount.Text = selectedUniversity.lecturesNumber.ToString();
            selectedUniversity.updateLaborantNumbers();
            laborantAmount.Text = selectedUniversity.laborantNumbers.ToString();
        }

        private void addStud_Click(object sender, EventArgs e)
        {
            Form2 enterData = new Form2(true);
            enterData.ShowDialog();

            update();
            // laborantAmount.Text =  enterData.Name;
        }

        private void deleteStud_Click(object sender, EventArgs e)
        {
            if (dropStud.SelectedIndex > -1)
            {
                selectedUniversity.students.Remove(selectedUniversity.students[dropStud.SelectedIndex]);
                dropStud.Items.Remove(dropStud.SelectedItem);
            }
            else
            {
                messageBox();
            }

        }

        private void deleteTeach_Click(object sender, EventArgs e)
        {
            if (dropTeach.SelectedIndex > -1)
            {
                selectedUniversity.students.Remove(selectedUniversity.staff[dropTeach.SelectedIndex]);
                dropTeach.Items.Remove(dropTeach.SelectedItem);
            }
            else
            {
                messageBox();
            }
        }
        private void messageBox()
        {
            MessageBox.Show("Никто не выбран. \nПопробуйте еще раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void update()
        {
            dropStud.Items.Clear();
            dropTeach.Items.Clear();
            for (int i = 0; i < logics.universities.Count; i++)
            {
                if ((logics.universities[i].name).Equals(dropUniv.SelectedItem))
                {
                    selectedUniversity = logics.universities[i];
                }
            }
            facultyAmount.Text = selectedUniversity.faculty.ToString();
            lecAmount.Text = selectedUniversity.lecturesNumber.ToString();
            labAmount.Text = selectedUniversity.laboratoriesNumber.ToString();
            laborantAmount.Text = selectedUniversity.laborantNumbers.ToString();
            for (int i = 0; i < selectedUniversity.students.Count; i++)
            {
                dropStud.Items.Add(selectedUniversity.students[i]);
            }
            for (int i = 0; i < selectedUniversity.staff.Count; i++)
            {
                dropTeach.Items.Add(selectedUniversity.staff[i]);
            }
        }

        private void addTeach_Click(object sender, EventArgs e)
        {
            Form2 enterData = new Form2(false);
            enterData.ShowDialog();
            update();
        }

        private void toOne_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 10)
            int rnd1 = rnd.Next(0, logics.universities.Count - 1);
            int rnd2 = rnd.Next(0, logics.universities.Count - 1);
           //University univ = logics.universities[rnd1] + logics.universities[rnd2];
        }
        public static University operator +(University obj, University obj2)
        {
            University result = new University(obj.name + "+" + obj2.name, obj.faculty + obj2.faculty, obj.laboratoriesNumber + obj2.laboratoriesNumber, obj.lecturesNumber + obj2.lecturesNumber, obj.students.Join(obj2.students), obj.staff.Union<>(obj2.staff) );
            return result;
        }
    }


   
}
