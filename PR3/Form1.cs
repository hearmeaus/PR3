using Microsoft.EntityFrameworkCore;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Lb2PartnersContext db = new Lb2PartnersContext())
            {
                var partners = db.Partners.Include(u => u.TypeOfPartner).ToList();
                int yOffset = 70; // отступ по вертикали

                foreach (Partner u in partners)
                {
                    Panel partnerPanel = new Panel // создаем новую панель для каждого партнера
                    {
                        Size = new System.Drawing.Size(300, 90), // размер панели
                        Location = new System.Drawing.Point(5, yOffset), // позиция панели
                        BorderStyle = BorderStyle.FixedSingle // граница панели
                    };

                    // Создаем запись для отображения информации о партнере
                    Label partnerLabel = new Label
                    {
                        Text = $"{u.TypeOfPartner.PartnerType} | {u.Name}\n" +
                        $"{u.NameOfDirector}\n" +
                        $"{u.Phone}\n" +
                        $"Рейтинг: {u.Rating}",
                        AutoSize = true, // автоматический размер записи
                    };

                    partnerPanel.Controls.Add(partnerLabel); // добавляем запись на панель



                    this.Controls.Add(partnerPanel); // добавляем панель на форму

                    yOffset += partnerPanel.Height + 10; // отступ между панелями
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}