using Testbed.Api.Codegen.Models;
using TaxCard = Vero.Api.Codegen.Model.TaxCard;

namespace VeroProductizer.Utilities;

public class PostTaxCardRequestAdapter : Vero.Api.Codegen.Model.PostUsersUserIdTaxCardsTaxCardIdRequest
{
    public PostTaxCardRequestAdapter(PostDraftPersonTaxCardWriteRequest request)
    {
        TaxCard = new TaxCard
        {
            Identifier = request.Data.Identifier,
            Ssn = request.Data.Ssn,
            Type = (TaxCard.TypeEnum?)request.Data.Type,
            ValidFromDate = request.Data.ValidFromDate,
            IncomeLimit = request.Data.IncomeLimit,
            Percentage = request.Data.Percentage
        };
    }
}
