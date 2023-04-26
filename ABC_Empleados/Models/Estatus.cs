using System;
using System.Collections.Generic;

#nullable disable

namespace ABC_Empleados.Models
{
    public partial class Estatus
    {
        public Estatus()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int EstatusId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
