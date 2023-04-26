using Models;
using MyProject.Data;

namespace Controllers{

    public class Produto{

        public static void CriarProduto(Models.Produto produto){
            using(var context = new Context()){
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public static void AtualizarProduto(Models.Produto produto){
            using(var context = new Context()){
                context.Produtos.Update(produto);
                context.SaveChanges();
            }
        }

        public static void DeletarProduto(Models.Produto produto){
            using(var context = new Context()){
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
        }

        public static List<Models.Produto> ListarProdutos(){
            using(var context = new Context()){
                return context.Produtos.ToList();
            }
        }

        public static Models.Produto BuscarProduto(int id){
            using(var context = new Context()){
                return context.Produtos.Find(id);
            }
    
        }
    }
}
