﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCampu_Clase7
{
    class Program
    {
        static void Main()
        {
            Cajon cajon = new Cajon();
            for (int i = 0; i < 10; i++)
            {
                Fruta fruit = new Fruta();
                cajon.AgregarFruta(fruit);
            }
            cajon.


            
            Console.ReadKey();


        }
    }
}
