﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AmonicAirlines
{
    public partial class Route
    {
        public Route()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public int DepartureAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public int Distance { get; set; }
        public int FlightTime { get; set; }

        public virtual Airport ArrivalAirport { get; set; }
        public virtual Airport DepartureAirport { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
