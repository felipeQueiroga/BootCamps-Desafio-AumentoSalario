using System;
using System.Globalization;

namespace BootCamps_Desafio_AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "";
            double salario = 0.00;
            double reajuste = 0.00;
            double novoSalario = 0.00;
            double percentual = 0.00;


            linha = Console.ReadLine();
            linha = linha.Replace(",", ".");

            bool teste = double.TryParse(linha, out salario);
            if (teste)
            {
                salario = double.Parse(linha, CultureInfo.InvariantCulture);
            }
            else
            {
                salario = 0.00;
            }
            //insira os valores corretos de acordo com o enunciado
            if (salario < 0.000)
            {
                return;
            }
            else if (salario == 0.00)
            {
                reajuste = 0.00;
                novoSalario = 0.00;
                percentual = 15.00;

            }
            else if (salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.00) / salario;

            }
            else if (salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.00) / salario;

            }
            else if (salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.00) / salario;

            }
            else if (salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100.00) / salario;

            }

            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
            }

            else
            {
                return;
            }


            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual.ToString("F0", CultureInfo.InvariantCulture));


        }
    }
}

