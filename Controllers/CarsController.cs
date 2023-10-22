using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Dotnet5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
         private static readonly string[] Cars = new[]
    {
        "Maruti", "BMW", "Audi", "Benz","Lambo","Volswagon","Tata",
    };

 [HttpGet(Name = "GetCars")]
    public object Get()
    {
        return Cars.ToArray();
    }

    }
}