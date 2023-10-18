using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljanjeIznimkamaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ispitTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void unesiBtn_Click(object sender, EventArgs e)
        {
            try {
                int godRod = Convert.ToInt16(upisTxt.Text);
                ispisTxt.Text = godRod.ToString();
                upisTxt.Clear();
            }

            catch (Exception greska) {
                DialogResult odabir = MessageBox.Show("Molim vas da upišete broj.\nDa li želite izbrisati vaš postojeći unos","Pogrešan unos", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                switch (odabir) { 
                    case DialogResult.Yes:
                        upisTxt.Clear(); break;
                    case DialogResult.No:
                        break;
                
                }

                upisTxt.Select();
            }

        }
    }
}
