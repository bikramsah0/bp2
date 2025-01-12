﻿using LDC.Atlas.DataAccess;
using LDC.Atlas.Infrastructure.ViewModel;
using LDC.Atlas.Services.MasterData.Entities;
using LDC.Atlas.Services.MasterData.Model;
using LDC.Atlas.Services.MasterData.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace LDC.Atlas.Services.MasterData.Controllers
{
    [Route("api/v1/masterdata/{company}/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ResponseCache(CacheProfileName = "Never")]
    [Authorize]
    public class BankNccTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBankNccTypeRepository _bankNccTypeRepository;
        private readonly IRedisConnectionFactory _cache;

        public BankNccTypesController(IUnitOfWork unitOfWork, IBankNccTypeRepository bankNccTypeRepository, IRedisConnectionFactory cache)
        {
            _unitOfWork = unitOfWork;
            _bankNccTypeRepository = bankNccTypeRepository;
            _cache = cache;
        }

        /// <summary>
        /// Returns the list of bank ncc types.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(CollectionViewModel<EnumEntity>), StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionViewModel<EnumEntity>>> Get()
        {
            IEnumerable<EnumEntity> bankNccTypes = await _bankNccTypeRepository.GetAllAsync();

            var response = new CollectionViewModel<EnumEntity>(bankNccTypes.ToList());

            return Ok(response);
        }
    }
}
