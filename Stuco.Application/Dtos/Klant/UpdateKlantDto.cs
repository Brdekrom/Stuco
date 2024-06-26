﻿using Stuco.Application.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Stuco.Application.Dtos.Klant;

public sealed class UpdateKlantDto : DtoBase
{
    [Required]
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; }
}