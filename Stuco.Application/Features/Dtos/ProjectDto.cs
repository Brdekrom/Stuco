﻿using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Features.Dtos;

public class ProjectDto
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}