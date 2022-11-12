using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoViernes.Models
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Fecha es Requerido")]
        public DateTime Fecha { get; set; } 
        
        [Required(ErrorMessage = "Empleado es Requerido")]
        public int id_Empleado { get; set; }

        [Required(ErrorMessage = "Sueldo es Requerido")]
        public decimal Sueldo { get; set; } 
        
        [Required(ErrorMessage = "Dias es Requerido")]
        public int Dias { get; set; } 
        
        public decimal Basico { get { return (Sueldo * Dias) / 30;} }//sueldo*dias/30
        
        [Required(ErrorMessage = "Extras Requerido")]
        public decimal Extras { get; set; }
        
        public decimal Devengado { get { return Basico + Extras; } }// basico+extras

    }
}
