using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2G
{
    public partial class Form1 : Form
    {
        private int MarkSubject1;
        private int MarkSubject2;
        

        private int intValidation;

        private bool bSubject1 = false;
        private bool bSubject2 = false;
      





        public Form1()
        {
            InitializeComponent();

            MarkSubject1 = 0;
            MarkSubject2 = 0;

            txtResult.ReadOnly = true;
        }

        private void txtMarkSubject1_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtMarkSubject1, "");
            bSubject1 = false;
            if (!int.TryParse(txtMarkSubject1.Text, out intValidation))
            {
                bSubject1 = true;
                errorProvider1.SetError(txtMarkSubject1, "Please fill the required field");
            }


        }

        

        private void txtMarkSubject2_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(txtMarkSubject2, "");
            bSubject2 = false;
            if (!int.TryParse(txtMarkSubject2.Text, out intValidation))
            {
                bSubject2 = true;
                errorProvider2.SetError(txtMarkSubject2, "Please fill the required field");
            }

        }
      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bSubject1 == false && bSubject2 == false)
                {
                    MarkSubject1 = int.Parse(txtMarkSubject1.Text);
                    MarkSubject2 = int.Parse(txtMarkSubject2.Text);

                    result = ((MarkSubject1 + MarkSubject2) / 2);

                    txtResult.Text = result.ToString();

                    if (result >= 0 && result <= 40)
                    {
                        labelMark.Text = "Grade F";

                    }
                    else if (result >= 40 && result <= 65)
                    {
                        labelMark.Text = "Grade C";

                    }
                    else if (result >= 65 && result <= 75)
                    {
                        labelMark.Text = "Grade B";

                    }
                    else if (result >= 75 && result <= 100)
                    {
                        labelMark.Text = "Grade A";

                    }





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
