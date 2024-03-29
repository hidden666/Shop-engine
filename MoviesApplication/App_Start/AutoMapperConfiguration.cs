﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Infrastructure.DomainToModelProfilers;

namespace MoviesApplication.App_Start
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x => x.AddProfile<DomainToViewModelProfile>());
        }
    }
}