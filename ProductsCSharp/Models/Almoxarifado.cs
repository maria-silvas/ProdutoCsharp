namespace Models{
    public class Almoxarifado{
        public int Id { get; set; }
        public string Nome { get; set; }

        public Almoxarifado(string Nome){
            this.Nome = Nome;
        }
    }
}