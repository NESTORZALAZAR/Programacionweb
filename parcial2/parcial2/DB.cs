using Npgsql;
using System;

public class DatabaseConnection
{
    private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1404;Database=DBFACTURA";


    public static NpgsqlConnection Connect()
    {
        try
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            // Elimina o comenta el MessageBox
            // MessageBox.Show("Conexión exitosa.");
            return conn;
        }
        catch (Exception ex)
        {
            // Puedes mantener el manejo de errores sin el MessageBox
            Console.WriteLine("Error de conexión: " + ex.Message);
            return null;
        }
    }

    public static void CloseConnection(NpgsqlConnection conn)
    {
        if (conn != null)
        {
            conn.Close();
            // Elimina o comenta el MessageBox
            // MessageBox.Show("Conexión cerrada.");
        }
    }
}