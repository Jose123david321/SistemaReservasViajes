namespace SistemaReservasViajes.Models
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public int ClienteID { get; set; }
        public DateTime FechaReserva { get; set; }
        public string? Estado { get; set; }
    }
}
