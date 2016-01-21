using MvcApplication3___Prawdzik.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication3___Prawdzik.Controllers
{
    public class CarsController : ApiController
    {
        //Dane przykładowe
        Car[] Cars = new Car[] 
        {
            new Car{ Id = 1, Marka = "Audi A6", Paliwo ="Diesel", Cena = 69999.00M }, 
            new Car{ Id = 2, Marka = "Fiat 500", Paliwo ="Benzyna", Cena = 39999.99M }, 
            new Car{ Id = 3, Marka = "Tesla 32T", Paliwo="Elektryczny", Cena = 450000M },
            new Car{ Id = 4, Marka = "BMW e750", Paliwo="Diesel", Cena = 55000M },
            new Car{ Id = 5, Marka = "Smart", Paliwo="Elektryczny", Cena = 45000M }
        };

        //Zwraca całą tablicę
        //URL: /api/Cars/
        public IEnumerable GetAllCars()
        {
            return Cars;
        }

        //Zwraca samochod o podanym id
        //URL: /api/Cars/id
        public IHttpActionResult GetCar(int id)
        {
            var product = Cars.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
