namespace Confeitaria_NoMilk.Models
{
	public class CATEGORIA
	{
        public int CATEGORIA_ID { get; set; }
        public string CATEGORIA_NOME { get; set; }
        public string DESCRICAO { get; set; }

        // relacionamento de um para muitos lanches 
        public List <LANCHE> LANCHEs { get; set; }
    }
}
