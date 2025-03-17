namespace PokeTo.Lib
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(string titular) : base(titular) { }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        internal protected void Transferir(ContaCorrente contaDestino, decimal valor)
        {
            if (Saldo >= valor)
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }
    }
}