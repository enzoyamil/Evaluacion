using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluacion.Models
{
   [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Descripcion { get; set; }
        [Column(TypeName ="decimal(5,2)")]
        public double Precio { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaCreacion { get; set; }

    }
}
