using Casgem_CodeFirstProje.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Casgem_CodeFirstProje.DAL.Context
{
    public class TravelContext:DbContext
        //tablolar bu sınıf uzerinden yansıtılacak onu soyluyorum
        //cogul olan tablo ismi, tekil olan sınıf ismi
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}