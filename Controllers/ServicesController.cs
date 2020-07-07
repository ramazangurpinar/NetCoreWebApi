using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MutlubievWebApiProject.Models;

namespace MutlubievWebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        MutlubievDBContext _context;
        public ServicesController()
        {
            _context = new MutlubievDBContext();
        }
        [HttpGet]
        public IEnumerable<Service> Get()
        {
            List<Service> services = new List<Service>();
            foreach (var item in _context.Service.ToList())
            {
                Service service = new Service();
                service.Id = item.Id;
                service.IsPopular = item.IsPopular;
                service.Name = item.Name;
                service.Title = item.Title;
                service.Description = item.Description;

                services.Add(service);
            }
            return services.ToList();
        }
    }
}
