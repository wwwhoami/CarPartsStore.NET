using System.ComponentModel.DataAnnotations.Schema;

namespace CarPartsStore.Data.Models
{
    //Модель для автозапчасти (подправишь что будет надо)
    public class Carpart
    {
        public int CarpartId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int InStock { get; set; }
        [ForeignKey("Vin")]
        public Car Car { get; set; }
        public virtual Category Category { get; set; }
    }
}