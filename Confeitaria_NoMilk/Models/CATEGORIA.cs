using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Confeitaria_NoMilk.Models
{

	[Table("CATEGORIAS")]
	public class CATEGORIA
	{
		[Key]
        public int CATEGORIAID { get; set; }

		[StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
		[Required(ErrorMessage = "Informe o nome da categoria")]
		[Display(Name = "Nome")]
        public string CATEGORIA_NOME { get; set; }

		[StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
		[Required(ErrorMessage = "Informe a descrição da categoria")]
		[Display(Name = "Descrição")]
        public string DESCRICAO { get; set; }

        // relacionamento de um para muitos lanches 
        public List <LANCHE> LANCHEs { get; set; }
    }
}
