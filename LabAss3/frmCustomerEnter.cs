using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class frmCustomerEnter : Form
    {
        public frmCustomerEnter()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby = "", Status = "";
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";
            try
            {
                CustomerValidation objVal =new CustomerValidation();
                objVal.CheckCustomerName(txtName.Text);

                frmCustomerPreview objPriview = new frmCustomerPreview();
                objPriview.SetValues(txtName.Text, txtCountry.Text, Gender, Hobby, Status);
                objPriview.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
