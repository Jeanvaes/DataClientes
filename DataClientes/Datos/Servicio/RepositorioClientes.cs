using Microsoft.EntityFrameworkCore;

namespace DataClientes.Datos.Servicio
{
    public class RepositorioClientes : DbContext
    {
        public RepositorioClientes(DbContextOptions<RepositorioClientes> options)
            : base(options)
        {
        }

        public DbSet<DataClientes.Datos.Modelo.Cliente> Cliente { get; set; }

    }
}
