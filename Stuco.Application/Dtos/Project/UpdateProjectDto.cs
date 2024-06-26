﻿using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Project;

public sealed class UpdateProjectDto : DtoBase
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }

    [Required]
    public int KlantId { get; set; }
}