namespace Web.data.Models
{
    public class Qita
    {
        public int ID { get; set; }
        public string Nomi { get; set; }
        public virtual List<Davlatlar> Davlat { get; set; }
    }
}