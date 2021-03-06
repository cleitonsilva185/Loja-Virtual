﻿using AutoMapper;
using LojaVirtualCleiton.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtualCleiton.Mappers
{
    public class CategoriaViewModelMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Fornecedor, CategoriaViewModel>();
            Mapper.CreateMap<CategoriaViewModel, Fornecedor>();
           
        }
    }
}