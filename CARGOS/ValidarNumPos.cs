﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    class ValidarNumPos
    {
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
         
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se aceptan Numeros y Positivos", "Mensaje del Proceso");
            }
        }
    }
}
