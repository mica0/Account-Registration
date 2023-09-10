using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void NextBTN_Click(object sender, EventArgs e)
        {
            StudentInfo.FirstName = FirstNBox.Text.ToString();
            StudentInfo.LastName = LastNBox.Text.ToString();
            StudentInfo.MiddleName = MiddleNBox.Text.ToString();
            StudentInfo.Address = AddressBox.Text.ToString();
            StudentInfo.Program = ProgramBox.Text.ToString();

            StudentInfo.Age = Convert.ToInt64(AgeBox.Text.ToString());
            StudentInfo.ContactNo = Convert.ToInt64(ContactNBox.Text.ToString());
            StudentInfo.StudentNo = Convert.ToInt64(StudentNBox.Text.ToString());

            using (FrmConfirm confirm = new FrmConfirm()) {
                if (confirm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    StudentNBox.Clear();
                    ProgramBox.SelectedIndex = 1;
                    LastNBox.Clear();
                    FirstNBox.Clear();
                    MiddleNBox.Clear();
                    AgeBox.Clear();
                    ContactNBox.Clear();
                    AddressBox.Clear();
                }
            
            }
        }
    }
}

