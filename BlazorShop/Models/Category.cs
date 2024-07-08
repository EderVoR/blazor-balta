using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models
{
	public class Category
	{
		[Key]
		[Required(ErrorMessage = "Id é obrigatorio")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Título é obrigatorio")]
		[MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres")]
		[MinLength(5, ErrorMessage = "Título deve ter no minimo 5 caracteres")]
        public string Title { get; set; }

		public List<Product> Products { get; set; } = new();
    }
}
