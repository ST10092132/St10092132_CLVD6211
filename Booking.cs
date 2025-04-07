﻿using System;
using System.Collections.Generic;

namespace ST10092132.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int EventId { get; set; }

    public int VenueId { get; set; }

    public DateTime BookingDate { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Venue Venue { get; set; } = null!;
}
