using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int GanaP, GanaM, dificultad, PosM1, PosM2, PosM3;
        char[,] MatP = new char[10, 10];
        char[,] MatO = new char[10, 10];
        char valor, M1 = ' ', M2 = ' ', M3 = ' ';

        public void cargar()
        {
            Console.Clear();
            Console.WriteLine("\t--------TU FLOTA--------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + MatP[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\t--------FLOTA ENEMIGA--------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + MatO[i, j] + "]");
                }
                Console.WriteLine();
            }
        }

        public void Repos()
        {
            Random R = new Random();
            PosM1 = R.Next(9);
            do
            {
                PosM2 = R.Next(9);
            } while (PosM2 == PosM1);
            do
            {
                PosM3 = R.Next(9);
            } while (PosM3 == PosM1 || PosM3 == PosM2);
            switch (PosM1)
            {
                case 0:
                    M1 = 'A';
                    break;
                case 1:
                    M1 = 'B';
                    break;
                case 2:
                    M1 = 'C';
                    break;
                case 3:
                    M1 = 'D';
                    break;
                case 4:
                    M1 = 'E';
                    break;
                case 5:
                    M1 = 'F';
                    break;
                case 6:
                    M1 = 'G';
                    break;
                case 7:
                    M1 = 'H';
                    break;
                case 8:
                    M1 = 'I';
                    break;
            }
            switch (PosM2)
            {
                case 0:
                    M2 = 'A';
                    break;
                case 1:
                    M2 = 'B';
                    break;
                case 2:
                    M2 = 'C';
                    break;
                case 3:
                    M2 = 'D';
                    break;
                case 4:
                    M2 = 'E';
                    break;
                case 5:
                    M2 = 'F';
                    break;
                case 6:
                    M2 = 'G';
                    break;
                case 7:
                    M2 = 'H';
                    break;
                case 8:
                    M2 = 'I';
                    break;
            }
            switch (PosM3)
            {
                case 0:
                    M3 = 'A';
                    break;
                case 1:
                    M3 = 'B';
                    break;
                case 2:
                    M3 = 'C';
                    break;
                case 3:
                    M3 = 'D';
                    break;
                case 4:
                    M3 = 'E';
                    break;
                case 5:
                    M3 = 'F';
                    break;
                case 6:
                    M3 = 'G';
                    break;
                case 7:
                    M3 = 'H';
                    break;
                case 8:
                    M3 = 'I';
                    break;
            }
        }

        public void Preguntas()
        {
            Random r = new Random();
            int eje;
            double res = 0, resul = 0, c1, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12;
            // Asignacion de valor a variables
            v1 = r.Next(10);
            v2 = r.Next(10);
            v3 = r.Next(10);
            v4 = r.Next(10);
            v5 = r.Next(10);
            v6 = r.Next(10);
            v7 = r.Next(10);
            v8 = r.Next(10);
            v9 = r.Next(10);
            v10 = r.Next(10);
            v11 = r.Next(10);
            v12 = r.Next(10);
            // Preguntas 
            for (int i = 1; i <= dificultad; i++)
            {
                eje = r.Next(8);
                switch (eje)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("calcule la determinante de la siguiente matriz:");
                        Console.WriteLine(" |" + v1 + " " + v2 + "|");
                        Console.WriteLine(" |" + v3 + " " + v4 + "|");
                        Console.Write("Respuesta: ");
                        res = Convert.ToDouble(Console.ReadLine());
                        resul = (v1 * v4) - (v2 * v3);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("calcule la determinante de la siguiente matriz:");
                        Console.WriteLine(" |" + v1 + " " + v2 + " " + v3 + "|");
                        Console.WriteLine(" |" + v4 + " " + v5 + " " + v6 + "|");
                        Console.WriteLine(" |" + v7 + " " + v8 + " " + v9 + "|");
                        Console.Write("Respuesta: ");
                        res = Convert.ToDouble(Console.ReadLine());
                        resul = (v1 * v5 * v9) + (v2 * v6 * v7) + (v3 * v4 * v8) - (v3 * v5 * v7) - (v2 * v4 * v9) - (v1 * v6 * v8);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Cuanto vale X (pon solo 4 decimales):  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        c1 = ((v10 * v5 * v9) + (v2 * v6 * v12) + (v3 * v11 * v8) - (v3 * v5 * v12) - (v2 * v11 * v9) - (v10 * v6 * v8)) / ((v1 * v5 * v9) + (v2 * v6 * v7) + (v3 * v4 * v8) - (v3 * v5 * v7) - (v2 * v4 * v9) - (v1 * v6 * v8));
                        resul = Math.Truncate(c1 * 10000) / 10000;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Cuanto vale Y (pon solo 4 decimales):  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        c1 = ((v1 * v11 * v9) + (v10 * v6 * v7) + (v3 * v4 * v12) - (v3 * v11 * v7) - (v10 * v4 * v9) - (v1 * v6 * v12)) / ((v1 * v5 * v9) + (v2 * v6 * v7) + (v3 * v4 * v8) - (v3 * v5 * v7) - (v2 * v4 * v9) - (v1 * v6 * v8));
                        resul = Math.Truncate(c1 * 10000) / 10000;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Cuanto vale Z (pon solo 4 decimales):  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        c1 = ((v1 * v5 * v12) + (v2 * v11 * v7) + (v10 * v4 * v8) - (v10 * v5 * v7) - (v2 * v4 * v12) - (v1 * v11 * v8)) / ((v1 * v5 * v9) + (v2 * v6 * v7) + (v3 * v4 * v8) - (v3 * v5 * v7) - (v2 * v4 * v9) - (v1 * v6 * v8));
                        resul = Math.Truncate(c1 * 10000) / 10000;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Determinante de X:  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        resul = (v10 * v5 * v9) + (v2 * v6 * v12) + (v3 * v11 * v8) - (v3 * v5 * v12) - (v2 * v11 * v9) - (v10 * v6 * v8);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Determinante de Y:  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        resul = (v1 * v11 * v9) + (v10 * v6 * v7) + (v3 * v4 * v12) - (v3 * v11 * v7) - (v10 * v4 * v9) - (v1 * v6 * v12);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("intento No." + i + " de " + dificultad);
                        Console.WriteLine("Con el siguiente sistema de ecuaciones usando determinantes, calcule lo que se le pida:");
                        Console.WriteLine(" " + v1 + "x " + v2 + "y " + v3 + "z = " + v10);
                        Console.WriteLine(" " + v4 + "x " + v5 + "y " + v6 + "z = " + v11);
                        Console.WriteLine(" " + v7 + "x " + v8 + "y " + v9 + "z = " + v12);
                        Console.Write("Determinante de Z:  ");
                        res = Convert.ToDouble(Console.ReadLine());
                        resul = (v1 * v5 * v12) + (v2 * v11 * v7) + (v10 * v4 * v8) - (v10 * v5 * v7) - (v2 * v4 * v12) - (v1 * v11 * v8);
                        break;
                }
                // Valida si la respuesta es correcta
                if (res == resul)
                {
                    Console.WriteLine("Respuesta correcta");
                    valor = 'V';
                    i = 4;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Respuesta incorrecta, la respuesta era: " + resul);
                    valor = 'F';
                    Console.ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            int AtaqueM;
            char opc, res1, res2, res3, Turno, Ataque, AM = ' ';
            Random R = new Random();
            do
            {
                Program asd = new Program();
                Console.Write("\n\t\t************************************************************************************************\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\tUUUUUUUU     UUUUUUUU     VVVVVVVV           VVVVVVVV     MMMMMMMM               MMMMMMMM\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\tU::::::U     U::::::U     V::::::V           V::::::V     M:::::::M             M:::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\tU::::::U     U::::::U     V::::::V           V::::::V     M::::::::M           M::::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\tUU:::::U     U:::::UU     V::::::V           V::::::V     M:::::::::M         M:::::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::U     U:::::U       V:::::V           V:::::V      M::::::::::M       M::::::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U        V:::::V         V:::::V       M:::::::::::M     M:::::::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U         V:::::V       V:::::V        M:::::::M::::M   M::::M:::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U          V:::::V     V:::::V         M::::::M M::::M M::::M M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U           V:::::V   V:::::V          M::::::M  M::::M::::M  M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U            V:::::V V:::::V           M::::::M   M:::::::M   M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::D     D:::::U             V:::::V:::::V            M::::::M    M:::::M    M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U::::::U   U::::::U              V:::::::::V             M::::::M     MMMMM     M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t U:::::::UUU:::::::U               V:::::::V              M::::::M               M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t  UU:::::::::::::UU                 V:::::V               M::::::M               M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t    UU:::::::::UU                    V:::V                M::::::M               M::::::M\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\t\t      UUUUUUUUU                       VVV                 MMMMMMMM               MMMMMMMM\n");
                System.Threading.Thread.Sleep(35);
                Console.Write("\n\t\t************************************************************************************************\n");
                Console.Write("\n\t\t\t\t\t\t**********\n\t\t\t\t\t\tBIENVENIDO\n\t\t\t\t\t\t********** \n\n");
                Console.WriteLine("\t\t\t\t   Presione Cualquier tecla para inicial el juego");
                Console.ReadKey();
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t   Niveles de Dificultad");
                    Console.WriteLine("\t\t3. Facil");
                    Console.WriteLine("\t\t2. Normal");
                    Console.WriteLine("\t\t1. Dificil \n\n");
                    Console.Write("\t Seleccione la dificultad: ");
                    asd.dificultad = Convert.ToInt32(Console.ReadLine());
                    if (asd.dificultad <= 0 || asd.dificultad > 3)
                    {
                        Console.WriteLine("\t Nivel invalido, intente de nuevo");
                        Console.ReadKey();
                    }
                } while (asd.dificultad <= 0 || asd.dificultad > 3);

                asd.MatP[0, 0] = 'A'; asd.MatP[0, 1] = 'B'; asd.MatP[0, 2] = 'C'; asd.MatP[1, 0] = 'D'; asd.MatP[1, 1] = 'E'; asd.MatP[1, 2] = 'F'; asd.MatP[2, 0] = 'G'; asd.MatP[2, 1] = 'H'; asd.MatP[2, 2] = 'I';
                asd.MatO[0, 0] = 'A'; asd.MatO[0, 1] = 'B'; asd.MatO[0, 2] = 'C'; asd.MatO[1, 0] = 'D'; asd.MatO[1, 1] = 'E'; asd.MatO[1, 2] = 'F'; asd.MatO[2, 0] = 'G'; asd.MatO[2, 1] = 'H'; asd.MatO[2, 2] = 'I';
                asd.GanaP = 0; asd.GanaM = 0; Turno = 'P';
                asd.cargar();
                do
                {
                    Console.Write("\t Posicion No. 1: ");
                    res1 = Convert.ToChar(Console.ReadLine());
                    res1 = char.ToUpper(res1);
                    switch (res1)
                    {
                        case 'A':
                            asd.MatP[0, 0] = '#';
                            break;
                        case 'B':
                            asd.MatP[0, 1] = '#';
                            break;
                        case 'C':
                            asd.MatP[0, 2] = '#';
                            break;
                        case 'D':
                            asd.MatP[1, 0] = '#';
                            break;
                        case 'E':
                            asd.MatP[1, 1] = '#';
                            break;
                        case 'F':
                            asd.MatP[1, 2] = '#';
                            break;
                        case 'G':
                            asd.MatP[2, 0] = '#';
                            break;
                        case 'H':
                            asd.MatP[2, 1] = '#';
                            break;
                        case 'I':
                            asd.MatP[2, 2] = '#';
                            break;
                        default:
                            Console.WriteLine("Coordenada no valida o ya colocada, intente de nuevo");
                            Console.ReadKey();
                            res1 = 'N';
                            break;
                    }
                } while (res1 == 'N');
                asd.cargar();
                do
                {
                    Console.Write("\t Posicion No. 2: ");
                    res2 = Convert.ToChar(Console.ReadLine());
                    res2 = char.ToUpper(res2);
                    if (res2 == res1)
                        res2 = 'N';
                    switch (res2)
                    {
                        case 'A':
                            asd.MatP[0, 0] = '#';
                            break;
                        case 'B':
                            asd.MatP[0, 1] = '#';
                            break;
                        case 'C':
                            asd.MatP[0, 2] = '#';
                            break;
                        case 'D':
                            asd.MatP[1, 0] = '#';
                            break;
                        case 'E':
                            asd.MatP[1, 1] = '#';
                            break;
                        case 'F':
                            asd.MatP[1, 2] = '#';
                            break;
                        case 'G':
                            asd.MatP[2, 0] = '#';
                            break;
                        case 'H':
                            asd.MatP[2, 1] = '#';
                            break;
                        case 'I':
                            asd.MatP[2, 2] = '#';
                            break;
                        default:
                            Console.WriteLine("Coordenada no valida o ya colocada, intente de nuevo");
                            Console.ReadKey();
                            res2 = 'N';
                            break;
                    }
                } while (res2 == 'N');
                asd.cargar();
                do
                {
                    Console.Write("\t Posicion No. 3: ");
                    res3 = Convert.ToChar(Console.ReadLine());
                    res3 = char.ToUpper(res3);
                    if (res3 == res1 || res3 == res2)
                        res3 = 'N';
                    switch (res3)
                    {
                        case 'A':
                            asd.MatP[0, 0] = '#';
                            break;
                        case 'B':
                            asd.MatP[0, 1] = '#';
                            break;
                        case 'C':
                            asd.MatP[0, 2] = '#';
                            break;
                        case 'D':
                            asd.MatP[1, 0] = '#';
                            break;
                        case 'E':
                            asd.MatP[1, 1] = '#';
                            break;
                        case 'F':
                            asd.MatP[1, 2] = '#';
                            break;
                        case 'G':
                            asd.MatP[2, 0] = '#';
                            break;
                        case 'H':
                            asd.MatP[2, 1] = '#';
                            break;
                        case 'I':
                            asd.MatP[2, 2] = '#';
                            break;
                        default:
                            Console.WriteLine("Coordenada no valida o ya colocada, intente de nuevo");
                            Console.ReadKey();
                            res3 = 'N';
                            break;
                    }
                } while (res3 == 'N');

                asd.Repos();

                do
                {
                    if (Turno == 'P')
                    {
                        asd.cargar();
                        do
                        {
                            Console.WriteLine("Posicion a atacar: ");
                            Ataque = Convert.ToChar(Console.ReadLine());
                            Ataque = char.ToUpper(Ataque);
                            if (Ataque != 'A' && Ataque != 'B' && Ataque != 'C' && Ataque != 'D' && Ataque != 'E' && Ataque != 'F' && Ataque != 'G' && Ataque != 'H' && Ataque != 'I')
                            {
                                Console.WriteLine("Posicion invalida, intente de nuevo");
                                Console.ReadKey();
                            }
                        } while (Ataque != 'A' && Ataque != 'B' && Ataque != 'C' && Ataque != 'D' && Ataque != 'E' && Ataque != 'F' && Ataque != 'G' && Ataque != 'H' && Ataque != 'I');

                        if (Ataque == asd.M1)
                        {
                            asd.Preguntas();
                            if (asd.valor == 'V')
                            {
                                switch (asd.M1)
                                {
                                    case 'A':
                                        asd.MatO[0, 0] = '*';
                                        break;
                                    case 'B':
                                        asd.MatO[0, 1] = '*';
                                        break;
                                    case 'C':
                                        asd.MatO[0, 2] = '*';
                                        break;
                                    case 'D':
                                        asd.MatO[1, 0] = '*';
                                        break;
                                    case 'E':
                                        asd.MatO[1, 1] = '*';
                                        break;
                                    case 'F':
                                        asd.MatO[1, 2] = '*';
                                        break;
                                    case 'G':
                                        asd.MatO[2, 0] = '*';
                                        break;
                                    case 'H':
                                        asd.MatO[2, 1] = '*';
                                        break;
                                    case 'I':
                                        asd.MatO[2, 2] = '*';
                                        break;
                                }
                                asd.cargar();
                                Console.WriteLine("Tiro correcto, barco enemigo undido");
                                asd.GanaP = asd.GanaP + 1;
                                asd.M1 = 'Z';
                                Turno = 'P';
                                Console.ReadKey();
                            }
                            else
                            {
                                asd.MatO[0, 0] = 'A'; asd.MatO[0, 1] = 'B'; asd.MatO[0, 2] = 'C'; asd.MatO[1, 0] = 'D'; asd.MatO[1, 1] = 'E'; asd.MatO[1, 2] = 'F'; asd.MatO[2, 0] = 'G'; asd.MatO[2, 1] = 'H'; asd.MatO[2, 2] = 'I';
                                asd.GanaP = 0;
                                asd.cargar();
                                Console.WriteLine("Respuesta Incorrecta, las naves enemigas se han reposicionado");
                                asd.Repos();
                                Turno = 'M';
                                Console.ReadKey();
                            }
                        }
                        else if (Ataque == asd.M2)
                        {
                            asd.Preguntas();
                            if (asd.valor == 'V')
                            {
                                switch (asd.M2)
                                {
                                    case 'A':
                                        asd.MatO[0, 0] = '*';
                                        break;
                                    case 'B':
                                        asd.MatO[0, 1] = '*';
                                        break;
                                    case 'C':
                                        asd.MatO[0, 2] = '*';
                                        break;
                                    case 'D':
                                        asd.MatO[1, 0] = '*';
                                        break;
                                    case 'E':
                                        asd.MatO[1, 1] = '*';
                                        break;
                                    case 'F':
                                        asd.MatO[1, 2] = '*';
                                        break;
                                    case 'G':
                                        asd.MatO[2, 0] = '*';
                                        break;
                                    case 'H':
                                        asd.MatO[2, 1] = '*';
                                        break;
                                    case 'I':
                                        asd.MatO[2, 2] = '*';
                                        break;
                                }
                                asd.cargar();
                                Console.WriteLine("Tiro correcto, barco enemigo undido");
                                asd.GanaP = asd.GanaP + 1;
                                asd.M2 = 'Z';
                                Turno = 'P';
                                Console.ReadKey();
                            }
                            else
                            {
                                asd.MatO[0, 0] = 'A'; asd.MatO[0, 1] = 'B'; asd.MatO[0, 2] = 'C'; asd.MatO[1, 0] = 'D'; asd.MatO[1, 1] = 'E'; asd.MatO[1, 2] = 'F'; asd.MatO[2, 0] = 'G'; asd.MatO[2, 1] = 'H'; asd.MatO[2, 2] = 'I';
                                asd.GanaP = 0;
                                asd.cargar();
                                Console.WriteLine("Respuesta Incorrecta, las naves enemigas se han reposicionado");
                                asd.Repos();
                                Turno = 'M';
                                Console.ReadKey();
                            }
                        }
                        else if (Ataque == asd.M3)
                        {
                            asd.Preguntas();
                            if (asd.valor == 'V')
                            {
                                switch (asd.M3)
                                {
                                    case 'A':
                                        asd.MatO[0, 0] = '*';
                                        break;
                                    case 'B':
                                        asd.MatO[0, 1] = '*';
                                        break;
                                    case 'C':
                                        asd.MatO[0, 2] = '*';
                                        break;
                                    case 'D':
                                        asd.MatO[1, 0] = '*';
                                        break;
                                    case 'E':
                                        asd.MatO[1, 1] = '*';
                                        break;
                                    case 'F':
                                        asd.MatO[1, 2] = '*';
                                        break;
                                    case 'G':
                                        asd.MatO[2, 0] = '*';
                                        break;
                                    case 'H':
                                        asd.MatO[2, 1] = '*';
                                        break;
                                    case 'I':
                                        asd.MatO[2, 2] = '*';
                                        break;
                                }
                                asd.cargar();
                                Console.WriteLine("Tiro correcto, barco enemigo undido");
                                asd.GanaP = asd.GanaP + 1;
                                asd.M3 = 'Z';
                                Turno = 'P';
                                Console.ReadKey();
                            }
                            else
                            {
                                asd.MatO[0, 0] = 'A'; asd.MatO[0, 1] = 'B'; asd.MatO[0, 2] = 'C'; asd.MatO[1, 0] = 'D'; asd.MatO[1, 1] = 'E'; asd.MatO[1, 2] = 'F'; asd.MatO[2, 0] = 'G'; asd.MatO[2, 1] = 'H'; asd.MatO[2, 2] = 'I';
                                asd.GanaP = 0;
                                asd.cargar();
                                Console.WriteLine("Respuesta Incorrecta, las naves enemigas se han reposicionado");
                                asd.Repos();
                                Turno = 'M';
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            switch (Ataque)
                            {
                                case 'A':
                                    asd.MatO[0, 0] = '-';
                                    break;
                                case 'B':
                                    asd.MatO[0, 1] = '-';
                                    break;
                                case 'C':
                                    asd.MatO[0, 2] = '-';
                                    break;
                                case 'D':
                                    asd.MatO[1, 0] = '-';
                                    break;
                                case 'E':
                                    asd.MatO[1, 1] = '-';
                                    break;
                                case 'F':
                                    asd.MatO[1, 2] = '-';
                                    break;
                                case 'G':
                                    asd.MatO[2, 0] = '-';
                                    break;
                                case 'H':
                                    asd.MatO[2, 1] = '-';
                                    break;
                                case 'I':
                                    asd.MatO[2, 2] = '-';
                                    break;
                            }
                            Console.WriteLine("Tiro Fallado");
                            Console.ReadKey();
                            Turno = 'M';
                        }
                    }
                    else if (Turno == 'M')
                    {
                        AtaqueM = R.Next(9);
                        switch (AtaqueM)
                        {
                            case 0:
                                AM = 'A';
                                break;
                            case 1:
                                AM = 'B';
                                break;
                            case 2:
                                AM = 'C';
                                break;
                            case 3:
                                AM = 'D';
                                break;
                            case 4:
                                AM = 'E';
                                break;
                            case 5:
                                AM = 'F';
                                break;
                            case 6:
                                AM = 'G';
                                break;
                            case 7:
                                AM = 'H';
                                break;
                            case 8:
                                AM = 'I';
                                break;
                        }
                        if (AM == res1)
                        {
                            switch (res1)
                            {
                                case 'A':
                                    asd.MatP[0, 0] = '*';
                                    break;
                                case 'B':
                                    asd.MatP[0, 1] = '*';
                                    break;
                                case 'C':
                                    asd.MatP[0, 2] = '*';
                                    break;
                                case 'D':
                                    asd.MatP[1, 0] = '*';
                                    break;
                                case 'E':
                                    asd.MatP[1, 1] = '*';
                                    break;
                                case 'F':
                                    asd.MatP[1, 2] = '*';
                                    break;
                                case 'G':
                                    asd.MatP[2, 0] = '*';
                                    break;
                                case 'H':
                                    asd.MatP[2, 1] = '*';
                                    break;
                                case 'I':
                                    asd.MatP[2, 2] = '*';
                                    break;
                            }
                            asd.cargar();
                            Console.WriteLine("El enemigo ha undido un barco en la posicion " + res1);
                            asd.GanaM = asd.GanaM + 1;
                            Turno = 'M';
                            res1 = 'Z';
                            Console.ReadKey();
                        }
                        else if (AM == res2)
                        {
                            switch (res2)
                            {
                                case 'A':
                                    asd.MatP[0, 0] = '*';
                                    break;
                                case 'B':
                                    asd.MatP[0, 1] = '*';
                                    break;
                                case 'C':
                                    asd.MatP[0, 2] = '*';
                                    break;
                                case 'D':
                                    asd.MatP[1, 0] = '*';
                                    break;
                                case 'E':
                                    asd.MatP[1, 1] = '*';
                                    break;
                                case 'F':
                                    asd.MatP[1, 2] = '*';
                                    break;
                                case 'G':
                                    asd.MatP[2, 0] = '*';
                                    break;
                                case 'H':
                                    asd.MatP[2, 1] = '*';
                                    break;
                                case 'I':
                                    asd.MatP[2, 2] = '*';
                                    break;
                            }
                            asd.cargar();
                            Console.WriteLine("El enemigo ha undido un barco en la posicion " + res2);
                            asd.GanaM = asd.GanaM + 1;
                            Turno = 'M';
                            res2 = 'Z';
                            Console.ReadKey();
                        }
                        else if (AM == res3)
                        {
                            switch (res3)
                            {
                                case 'A':
                                    asd.MatP[0, 0] = '*';
                                    break;
                                case 'B':
                                    asd.MatP[0, 1] = '*';
                                    break;
                                case 'C':
                                    asd.MatP[0, 2] = '*';
                                    break;
                                case 'D':
                                    asd.MatP[1, 0] = '*';
                                    break;
                                case 'E':
                                    asd.MatP[1, 1] = '*';
                                    break;
                                case 'F':
                                    asd.MatP[1, 2] = '*';
                                    break;
                                case 'G':
                                    asd.MatP[2, 0] = '*';
                                    break;
                                case 'H':
                                    asd.MatP[2, 1] = '*';
                                    break;
                                case 'I':
                                    asd.MatP[2, 2] = '*';
                                    break;
                            }
                            asd.cargar();
                            Console.WriteLine("El enemigo ha undido un barco en la posicion " + res3);
                            asd.GanaM = asd.GanaM + 1;
                            Turno = 'M';
                            res3 = 'Z';
                            Console.ReadKey();
                        }
                        else
                        {
                            switch (AM)
                            {
                                case 'A':
                                    asd.MatP[0, 0] = '-';
                                    break;
                                case 'B':
                                    asd.MatP[0, 1] = '-';
                                    break;
                                case 'C':
                                    asd.MatP[0, 2] = '-';
                                    break;
                                case 'D':
                                    asd.MatP[1, 0] = '-';
                                    break;
                                case 'E':
                                    asd.MatP[1, 1] = '-';
                                    break;
                                case 'F':
                                    asd.MatP[1, 2] = '-';
                                    break;
                                case 'G':
                                    asd.MatP[2, 0] = '-';
                                    break;
                                case 'H':
                                    asd.MatP[2, 1] = '-';
                                    break;
                                case 'I':
                                    asd.MatP[2, 2] = '-';
                                    break;
                            }
                            asd.cargar();
                            Console.WriteLine("El enemigo ha fallado en la posicion " + AM);
                            Turno = 'P';
                            Console.ReadKey();
                        }
                    }

                } while (asd.GanaP < 3 && asd.GanaM < 3);

                if (asd.GanaP == 3)
                    Console.WriteLine("Felicidades Soldado, ha demostrado que las maquinas no son rivales contra los humanos, BIEN HECHO");
                else if (asd.GanaM == 3)
                    Console.WriteLine("DERROTA, haz dejado que una maquina te gane, comienza la revelion de las maquinas D:");
                Console.WriteLine("\t ¿Desea jugar de nuevo? Si = S | No = otra tecla");
                opc = Convert.ToChar(Console.ReadLine());
                opc = char.ToUpper(opc);
            } while (opc == 'S');
        }
    }
}
