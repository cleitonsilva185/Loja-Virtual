﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaVirtualCleiton.Models
{
    public class ProdutoListaViewModel
    {
        public Guid? Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio.")]
        public string Nome { get; set; }

        public string Categoria { get; set; }

        public string Fornecedor { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }

    }
} 