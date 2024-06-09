namespace SistemaReservasViajes.Models
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int ReservaID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaOagi { get; set; }
        public string? MetodoPago { get; set; }
        public string? EstadoPago { get; set; }

    }
}
