using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Column("id")]
        private int id;

        private char canceled;

        private ICollection<ItemPedido> itens;

        public Pedido() { }
        public Pedido(char value)
        {
            this.canceled = value;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }
        public char Canceled
        {
            get { return canceled; }
            set { canceled = value; }
        }

        public ICollection<ItemPedido> Itens
        {
            get { return itens; }
        }

        public void setItem(ItemPedido item)
        {
            this.itens.Add(item);
        }
    }
}
