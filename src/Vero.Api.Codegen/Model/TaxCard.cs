/*
 * Vero API
 *
 * All your money are belong to us
 *
 * The version of the OpenAPI document: 1.0
 * Contact: lassi.patanen@gofore.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Vero.Api.Codegen.Client.OpenAPIDateConverter;

namespace Vero.Api.Codegen.Model
{
    /// <summary>
    /// TaxCard
    /// </summary>
    [DataContract(Name = "TaxCard")]
    public partial class TaxCard : IEquatable<TaxCard>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum B for value: B
            /// </summary>
            [EnumMember(Value = "B")]
            B = 2

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCard" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="ssn">ssn.</param>
        /// <param name="type">type.</param>
        /// <param name="validFromDate">validFromDate.</param>
        /// <param name="incomeLimit">incomeLimit.</param>
        /// <param name="percentage">percentage.</param>
        public TaxCard(Guid? identifier = default(Guid?), string ssn = default(string), TypeEnum? type = default(TypeEnum?), DateTime? validFromDate = default(DateTime?), decimal? incomeLimit = default(decimal?), decimal? percentage = default(decimal?))
        {
            this.Identifier = identifier;
            this.Ssn = ssn;
            this.Type = type;
            this.ValidFromDate = validFromDate;
            this.IncomeLimit = incomeLimit;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = true)]
        public Guid? Identifier { get; set; }

        /// <summary>
        /// Gets or Sets Ssn
        /// </summary>
        [DataMember(Name = "ssn", EmitDefaultValue = true)]
        public string Ssn { get; set; }

        /// <summary>
        /// Gets or Sets ValidFromDate
        /// </summary>
        [DataMember(Name = "validFromDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ValidFromDate { get; set; }

        /// <summary>
        /// Gets or Sets IncomeLimit
        /// </summary>
        [DataMember(Name = "incomeLimit", EmitDefaultValue = true)]
        public decimal? IncomeLimit { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxCard {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidFromDate: ").Append(ValidFromDate).Append("\n");
            sb.Append("  IncomeLimit: ").Append(IncomeLimit).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxCard);
        }

        /// <summary>
        /// Returns true if TaxCard instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ValidFromDate == input.ValidFromDate ||
                    (this.ValidFromDate != null &&
                    this.ValidFromDate.Equals(input.ValidFromDate))
                ) && 
                (
                    this.IncomeLimit == input.IncomeLimit ||
                    (this.IncomeLimit != null &&
                    this.IncomeLimit.Equals(input.IncomeLimit))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Ssn != null)
                {
                    hashCode = (hashCode * 59) + this.Ssn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.ValidFromDate != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFromDate.GetHashCode();
                }
                if (this.IncomeLimit != null)
                {
                    hashCode = (hashCode * 59) + this.IncomeLimit.GetHashCode();
                }
                if (this.Percentage != null)
                {
                    hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}