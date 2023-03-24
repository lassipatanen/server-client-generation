using Testbed.Api.Codegen.Models;

namespace VeroProductizer.Utilities;

public class VeroTestbedTaxCardAdapter : TaxCard
{
    public VeroTestbedTaxCardAdapter(Vero.Api.Codegen.Model.TaxCard? resultResult)
    {
        Identifier = resultResult.Identifier;
        Ssn = resultResult.Ssn;
        Type = (TypeEnum)resultResult.Type;
        ValidFromDate = (DateTime)resultResult.ValidFromDate;
        IncomeLimit = (decimal)resultResult.IncomeLimit;
        Percentage = (decimal)resultResult.Percentage;
    }
}
