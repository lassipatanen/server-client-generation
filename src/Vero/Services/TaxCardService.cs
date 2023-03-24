using Vero.Repositories;
using Vero.Utilities;
using TaxCard = Vero.Api.Codegen.Model.TaxCard;

namespace Vero.Services;

public class TaxCardService : ITaxCardService
{
    private readonly ITaxCardRepository _repository;

    public TaxCardService(ITaxCardRepository repository)
    {
        _repository = repository;
    }

    public TaxCard Load(Guid id)
    {
        var taxCard = _repository.Load(id);
        return new MongoTestbedTaxCardAdapter(taxCard);
    }

    public IReadOnlyList<TaxCard> LoadAll()
    {
        var taxCards = _repository.LoadAll();
        return taxCards.Select(x => new MongoTestbedTaxCardAdapter(x)).ToList();
    }

    public object Create(Guid employeeIdentifier, TaxCard taxCard)
    {
        var taxCardData = new TestbedMongoTaxCardAdapter(taxCard);
        taxCardData.SetEmployeeIdentifier(employeeIdentifier);
        
        var result = _repository.Create(taxCardData);
        return result;
    }
}
