using System;
namespace Periodo_Atras.ConsoleApp
{
    internal class Data
    {

        public DateTime data;
        public double resto = 0;
        public string resultado;

        public void obterData()
        {

            Console.WriteLine("Insira ");
            try
            {

                data = Convert.ToDateTime(Console.ReadLine());

            }
            catch (Exception)
            {

                Console.WriteLine("Erro!");

            }

        }

        public void obterPeriodoAtras()
        {

            TimeSpan diasTotais = DateTime.Now - data;

            obterAnos(diasTotais);
            obterMeses(resto);
            obterSemanas(resto);
            obterDias(resto);
        }

        public void obterAnos(TimeSpan diasTotais)
        {

            double anos = Math.Floor(diasTotais.TotalDays / 365);

            if (anos == 0)
            {

                resto = Math.Floor(diasTotais.TotalDays);
                return;

            }
                

                
            else
            {

                this.resto = Math.Floor(diasTotais.TotalDays % 365);

                resultado += anos.ToString() + " ano(s) + ";

            }

        }

        public void obterMeses(double resto)
        {

            double meses = resto / 30;
            meses = Math.Floor(meses);

            if (meses == 0)
                return;
            else
            {

                this.resto = Math.Floor(resto % 30);

                resultado += Math.Floor(meses).ToString() + " mês(es) + ";

            }
        }

        public void obterSemanas(double resto)
        {

            double semanas = resto / 7;
            semanas = Math.Floor(semanas); 

            if (semanas == 0)
                return;
            else
            {

                this.resto = Math.Floor(resto % 7);

                resultado += Math.Floor(semanas).ToString() + " semana(s) + ";

            }

        }

        public void obterDias(double resto)
        {

            double dias = resto;

            if (dias == 0)
                return;
            else
            {

                resultado += Math.Floor(dias).ToString() + " dia(s) ";

            }

        }

        public void mostrar()
        {

            Console.WriteLine(resultado + "atrás.");

        }

    }
}
