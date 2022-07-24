﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuentinhasDoBill.Models
{
    public class Tipo
    {
        [Column("id")]
        private int Id;

        [Required]
        private string description;

        [Required]
        private ICollection<Quentinha> quentinhas;

        public Tipo() { }
        public Tipo(string description, Quentinha quentinha) {
            this.description = description;
            this.quentinhas.Add(quentinha);
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public ICollection<Quentinha> Quentinhas
        {
            get { return quentinhas; }
        }
        public void setQuentinhas(Quentinha value)
        {
            quentinhas.Add(value);
        }
    }
}
