namespace SistemaReservasViajes.Models
{
    public class Auto
    {
        public int AutoID { get; set; }
        public int ReservaID { get; set; }
        public int DestinoID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public DateTime? FechaRecogida { get; set; }
        public DateTime? FechaDevolucion { get; set; }
    }
}
