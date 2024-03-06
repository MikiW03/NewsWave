using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWave.Data.Entities
{
    public class NewsAuthor
    {
        public int Id { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

        public Guid NewsId { get; set; }
        public News News { get; set; }
    }
}
