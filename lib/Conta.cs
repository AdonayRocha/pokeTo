namespace PokeTo.Lib
{
    public abstract class Conta
    {
        public string Titular { get; private set; }
        protected decimal Saldo { get; set; }
        internal string Banco { get; set; }
        protected internal string Agencia { get; set; }
        private protected string NumeroConta { get; set; }

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
            NumeroConta = "0000"; 
            Banco = string.Empty; 
            Agencia = string.Empty; // Erro na build, iniciando null?
        }

        public abstract void Depositar(decimal valor);
        public abstract void Sacar(decimal valor);

        private void AtualizarSaldo(decimal valor)
        {
            Saldo += valor;
        }

        internal void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}");
        }
        public decimal ObterSaldo()
        {
            return Saldo;
        }
    }
}