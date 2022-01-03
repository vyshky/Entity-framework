using System.Data.SqlTypes;

namespace EF.Model
{
    public record Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Genre { get; set; }
        public string Release { get; set; }
    }
}
