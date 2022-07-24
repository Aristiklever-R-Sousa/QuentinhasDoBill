using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    public class Pedido
    {
        [Column("id")]
        private int Id;

        [Required]
        private char canceled;

        [Required]
        private ICollection<ItemPedido> itens;

        public Pedido() { }
        public Pedido(char value)
        {
            this.canceled = value;
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
