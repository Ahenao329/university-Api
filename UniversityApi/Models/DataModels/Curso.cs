using System.ComponentModel.DataAnnotations;

namespace UniversityApi.Models.DataModels
{
    public class Curso
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;

        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;

        public Level Level { get; set; } = Level.Basic;
    }

    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }

}
