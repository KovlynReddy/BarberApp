using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ModelGUID { get; set; }
        public int IsDeleted { get; set; }
        [Required]
        public string CreatedDateTime { get; set; }
        public string DeletedDateTime { get; set; }
        public string CompletedDateTime { get; set; }
        public string CreatorId { get; set; }
    }
}
