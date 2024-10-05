namespace ExercicioWinFormsApp1
{
    public partial class Form1 : Form
    {
        private object resposta;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("você gosta de café?","Pergunta",MessageBoxButtons.YesNo);
            listBox1.Items.Add(resposta);
        }
    }
}
