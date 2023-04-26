using System;
using System.Collections.Generic;

#nullable disable

namespace ABC_Empleados.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? EstatusId { get; set; }

        public virtual Estatus Estatus { get; set; }
    }
}
