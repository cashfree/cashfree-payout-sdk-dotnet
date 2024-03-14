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
    /// Beneficiary instrument details
    /// </summary>
    [DataContract(Name = "CreateBeneficiaryRequest_beneficiary_instrument_details")]
    public class CreateBeneficiaryRequestBeneficiaryInstrumentDetails : IEquatable<CreateBeneficiaryRequestBeneficiaryInstrumentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBeneficiaryRequestBeneficiaryInstrumentDetails" /> class.
        /// </summary>
        /// <param name="bankAccountNumber">It is the beneficiary bank account number. The value should be between 9 and 18 characters. Alphanumeric characters are allowed. You need to input bank_ifsc if bank_account_number is passed..</param>
        /// <param name="bankIfsc">It is the IFSC information of the beneficiary&#39;s bank account in the standard IFSC format. The value should be 11 characters. (The first 4 characters should be alphabets, the 5th character should be a 0, and the remaining 6 characters should be numerals.). You need to input bank_account_number if bank_ifsc is passed..</param>
        /// <param name="vpa">It is the UPI VPA information of the beneficiary. Only valid UPI VPA information is accepted. It can be an Alphanumeric value with only period (.), hyphen (-), underscore ( _ ), and at the rate of (@). Hyphen (-) is accepted only before at the rate of (@)..</param>
        public CreateBeneficiaryRequestBeneficiaryInstrumentDetails(string bankAccountNumber = default(string), string bankIfsc = default(string), string vpa = default(string))
        {
            this.bank_account_number = bankAccountNumber;
            this.bank_ifsc = bankIfsc;
            this.vpa = vpa;
        }

        /// <summary>
        /// It is the beneficiary bank account number. The value should be between 9 and 18 characters. Alphanumeric characters are allowed. You need to input bank_ifsc if bank_account_number is passed.
        /// </summary>
        /// <value>It is the beneficiary bank account number. The value should be between 9 and 18 characters. Alphanumeric characters are allowed. You need to input bank_ifsc if bank_account_number is passed.</value>
        /// <example>00111122233</example>
        [DataMember(Name = "bank_account_number", EmitDefaultValue = false)]
        public string bank_account_number { get; set; }

        /// <summary>
        /// It is the IFSC information of the beneficiary&#39;s bank account in the standard IFSC format. The value should be 11 characters. (The first 4 characters should be alphabets, the 5th character should be a 0, and the remaining 6 characters should be numerals.). You need to input bank_account_number if bank_ifsc is passed.
        /// </summary>
        /// <value>It is the IFSC information of the beneficiary&#39;s bank account in the standard IFSC format. The value should be 11 characters. (The first 4 characters should be alphabets, the 5th character should be a 0, and the remaining 6 characters should be numerals.). You need to input bank_account_number if bank_ifsc is passed.</value>
        /// <example>HDFC0000001</example>
        [DataMember(Name = "bank_ifsc", EmitDefaultValue = false)]
        public string bank_ifsc { get; set; }

        /// <summary>
        /// It is the UPI VPA information of the beneficiary. Only valid UPI VPA information is accepted. It can be an Alphanumeric value with only period (.), hyphen (-), underscore ( _ ), and at the rate of (@). Hyphen (-) is accepted only before at the rate of (@).
        /// </summary>
        /// <value>It is the UPI VPA information of the beneficiary. Only valid UPI VPA information is accepted. It can be an Alphanumeric value with only period (.), hyphen (-), underscore ( _ ), and at the rate of (@). Hyphen (-) is accepted only before at the rate of (@).</value>
        /// <example>test@upi</example>
        [DataMember(Name = "vpa", EmitDefaultValue = false)]
        public string vpa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateBeneficiaryRequestBeneficiaryInstrumentDetails {\n");
            sb.Append("  bank_account_number: ").Append(bank_account_number).Append("\n");
            sb.Append("  bank_ifsc: ").Append(bank_ifsc).Append("\n");
            sb.Append("  vpa: ").Append(vpa).Append("\n");
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
            return this.Equals(input as CreateBeneficiaryRequestBeneficiaryInstrumentDetails);
        }

        /// <summary>
        /// Returns true if CreateBeneficiaryRequestBeneficiaryInstrumentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBeneficiaryRequestBeneficiaryInstrumentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBeneficiaryRequestBeneficiaryInstrumentDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.bank_account_number == input.bank_account_number ||
                    (this.bank_account_number != null &&
                    this.bank_account_number.Equals(input.bank_account_number))
                ) && 
                (
                    this.bank_ifsc == input.bank_ifsc ||
                    (this.bank_ifsc != null &&
                    this.bank_ifsc.Equals(input.bank_ifsc))
                ) && 
                (
                    this.vpa == input.vpa ||
                    (this.vpa != null &&
                    this.vpa.Equals(input.vpa))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringbank_account_number) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringbank_account_number);
            if (deserializedJsonString.ContainsKey("bank_account_number")) {
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
                if (this.bank_account_number != null)
                {
                    hashCode = (hashCode * 59) + this.bank_account_number.GetHashCode();
                }
                if (this.bank_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.bank_ifsc.GetHashCode();
                }
                if (this.vpa != null)
                {
                    hashCode = (hashCode * 59) + this.vpa.GetHashCode();
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
            // bank_account_number (string) maxLength
            if (this.bank_account_number != null && this.bank_account_number.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bank_account_number, length must be less than 25.", new [] { "bank_account_number" });
            }

            // bank_account_number (string) minLength
            if (this.bank_account_number != null && this.bank_account_number.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bank_account_number, length must be greater than 4.", new [] { "bank_account_number" });
            }

            yield break;
        }
    }

}