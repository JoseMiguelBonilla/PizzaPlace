

using System.Text.Json;

namespace PizzaPlace.Clientes
{
	public static class Depuraciones
	{
		private static JsonSerializerOptions Options = new 
			JsonSerializerOptions{ WriteIndented = true };

		public static string ToJson(this object obj)
			=> JsonSerializer.Serialize(obj, Options);
	}
}