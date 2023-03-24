using Vero.Api.Codegen.Model;

namespace Vero.Services;

public interface ITaxCardService
{
    public TaxCard Load(Guid id);
    public IReadOnlyList<TaxCard> LoadAll();
    public object Create(Guid employeeIdentifier, TaxCard taxCard);
}
