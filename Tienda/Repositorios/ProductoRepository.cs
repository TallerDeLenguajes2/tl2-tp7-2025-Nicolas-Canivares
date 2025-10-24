
using Microsoft.Data.Sqlite;

namespace TiendaDB;

public class ProductoRepository
{
    private string _connectionString = "Data Source=Tienda.db;";

    //Metodo para agregar un nuevo producto
    public bool addNewProducto(Productos productos)
    {

        using (var connection = new SqliteConnection(_connectionString))
        {

            connection.Open();
            string sql = "INSERT INTO Productos (Descripcion, Precio) Values (@desc, @prec);";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@desc", productos.Descripcion);
                command.Parameters.AddWithValue("@prec", productos.Precio);

                var filasInsertadas = command.ExecuteNonQuery();

                if (filasInsertadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
    


}