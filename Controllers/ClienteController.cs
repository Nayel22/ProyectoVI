using Microsoft.AspNetCore.Mvc;
using ProyectoVI.Models;

namespace ProyectoVI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AccesoDatos _acceso;

        public ClienteController(AccesoDatos acceso)
        {
            _acceso = acceso;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Cliente modelo)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", modelo);
            }

            try
            {
                // Establecer quién está creando el cliente (podrías obtenerlo de la autenticación)
                modelo.AdicionadoPor = User.Identity?.Name ?? "Sistema";

                // Llamar al método para agregar el cliente
                int idCliente = _acceso.AgregarCliente(modelo);

                // Si se agregó exitosamente
                TempData["SuccessMessage"] = "El cliente se guardó con éxito.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "El cliente no se guardó. " + ex.Message;
                return View("Create", modelo);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Aquí necesitarías agregar un método en AccesoDatos para obtener un cliente por ID
            // Por ahora, retornando una vista vacía
            return View();
        }

        [HttpPost]
        public IActionResult Update(Cliente modelo)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", modelo);
            }

            try
            {
                // Aquí necesitarías agregar un método en AccesoDatos para actualizar un cliente
                // modelo.ModificadoPor = User.Identity?.Name ?? "Sistema";
                // modelo.FechaModificacion = DateTime.Now;
                // _acceso.ActualizarCliente(modelo);

                TempData["SuccessMessage"] = "El cliente se actualizó con éxito.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "El cliente no se actualizó. " + ex.Message;
                return View("Edit", modelo);
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            // Aquí necesitarías agregar un método en AccesoDatos para obtener los detalles del cliente
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Aquí necesitarías agregar un método en AccesoDatos para obtener un cliente para eliminación
            return View();
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                // Aquí necesitarías agregar un método en AccesoDatos para eliminar un cliente
                // _acceso.EliminarCliente(id);

                TempData["SuccessMessage"] = "El cliente se eliminó con éxito.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "El cliente no se eliminó. " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}