namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        
        /*A palavra-chave this é usada para acessar um membro da instância da própria classe.Em outras palavras,
         * é usada para a diferenciação e identificação em uso e/ou modificação de membros (variáveis,campos,métodos,...)
         * de uma classe,onde nessa,já existe um outro objeto com mesmo nome (em um parâmetro,por exemplo).*/

        //virtual permite que o	método	seja sobrescrito pela classes filhas
        public virtual void Saca(double valorOperacao)
        {
            if (this.Saldo >= valorOperacao)
            {
                this.Saldo -= valorOperacao;
            } 
        }

        public virtual void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        /*public virtual void Transfere(double valorOPeracao, Conta destino)
        {
            if (this.Saca(valorOperacao))
            {
                destino.Deposita(valorOperacao);
            }
        }*/
    }
}