namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataAtual_Click(object sender, EventArgs e)
        {
            DateTime dataHora;

            dataHora = DateTime.Now;

            txtDataInicial.Text = dataHora.ToString("dd/MM/yyyy");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DateTime Data;
            int dia, mes, ano;

            if (TratamentoDeExeption())
            {
                Data = Convert.ToDateTime(txtDataInicial.Text);

                dia = Convert.ToInt32(txtDias.Text);
                mes = Convert.ToInt32(txtMeses.Text);
                ano = Convert.ToInt32(txtAno.Text);

                Data = Data.AddDays(dia);
                Data = Data.AddMonths(mes);
                Data = Data.AddYears(ano);

                txtDataFinal.Text = Data.ToString("dd/MM/yyyy");
            }
            

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DateTime Data;
            int dia, mes, ano;

            if(TratamentoDeExeption())
            {
                Data = Convert.ToDateTime(txtDataInicial.Text);

                dia = Convert.ToInt32(txtDias.Text);
                mes = Convert.ToInt32(txtMeses.Text);
                ano = Convert.ToInt32(txtAno.Text);

                Data = Data.AddDays(-dia);
                Data = Data.AddMonths(-mes);
                Data = Data.AddYears(-ano);

                txtDataFinal.Text = Data.ToString("dd/MM/yyyy");
            }
            
        }

        private bool TratamentoDeExeption()
        {
            bool validador = true;
            DateTime data;
            int dia = 0, mes = 0, ano = 0;

            if(!DateTime.TryParse(txtDataInicial.Text, out data))
            {
                validador = false;
                MessageBox.Show("Insira uma data válida");
            }

            if (txtDias.Text == "" && txtMeses.Text == "" && txtAno.Text == "")
            {
                validador = false;
                MessageBox.Show("Preencha as caixas");
            }

            if(!int.TryParse(txtDias.Text, out dia))
            {
                validador = false;
                MessageBox.Show("Inira um dia válido");
            }

            if (!int.TryParse(txtDias.Text, out mes))
            {
                validador = false;
                MessageBox.Show("Inira um mes válido");
            }

            if (!int.TryParse(txtDias.Text, out ano))
            {
                validador = false;
                MessageBox.Show("Inira um ano válido");
            }

            if (dia <= 0 || mes <= 0 || ano <= 0)
            {
                validador = false;
                MessageBox.Show("Insira um adata maior que zero");
            }

            return validador;
        }
    }
}