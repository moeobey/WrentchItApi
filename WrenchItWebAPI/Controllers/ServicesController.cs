using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WrenchItWebAPI.Data;
using WrenchItWebAPI.Models;
using Newtonsoft.Json;

namespace WrenchItWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ServicesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Services
        
       
        public IActionResult GetServices()
        {
            var serviceList = _context.Services.ToList();
            return Ok(serviceList);
        }

        // GET: api/Services/5
        [HttpGet("[action]/{id}")]
        public IActionResult GetService(int id)
        {
            Service service = _context.Services.Where(a => a.id == id).FirstOrDefault();

            return Ok(service);
        }

        // PUT: api/Services/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("[action]")]
        public IActionResult PutService([FromBody] Service service)
        {
            //update service
            var serviceToUpdate = _context.Services.Single(a => a.id == service.id);
           
            serviceToUpdate.IsCompleted = service.IsCompleted;
            _context.SaveChanges();
            return Ok(serviceToUpdate);            
        }
        [HttpGet("[action]")]
        public IActionResult GetPendingServices()
        {
            Service service = _context.Services.Where(a => a.IsCompleted == false).FirstOrDefault();

            if (service != null)
            {
                return Ok(service);
            }
            return NotFound();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetServiceRequestByCustomerId(int id)
        {
            var service = _context.Services.Where(a => a.CustomerId == id).ToList();
            if (service != null)
            {
                return Ok(service);
            }
            return NotFound();
        }

        // POST: api/Services
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("[action]")]
        public IActionResult PostService([FromBody]Service service)
        {
            service.IsCompleted = false;
            _context.Services.Add(service);
           _context.SaveChanges();

            return Ok(service);
        }

        // DELETE: api/Services/5
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var service =  _context.Services.Where(a => a.id == id).FirstOrDefault();
            _context.Services.Remove(service);
            _context.SaveChanges();
            return Ok(_context.Services.ToList());
            
        }
       
    }
}
