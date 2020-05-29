using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetStoreMVC.Models;

namespace PetStoreMVC.Models
{
    public class PetStoreMVCContext : DbContext
    {
        public PetStoreMVCContext (DbContextOptions<PetStoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PetStoreMVC.Models.Owner> Owner { get; set; }

        public DbSet<PetStoreMVC.Models.Pet> Pet { get; set; }
    }
}
