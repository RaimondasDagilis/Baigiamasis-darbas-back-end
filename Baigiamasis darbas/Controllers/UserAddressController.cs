﻿using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Baigiamasis_darbas.Controllers
{
    [Route("[controller]")]
    [ApiController]    
    public class UserAddressController : ControllerBase
    {
        private readonly IUserAddressRepository userAddressRepository;
        public UserAddressController(IUserAddressRepository userAddressRepository)
        {
            this.userAddressRepository = userAddressRepository;
        }

        [HttpGet]
        public ActionResult<UserAddress> Get([FromQuery] int id)
        {
            UserAddress userAddress = userAddressRepository.GetById(id);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }                

        [HttpPost]
        public ActionResult<UserAddress> Create([FromBody] UserAddressDTO value)
        {
            UserAddress userAddress = userAddressRepository.Create(value);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }

        [HttpPut("FlatNo")]
        public ActionResult<UserAddress> PutFlatNo([FromQuery]int id, [FromQuery] string value)
        {
            UserAddress userAddress = userAddressRepository.UpdateFlatNo(id, value);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }

        [HttpPut("HouseNo")]
        public ActionResult<UserAddress> PutHouseNo([FromQuery] int id, [FromQuery] string value)
        {
            UserAddress userAddress = userAddressRepository.UpdateHouseNo(id, value);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }

        [HttpPut("Street")]
        public ActionResult<UserAddress> PutStreet([FromQuery] int id, [FromQuery] string value)
        {
            UserAddress userAddress = userAddressRepository.UpdateStreet(id, value);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPut("Town")]
        public ActionResult<UserAddress> PutTown([FromQuery] int id, [FromQuery] string value)
        {
            UserAddress userAddress = userAddressRepository.UpdateTown(id, value);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
    }
}
