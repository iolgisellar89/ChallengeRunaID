namespace ChallengeRunaID.Models
{
    public class ListaTarea
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Tarea> ? Tareas { get; set; } = null;


        public ListaTarea()
        {
            Tareas = new List<Tarea>();
        }
    }
}
