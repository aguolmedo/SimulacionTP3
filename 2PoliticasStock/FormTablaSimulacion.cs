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

        private Random _generadorRndDemanda;
        private double _rndDemanda;
        private int _demanda;

        private bool _seEfectuaPedido;

        private Random _generadorRndDemora;
        private double _rndDemora;
        private int _demora;

        private int _stock;

        private int _costoAlmacenamiento = 3;
        private int _costoRuptura = 4;

        private int _cantPedido;
        private int _costoUnitario;
        private int _costoTotal;
        private int _costoTotalAcumulado;

        private string _politica;

        private int _dia;
        private int _cantDias;
        private int _cantAMostrar;
        private int _mostrarDesde;







        public FormTablaSimulacion(Dictionary<string, string> tablaProbDemoraAC, Dictionary<string, string> tablaProbDemandaAC, double[] listaCosto, string politica, int cantPedido, int cantDias, int mostrarDesde, int cantAMostrar)
        {

            int[] listaCantidadesCosto = new int[] { 100, 200, int.MaxValue };

            for (int i = 0; i < 3; i++)
            {
                _tablaCosto.Add(listaCantidadesCosto[i], listaCosto[i]);
            }


            _generadorRndDemanda = new Random();
            _generadorRndDemora = new Random();
            _costoTotalAcumulado = 0;
            _stock = 20;
            _politica = politica;
            _cantPedido = cantPedido;

            _dia = 0;
            _cantDias = cantDias;
            _cantAMostrar = cantAMostrar;
            _mostrarDesde = mostrarDesde;


            _cantPedido = cantPedido;
            _tablaProbDemandaAC = tablaProbDemandaAC;
            _tablaProbDemoraAC = tablaProbDemoraAC;
            InitializeComponent();
        }


        public void Simular()
        {

            for (int i = 0; i < _cantDias; i++)
            {

                _dia = i;
                _rndDemanda = _generadorRndDemanda.NextDouble();

                foreach (var value in _tablaProbDemandaAC.Keys)
                {
                    if (_rndDemanda < Convert.ToDouble(_tablaProbDemandaAC[value]))
                    {
                        _demanda = Convert.ToInt32(value);
                        break;
                    }
                }

                switch (_politica) {

                    case "Politica A":
                        break;
                    case "Politica B":
                        break;




                }







            }



        }

        private void FormTablaSimulacion_Load(object sender, EventArgs e)
        {
            Simular();
        }
    }
}
