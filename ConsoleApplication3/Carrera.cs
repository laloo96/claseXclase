﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace claseTres
{
    public class Carrera
    {
        //Depreticated por collection.
        /*public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;*/
        public List<Auto> listaAutos; 
        private static Random rnd;
        public Auto max = new Auto();
        public Auto min = new Auto();
        public string nombre;
        public string fecha;
        public string lugar;

        public Carrera()
        {
            #region nonColection
            //Depreticated por collection.
            /*this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();*/
            #endregion
            this.listaAutos = new List<Auto>(); //Creo una lista tipada de autos.
            rnd = new Random();
        }
        public Carrera(string nombre, string lugar, string fecha):this()
        {
            this.nombre = nombre;
            this.lugar = lugar;
            this.fecha = fecha;
        }

        public void volverACero()
        {
            foreach (Auto item in this.listaAutos)
            {
                item.VolverAcero();
            }

            max = null;
            min = null;
        }
        #region carrera
        public void CorrerCarreraTime(Tiempo time)
        {
            for (int i = 0; i < (int) time; i++)
            {
                foreach (Auto item in this.listaAutos)
                {
                    item.Agregar((Kilometros)rnd.Next(10, 100), (int)time);                    
                }
                #region nonColection
                //Deprecated.
                /*this.auto1.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto2.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto3.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto4.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto5.Agregar((Kilometros)rnd.Next(10, 100), (int)time);
                this.auto6.Agregar((Kilometros)rnd.Next(10, 100), (int)time);*/
                #endregion
            }

            foreach (Auto item in this.listaAutos)
            {
                int t = 0;  
                    if (t == 0)
                    {
                        max = item;
                        min = item;
                    }
                    else
                    {
                        if ((item.obtenerKilometros) < min.obtenerKilometros)
                            min = item;
                        if ((item.obtenerKilometros) > max.obtenerKilometros)
                            max = item;
                    }
                    t++;
            }
        }

        public void CorrerCarrera(Kilometros kilometros)
        {
            for (int i = 0; i < (int) kilometros; i++)
            {
                foreach (Auto item in this.listaAutos)
                {
                    item.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                }

                foreach (Auto item in this.listaAutos)
                {
                    int t = 0;
                    if (t == 0)
                    {
                        max = item;
                        min = item;
                    }
                    else
                    {
                        if ((item.obtenerKilometros) < min.obtenerKilometros)
                            min = item;
                        if ((item.obtenerKilometros) > max.obtenerKilometros)
                            max = item;
                    }
                    t++;
                }
                #region noncolecion
                //NonColection.
                /*this.auto1.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto2.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto3.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto4.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto5.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));
                this.auto6.Agregar((int)kilometros, (Tiempo)rnd.Next(10, 100));*/
                #endregion
            }


        }
        #endregion
        
        public string MostrarCarreraTiempo()
        {
            StringBuilder str = new StringBuilder();

            foreach (Auto car in this.listaAutos) //Recorre la lista y muestra auto por auto.
            {
                str.AppendLine("Name: "+car.obtenerNombre+"Km recorridos: " + car.obtenerKilometros);
                //Console.WriteLine(car.datosEnString);
            }

            return str.ToString();
            //Console.WriteLine("El ganador es: " + max.datosEnString+"\n"+"El ultimo fue: "+min.datosEnString);
            #region nonColection
            //Deprecated-nonColection-.
            /* this.auto1.MostarAuto();
            this.auto2.MostarAuto();
            this.auto3.MostarAuto();
            this.auto4.MostarAuto();
            this.auto5.MostarAuto();
            this.auto6.MostarAuto();*/
            #endregion
        }

        public string MostrarCarreraKilometros()
        {
            StringBuilder str = new StringBuilder();
            foreach (Auto car in this.listaAutos)
            {
                str.AppendLine("Name: " + car.obtenerNombre + "Tiempo demorado: " + car.obtenerTiempo);
            }
            str.AppendLine("");
            str.AppendLine("");
            str.AppendLine(this.MostrarGanador());
            return str.ToString();
        }

        public string MostrarGanador()
        {
            StringBuilder str = new StringBuilder();

            str.Append("El ganador es: " + max.datosEnString);
            str.AppendLine("  El ultimo fue: " + min.datosEnString);

            return str.ToString();
        }

        //Agrega el auto pasado atraves del metodo Add de system.collection.
        public bool agregarAuto(Auto autoUno)
        {
            this.listaAutos.Add(autoUno);

            return true;
        }

        //Agrega el auto pasado a la lista tambien pasada. Devuelve referencia con el auto ya agregado.
        public static Carrera operator +(Carrera race, Auto auto)
        {
            race.agregarAuto(auto);
            return race;
        }

    }

}
