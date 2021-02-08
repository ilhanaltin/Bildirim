using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bildirim.Domain.Entities.Entity
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public virtual long Id { get; set; }

        [Column("CREATED_DATE")]
        public DateTime CreatedDateTime { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDateTime { get; set; }

        [Column("CREATED_USER")]
        public long CreatedUserId { get; set; }

        [Column("UPDATED_USER")]
        public long? UpdatedUserId { get; set; }
    }
}
