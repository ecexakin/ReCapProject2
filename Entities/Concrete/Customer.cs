﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {

        public int UserId { get; set; }
        [Key]

        public string CompanyName { get; set; }
    }
}
