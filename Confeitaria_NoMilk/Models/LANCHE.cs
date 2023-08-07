namespace Confeitaria_NoMilk.Models
{
    public class LANCHE
    {
        public int LANCHE_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRICAO_CURTA { get; set; }
        public string DESCRICAO_DETALHADA { get; set; }
        public Decimal PRECO { get; set; }
        public string IMAGEM_URL { get; set; }
        public string IMAGEM_THUMBNAI_URL { get; set; }
        public string IS_LANCHE_PREFERIDO { get; set; }
        public bool EM_ESTOQUE { get; set; }

        

        //definição de relacionamento da classe lanche com o a classe categoria
        public int CATEGORIA_ID { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set;}
    }
}
