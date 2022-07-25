using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    [Table("itens_carrinho")]
    public class ItemCarrinho
    {
        private int id;
        private Quentinha quentinha;
        private int quantity;
        private TimestampAttribute created_at;
        private TimestampAttribute updated_at;

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public Quentinha Quentinha
        {
            get { return quentinha; }
            set { quentinha = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
