using AvaliaçãoEtapa2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AvaliaçãoEtapa2
{
    public class Cliente
    {
        [Key]
        public string Cpf { get; set; } = "";

        public string Nome { get; set; } = "";

        public string Endereco { get; set; } = "";

        public List<Conta> Contas { get; set; } = new();
    }

}
