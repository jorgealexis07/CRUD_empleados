using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ABC_Empleados.Models;

namespace ABC_Empleados.Data
{
    public class ABC_EmpleadosContext : DbContext
    {
        public ABC_EmpleadosContext (DbContextOptions<ABC_EmpleadosContext> options)
            : base(options)
        {
        }

        public DbSet<ABC_Empleados.Models.Estatus> Estatus { get; set; }
    }
}
