using System;
using System.Threading;

namespace HoraData
{
    public class MainClass
    {

        public static void Main()
        {
            string version = "1.0";
            string DiaDaSemana;
            string mes;

            Console.WriteLine("##########################");
            Console.WriteLine("Hora e Data - Versão {0}", version);
            Console.WriteLine("##########################\n");
            Console.WriteLine("Para sair, 'CTRL + C'!\n");

            while (true)
            {

                switch ((int)DateTime.Now.DayOfWeek)
                {

                    case 0:

                        DiaDaSemana = "Domingo";
                        break;

                    case 1:

                        DiaDaSemana = "Segunda-feira";
                        break;

                    case 2:

                        DiaDaSemana = "Terça-feira";
                        break;
                    case 3:

                        DiaDaSemana = "Quarta-feira";
                        break;
                        break;

                    case 4:

                        DiaDaSemana = "Quinta-feira";
                        break;

                    case 5:

                        DiaDaSemana = "Sexta-feira";
                        break;

                    case 6:

                        DiaDaSemana = "Sábado";
                        break;

                    default:
                        DiaDaSemana = "N/D";
                        break;

                }

                switch ((int)DateTime.Now.Month)
                {

                    case 1:

                        mes = "Janeiro";
                        break;

                    case 2:

                        mes = "Fevereiro";
                        break;

                    case 3:

                        mes = "Março";
                        break;

                    case 4:

                        mes = "Abril";
                        break;

                    case 5:

                        mes = "Maio";
                        break;

                    case 6:

                        mes = "Junho";
                        break;

                    case 7:

                        mes = "Julho";
                        break;

                    case 8:

                        mes = "Agosto";
                        break;

                    case 9:

                        mes = "Setembro";
                        break;

                    case 10:

                        mes = "Outubro";
                        break;

                    case 11:

                        mes = "Novembro";
                        break;

                    case 12:

                        mes = "Dezembro";
                        break;

                    default:

                        mes = "N/D";
                        break;


                }

                Console.Write("\r{0} - {1} de {2} de {3} - {4}",
                              DiaDaSemana,
                              DateTime.Now.ToString("dd"),
                              mes,
                              DateTime.Now.ToString("yyyy"),
                              DateTime.Now.ToString("HH:mm:ss"));


                Thread.Sleep(1000);

            }


        }
    }
}