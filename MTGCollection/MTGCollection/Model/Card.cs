using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTGCollection.Model
{
    [Table("Cards")]
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Tipo")]
        public string Tipo { get; set; }

        [Column("Cor")]
        public string Cor { get; set; }

        [Column("Quantidade")]
        public int Quantidade { get; set; }

    }
}

