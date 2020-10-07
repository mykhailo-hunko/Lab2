using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {

        Boolean staff;
        public Form2(Boolean stud)
        {
            staff = !stud;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (checkString(text))
            {
                if (staff)
                {
                    Form1.selectedUniversity.staff.Add(text);
                }
                else
                {
                    Form1.selectedUniversity.students.Add(text);
                }

                MessageBox.Show("Успешно добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } 
            
            
        }

        private Boolean checkString(string A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 'А' && A[i] <= 'Я' || A[i] >= 'a' && A[i] <= 'я' || A[i].Equals(' ') ) 
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
