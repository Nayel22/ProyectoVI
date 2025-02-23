using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoVI.Models
{
    public class Venta: Cliente
    {
        private int IdVenta {  get; set; }
        private DateTime Date { get; set; }
        private double Total { get; set; }
        private int IdCliente { get; set; }

        public Venta(int idCliente, int idVenta, DateTime date, double total)
        {
            IdCliente = idCliente;
            IdVenta = idVenta;
            Date = date;
            Total = total;
        }
    }
}
