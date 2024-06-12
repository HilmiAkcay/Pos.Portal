using AutoMapper;
using CloudDomain.Domain;
using Pos.Application.Dtos.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Application.Profiles
{
    public class PageProfile:Profile
    {
        public PageProfile()
        {
            CreateMap<PageCreateDto, Page>().ReverseMap();
        }
    }
}
