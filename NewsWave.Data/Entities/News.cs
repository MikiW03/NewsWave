using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWave.Data.Entities
{
    public class News
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PositivityRating { get; set; }

        public string Source { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
