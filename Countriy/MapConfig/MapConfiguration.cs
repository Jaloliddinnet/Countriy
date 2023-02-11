using AutoMapper;
using Web.data.Models;
using Web.Data.DTO;

namespace Countriy.MapConfig
{
    public class MapConfiguration:Profile
    {
        public MapConfiguration()
        {
            CreateMap<Qita, AddQitaDto>().ReverseMap();
        }
    }
}
