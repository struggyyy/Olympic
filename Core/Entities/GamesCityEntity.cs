using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GamesCityEntity
    {
        [Column("games_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GamesId { get; set; }

        [Column("city_id")]
        public int CityId { get; set; }

        public CityEntity City { get; set; }

        public GamesEntity Games { get; set; }

        //public ISet<GamesEntity> Games { get; set; } = new HashSet<GamesEntity>();
    }
}
