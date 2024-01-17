using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Calificación_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] calificaciones = new double[4];
            int semestres = 0;
            double suma = 0;
            double promedio = 0;
            do
            {
                string ingresarCalificacion = Interaction.InputBox("Ingresa tu calificación para promediar por semestres");
                if (ingresarCalificacion == "")
                {
                    break;
                }
                else
                {
                    try
                    {
                        double calificacion = Convert.ToDouble(ingresarCalificacion);
                        calificaciones[semestres] = calificacion;
                        semestres++;
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Debes ingresar un valor numero no mayor a 10");
                    }
                }
            } while(semestres < 4);
            if (semestres>0)
            {
                foreach (double item in calificaciones)
                {
                    suma += item;
                }
                promedio = suma / semestres;
                MessageBox.Show("Tu promedio es de " + promedio);
            }
            else
            {
                MessageBox.Show("Debes ingresar algún valor para poder calcular tu promedio");
            }
        }
    }
}
