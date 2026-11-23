using AvaliaçãoEtapa2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace AvaliaçãoEtapa2
{
    public class Agencia
    {
        [Key]
        public int Numero { get; set; }

        public string Endereco { get; set; } = "";

        // Chave estrangeira
        public int BancoCodigo { get; set; }

        // Relacionamento com Banco
        public Banco Banco { get; set; } = null!;

        public List<Conta> Contas { get; set; } = new();
    }

}