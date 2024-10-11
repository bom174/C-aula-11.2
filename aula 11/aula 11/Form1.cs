namespace aula_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data;

            data = Convert.ToDateTime(Data.Text);

            dataA.Text = data.ToShortDateString();
            dataL.Text = data.ToLongDateString();
            dataC.Text = data.ToString("dd/MM/yy");

            horaA.Text = data.ToShortDateString();
            horaL.Text = data.ToLongDateString();
            horaC.Text = data.ToString("HH:mm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Text = DateTime.Now.ToString();
        }
    }
}