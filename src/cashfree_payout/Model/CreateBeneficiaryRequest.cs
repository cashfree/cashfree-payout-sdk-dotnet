/*
 * Cashfree Payout APIs
 *
 * Cashfree's Payout APIs provide developers with a streamlined pathway to integrate advanced payout capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2024-01-01
 * Contact: developers@cashfree.com
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
using OpenAPIDateConverter = cashfree_payout.Client.OpenAPIDateConverter;

namespace cashfree_payout.Model
{
    /// <summary>
    /// Find the request parameters to create a beneficiary
    /// </summary>
    [DataContract(Name = "CreateBeneficiaryRequest")]
    public class CreateBeneficiaryRequest : IEquatable<CreateBeneficiaryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBeneficiaryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBeneficiaryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBeneficiaryRequest" /> class.
        /// </summary>
        /// <param name="beneficiaryId">It is the unique ID you create to identify the beneficiary. Alphanumeric, underscore ( _ ), pipe ( | ), and dot ( . ) are allowed. (required).</param>
        /// <param name="beneficiaryName">It is the name of the beneficiary. The maximum character limit is 100. Only alphabets and whitespaces are allowed. (required).</param>
        /// <param name="beneficiaryInstrumentDetails">beneficiaryInstrumentDetails.</param>
        /// <param name="beneficiaryContactDetails">beneficiaryContactDetails.</param>
        public CreateBeneficiaryRequest(string beneficiaryId = default(string), string beneficiaryName = default(string), CreateBeneficiaryRequestBeneficiaryInstrumentDetails beneficiaryInstrumentDetails = default(CreateBeneficiaryRequestBeneficiaryInstrumentDetails), CreateBeneficiaryRequestBeneficiaryContactDetails beneficiaryContactDetails = default(CreateBeneficiaryRequestBeneficiaryContactDetails))
        {
            // to ensure "beneficiaryId" is required (not null)
            if (beneficiaryId == null)
            {
                throw new ArgumentNullException("beneficiaryId is a required property for CreateBeneficiaryRequest and cannot be null");
            }
            this.beneficiary_id = beneficiaryId;
            // to ensure "beneficiaryName" is required (not null)
            if (beneficiaryName == null)
            {
                throw new ArgumentNullException("beneficiaryName is a required property for CreateBeneficiaryRequest and cannot be null");
            }
            this.beneficiary_name = beneficiaryName;
            this.beneficiary_instrument_details = beneficiaryInstrumentDetails;
            this.beneficiary_contact_details = beneficiaryContactDetails;
        }

        /// <summary>
        /// It is the unique ID you create to identify the beneficiary. Alphanumeric, underscore ( _ ), pipe ( | ), and dot ( . ) are allowed.
        /// </summary>
        /// <value>It is the unique ID you create to identify the beneficiary. Alphanumeric, underscore ( _ ), pipe ( | ), and dot ( . ) are allowed.</value>
        /// <example>JOHN18011343</example>
        [DataMember(Name = "beneficiary_id", IsRequired = true, EmitDefaultValue = true)]
        public string beneficiary_id { get; set; }

        /// <summary>
        /// It is the name of the beneficiary. The maximum character limit is 100. Only alphabets and whitespaces are allowed.
        /// </summary>
        /// <value>It is the name of the beneficiary. The maximum character limit is 100. Only alphabets and whitespaces are allowed.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "beneficiary_name", IsRequired = true, EmitDefaultValue = true)]
        public string beneficiary_name { get; set; }

        /// <summary>
        /// Gets or Sets beneficiary_instrument_details
        /// </summary>
        [DataMember(Name = "beneficiary_instrument_details", EmitDefaultValue = false)]
        public CreateBeneficiaryRequestBeneficiaryInstrumentDetails beneficiary_instrument_details { get; set; }

        /// <summary>
        /// Gets or Sets beneficiary_contact_details
        /// </summary>
        [DataMember(Name = "beneficiary_contact_details", EmitDefaultValue = false)]
        public CreateBeneficiaryRequestBeneficiaryContactDetails beneficiary_contact_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateBeneficiaryRequest {\n");
            sb.Append("  beneficiary_id: ").Append(beneficiary_id).Append("\n");
            sb.Append("  beneficiary_name: ").Append(beneficiary_name).Append("\n");
            sb.Append("  beneficiary_instrument_details: ").Append(beneficiary_instrument_details).Append("\n");
            sb.Append("  beneficiary_contact_details: ").Append(beneficiary_contact_details).Append("\n");
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
            return this.Equals(input as CreateBeneficiaryRequest);
        }

        /// <summary>
        /// Returns true if CreateBeneficiaryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBeneficiaryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBeneficiaryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.beneficiary_id == input.beneficiary_id ||
                    (this.beneficiary_id != null &&
                    this.beneficiary_id.Equals(input.beneficiary_id))
                ) && 
                (
                    this.beneficiary_name == input.beneficiary_name ||
                    (this.beneficiary_name != null &&
                    this.beneficiary_name.Equals(input.beneficiary_name))
                ) && 
                (
                    this.beneficiary_instrument_details == input.beneficiary_instrument_details ||
                    (this.beneficiary_instrument_details != null &&
                    this.beneficiary_instrument_details.Equals(input.beneficiary_instrument_details))
                ) && 
                (
                    this.beneficiary_contact_details == input.beneficiary_contact_details ||
                    (this.beneficiary_contact_details != null &&
                    this.beneficiary_contact_details.Equals(input.beneficiary_contact_details))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringbeneficiary_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringbeneficiary_id);
            if (deserializedJsonString.ContainsKey("beneficiary_id")) {
                return true;
            }
            return false;
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
                if (this.beneficiary_id != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_id.GetHashCode();
                }
                if (this.beneficiary_name != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_name.GetHashCode();
                }
                if (this.beneficiary_instrument_details != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_instrument_details.GetHashCode();
                }
                if (this.beneficiary_contact_details != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_contact_details.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // beneficiary_id (string) maxLength
            if (this.beneficiary_id != null && this.beneficiary_id.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for beneficiary_id, length must be less than 50.", new [] { "beneficiary_id" });
            }

            // beneficiary_name (string) maxLength
            if (this.beneficiary_name != null && this.beneficiary_name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for beneficiary_name, length must be less than 100.", new [] { "beneficiary_name" });
            }

            yield break;
        }
    }

}
