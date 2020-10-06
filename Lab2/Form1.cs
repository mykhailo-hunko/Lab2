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

   
    public partial class Form1 : Form
    {

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteUniv_Click(object sender, EventArgs e)
        { 
           

        }

        private void dropUniv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // logics.universities.Remove(logics.universities[dropUniv.SelectedIndex]);
           
        }
    }


   
}
