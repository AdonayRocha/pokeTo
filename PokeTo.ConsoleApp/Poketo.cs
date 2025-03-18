using PokeTo.Lib;

namespace PokeTo.ConsoleApp
{
    class Poketo
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("João Silva");
            FileScopedLogger logger = new FileScopedLogger();

            logger.Log("=== Saque x Depósito ===");
            logger.Log($"Titular: {conta.Titular}, Saldo Inicial: {conta.ObterSaldo():C}");
            
            conta.Depositar(5000);
            logger.Log($"Depósito: R$ 5.000,00");
            logger.Log($"Saldo após depósito: {conta.ObterSaldo():C}");
            
            conta.Sacar(500);
            logger.Log($"Saque: R$ 500,00");
            logger.Log($"Saldo após saque: {conta.ObterSaldo():C}");
            
            logger.Log("\n=== Transferência ===");
            ContaCorrente contaDestino = new ContaCorrente("Maria Oliveira");
            conta.RealizarTransferencia(contaDestino, 2000);
            
            logger.Log($"Transferência: R$ 2.000,00 para {contaDestino.Titular}");
            logger.Log($"Saldo de {conta.Titular} após transferência: {conta.ObterSaldo():C}");
            logger.Log($"Saldo de {contaDestino.Titular} após transferência: {contaDestino.ObterSaldo():C}");
        }
    }
}

// Logger
file class FileScopedLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}