namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public Conta()
        {
            Titular = new Cliente();
        }

        /*A palavra-chave this é usada para acessar um membro da instância da própria classe.Em outras palavras,
         * é usada para a diferenciação e identificação em uso e/ou modificação de membros (variáveis,campos,métodos,...)
         * de uma classe,onde nessa,já existe um outro objeto com mesmo nome (em um parâmetro,por exemplo).*/

        public virtual void Saca(double valorOperacao)
        {
            if (this.Saldo >= valorOperacao)
            {
                this.Saldo -= valorOperacao;
            } 
        }

        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        /*public void Transfere(double valorOPeracao, Conta destino)
        {
            if (this.Saca(valorOperacao))
            {
                destino.Deposita(valorOperacao);
            }
        }*/
    }
}