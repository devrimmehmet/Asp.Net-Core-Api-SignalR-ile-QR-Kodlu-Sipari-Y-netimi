﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Booking
    {
        [Key]
        public int Booking_ID { get; set; }
        public string? Booking_Name { get; set; }
        public string? Booking_Phone { get; set; }
        public string? Booking_Mail { get; set; }
        public int Booking_Person_Count { get; set; }
        public DateTime Booking_Date { get; set; }
    }
}
