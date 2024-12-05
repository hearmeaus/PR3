using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (Lb2PartnersContext db = new Lb2PartnersContext())

            {
                var partners = db.Partners.ToList();
                shapka1.Text = "Партнеры:";
                foreach (Partner u in partners)
                {
                    Output1.Text += ($"{u.Id} - {u.TypeOfPartnerId} - {u.Name} - {u.LegalAdress} - {u.Tin} - {u.NameOfDirector} - {u.Phone} - {u.Email} - {u.Rating}\n");
                }
            }
        }

        private void Output1_Click(object sender, EventArgs e)
        {

        }
    }
}
