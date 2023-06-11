using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Shared
{
    public class Clientes
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; } = default!;

		[Required(ErrorMessage ="La direccion es requerida")]
		public string Calle { get; set; } = default!;

		[Required(ErrorMessage ="La ciudad es requerida")]
		public string Ciudad { get; set; } = default!;
    }
}