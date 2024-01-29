using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abanAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Nombres = "Sofia",
                    Apellidos = "García Morales",
                    FechaDeNacimiento = new DateTime(1990, 5, 15),
                    Cuit = "20-12345678-9",
                    Domicilio = "Av. Rivadavia 1234",
                    Celular = "+54 9 11 1234-5678",
                    Email = "sofia.garcia.morales@example.com"
                },
                new User()
                {
                    Id = 2,
                    Nombres = "Javier",
                    Apellidos = "López Martínez",
                    Cuit = "23-45678901-9",
                    Domicilio = "Calle Independencia 789",
                    Celular = "+54 9 11 2345-6789",
                    Email = "javier.lopez.martinez@example.com"
                },
                new User()
                {
                    Id = 3,
                    Nombres = "Valentina",
                    Apellidos = "Rodríguez Navarro",
                    FechaDeNacimiento = new DateTime(1985, 9, 28),
                    Cuit = "27-87654321-1",
                    Domicilio = "Calle San Martín 567",
                    Celular = "+54 9 11 9876-5432",
                    Email = "valentina.rodriguez.navarro@example.com"
                },
                new User()
                {
                    Id = 4,
                    Nombres = "Mateo",
                    Apellidos = "González Sánchez",
                    Email = "mateo.gonzalez.sanchez@example.com"
                },
                new User()
                {
                    Id = 5,
                    Nombres = "Isabella",
                    Apellidos = "Pérez Romero",
                    Cuit = "30-98765432-1",
                    Domicilio = "Av. Belgrano 4321",
                    Celular = "+54 9 11 8765-4321",
                    Email = "isabella.perez.romero@example.com"
                },
                new User()
                {
                    Id = 6,
                    Nombres = "Lucas",
                    Apellidos = "Martín Herrera",
                    FechaDeNacimiento = new DateTime(2000, 3, 10),
                    Email = "lucas.martin.herrera@example.com"
                },
                new User()
                {
                    Id = 7,
                    Nombres = "Camila",
                    Apellidos = "Fernández Torres",
                    Email = "camila.fernandez.torres@example.com"
                },
                new User()
                {
                    Id = 8,
                    Nombres = "Daniel",
                    Apellidos = "Ruiz Castro",
                    FechaDeNacimiento = new DateTime(1995, 7, 20),
                    Cuit = "24-56789012-3",
                    Domicilio = "Calle Sarmiento 321",
                    Celular = "+54 9 11 3456-7890",
                    Email = "daniel.ruiz.castro@example.com"
                },
                new User()
                {
                    Id = 9,
                    Nombres = "Valeria",
                    Apellidos = "Díaz González",
                    Email = "valeria.diaz.gonzalez@example.com"
                },
                new User()
                {
                    Id = 10,
                    Nombres = "Juan Pablo",
                    Apellidos = "Gómez Ortega",
                    FechaDeNacimiento = new DateTime(1978, 11, 5),
                    Email = "juanpablo.gomez.ortega@example.com"
                }
            );
        }
    }
}