namespace atividade_03_revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResult.Text = "";
        }

        float n1;
        float n2;
        float total;
        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoMais_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N1");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (txtN2.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N2");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, 0 valor de N1 deve ser numérico");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, 0 valor de N2 deve ser numérico");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            total = n1 + n2;
            lblResult.Text = total.ToString();
        }

        private void btoMenos_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N1");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (txtN2.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N2");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, 0 valor de N1 deve ser numérico");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, 0 valor de N2 deve ser numérico");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            total = n1 - n2;
            lblResult.Text = total.ToString();
        }

        private void btoVezes_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N1");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (txtN2.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N2");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, 0 valor de N1 deve ser numérico");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, 0 valor de N2 deve ser numérico");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            total = n1 * n2;
            lblResult.Text = total.ToString();
        }

        private void btoDivisao_Click(object sender, EventArgs e)
        {
            if (txtN1.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N1");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (txtN2.Text.Trim() == "")
            {
                MessageBox.Show("Erro, informar valor de N2");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, 0 valor de N1 deve ser numérico");
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, 0 valor de N2 deve ser numérico");
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            total = n1 / n2;
            lblResult.Text = total.ToString();
        }
    }
}