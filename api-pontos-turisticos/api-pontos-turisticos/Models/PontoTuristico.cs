using System.ComponentModel.DataAnnotations.Schema;

namespace api_pontos_turisticos.Models
{
    public class PontoTuristico
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string? Nome { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string? UF { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Cidade { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string? Endereco { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? Descricao { get; set; }
    }
}
