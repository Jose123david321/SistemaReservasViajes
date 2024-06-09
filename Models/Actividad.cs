namespace SistemaReservasViajes.Models
{
    public class Actividad
    {
        public int ActividadID { get; set; }
        public int ReservaID { get; set;}
        public int DestiniID { get; set;}
        public string? NombreActividad { get; set;}
        public DateTime? FechaActividad { get; set;}
        public int? DuracionHoras { get; set;}
    }
}
