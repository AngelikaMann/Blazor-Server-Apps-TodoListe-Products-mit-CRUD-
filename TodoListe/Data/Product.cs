using System.ComponentModel.DataAnnotations;

namespace TodoListe.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Anzahl { get; set; }
        public string Category { get; set; }
    }
}
