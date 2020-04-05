﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertApi.Models;
using AutoMapper;
namespace Advert.API.Services
{
    public class AdvertProfile:Profile

    {
        public AdvertProfile()
        {
            CreateMap<AdvertModel,AdvertDbModel>();
        }
    }
}
