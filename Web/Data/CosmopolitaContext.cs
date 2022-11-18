using Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class CosmopolitaContext : DbContext
    {
        public CosmopolitaContext(DbContextOptions<CosmopolitaContext> options)
            : base(options)
        {
        }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<Inscripto> Inscriptos { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        // LA CONFIGURACIÓN DE LA CONEXIÓN EN LOS PROYECTOS WEB SE REALIZA EN EL ARCHIVO
        // PROGRAM.CS COMO UN SERVICIO

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if(!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.LogTo(m => Debug.WriteLine(m), new[] { DbLoggerCategory.Database.Name }, LogLevel.Information)
        //            .EnableSensitiveDataLogging()
        //            .UseMySql(Helper.GetConnectionString(),
        //            ServerVersion.AutoDetect(Helper.GetConnectionString()),
        //            options => options.EnableRetryOnFailure(
        //            maxRetryCount: 5,
        //            maxRetryDelay: System.TimeSpan.FromSeconds(30),
        //           errorNumbersToAdd: null));
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //datos semilla
            #region carga de actividades
            modelBuilder.Entity<Actividad>().HasData(
                new Actividad
                {
                    Id = 1,
                    Nombre = "Folklore",
                    Horarios = "Martes y jueves 20hs",
                    Costo = 2000
                },
                new Actividad
                {
                    Id = 2,
                    Nombre = "Teatro",
                    Horarios = "Lunes y miércoles 20hs",
                    Costo = 3000
                },
                new Actividad
                {
                    Id = 3,
                    Nombre = "Telas",
                    Horarios = "Lunes y miércoles 21hs",
                    Costo = 2500
                }
                );
            #endregion
            #region carga de cobradores
            modelBuilder.Entity<Cobrador>().HasData(
                new Cobrador
                {
                    Id = 1,
                    Apellido_Nombre="Juan Perez"
                },
                new Cobrador
                {
                    Id = 2,
                    Apellido_Nombre = "Franco Gomez"
                }
                );
            #endregion
            #region carga de Socios
            modelBuilder.Entity<Socio>().HasData(
                new Socio
                {
                    Id = 1,
                    Apellido_Nombre = "Juan Perez",
                    Dirección="9 de Julio 2323",
                    Teléfono="1111111"
                },
                new Socio
                {
                    Id = 2,
                    Apellido_Nombre = "Franco Gomez",
                    Dirección="San Martin 2342",
                    Teléfono="22222"
                }
                );
            #endregion
            #region carga de Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Administrador",
                    User="admin",
                    TipoUsuario= TipoUsuarioEnum.Administrador,
                    Password = Helper.ObtenerHashSha256("123")
                }
                );
            #endregion
            #region carga de Inscriptos
            modelBuilder.Entity<Inscripto>().HasData(
                new Inscripto
                {
                    Id = 1,
                    SocioId = 1,
                    ActividadId = 1
                },
                new Inscripto
                {
                    Id = 2,
                    SocioId = 1,
                    ActividadId = 2
                },
                new Inscripto
                {
                    Id = 3,
                    SocioId = 2,
                    ActividadId = 1
                }
                );
            #endregion
        }


    }
}
