﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Models
{
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
                
        [Column("DataCadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }

        public int Idmarca { get; set; }
        public Marca Marca { get; set; }
    }
}
