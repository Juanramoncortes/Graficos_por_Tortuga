using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_de_Tortuga
{
    class Graficos
    {
        public char[,] tablero { get; set; }   
        
        public Graficos(int x,int y)
        {
            tablero = new char[x, y];
            generar();
            
        }
        private void generar()
        {
            for (int x = 0; x < 20; x++)
            for (int y=0; y < 20; y++)
            {
                tablero[x, y] = '0';
               
            }
        }            
        public override string ToString()
        {
            string txt="";
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    txt += Convert.ToString(tablero[x, y])+" ";
                }
                txt += Environment.NewLine;
            }
            return txt;
        }
    }
}
