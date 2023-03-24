using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Testbed.Api.Codegen.Controllers;
using Testbed.Api.Codegen.Models;
using VeroProductizer.Utilities;
using TaxCard = Vero.Api.Codegen.Model.TaxCard;

namespace VeroProductizer.Controllers;

public class TestbedController : TestbedApiController
{
    private const string VeroApiBaseAddress = "http://localhost:5081";
    private readonly IHttpClientFactory _httpClientFactory;

    public TestbedController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public override IActionResult PostDraftPersonTaxCard(
        PostDraftPersonTaxCardRequest postDraftPersonTaxCardRequest)
    {
        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(VeroApiBaseAddress);
        var response = client.GetAsync($"tax-cards/{postDraftPersonTaxCardRequest.EmployeeIdentifier}");
        var result = response.Result.Content.ReadFromJsonAsync<TaxCard>();

        var responseResult = new PostDraftPersonTaxCard200Response
        {
            EmployeeIdentifier = postDraftPersonTaxCardRequest.EmployeeIdentifier,
            TaxCard = new VeroTestbedTaxCardAdapter(result.Result)
        };

        return Ok(responseResult);
    }

    public override async Task<IActionResult> PostDraftPersonTaxCardWrite(
        PostDraftPersonTaxCardWriteRequest postDraftPersonTaxCardWriteRequest)
    {
        var userId = postDraftPersonTaxCardWriteRequest.EmployeeIdentifier;

        var client = _httpClientFactory.CreateClient();
        client.BaseAddress = new Uri(VeroApiBaseAddress);

        var json = JsonSerializer.Serialize(new PostTaxCardRequestAdapter(postDraftPersonTaxCardWriteRequest));
        var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync($"/users/{userId}/tax-cards", stringContent);

        var result = await response.Content.ReadFromJsonAsync<TaxCard>();

        return Ok(result);
    }
}
