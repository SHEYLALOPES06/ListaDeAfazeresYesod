using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data.SqlClient;
using Org.BouncyCastle.Security;

class Programa
{
    private static string connectionString;

    static void Main(string[] args)
    {
        // Load configuration from appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        connectionString = configuration.GetConnectionString("dados");

        Console.Write("Digite a tarefa: ");
        var tarefa = Console.ReadLine();
        Console.WriteLine("Digite a data da tarefa (yyyy-mm-dd): ");
        var data = Console.ReadLine();

        // Connect to MySQL database and insert data
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO cad_tarefas(tarefa, data_tarefa) VALUES (@tarefa, @data)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tarefa", tarefa);
                command.Parameters.AddWithValue("@data", DateTime.Parse(data));
                command.ExecuteNonQuery();
            }
        }

        Console.WriteLine("Tarefa inserida com sucesso.");
    }
}
        Private static void menu()

           Console.Clear(); // Limpa a tela para uma nova exibição de menu
           Console.WriteLine("Menu:");
           Console.WriteLine("1. Inserir String de Conexão");
           Console.WriteLine("2. Exibir String de Conexão");
           Console.WriteLine("3. Sair");
           Console.Write("Escolha uma opção: ");


var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        InsertConnectionString();
        break;
    case "2":
        DisplayConnectionString();
        break;
    case "3":
        Console.WriteLine("Saindo...");
        return; // Sai do método Main, encerrando o programa
    default:
        Console.WriteLine("Opção inválida. Tente novamente.");
        break;
}

    {        
     static void main()

             int counter = 0;

        // O loop 'while' continuará enquanto 'counter' for menor que 5
        while (counter < 5)
        {
            Console.WriteLine($"Contador: {counter}");
            counter++; // Incrementa o contador
        }

        Console.WriteLine("Loop concluído!");
   }
       