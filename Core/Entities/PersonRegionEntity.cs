using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PersonRegionEntity
    {
        [Column("person_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        [Column("region_id")]
        public int RegionId { get; set; }

        public NocRegionEntity NocRegion { get; set; }

        public PersonEntity Person { get; set; }
    }
}
