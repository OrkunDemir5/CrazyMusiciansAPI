using CrazyMusiciansAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusiciansAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicianController : ControllerBase
    {
        private static List<Musician> musicians = new()
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFact = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFact = "Şarkıları yanlış anlaşılır ama çok popüler" }
        };

        // GET: api/Musician
        [HttpGet]
        public IActionResult GetAllMusicians()
        {
            return Ok(musicians);
        }

        // GET: api/Musician/{id}
        [HttpGet("{id}")]
        public IActionResult GetMusicianById(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null) return NotFound("Musician not found.");
            return Ok(musician);
        }

        // POST: api/Musician
        [HttpPost]
        public IActionResult AddMusician([FromBody] Musician newMusician)
        {
            if (newMusician == null) return BadRequest("Invalid data.");
            musicians.Add(newMusician);
            return CreatedAtAction(nameof(GetMusicianById), new { id = newMusician.Id }, newMusician);
        }

        // PUT: api/Musician/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMusician(int id, [FromBody] Musician updatedMusician)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null) return NotFound("Musician not found.");
            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunFact = updatedMusician.FunFact;
            return NoContent();
        }

        // PATCH: api/Musician/{id}
        [HttpPatch("{id}")]
        public IActionResult UpdateMusicianPartial(int id, [FromQuery] string funFact)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null) return NotFound("Musician not found.");
            musician.FunFact = funFact;
            return Ok(musician);
        }

        // DELETE: api/Musician/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMusician(int id)
        {
            var musician = musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null) return NotFound("Musician not found.");
            musicians.Remove(musician);
            return NoContent();
        }
    }
}
