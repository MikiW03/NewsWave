using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWave.Data.Entities
{
    public class Preference
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public int PositivityPriorityId { get; set; }
        public Priority PositivityPriority { get; set; }
    }
}
