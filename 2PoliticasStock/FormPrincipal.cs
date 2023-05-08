namespace _2PoliticasStock
{
    public partial class FormPrincipal : Form
    {

        private Dictionary<string, string> TablaDemoraProbAC;
        private Dictionary<string, string> TablaDemandaProbAC;
        private double[] ListaCosto;

        public FormPrincipal()
        {
            InitializeComponent();
            textBoxCantPedido.Visible = false;
            labelCantidadPedido.Visible = false;

            comboBoxPolitica.Items.Add("Politica A");
            comboBoxPolitica.Items.Add("Politica B");

        }

        private void FormPrincipal_onLoad(object sender, EventArgs e)
        {
            InicializarTabla(dataGridViewDemanda, new string[] { "Demanda x día (en decenas)", "Probabilidades" }, new string[] { "0", "10", "20", "30", "40", "50" }, new double[] { 0.05, 0.12, 0.18, 0.25, 0.22, 0.18 });
            InicializarTabla(dataGridViewDemora, new string[] { "Demora (en días)", "Probabilidades" }, new string[] { "1", "2", "3", "4" }, new double[] { 0.15, 0.20, 0.40, 0.25 });
            InicializarTabla(dataGridViewCosto, new string[] { "Decenas pedidas", "Costo ($)" }, new string[] { "0-100", "101-200", ">200" }, new double[] { 200, 280, 300 });

        }

        private void comboBoxPolitica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPolitica.SelectedIndex == 0)
            {
                textBoxCantPedido.Visible = true;
                labelCantidadPedido.Visible = true;
                return;
            }

            textBoxCantPedido.Visible = false;
            labelCantidadPedido.Visible = false;

        }

        private void InicializarTabla(DataGridView dataGridView, string[] header, string[] filaSuperior, double[] filaInferior)
        {
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnCount = filaSuperior.Length + 1;
            dataGridView.RowCount = 2;

            Dictionary<string, string> tablaAc = new Dictionary<string, string>();
            double probAC = 0.0;

            for (int i = 1; i < dataGridView.ColumnCount; i++)
            {

                dataGridView[i, 0].Value = filaSuperior[i - 1];
                dataGridView[i, 0].ReadOnly = true;
                dataGridView[i, 0].Style.BackColor = Color.Gray;


                dataGridView[i, 1].Value = filaInferior[i - 1];
                dataGridView[i, 1].ValueType = typeof(double);
                probAC = probAC + (double)dataGridView[i, 1].Value;
                probAC = Math.Round(probAC, 2);
                tablaAc.Add(dataGridView[i, 0].Value.ToString(), probAC.ToString());
                if (dataGridView.Name == dataGridViewCosto.Name) { ListaCosto = filaInferior; }
            }
            dataGridView[0, 0].Value = header[0];
            dataGridView[0, 0].ReadOnly = true;
            dataGridView[0, 0].Style.BackColor = Color.Gray;
            dataGridView[0, 1].Value = header[1];
            dataGridView[0, 1].ReadOnly = true;
            dataGridView[0, 1].Style.BackColor = Color.Gray;

            if (dataGridView.Name == dataGridViewDemanda.Name) { TablaDemandaProbAC = tablaAc; }
            if (dataGridView.Name == dataGridViewDemora.Name) { TablaDemoraProbAC = tablaAc; }

        }

        private bool verificarTablaProbabilidades(DataGridView dataGridView)
        {

            var probabilidadAC = 0.0;
            for (int i = 1; i < dataGridView.ColumnCount; i++)
            {

                probabilidadAC += (double)dataGridView[i, 1].Value;
                if ((double)dataGridView[i, 1].Value < 0) return false;
            }
            if (probabilidadAC == 1.0) { return true; }
            return false;
        }
        private void buttonSimular_Click(object sender, EventArgs e)
        {
            if (!verificarTablaProbabilidades(dataGridViewDemanda)) MessageBox.Show($"Recorda que la suma de todas las probabilidades debe ser igual a 1. \nNo se puede ingresar numeros negativos.", "Error de validacion en la tabla Demanda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!verificarTablaProbabilidades(dataGridViewDemora)) MessageBox.Show($"Recorda que la suma de todas las probabilidades debe ser igual a 1. \nNo se puede ingresar numeros negativos.", "Error de validacion en la tabla Demora", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var formTablaSimulacion = new FormTablaSimulacion(TablaDemoraProbAC, TablaDemandaProbAC, ListaCosto, comboBoxPolitica.SelectedItem.ToString(), Convert.ToInt32(textBoxCantPedido.Text));

            formTablaSimulacion.Show();

        }
    }


}