namespace PokeTo.Lib
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string titular) : base(titular) { }

        public override void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo.");
                return;
            }
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        internal protected void Transferir(ContaCorrente contaDestino, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor da transferência deve ser positivo.");
                return;
            }
            if (Saldo >= valor)
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
                Console.WriteLine($"Transferência de {valor:C} para {contaDestino.Titular} realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }

        public void RealizarTransferencia(ContaCorrente contaDestino, decimal valor)
        {
            Transferir(contaDestino, valor);
        }
    }
}