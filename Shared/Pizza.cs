
namespace PizzaPlace.Shared
{
    public class Pizzas
    {
        public Pizzas(int id, string nombre, decimal precio, Picantes picantes)
        {

            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picante = picantes;

        }

        public decimal Precio { get; }
        public Picantes Picante { get; }
        public int Id { get; }
        public string? Nombre { get; }
 
    };
}