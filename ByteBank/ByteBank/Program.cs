using System;
using System.Collections.Generic;
using System.IO;
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
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }
            

            Console.WriteLine("Execução finalizada. Tecle enter para sair");

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //--------------------------------------

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();

            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");

            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}


        }

        private void TestaInnerException()
        {
            try
            {

                ContaCorrente conta = new ContaCorrente(456, 457840);
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