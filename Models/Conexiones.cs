using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa.Models;

public class Conexiones : DbContext{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {

    }
    public DbSet<Clientes> Clientes { get; set; } = null!;
    public DbSet<Proveedores> Proveedores { get; set; } = null!;

//En caso de no crear automaticamente el proveedoresController forzarlo a que sepa cual es la clave primaria en este caso es todo ese comando
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<Proveedores>().HasKey(p => p.id_proveedor);
    }
} 

        


