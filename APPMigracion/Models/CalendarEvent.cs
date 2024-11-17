using System;
using System.ComponentModel.DataAnnotations;

namespace APPMigracion.Models
{

    public class CalendarEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Color { get; set; }
    }


}
