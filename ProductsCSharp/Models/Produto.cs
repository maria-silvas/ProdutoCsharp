
namespace Models{
    public class Produto{

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }        

        public Produto(string Nome, decimal Preco){
            this.Nome = Nome;
            this.Preco = Preco;
        }

    }
}