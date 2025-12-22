
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WEB_RESTAURANTE_DATOS.Entidades;

namespace WEB_RESTAURANTE_DATOS
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options)
       : base(options) { }
        //private readonly string _connectionString;
        //public AplicacionContexto()
        //{
        //    //var config = new ConfigurationBuilder()
        //    //    .SetBasePath(Directory.GetCurrentDirectory())
        //    //    .AddJsonFile("appsettings.json")
        //    //    .Build();

        //    _connectionString = "Data Source=LAPTOP-ICLC5GJE\\SQLEXPRESS;Initial Catalog=REQRESTA;user id=sa;password=1234;TrustServerCertificate=True";

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer(_connectionString);
        //}

        public DbSet<Clientes> Cliente { get; set; }

        public DbSet<Usuarios> Usuario { get; set; }




    }
}
