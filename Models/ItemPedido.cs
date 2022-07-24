using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuentinhasDoBill.Models
{
    public class ItemPedido
    {
        [Column("id")]
        private int Id;

        [Required]
        private Quentinha quentinha;
        
        public ItemPedido() { }
        public ItemPedido(Quentinha quentinha)
        {
            this.quentinha = quentinha;
        }
        public Quentinha Quentinha
        {
            get { return quentinha; }
            set { quentinha = value; }
        }
    }
}
