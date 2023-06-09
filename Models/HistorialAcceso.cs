namespace LASSO_GONZALEZ.Models
{
    public class HistorialAcceso
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; }
    }
}
