using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PoliticasStock
{
    public class VectorEstado
    {



        public int dia;

        public int diaLlegadaPedido;

        public bool seEfectuaPedido;

        public int demanda;

        public int demora;


        public int contadorAcumuladorDemanda;

        public int demandaAC;

        public int stock;

        public int cantPedido;

        public int costoUnitario;

        public int costoPedido;

        public int costoTotal;

        public int costoRuptura;
    
        public int costoAlmacenamiento;

        public int costoTotalAC;


        public VectorEstado(int dia, int demanda,int stock,  int demora,int diaLLegadaPedido,bool seEfectuaPedido, int cantPedido, int costoUnitario)
        {
            this.dia = dia;
            this.costoTotalAC = 0;
            this.stock = stock;
            this.seEfectuaPedido  = seEfectuaPedido;
            this.diaLlegadaPedido = diaLLegadaPedido;
            this.demanda = demanda;
            this.demora = demora;
            this.costoRuptura = 0;
            this.costoAlmacenamiento = 0;
            this.cantPedido = cantPedido;
            this.costoUnitario = costoUnitario;
            this.costoPedido = costoUnitario * cantPedido;
        }


    }
}
