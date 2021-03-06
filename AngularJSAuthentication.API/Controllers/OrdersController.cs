﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularJSAuthentication.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ShipperCity { get; set; }
        public bool IsShipped { get; set; }

        public static IList<Order> CreateOrders()
        {
            var orderList = new List<Order>
            {
                new Order {OrderId = 10248, CustomerName = "Taiseer Joudeh", ShipperCity = "Amman", IsShipped = true},
                new Order {OrderId = 10249, CustomerName = "Ahmad Hasan", ShipperCity = "Dubai", IsShipped = false},
                new Order {OrderId = 10250, CustomerName = "Tamer Yaser", ShipperCity = "Jeddah", IsShipped = false},
                new Order {OrderId = 10251, CustomerName = "Lina Majed", ShipperCity = "Abu Dhabi", IsShipped = false},
                new Order {OrderId = 10252, CustomerName = "Yasmeen Rami", ShipperCity = "Kuwait", IsShipped = true}
            };

            return orderList;
        }
    }
}
