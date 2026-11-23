using AvaliaçãoEtapa2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace AvaliaçãoEtapa2
{
    public class Conta
    {
        [Key]
        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        public string Tipo { get; set; } = "";

        // Chave estrangeira
        public int AgenciaNumero { get; set; }

        // Relacionamento com Agencia
        public Agencia Agencia { get; set; } = null!;

        public List<Cliente> Clientes { get; set; } = new();
    }
}