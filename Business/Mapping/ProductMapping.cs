﻿using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping() 
        {
            //CreateMap<Product, CreatedProductResponse>()
            //.ForMember(destination => destination.Id, oparation => oparation.MapFrom(source => source.Id))
            //.ForMember(destination => destination.ProductName, oparation => oparation.MapFrom(source => source.ProductName))
            //.ForMember(destination => destination.QuantityPerUnit, oparation => oparation.MapFrom(source => source.QuantityPerUnit))
            //.ForMember(destination => destination.UnitPrice, oparation => oparation.MapFrom(source => source.UnitPrice))
            //.ForMember(destination => destination.UnitsInStock, oparation => oparation.MapFrom(source => source.UnitsInStock));

            //CreateMap<Product, CreateProductRequest >()
            //.ForMember(destination => destination.ProductName, oparation => oparation.MapFrom(source => source.ProductName))
            //.ForMember(destination => destination.QuantityPerUnit, oparation => oparation.MapFrom(source => source.QuantityPerUnit))
            //.ForMember(destination => destination.UnitPrice, oparation => oparation.MapFrom(source => source.UnitPrice))
            //.ForMember(destination => destination.UnitsInStock, oparation => oparation.MapFrom(source => source.UnitsInStock));

            CreateMap< CreatedProductResponse ,Product >().ReverseMap();
            CreateMap<CreateProductRequest, Product>().ReverseMap();
            CreateMap<Paginate<Product>, Paginate<CreatedProductResponse>>().ReverseMap();
            CreateMap<Product, CreatedProductResponse>().ReverseMap();

        }

    }
}
