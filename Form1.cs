using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        /*23. Realizar un programa en el que vayamos introduciendo el peso de los distintos alumnos de
        una clase.Los pesos se irán introduciendo con InputBox hasta que se introduzca un peso
        negativo, de manera similar a como se hace en el ejercicio 15.
        Queremos obtener cuántos alumnos hay en cada uno de los rangos de peso siguientes: (<=50),
        (>50 y <=65), (>65 y <=80), (>80) así como el tanto por ciento que representan frente al total
        de alumnos y el peso medio de toda la clase.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonIntro_Click(object sender, EventArgs e)
        {
            int peso, pesoMin, pesoMax;

            peso = int.Parse(Interaction.InputBox("Introduzca un Peso:", "Ejercicio23","0"));

            if(peso > 0)
            {
                pesoMax = peso;


                pesoMin = peso;

                while (peso > 0)
                {
                    if (peso > pesoMax)
                    {
                        pesoMax = peso;
                    }
                    if (peso < pesoMin)
                    {
                        pesoMin = peso;

                    }


                peso = int.Parse(Interaction.InputBox("Introduca un Peso:", "Ejercicio23", "0"));//try cach dentro de interaction
                }

                MessageBox.Show("El Peso máximo es:" + pesoMax + ", y el menor es: " + pesoMin);
            }
            else
            {

                MessageBox.Show("Ha introducido un Peso negativo. No hay máximo ni mínimo");
            }

        }

    }
}
