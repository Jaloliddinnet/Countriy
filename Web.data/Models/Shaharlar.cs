namespace Web.data.Models
{
    public class Shaharlar
    {
        public int Id { get; set; }
        public string Nomi { get; set; }
        public int Davlat_id { get; set; }
        public virtual Davlatlar Davlat { get; set; }

    }
}