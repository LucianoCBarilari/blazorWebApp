using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazorwebapp.Data
{
    [Table("ExperienciaLaboral")]
    public class ExperienciaLaboralModel
    {
        [Key]
        public int Id { get; set; }
        public string? Empresa { get; set; }
        public string? Descripcion { get; set; }
        public string? Ubicacion { get; set; }
    }
}
