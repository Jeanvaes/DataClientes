// <auto-generated />
using DataClientes.Datos.Servicio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataClientes.Migrations
{
    [DbContext(typeof(RepositorioClientes))]
    [Migration("20220526232947_inicializarcl")]
    partial class inicializarcl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataClientes.Datos.Modelo.Cliente", b =>
                {
                    b.Property<int>("numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("numero"), 1L, 1);

                    b.Property<string>("marcaPreferida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroCarros")
                        .HasColumnType("int");

                    b.Property<string>("sueldo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("numero");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
