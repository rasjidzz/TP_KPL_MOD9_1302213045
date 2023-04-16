using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302213045.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> _data = new List<Mahasiswa>
        {
            new Mahasiswa("Risjad Shidqi", "1302213045"),
            new Mahasiswa("Ashar Syahbudi", "1302210070"),
            new Mahasiswa("Zhafran Hafiz", "1302210036"),
            new Mahasiswa("Gifari Juliandri", "1302210087"),
            new Mahasiswa("Surya Aulia", "1302210084"),
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _data;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            return _data[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            _data.Add(value);
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= _data.Count)
            {
                NotFound();
            }
            _data.RemoveAt(id); 
        }
    }
}
