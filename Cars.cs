using SQLite;
using System.Diagnostics;
using System.Xml.Linq;

namespace CrudToo
{
    [Table("Car")]
    public class Car
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Car_name")]
        public string Name { get; set; }

        [Column("VINNumber")]
        public string VINNumber { get; set; }

        [Column("Year")]
        public string Year { get; set; }

        public (bool IsValid, string? ErrorMessage) Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return (false, $"{nameof(Name)} is required.");
            }
            return (true, null);
        }
    }
}
