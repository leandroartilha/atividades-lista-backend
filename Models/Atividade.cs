using System;
using System.ComponentModel.DataAnnotations;
using AtividadesApi.Models;

namespace AtividadesApi
{
    public class Atividade
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Titulo { get; set; }


        [StringLength(100)]
        public string Descricao { get; set; }

        public Prioridade Prioridade { get; set; }
    }
}

