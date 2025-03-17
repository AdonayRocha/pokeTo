using PokeTo.Lib;

namespace PokeTo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("João Silva");
            conta.Depositar(5000);
            conta.Sacar(500);

            Console.WriteLine($"Titular: {conta.Titular}, Saldo: {conta.ObterSaldo()}");

            conta.ExibirSaldo();
        }
    }
}