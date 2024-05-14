using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SportEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("sport_name", TypeName = "varchar(200)")]
        public string SportName { get; set; }

        public ISet<EventEntity> Events { get; set; } = new HashSet<EventEntity>();
    }
}
