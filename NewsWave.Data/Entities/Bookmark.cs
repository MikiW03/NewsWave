using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWave.Data.Entities
{
    public class Bookmark
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid NewsId { get; set; }
        public News News { get; set; }
    }
}
