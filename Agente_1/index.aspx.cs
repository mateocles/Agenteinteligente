using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agente_1.Red;

namespace Agente_1
{
    public partial class index : System.Web.UI.Page
    {
        public List<int> Y_Ante = new List<int>();
        public List<int> Entradas = new List<int>();
        public List<int> Vector = new List<int>();
        public int Msalida;
        public List<float> Wpesos = new List<float>();
        Random ranpesos = new Random();
        Red_Neuronal Neu;

        DataTable CNX = Conexion.EjecutarConsulta("SELECT * FROM tablero");
        int columna = 0, row = 0;

        protected void Page_Load(object sender, EventArgs e)


    {
            do { columna = buscarAgente2(row); } while (columna == 0);//Buscar Ubicación del agente
            Entradas.Add(AgregarEntrada(columna - 1, row - 1));//Entrada E1
            Entradas.Add(AgregarEntrada(columna - 1, row));//Entrada E2
            Entradas.Add(AgregarEntrada(columna - 1, row + 1));//Entrada E3
            Entradas.Add(0);//Entrada E4
            Vector.Add(Entradas[0]); Vector.Add(Entradas[1]); Vector.Add(Entradas[2]);//Vector de comparación
            for (int i = 0; i < 4; i++) { Y_Ante.Add(0); Response.Write(Entradas[i]); }//Llenar la Y inicial y el vector de conparación
            for (int i = 0; i < 20; i++) { Wpesos.Add(((float)(ranpesos.Next(0, 101)) / 100)); }//Llenar los pesos sinaticos con valores al azar
            Neu = new Red_Neuronal(Entradas, Wpesos); //Instanciar la red neuronal con los valores de las entradas y los pesos
            Msalida = Neu.entrenamiento(Y_Ante, Vector);//Procesos de entrenamiento de ls neurona
            Conexion.EjecutarOperacion("UPDATE `tableroia`.`agente2` SET `Movimiento`='" + Msalida + "' WHERE  `Movimiento`=0 LIMIT 1;");//
        }

        //Buscar Agente
        private int buscarAgente2(int fila)
        {
            if ("2" == CNX.Rows[fila]["C1"].ToString()) { return 1; }
            if ("2" == CNX.Rows[fila]["C2"].ToString()) { return 2; }
            if ("2" == CNX.Rows[fila]["C3"].ToString()) { return 3; }
            if ("2" == CNX.Rows[fila]["C4"].ToString()) { return 4; }
            if ("2" == CNX.Rows[fila]["C5"].ToString()) { return 5; }
            if ("2" == CNX.Rows[fila]["C6"].ToString()) { return 6; }
            if ("2" == CNX.Rows[fila]["C7"].ToString()) { return 7; }
            if ("2" == CNX.Rows[fila]["C8"].ToString()) { return 8; }
            if ("2" == CNX.Rows[fila]["C9"].ToString()) { return 9; }
            if ("2" == CNX.Rows[fila]["C10"].ToString()) { return 10; }
            row++;
            return 0;
        }

        //Agregar entrada en binarios de la tabla del escenario
        private int AgregarEntrada(int colum, int fil)
        {
            try
            {
                if (CNX.Rows[fil][colum].ToString() == "0")
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception)
            {
                return 1;
            }

        }

    }
    

}