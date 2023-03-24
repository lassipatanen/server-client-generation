/*
 * TestBed
 *
 * TestBed dataspace for standardizing data
 *
 * The version of the OpenAPI document: 1.0
 * Contact: lassi.patanen@gofore.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Testbed.Api.Codegen.Attributes;
using Testbed.Api.Codegen.Models;

namespace Testbed.Api.Codegen.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class TestbedApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get tax card for user from testbed</remarks>
        /// <param name="postDraftPersonTaxCardRequest"></param>
        /// <response code="200">Example response</response>
        [HttpPost]
        [Route("/draft/Person/TaxCard")]
        [Consumes("application/json")]
        [ValidateModelState]
        [ProducesResponseType(statusCode: 200, type: typeof(PostDraftPersonTaxCard200Response))]
        public abstract IActionResult PostDraftPersonTaxCard([FromBody]PostDraftPersonTaxCardRequest postDraftPersonTaxCardRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Create or update tax card using testbed</remarks>
        /// <param name="postDraftPersonTaxCardWriteRequest"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/draft/Person/TaxCard/Write")]
        [Consumes("application/json")]
        [ValidateModelState]
        public abstract Task<IActionResult> PostDraftPersonTaxCardWrite(
            [FromBody] PostDraftPersonTaxCardWriteRequest postDraftPersonTaxCardWriteRequest);
    }
}