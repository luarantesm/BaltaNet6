﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug obrigatório")]
        public string Slug { get; set; }
    }
}