﻿using System.ComponentModel.DataAnnotations;

namespace CompKing.API.Models
{
    public class ComponentForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
