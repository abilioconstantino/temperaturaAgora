using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using temperaturaAgora.Data;
using temperaturaAgora.Model;
using temperaturaAgora.repository.Interfaces;

namespace temperaturaAgora.Controllers
{
    
    [Route("api/temperature")]
    [ApiController]
    public class TemperatureController : Controller
    {     public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Temperature> listaNotas = dbContext.Temperature.Find(m => true).ToList();
            return View(listaNotas);
        }
   
        [Route("Edit")]
        [HttpPost]
        public IActionResult Edit(Temperature entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Temperature.ReplaceOne(m => m.Id == entity.Id, entity);
            return View(entity);
        }
  
        [Route("Add")]
        [HttpPost]
        public Temperature Add(Temperature entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            entity.Id = Guid.NewGuid();
            dbContext.Temperature.InsertOne(entity);
            return entity;
        }
        [Route("Delete")]
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Temperature.DeleteOne(m => m.Id == id);
            return RedirectToAction("Index", "Temperature");
        }
    }
}