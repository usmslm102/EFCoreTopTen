﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe.Dal.Models
{
    [Table("Ingredient")]
    public partial class Ingredient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public int? SortOrder { get; set; }
        [MaxLength(50)]
        public string Units { get; set; }
        [MaxLength(50)]
        public string UnitType { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public long? RecipeId { get; set; }

        [ForeignKey("RecipeId")]
        [InverseProperty("Ingredients")]
        public virtual Recipe Recipe { get; set; }
    }
}
