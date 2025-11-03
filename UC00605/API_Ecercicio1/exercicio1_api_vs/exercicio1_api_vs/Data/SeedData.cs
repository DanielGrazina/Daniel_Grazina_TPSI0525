using exercicio1_api_vs.Models;

namespace exercicio1_api_vs.Data
{
    public class SeedData
    {
        public static void Initialize(ApiContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any()) return;

            // --- Students ---
            context.Students.AddRange(
                new Student { Nome = "Ana", Idade = 15, Curso = "Técnico de Informática" },
                new Student { Nome = "Bruno", Idade = 17, Curso = "Gestão" }
            );

            // --- Products ---
            context.Products.AddRange(
                new Product { Nome = "Parafuso", Preco = 0.50, Quantidade = 100 },
                new Product { Nome = "Martelo", Preco = 12.99, Quantidade = 10 }
            );

            // --- Employees ---
            context.Employees.AddRange(
                new Employee { Nome = "Carlos", Salario = 950 },
                new Employee { Nome = "Diana", Salario = 1200 }
            );

            // --- Tasks ---
            context.Tasks.AddRange(
                new TaskItem { Titulo = "Revisar código", Concluida = false },
                new TaskItem { Titulo = "Fazer backup", Concluida = true }
            );

            // --- Books ---
            context.Books.AddRange(
                new Book { Titulo = "1984", Emprestado = false },
                new Book { Titulo = "O Senhor dos Anéis", Emprestado = true }
            );

            // --- Customers ---
            context.Customers.AddRange(
                new Costumer { Nome = "João" },
                new Costumer { Nome = "Marta" }
            );

            // --- Orders ---
            context.Orders.AddRange(
                new Order { ClienteId = 1, Estado = "Em processamento" },
                new Order { ClienteId = 2, Estado = "Concluído" }
            );

            // --- Reservations ---
            context.Reservations.AddRange(
                new Reservations { Cliente = "Rita", Checkin = DateTime.Today, Checkout = DateTime.Today.AddDays(2) },
                new Reservations { Cliente = "Tiago", Checkin = DateTime.Today.AddDays(1), Checkout = DateTime.Today.AddDays(3) }
            );

            context.SaveChanges();
        }
    }
}
