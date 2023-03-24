using Vero.Models;

namespace Vero.Utilities;

public class TestbedMongoTaxCardAdapter : TaxCard
{
    public TestbedMongoTaxCardAdapter(Api.Codegen.Model.TaxCard taxCard)
    {
        Identifier = taxCard.Identifier ?? Guid.Empty;
        EmployeeIdentifier = Guid.Empty;
        Ssn = taxCard.Ssn;
        Type = (TaxCardType?)taxCard.Type;
        ValidFromDate = taxCard.ValidFromDate;
        IncomeLimit = taxCard.IncomeLimit;
        Percentage = taxCard.Percentage;
    }

    public void SetEmployeeIdentifier(Guid employeeIdentifier)
    {
        EmployeeIdentifier = employeeIdentifier;
    }
}
