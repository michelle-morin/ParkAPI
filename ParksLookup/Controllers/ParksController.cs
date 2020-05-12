using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [ApiVersion("1.0")]
  public class ParksController : ControllerBase
  {
    private ParksLookupContext _db;

    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }

    // GET '/api/parks'
    [EnableCors("MyPolicy")]
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get(string name, string agency, string state, bool? campsites)
    {
      var query = _db.Parks.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (agency != null)
      {
        query = query.Where(entry => entry.Agency == agency);
      }
      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }
      if (campsites != null)
      {
        query = query.Where(entry => entry.Campsites == campsites);
      }
      List<Park> parksList = query.ToList();
      parksList.Sort((x,y) => string.Compare(x.Name, y.Name));
      return parksList;
    }

    // POST '/api/parks'
    [EnableCors("MyPolicy")]
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }

    // GET '/api/parks/{id}'
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    // PUT '/api/parks/{id}'
    [EnableCors("MyPolicy")]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE '/api/parks/{id}'
    [EnableCors("MyPolicy")]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Park parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}