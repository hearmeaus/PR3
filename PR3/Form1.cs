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
                var prodTypes = db.ProductTypes.ToList();
                shapka.Text = "Типы продуктов:";
                foreach (ProductType u in prodTypes)
                {
                   Output.Text += ($"{u.Id} - {u.TypeProduct}\n");
                }
            }
        }

        private void shapka_Click(object sender, EventArgs e)
        {

        }

        private void Output_Click(object sender, EventArgs e)
        {

        }
    }
}
