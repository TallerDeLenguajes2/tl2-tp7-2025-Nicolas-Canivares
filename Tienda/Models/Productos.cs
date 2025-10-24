namespace TiendaDB;

public class Productos
{
    private int idProducto;
    private string descripcion;
    private int precio;

    public Productos()
    {

    }
    public Productos(int idProducto, string descripcion, int precio)
    {
        this.IdProducto = idProducto;
        this.Descripcion = descripcion;
        this.Precio = precio;
    }

    public int IdProducto { get => idProducto; set => idProducto = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Precio { get => precio; set => precio = value; }
}
