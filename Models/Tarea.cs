namespace ChallengeRunaID.Models
{
    public class Tarea
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid ListaID { get; set; }
        public List<string>? Categorias { get; set; } = null;

        public Tarea()
        {
            Categorias = new List<string>();
        }
    }
}
