using Vero.Api.Codegen.Model;

namespace Vero.Utilities;

public class MongoTestbedTaxCardAdapter : TaxCard
{
    public MongoTestbedTaxCardAdapter(Models.TaxCard taxCard)
    {
        Identifier = taxCard.Identifier;
        Ssn = taxCard.Ssn ?? string.Empty;
        Type = (TypeEnum?)taxCard.Type;
        ValidFromDate = taxCard.ValidFromDate;
        IncomeLimit = taxCard.IncomeLimit;
        Percentage = taxCard.Percentage;
    }
}
