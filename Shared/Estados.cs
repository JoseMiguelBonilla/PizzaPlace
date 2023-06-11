namespace PizzaPlace.Shared
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();

        public CestasCompras Cestas { get; } = new CestasCompras();

        public Interfaces Interfaces { get; set; } = new Interfaces();

		public decimal PrecioTotal
        
        => Cestas.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
	}
}