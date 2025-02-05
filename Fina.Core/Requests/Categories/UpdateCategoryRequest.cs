﻿using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Titulo inválido")]
    [MaxLength(80, ErrorMessage = "O titulo deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição invalida")]
    public string Description { get; set; } = string.Empty;
}
