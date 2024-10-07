using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

     
        private void button1_Click_1(object sender, EventArgs e)
        { // Create a new instance of StudentInfo
            StudentInfo student = new StudentInfo
            {
                FirstName = tb_firstName.Text,
                LastName = tb_lastName.Text,
                StudentID = tb_studentID.Text
            };

            // Add information to the list boxes
            lb_firstName.Items.Add(student.FirstName);
            lb_lastName.Items.Add(student.LastName);
            lb_studentID.Items.Add(student.StudentID);

            // Clear text boxes after adding
            tb_firstName.Clear();
            tb_lastName.Clear();
            tb_studentID.Clear();
        }

        
    }
}
