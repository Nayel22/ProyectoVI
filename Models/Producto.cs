namespace ProyectoVI.Models
{
    public class Producto
    {

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaRegistro { get; set; }


        // Constructor por defecto
        public Producto() { }

        // Constructor parametrizado
        public Producto(int idProducto, string nombre, double precio, int stock, DateTime fechaRegistro)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            FechaRegistro = fechaRegistro;
        }

    }
}
