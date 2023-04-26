using Models;
using MyProject.Data;

namespace Controllers{

    public class Almoxarifado{
            
        public static void CriarAlmoxarifado(Models.Almoxarifado almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Add(almoxarifado);
                context.SaveChanges();
            }
        }

        public static void AtualizarAlmoxarifado(Models.Almoxarifado almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Update(almoxarifado);
                context.SaveChanges();
            }
        }

        public static void DeletarAlmoxarifado(Models.Almoxarifado almoxarifado){
            using(var context = new Context()){
                context.Almoxarifados.Remove(almoxarifado);
                context.SaveChanges();
            }
        }

        public static List<Models.Almoxarifado> ListarAlmoxarifados(){
            using(var context = new Context()){
                return context.Almoxarifados.ToList();
            }
        }

        public static Models.Almoxarifado BuscarAlmoxarifado(int id){
            using(var context = new Context()){
                return context.Almoxarifados.Find(id);
            }
    
        }
    }
}