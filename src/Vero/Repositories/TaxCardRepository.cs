using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Vero.Config;
using Vero.Models;

namespace Vero.Repositories;

internal class TaxCardRepository : ITaxCardRepository
{
    private readonly IMongoCollection<TaxCard> _taxCardCollection;

    public TaxCardRepository(IOptions<DatabaseSettings> settings)
    {
        var mongoClient = new MongoClient(settings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);
        _taxCardCollection = mongoDatabase.GetCollection<TaxCard>(settings.Value.CollectionName);
    }

    public TaxCard Load(Guid id)
    {
        var taxCard = _taxCardCollection.AsQueryable().FirstOrDefault(t => t.Identifier == id);

        return taxCard;
    }

    public IEnumerable<TaxCard> LoadAll()
    {
        var taxCards = _taxCardCollection.Find(_ => true);
        var test = taxCards.SortByDescending(t => t.Id).ToList();
        return test;
    }

    public object Create(TaxCard taxCard)
    {
        _taxCardCollection.InsertOne(taxCard);
        var lastInsertedTaxCard = _taxCardCollection
            .Find(_ => true)
            .SortByDescending(t => t.Id)
            .Limit(1)
            .FirstOrDefault();

        return lastInsertedTaxCard;
    }
}
