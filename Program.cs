using System;

namespace Practica_4_Part._1_
{
    class Program
    {

        static void Main(string[] args)

        //Ejercicio 1

        #region 
        // Un programa que pida al usuario 4 números, los memorice (utilizando un array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
        #endregion

        {
            /*int[] numero = new int[4];
            int suma = 0;
            int m;

            Console.WriteLine("Introduzca 4 números\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduzca el valor {0}: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
                suma += numero[i];
            }
            m = suma / 4;
            Console.WriteLine("Los números introducidos en el teclado son: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" {0} ", numero[i]);
            }
            Console.WriteLine("\nLa media aritmetica es: {0}\n", m);*/


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 2

            #region 
            //Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.
            #endregion

            /*float[] numero = new float[5];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Introduzca el valor real {0}", i);
                numero[i] = float.Parse(Console.ReadLine());

            }
            for (int i = 4; i >= 0; i--)
            {
                Console.Write("{0} ", numero[i]);

            }*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 3

            #region 
            //Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.
            #endregion

            /*int mes;
            int[] meses = new int[13];
            meses[1] = 31;
            meses[2] = 28;
            meses[3] = 30;
            meses[4] = 31;
            meses[5] = 31;
            meses[6] = 30;
            meses[7] = 31;
            meses[8] = 31;
            meses[9] = 30;
            meses[10] = 31;
            meses[11] = 31;
            meses[12] = 31;

            string[] nombre = new string[13];
            nombre[1] = "Enero";
            nombre[2] = "Febrero";
            nombre[3] = "Marzo";
            nombre[4] = "Abril";
            nombre[5] = "Mayo";
            nombre[6] = "Junio";
            nombre[7] = "Julio";
            nombre[8] = "Agosto";
            nombre[9] = "Septiembre";
            nombre[10] = "Octubre";
            nombre[11] = "Noviembre";
            nombre[12] = "Diciembre";

            Console.WriteLine("\nPrograma que muestra los días que tiene un mes\n");

            Console.WriteLine("Ingrese el número de orden del mes");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} tiene {1} días", nombre[mes], meses[mes]);*/




            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 4

            #region 
            //Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.
            #endregion

            /*int[] numero = new int[10];
            int mayor;
            mayor = numero[0];

            Console.WriteLine("\nPrograma que identifica cuál es el número mayor entre los 10 valores introducidos\n");
            Console.WriteLine("\nIngrese 10 números\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el número {0}", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] > mayor) mayor = numero[i];
            }
            Console.WriteLine("\nEl mayor de todos los números es: {0}", mayor);*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 5

            #region 
            //Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.
            #endregion

            /*String[] nombres = new String[100];
            int cont = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre: {0} ", i + 1);
                String nom = Console.ReadLine();
                if (nom == "")
                {
                    break;
                }
                else
                {
                    nombres[i] = nom;
                    cont++;
                }
            }
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(nombres[i]);
            }*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 7
            #region 
            //Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Juan", debería aparecer en pantalla "J u a n".
            #endregion


            /*Console.WriteLine("Introduca su nombre");
            string nombre = Console.ReadLine();
            char[] nom = nombre.ToCharArray();
            foreach (char n in nom)
            {

                Console.Write("{0} ", n);
            }*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 8
            #region 
            //Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas.

            //Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
            #endregion

            /*int i, my = 0, mn = 0;
            float[] alt = new float[5];
            float sum = 0, prom;


            for (i = 0; i < alt.Length; i++)
            {

                Console.Write("Ingrese la altura de la persona {0}\n", i + 1);
                alt[i] = float.Parse(Console.ReadLine());


            }
            for (i = 0; i < alt.Length; i++)
            {
                sum = sum + alt[i];


            }
            prom = sum / 5;
            Console.WriteLine("\nPromedio de las alturas: {0}\n", prom);

            for (i = 0; i < alt.Length; i++)
            {

                if (alt[i] > prom)
                {
                    my++;
                }
                else
                {
                    if (alt[i] < prom)
                    {
                        mn++;
                    }

                }
            }

            Console.WriteLine("Cantidad de personas mayores al promedio: {0}", my);
            Console.WriteLine("Cantidad de personas menores al promedio: {0}", mn);

            return;*/

            #region 
            //Los ejercicios 9 y 10 están en el otro repositorio, para una mejor organización.
            #endregion


        }

    }


}
