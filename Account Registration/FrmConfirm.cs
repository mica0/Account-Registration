using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfo.GetProgram);
            DelLastName = new DelegateText(StudentInfo.GetLastName);
            DelFirstName = new DelegateText(StudentInfo.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfo.GetMiddleName);
            DelAddress = new DelegateText(StudentInfo.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfo.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfo.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfo.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            SNConfirm.Text = Convert.ToString(DelStudNo(StudentInfo.StudentNo));
            PConfirm.Text = DelProgram(StudentInfo.Program);
            LConfirm.Text = DelLastName(StudentInfo.LastName);
            FConfirm.Text = DelFirstName(StudentInfo.FirstName);
            MConfirm.Text = DelMiddleName(StudentInfo.MiddleName);
            AConfirm.Text = Convert.ToString(DelNumAge(StudentInfo.Age));
            CNConfirm.Text = Convert.ToString(DelNumContactNo(StudentInfo.ContactNo));
            AddConfirm.Text = DelAddress(StudentInfo.Address); 
        }
    }
}
