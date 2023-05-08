using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2PoliticasStock
{
    public partial class FormTablaSimulacion : Form
    {

        private Dictionary<string, string> _tablaProbDemoraAC;
        private Dictionary<string, string> _tablaProbDemandaAC;
        private Dictionary<int, double> _tablaCosto = new Dictionary<int, double>();

        private Random _rndDemanda;
        private int _demanda;

        private bool _seEfectuaPedido;

        private Random _rndDemora;
        private int _demora;

        private int _stock;

        private int _costoAlmacenamiento = 3;
        private int _costoRuptura = 4;

        private int _cantPedido;
        private int _costoUnitario;
        private int _costoTotal;
        private int _costoTotalAcumulado;

        private string _politica;







        public FormTablaSimulacion(Dictionary<string, string> tablaProbDemoraAC, Dictionary<string, string> tablaProbDemandaAC, double[] listaCosto, string politica, int cantPedido)
        {

            int[] listaCantidadesCosto = new int[] { 100, 200, int.MaxValue };

            for (int i = 0; i < 3; i++) {
                _tablaCosto.Add(listaCantidadesCosto[i], listaCosto[i]);
            }
           
            
            _rndDemanda = new Random();
            _rndDemora = new Random();
            _costoTotalAcumulado = 0;
            _stock = 20;
            _politica = politica;
            _cantPedido = cantPedido;


            _cantPedido = cantPedido;
            _tablaProbDemandaAC = tablaProbDemandaAC;
            _tablaProbDemoraAC = tablaProbDemoraAC;
            InitializeComponent();
        }






    }
}
