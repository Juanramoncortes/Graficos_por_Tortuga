using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos_de_Tortuga
{
    class Tortuga
    {
        bool _pluma;
        public bool pluma { get { return _pluma; } set { _pluma = value; } }
        int _posicion;
        public int posicion { get { return _posicion; } set { _posicion = value; } }
        int[] _localizacion;
        public int[] localizacion { get { return _localizacion; } set { _localizacion = value; } }
        public Graficos Graficos;
        public Tortuga(bool pluma)
        {
            _pluma = pluma;
            _posicion = 2;
            Graficos = new Graficos(20, 20);            
        }
        public Tortuga()
        {
            _pluma = false;
            _posicion = 1;
            _localizacion = new int[]{0,0};
            Graficos = new Graficos(20, 20);
            
        }

        public void avanzar(int posicion, int cantidad, bool pluma)
        {
           _pluma = pluma;
          _posicion = posicion;
            int x = _localizacion[0], y = _localizacion[1];
            int z = x,w=y;
            
            switch (_posicion)
            {
                
                case 0:
                    if (x > 0)
                    {
                        x -= 1;
                        
                       
                    }
                    if (pluma)
                    {

                        for (int I = 1; I <= (cantidad); I++)
                        {
                            w += y - 1;
                            Graficos.tablero[x, w] = '1';
                            
                        }
                    }
                    _localizacion[1] = y - (cantidad);

                    break;
                case 1:
                    
                    if (y > 19)
                    {
                       y -= 1;
                    }
                    
                    

                    if (pluma)
                    {
                        for (int I = 1; (I <= cantidad); I++)
                        {
                                Graficos.tablero[z, y] = '1';
                                z += x + 1;
                        }
                    }

                    _localizacion[0] = (x + cantidad);

                    break;
                case 2:
                    if (x > 0 )
                    {
                        x -= 1;
                       
                    }
                    
                    if (pluma)
                    {
                        for (int I = 1; I <=cantidad; I++)
                        {
                                 w += y + 1;
                                Graficos.tablero[x, w] = '1';
                                
                            
                        }
                    }
                    _localizacion[1] = y + (cantidad);

                    break;
                case 3:
                    if ( y >19)
                    {
                        
                        y -= 1;
                    }
                    
                    if (pluma)
                    {
                        for (int I = 1; I <=(cantidad); I++)
                        {                          
                                z += x - 1;
                                Graficos.tablero[z, y] = '1';
                        }
                    }
                    _localizacion[0] = x - (cantidad);
                    break;
            }

        }

        public int Datos(string[] datos)
        {
            //2,5:12,3,5:12,3,5:12,3,5:12,1,6,7
           // int cantidad=0;

                for (int i = 0; i < datos.Length; i++)
                {
                    int num = 0;
                    int avance = 0;
                    try
                    {
                        num = Convert.ToInt32(datos[i].Trim());
                    }
                    catch (Exception)
                    {
                        if (datos[i].Trim().Contains(":"))
                        {
                            try
                            {
                                string[] avanceValor = datos[i].Split(':');
                                num = Convert.ToInt32(avanceValor[0].Trim());
                                avance = Convert.ToInt32(avanceValor[1].Trim());

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Valor inválido de avance");
                                return 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresa solamente números o ',' para separar las instrucciones o ':' para separar la instrccuión de avance (5) y la cantidad de avance");
                            return 0;
                        }
                    }
                    switch (num)
                    {
                        case 1:
                        _pluma = false;
                            break;
                        case 2:
                        _pluma = true;
                        break;
                        case 3:
                            girar(true);
                            break;
                        case 4:
                            girar(false);
                            break;
                        case 5:                        
                            avanzar(_posicion,avance,_pluma);
                            break;
                        case 6:

                        return 1;
                        
                        case 7:
                            MessageBox.Show("Terminado");
                            return 0;
                    }
                }
            return 0;
            }

        public void girar(bool valor)
        {
            if (valor)
            {
                if (_posicion < 3)
                {
                    _posicion += 1;
                }
                else
                {
                    _posicion = 0;
                }
            }
            else
            {
                if (_posicion > 0)
                {
                    _posicion -= 1;
                }
                else
                {
                    _posicion = 3;
                }

            }
        }
        }
    }
    
    

