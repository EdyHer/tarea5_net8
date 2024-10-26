using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class Conexion : DbContext
{
    public Conexion(DbContextOptions<Conexion> options)
        : base(options)
    {
    }

    public DbSet<Clientes> TodoItems { get; set; } = null!;
}