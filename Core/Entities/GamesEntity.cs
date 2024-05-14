using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GamesEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("games_year")]
        public int GamesYear { get; set; }

        [Column("games_name", TypeName = "varchar(100)")]
        public string GamesName { get; set; }

        [Column("season", TypeName = "varchar(100)")]
        public string Season { get; set; }

        //public GamesCityEntity GamesCity { get; set; }

        public ISet<GamesCityEntity> GamesCity { get; set; } = new HashSet<GamesCityEntity>();

        public ISet<GamesCompetitorEntity> GamesCompetitors { get; set;} = new HashSet<GamesCompetitorEntity>();
    }
}
