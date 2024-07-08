using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models
{
	public class Product
	{
		[Key]
		[Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

		[Required(ErrorMessage = "Titulo é obrigatório")]
		[MaxLength(150, ErrorMessage = "Titulo deve ter no máximo 150 caracteres")]
		[MinLength(5, ErrorMessage = "Título deve ter no minimo 5 caracteres")]
        public string Title { get; set; }

		[Required(ErrorMessage = "Preço é obrigatorio")]
		[DataType(DataType.Currency)]
		[Range(1, 9999, ErrorMessage = "Preço deve estar entre 0 e 9999")]
        public decimal Price { get; set; }

		[Required(ErrorMessage = "Categoria é obrigatorio")]
		[Range(1, int.MaxValue, ErrorMessage = "Categoria deve ser informada")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null;
    }
}