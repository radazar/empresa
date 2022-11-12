using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoViernes.Models
{
    public class Empleados
    {
        [Key]
        [Required(ErrorMessage ="valor Requerido")]
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Nombres ")]
        [StringLength(60, ErrorMessage = "Nombres no puede exceder 60 caracteres.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Apellidos ")]
        [StringLength(60, ErrorMessage = "Apellidos no puede exceder 60 caracteres.")]
        public string Apellido { get; set;} = null!;

        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Direccion ")]
        [StringLength(60, ErrorMessage = "Direccion no puede exceder 60 caracteres.")]
        public string Direccion { get; set; } = null!;

        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Telefono ")]
        [StringLength(21, ErrorMessage = "Telefono no puede exceder 21 caracteres.")]
        public string Telefono { get; set; } = null!;

        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Fecha de ingreso ")]
        public DateTime Fecha_Ingreso { get; set; }
        
        [Required(ErrorMessage = "valor Requerido")]
        [Display(Name = "Area ")]
        [ForeignKey("Id_Area")]
        public int Id_Area { get; set; } 

    }
}