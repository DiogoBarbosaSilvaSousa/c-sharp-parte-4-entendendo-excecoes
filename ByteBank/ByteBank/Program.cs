using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ContaCorrente conta = new ContaCorrente(456,457840);
                ContaCorrente contaDois = new ContaCorrente(485, 45678);

               /// contaDois.Transferir(100000000, conta);
                contaDois.Sacar(10000000);

                /* conta.Depositar(50);
                 Console.WriteLine(conta.Saldo);
                 conta.Sacar(-500);
                 Console.WriteLine(conta.Saldo);*/

            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

               /* Console.WriteLine("");

                Console.WriteLine("Informações de INNER EXCPETION (exceção interna)");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);*/

            }
            /*
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);

                Console.WriteLine("");

                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("");

                Console.WriteLine(ex.Message);
                Console.WriteLine("Exeção do tipo SaldoInsuficienteException");
            }*/



            //Metodo();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");

            Console.ReadLine();
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao ->d Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int Dividir(int numero, int divisor)
        {


            return numero / divisor;


        }
    }
}