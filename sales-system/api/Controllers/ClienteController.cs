using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sales_system.Models;
using sales_system.Models.Responses;
using sales_system.Models.Requests;

namespace sales_system.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            Response response = new Response();

            try
            {
                using(VentaRealContext db = new VentaRealContext())
                {
                    response.data = db.Clientes.ToList();
                    response.status = 1;
                }
            }
            catch(Exception ex)
            {
                response.status = 0;
                response.message = ex.Message;
            }

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(ClienteRequest clienteRequest) 
        {
            Response response = new Response();

            try
            {
                using(VentaRealContext db = new VentaRealContext())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = clienteRequest.Nombre;

                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    
                    response.status = 1;
                }
            }
            catch(Exception ex)
            {
                response.status = 0;
                response.message = ex.Message;
            }

            return Ok(response);
        }
    }
}
