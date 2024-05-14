using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CityEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("city_name", TypeName = "varchar(200)")]
        public string CityName { get; set; }

        public ISet<GamesCityEntity> GamesCity { get; set; } = new HashSet<GamesCityEntity>();
    }
}
