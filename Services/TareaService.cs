using ChallengeRunaID.Models;

namespace ChallengeRunaID.Services
{
    public static class TareaService
    {
        static List<Tarea> Tareas { get; }
        static TareaService()
        {
            Tareas = new List<Tarea>
            {
                new Tarea
                {
                   Id = System.Guid.NewGuid(),
                   Nombre = "Primera tarea" ,
                   Descripcion = "primera tarea creada para la lista 1",
                   ListaID = Guid.Parse("58882ccf-f1d4-495a-8e2f-086f83dd194c"),
                   Categorias = new List<string> { "Diaria", "Semanal"}
                },
                new Tarea
                {
                   Id = System.Guid.NewGuid(),
                   Nombre = "Segunda tarea" ,
                   Descripcion = "segunda tarea creada para la lista 2",
                   ListaID = Guid.Parse("c7d24be3-4454-44da-9f36-6b4c42155d68"),
                   Categorias = new List<string> { "Trimestral"}
                }
            };
        }

        public static List<Tarea> GetAll() => Tareas;

        public static List<Tarea> GetByCategoria(string categoria) => Tareas.Where(x => x.Categorias.Contains(categoria)).ToList();

        public static Tarea? GetById(Guid id) => Tareas.FirstOrDefault(p=> p.Id == id);

        public static void Add(Tarea tarea)
        {
            tarea.Id = System.Guid.NewGuid();
            Tareas.Add(tarea);
        }

        public static void Update(Guid id,Tarea tarea)
        {
            var originalEntry = Tareas.Find(x => x.Id == id);
            if (originalEntry != null)
            {
                originalEntry.Nombre = tarea.Nombre;
                originalEntry.Descripcion = tarea.Descripcion;
                originalEntry.ListaID = tarea.ListaID;
            }
            
        }

        public static void Delete(Guid id)
        {
            var listaEliminar = Tareas.Find(x => x.Id == id);
            if(listaEliminar != null)
                Tareas.Remove(listaEliminar);
        }
        
    }
}
