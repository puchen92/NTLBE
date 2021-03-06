﻿using Data;
using Domain.IServices;
using Infrastructure.Decorator;
using Infrastructure.Queries;
using System.Collections.Generic;
using WebCore.Queries;

namespace WebCore.Services
{
    public class DeliveryTypeServices : IService<DeliveryType>, IDeliveryTypeServices
    {
        private readonly IQueryHandler<DeliveryTypeGetAllQuery, IEnumerable<DeliveryType>> getAllDeliveryTypeHandler;

        public DeliveryTypeServices(
            IQueryHandler<DeliveryTypeGetAllQuery, IEnumerable<DeliveryType>> _getAllDeliveryTypeHandler
        )
        {
            getAllDeliveryTypeHandler = _getAllDeliveryTypeHandler; 
        }
        public IEnumerable<DeliveryType> GetAllDeliveryType()
        {
            return getAllDeliveryTypeHandler.Handle(new DeliveryTypeGetAllQuery { });
        }

    
    }
}
