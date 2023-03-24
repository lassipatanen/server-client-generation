using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Vero.Models;

public class TaxCard
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    [BsonElement("identifier")] public Guid Identifier { get; set; }
    [BsonElement("employeeIdentifier")] public Guid EmployeeIdentifier { get; set; }
    [BsonElement("ssn")] public string? Ssn { get; set; }
    [BsonElement("taxCardType")] public TaxCardType? Type { get; set; }
    [BsonElement("validFromDate")] public DateTime? ValidFromDate { get; set; }
    [BsonElement("incomeLimit")] public decimal? IncomeLimit { get; set; }
    [BsonElement("percentage")] public decimal? Percentage { get; set; }
}
