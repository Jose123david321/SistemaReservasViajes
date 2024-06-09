using Microsoft.EntityFrameworkCore;
using SistemaReservasViajes.Models;
using System.Data;

namespace SistemaReservasViajes.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Actividad> Actividad { get; set; }
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Destino> Destino { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Vuelo> Vuelo { get; set; }
    }
}
