namespace SistemaReservasViajes.Models
{
    public class Vuelo
    {
        public int VueloID { get; set; }
        public int ReservaID { get; set; }
        public int DestinoID { get; set; }
        public string? NumeroVuelo { get; set; }
        public DateTime? FechaSalida { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public string? Aerolinea { get; set; }
    }
}
