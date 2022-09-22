using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    [Table("avatar")]
    public class Avatar
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("path")]
        public string Path { get; set; }
    }
}
