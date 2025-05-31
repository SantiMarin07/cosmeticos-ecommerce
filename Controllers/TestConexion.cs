using System;
using MySql.Data.MySqlClient;

class TestConexion
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=ecommerce_cosmeticos;Uid=root;Pwd=123456;";

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine("¡Conexión exitosa!");

                string query = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Producto: {reader["nombre"]}, Precio: {reader["precio"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar: " + ex.Message);
            }
        }
    }
}