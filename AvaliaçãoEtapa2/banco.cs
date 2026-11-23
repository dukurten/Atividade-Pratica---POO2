using AvaliaçãoEtapa2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AvaliaçãoEtapa2
{
    public class Banco
    {
        [Key]
        public int Codigo { get; set; }

        public string Nome { get; set; } = "";

        public List<Agencia> Agencias { get; set; } = new();

    }

}