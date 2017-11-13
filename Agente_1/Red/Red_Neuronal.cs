using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agente_1.Red
{
    public class Red_Neuronal
    {
        public List<int> Entrada;
        public List<float> Peso;

        public Red_Neuronal(List<int> Entradas, List<float> Pesos)
        {
            Entrada = Entradas;
            Peso = Pesos;
        }

        private int neu_pos = 0, Epo = 1;
        private float Error = 0;

        //Proceso de entrenamiento de la neurona
        public int entrenamiento(List<int> Y_anterior, List<int> Vector)
        {
            List<int> Salida = Y_anterior;
            int pivot = 0;
            Boolean Guardian = true;//Guardian 
            while (Guardian)
            {
                for (int i = 0; i < Entrada.Count; i++) { Salida[i] = modelo1(Peso, Entrada, i, Y_anterior); }

                float resultado = modelo2(Peso, Salida);
                pivot = Pivote(Vector);
                Error = Math.Abs(resultado - pivot);
                if (Error < 0.2)
                {
                   Guardian = false; 
                }
                else
                {
                    Tasa(pivot);
                }
            }

            switch (pivot)
            {
                case 1:
                    return 6;
                case 2:
                    return 7;
                case 3:
                    return 8;
                default:
                    return 0;
            }

        }

        //Modelo red Instar
        private int modelo1(List<float> pesos, List<int> entradas, int neurona, List<int> salidas)
        {
            float resultado = 0;
            switch (neurona)
            {
                case 0: // Neurona 0
                    resultado = (entradas[neurona] * pesos[0]) + (salidas[0] * pesos[1]) + (salidas[1] * pesos[2]) + (salidas[2] * pesos[3]) + (salidas[3] * pesos[4]) + 1;
                    if (resultado < 1) { return 0; } else { return 1; }
                case 1: // Neurona 1
                    resultado = (entradas[neurona] * pesos[5]) + (salidas[0] * pesos[6]) + (salidas[1] * pesos[7]) + (salidas[2] * pesos[8]) + (salidas[3] * pesos[9]) + 1;
                    if (resultado < 1) { return 0; } else { return 1; }
                case 2: // Neuroa 2
                    resultado = (entradas[neurona] * pesos[10]) + (salidas[0] * pesos[11]) + (salidas[1] * pesos[12]) + (salidas[2] * pesos[13] + (salidas[3] * pesos[14])) + 1;
                    if (resultado < 1) { return 0; } else { return 1; }
                case 3: // Neurona 3
                    resultado = (entradas[neurona] * pesos[15]) + (salidas[0] * pesos[16]) + (salidas[1] * pesos[17]) + (salidas[2] * pesos[18]) + (salidas[3] * pesos[19]) + 1;
                    if (resultado < 1) { return 0; } else { return 1; }
            }
            return 0;
        }

        //Modelo Adeline
        private float modelo2(List<float> pesos, List<int> salidas)
        {
            return (pesos[1] * salidas[0]) + (pesos[7] * salidas[1]) + (pesos[13] * salidas[2]) + (pesos[19] * salidas[3]);
        }

        //Tasa
        private void Tasa(int pivote)
        {
            switch (pivote)
            {
                case 1:
                    Peso[1] = Peso[1] - (float)0.1;
                    break;
                case 2:
                    Peso[7] = Peso[7] - (float)0.1;
                    break;
                case 3:
                    Peso[13] = Peso[13] - (float)0.1;
                    break;
                default:
                    Peso[19] = Peso[19] - (float)0.1;
                    break;

            }
          
                

        }
        //pivotes
        private int Pivote(List<int> Vector)
        {
            int pivote = 0;
            if (Vector[1] == 0) { return 2; }
            if (Vector[2] == 0) { return 1; }
            if (Vector[0] == 0) { return 3; }
            
            return pivote;
        }
    }
}