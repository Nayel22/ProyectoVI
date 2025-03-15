namespace ProyectoVI.Models
{
    public class DetalleVenta  
    {
        private int IdDetalleVenta { get; set; }
        private int IdVenta { get; set; }
        private int IdProducto { get; set; }
        private int Cantidad { get; set; }
        private double SubTotal {  get; set; }


        public DetalleVenta(int idDetalleVenta, int idVenta, int idProducto, int cantidad, double subTotal)
        {
            IdDetalleVenta = idDetalleVenta;
            IdVenta = idVenta;
            IdProducto = idProducto;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }


    }
}
