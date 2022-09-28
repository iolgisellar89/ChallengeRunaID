using ChallengeRunaID.Models;
using System.Threading;

namespace ChallengeRunaID.Services
{
    public static class ListaTareaService
    {
        static List<ListaTarea> ListaTareas { get; }
        static ListaTareaService()
        {
            ListaTareas = new List<ListaTarea>
            {
                new ListaTarea
                {
                   Id = Guid.Parse("58882ccf-f1d4-495a-8e2f-086f83dd194c"),
                   Nombre = "Primera lista de tareas" ,
                   Descripcion = "primera lista de tareas relacionadas"
                },
                new ListaTarea
                {
                    Id = Guid.Parse("c7d24be3-4454-44da-9f36-6b4c42155d68"),
                    Nombre = "Segunda lista de tareas" ,
                    Descripcion = "segunda lista de tareas relacionadas"
                }
            };
        }

        public static List<ListaTarea> GetAll() => ListaTareas;

        public static ListaTarea? GetById(Guid id) => ListaTareas.FirstOrDefault(p => p.Id == id);

        public static void Add(ListaTarea listaTarea)
        {
            listaTarea.Id = System.Guid.NewGuid();
            ListaTareas.Add(listaTarea);
        }

        public static void Update(Guid id, ListaTarea listaTarea)
        {
            var originalEntry = ListaTareas.Find(x => x.Id == id);
            if (originalEntry != null)
            {
                originalEntry.Nombre = listaTarea.Nombre;
                originalEntry.Descripcion = listaTarea.Descripcion;
            }

        }

        public static void Delete(Guid id)
        {
            var listaEliminar = ListaTareas.Find(x => x.Id == id);
            if (listaEliminar != null)
                ListaTareas.Remove(listaEliminar);
        }

    }
}
