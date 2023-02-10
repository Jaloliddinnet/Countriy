using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.data.Models
{
    public class Davlatlar
    {
        public int Id { get; set; }
        public string Nomi { get; set; }
        public int Qita_Id { get; set; }
        public virtual Qita qita { get; set; }
        public virtual List<Shaharlar> shahar { get; set; }
    }
}
