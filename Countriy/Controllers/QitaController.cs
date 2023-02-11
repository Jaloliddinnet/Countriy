using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.data.AddDbContex;
using Web.data.Models;
using Web.Data.DTO;

namespace Countriy.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QitaController : ControllerBase
    {
        AppDbContext db;
        IMapper mapper;
        public QitaController(AppDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddQita([FromForm]AddQitaDto qita)
        {
            var Qita = mapper.Map<Qita>(qita);
            await db.Qita.AddAsync(Qita);
            await db.SaveChangesAsync();
            return Ok(Qita);
        }
        [HttpGet]
        public async Task<IActionResult> ShowQita()
        {
            return Ok(await db.Qita.Include(p=>p.Davlat).ToListAsync());
        }
        
    }
}
