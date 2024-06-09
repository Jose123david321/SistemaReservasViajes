namespace SistemaReservasViajes.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public int ReservaID { get; set; }
        public int DestinoID {  get; set; }
        public string NombreHotel { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public string Direccion { get; set; }
    }
}
