using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class VehiculoBase
    {
        [Required(ErrorMessage = "El propiedad de placa es requerida")]
        [RegularExpression(@"^[A-Za-z]{9}-[0-9]{3}",ErrorMessage = "El formato de la placa debe de ser ###-ABC")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "El propiedad de color es requerida")]
        [StringLength(40, ErrorMessage ="La propiedad del color debe ser mayor a 4 caracteres y menos a 40", MinimumLength =4)]
        public string Color { get; set; }
        [Required(ErrorMessage = "El propiedad de anio es requerida")]
        [RegularExpression(@"^(19|20)\d\d", ErrorMessage = "El formato del año noes valido")]
        public int Anio { get; set; }
        [Required(ErrorMessage = "El propiedad de precio es requerida")]
        public Decimal Precio { get; set; }
        [Required(ErrorMessage = "El propiedad de correo es requerida")]
        [EmailAddress]
        public string CorreoPropietario { get; set; }
        [Required(ErrorMessage = "El propiedad de telefono es requerida")]
        [Phone]
        public string TelefonoPorpietario { get; set; }

    }
    public class VehiculoRequest : VehiculoBase
    {
        public Guid IdModelo { get; set; }
    }

    public class VehiculoResponse : VehiculoBase
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }

    public class VehiculoDetalle : VehiculoResponse
    { 
        public bool RevisionValidad { get; set; }
        public bool RegistroValido { get; set; }
    }

}