using System;
using System.Collections.Generic;
using System.Text;

namespace CosasPorHacer.Model
{
   public class TodoItem
    {
        public string Description { get; set; }
        public DateTimeOffset CreateAt { get; set; }
    }
}
