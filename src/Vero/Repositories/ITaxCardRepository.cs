using Vero.Models;

namespace Vero.Repositories;

public interface ITaxCardRepository
{
    public TaxCard Load(Guid id);
    public IEnumerable<TaxCard> LoadAll();
    public object Create(TaxCard taxCard);
}
