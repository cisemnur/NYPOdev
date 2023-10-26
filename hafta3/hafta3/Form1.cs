namespace hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            personel prs1 = new personel (adTxt.Text,adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaýTxt.Text),comboBox1 .Text);
            if(comboBox1.Text == "Ýþçi")


            {
                MessageBox.Show(prs1.ucrethesapla().ToString());
            }
            else
            {
                prs1.ucrethesapla(1000);
            }
                    
        } 
    }
}