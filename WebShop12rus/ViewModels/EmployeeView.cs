﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop12rus.ViewModels
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным.")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength: 30, MinimumLength = 2, ErrorMessage = "В имени должно быть 2..30 символов")]
        [RegularExpression(@"^[a-zA-Zа-яА-Я]{1,30}$")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательным.")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным.")]
        [Display(Name = "Возраст")]
        [Range(17, 100, ErrorMessage = "Возрастное ограничение: 18..99")]
        public int Age { get; set; }
    }
}
