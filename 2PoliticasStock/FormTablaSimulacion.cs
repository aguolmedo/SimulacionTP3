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
        public double _rndDemanda;


        private Random _generadorRndDemora;
        public double _rndDemora;


        private int _costoAlmacenamiento = 3;
        private int _costoRuptura = 4;

        private string _politica;

        private int _cantPedido;
        private int _cantDias;
        private int _cantAMostrar;
        private int _mostrarDesde;

        public VectorEstado? vectorEstadoAnterior;
        public VectorEstado? vectorEstadoActual;







        public FormTablaSimulacion(Dictionary<string, string> tablaProbDemoraAC, Dictionary<string, string> tablaProbDemandaAC, double[] listaCosto, string politica, int cantPedido, int cantDias, int mostrarDesde, int cantAMostrar)
        {

            int[] listaCantidadesCosto = new int[] { 100, 200, int.MaxValue };

            for (int i = 0; i < 3; i++)
            {
                _tablaCosto.Add(listaCantidadesCosto[i], listaCosto[i]);
            }


            _generadorRndDemanda = new Random();
            _generadorRndDemora = new Random();
           

            _politica = politica;

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

            

            for (int i = 1; i <= _cantDias; i++)
            {
                
                var dia = i;
                int demanda = 0, demora = 0;
                _rndDemanda = _generadorRndDemanda.NextDouble();

                foreach (var value in _tablaProbDemandaAC.Keys)
                {
                    if (_rndDemanda < Convert.ToDouble(_tablaProbDemandaAC[value]))
                    {
                        demanda = Convert.ToInt32(value);
                        break;
                    }
                }



                int demandaAC;
                int cantPedido = 0;
                bool seEfectuaPedido =  false;
                if (dia != 1)
                     demandaAC = vectorEstadoAnterior.demandaAC;
                else
                     demandaAC = 0;
                switch (_politica) {

                    case "Politica A":
                       

                        if (dia == 1 | dia % 7 == 0) {
                            seEfectuaPedido = true;
                            cantPedido = _cantPedido;
                            break;
                        };

                        demandaAC = 0;
                        seEfectuaPedido = false;



                        break;
                    case "Politica B":
                        if (dia == 1)
                        {
                            cantPedido = 200;
                            seEfectuaPedido = true;
                            demandaAC = 0;
                            break;
                        }
                        if (dia % 10 == 0)
                        {
                            seEfectuaPedido = true;
                            cantPedido = demandaAC;
                            demandaAC = 0;
                            break;
                        }

                        cantPedido = 0;
                        seEfectuaPedido = false;
                        demandaAC += demanda;
                        break;
                }



                int costo = 0;
                int diaLlegadaPedido = 0;
                if (seEfectuaPedido)
                {
                    _rndDemora = _generadorRndDemora.NextDouble();

                    foreach (var value in _tablaProbDemoraAC.Keys)
                    {
                        if (_rndDemora < Convert.ToDouble(_tablaProbDemoraAC[value]))
                        {
                            demora = Convert.ToInt32(value);
                            diaLlegadaPedido = dia + demora;
                            break;
                        }
                    }

                    foreach (var value in _tablaCosto.Keys)
                    {
                        if (_cantPedido <= value)
                        {
                            costo = Convert.ToInt32(_tablaCosto[value]);
                            break;
                        }
                    }


                }

                if (vectorEstadoAnterior is null)
                {
                    vectorEstadoActual = new VectorEstado(dia, demanda,demanda,20, demora, diaLlegadaPedido, seEfectuaPedido, cantPedido, costo);
                }
               
                

                if (vectorEstadoAnterior is not null)
                {

                    if (seEfectuaPedido)
                    {
                        vectorEstadoActual = new VectorEstado(dia, demanda, demandaAC , vectorEstadoAnterior.stock, demora, diaLlegadaPedido, seEfectuaPedido, cantPedido, costo);

                    }
                    else
                    {
                        vectorEstadoActual = new VectorEstado(dia, demanda, demandaAC, vectorEstadoAnterior.stock, 0, vectorEstadoAnterior.diaLlegadaPedido, seEfectuaPedido, vectorEstadoAnterior.cantPedido, costo);
                    }

                    if (vectorEstadoAnterior.diaLlegadaPedido == vectorEstadoActual.dia) {

                        vectorEstadoActual.stock = vectorEstadoAnterior.stock + vectorEstadoAnterior.cantPedido;
                    }    
                  
                }
                
                vectorEstadoActual.stock -= demanda;

                

                if (vectorEstadoActual.stock < 0) 
                {
                    vectorEstadoActual.costoRuptura = Math.Abs(vectorEstadoActual.stock) * _costoRuptura;
                    vectorEstadoActual.stock = 0;
                }

                vectorEstadoActual.costoAlmacenamiento = vectorEstadoActual.stock * _costoAlmacenamiento;

                vectorEstadoActual.costoTotal = vectorEstadoActual.costoAlmacenamiento + vectorEstadoActual.costoRuptura;


                if (vectorEstadoActual.seEfectuaPedido) {
                    vectorEstadoActual.costoTotal += vectorEstadoActual.costoPedido;
                }

                if (vectorEstadoAnterior is not null)
                {
                    vectorEstadoActual.costoTotalAC = vectorEstadoActual.costoTotal + vectorEstadoAnterior.costoTotalAC;
                }
                else {
                    vectorEstadoActual.costoTotalAC = vectorEstadoActual.costoTotal;
                }


                if (_mostrarDesde <= dia && dia < (_mostrarDesde + _cantAMostrar) || dia == _cantDias)
                {

                    dataGridViewSimulacion.Rows.Add(
                    vectorEstadoActual.dia,
                    _rndDemanda,
                    vectorEstadoActual.demanda,
                    vectorEstadoActual.demandaAC,
                    vectorEstadoActual.seEfectuaPedido,
                    vectorEstadoActual.diaLlegadaPedido,
                    vectorEstadoActual.demora==0 ? 0 : _rndDemora,
                    vectorEstadoActual.demora,
                    vectorEstadoActual.stock,
                    vectorEstadoActual.costoAlmacenamiento,
                    vectorEstadoActual.costoRuptura,
                    vectorEstadoActual.cantPedido,
                    vectorEstadoActual.costoTotal,
                    vectorEstadoActual.costoTotalAC);

                }

                vectorEstadoAnterior = vectorEstadoActual;


                vectorEstadoActual = null;

            };
                
            


            }

        private void FormTablaSimulacion_Load(object sender, EventArgs e)
        {
            dataGridViewSimulacion.Columns.Add("dia", "Día");
            dataGridViewSimulacion.Columns.Add("rndDemanda", "RND Demanda");
            dataGridViewSimulacion.Columns.Add("demanda", "Demanda");
            dataGridViewSimulacion.Columns.Add("DemandaAC", "Demanda AC");
            dataGridViewSimulacion.Columns.Add("seEfectuoPedido", "¿Se efectuó pedido?");
            dataGridViewSimulacion.Columns.Add("DiaLLegadaPedido", "Dia Llegada Pedido");
            dataGridViewSimulacion.Columns.Add("rndDemora", "RND Demora");
            dataGridViewSimulacion.Columns.Add("demora", "Demora");
            dataGridViewSimulacion.Columns.Add("stock", "Stock");
            dataGridViewSimulacion.Columns.Add("costoAlmacenamiento", "Costo Almacenamiento");
            dataGridViewSimulacion.Columns.Add("costoRuptura", "Costo Ruptura");
            dataGridViewSimulacion.Columns.Add("cantPedido", "Cantidad de Pedido");
            dataGridViewSimulacion.Columns.Add("costoTotal", "Costo Total");
            dataGridViewSimulacion.Columns.Add("costoTotalAC", "Costo Total AC");


            Simular();
        }

    }    
      
}

