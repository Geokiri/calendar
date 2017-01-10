using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Calendar
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
    }
}
