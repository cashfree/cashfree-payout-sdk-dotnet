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
    /// It displays the contact details of the beneficiary.
    /// </summary>
    [DataContract(Name = "Beneficiary_beneficiary_contact_details")]
    public class BeneficiaryBeneficiaryContactDetails : IEquatable<BeneficiaryBeneficiaryContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BeneficiaryBeneficiaryContactDetails" /> class.
        /// </summary>
        /// <param name="beneficiaryEmail">It displays the email address of the beneficiary..</param>
        /// <param name="beneficiaryPhone">It displays the phone number of the beneficiary without the country code..</param>
        /// <param name="beneficiaryCountryCode">It displays the country code of the beneficiary&#39;s phone number..</param>
        /// <param name="beneficiaryAddress">It displays the address of the beneficiary..</param>
        /// <param name="beneficiaryCity">It displays the name of the city as present in the beneficiary&#39;s address..</param>
        /// <param name="beneficiaryState">It displays the name of the state as present in the beneficiary&#39;s address..</param>
        /// <param name="beneficiaryPostalCode">It displays the PIN code as present in the beneficiary&#39;s address..</param>
        public BeneficiaryBeneficiaryContactDetails(string beneficiaryEmail = default(string), string beneficiaryPhone = default(string), string beneficiaryCountryCode = default(string), string beneficiaryAddress = default(string), string beneficiaryCity = default(string), string beneficiaryState = default(string), string beneficiaryPostalCode = default(string))
        {
            this.beneficiary_email = beneficiaryEmail;
            this.beneficiary_phone = beneficiaryPhone;
            this.beneficiary_country_code = beneficiaryCountryCode;
            this.beneficiary_address = beneficiaryAddress;
            this.beneficiary_city = beneficiaryCity;
            this.beneficiary_state = beneficiaryState;
            this.beneficiary_postal_code = beneficiaryPostalCode;
        }

        /// <summary>
        /// It displays the email address of the beneficiary.
        /// </summary>
        /// <value>It displays the email address of the beneficiary.</value>
        /// <example>johndoe1@cashfree.com</example>
        [DataMember(Name = "beneficiary_email", EmitDefaultValue = false)]
        public string beneficiary_email { get; set; }

        /// <summary>
        /// It displays the phone number of the beneficiary without the country code.
        /// </summary>
        /// <value>It displays the phone number of the beneficiary without the country code.</value>
        /// <example>9876543210</example>
        [DataMember(Name = "beneficiary_phone", EmitDefaultValue = false)]
        public string beneficiary_phone { get; set; }

        /// <summary>
        /// It displays the country code of the beneficiary&#39;s phone number.
        /// </summary>
        /// <value>It displays the country code of the beneficiary&#39;s phone number.</value>
        /// <example>+91</example>
        [DataMember(Name = "beneficiary_country_code", EmitDefaultValue = false)]
        public string beneficiary_country_code { get; set; }

        /// <summary>
        /// It displays the address of the beneficiary.
        /// </summary>
        /// <value>It displays the address of the beneficiary.</value>
        /// <example>177A Bleecker Street</example>
        [DataMember(Name = "beneficiary_address", EmitDefaultValue = false)]
        public string beneficiary_address { get; set; }

        /// <summary>
        /// It displays the name of the city as present in the beneficiary&#39;s address.
        /// </summary>
        /// <value>It displays the name of the city as present in the beneficiary&#39;s address.</value>
        /// <example>New York City</example>
        [DataMember(Name = "beneficiary_city", EmitDefaultValue = false)]
        public string beneficiary_city { get; set; }

        /// <summary>
        /// It displays the name of the state as present in the beneficiary&#39;s address.
        /// </summary>
        /// <value>It displays the name of the state as present in the beneficiary&#39;s address.</value>
        /// <example>New York</example>
        [DataMember(Name = "beneficiary_state", EmitDefaultValue = false)]
        public string beneficiary_state { get; set; }

        /// <summary>
        /// It displays the PIN code as present in the beneficiary&#39;s address.
        /// </summary>
        /// <value>It displays the PIN code as present in the beneficiary&#39;s address.</value>
        /// <example>560001</example>
        [DataMember(Name = "beneficiary_postal_code", EmitDefaultValue = false)]
        public string beneficiary_postal_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BeneficiaryBeneficiaryContactDetails {\n");
            sb.Append("  beneficiary_email: ").Append(beneficiary_email).Append("\n");
            sb.Append("  beneficiary_phone: ").Append(beneficiary_phone).Append("\n");
            sb.Append("  beneficiary_country_code: ").Append(beneficiary_country_code).Append("\n");
            sb.Append("  beneficiary_address: ").Append(beneficiary_address).Append("\n");
            sb.Append("  beneficiary_city: ").Append(beneficiary_city).Append("\n");
            sb.Append("  beneficiary_state: ").Append(beneficiary_state).Append("\n");
            sb.Append("  beneficiary_postal_code: ").Append(beneficiary_postal_code).Append("\n");
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
            return this.Equals(input as BeneficiaryBeneficiaryContactDetails);
        }

        /// <summary>
        /// Returns true if BeneficiaryBeneficiaryContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BeneficiaryBeneficiaryContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeneficiaryBeneficiaryContactDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.beneficiary_email == input.beneficiary_email ||
                    (this.beneficiary_email != null &&
                    this.beneficiary_email.Equals(input.beneficiary_email))
                ) && 
                (
                    this.beneficiary_phone == input.beneficiary_phone ||
                    (this.beneficiary_phone != null &&
                    this.beneficiary_phone.Equals(input.beneficiary_phone))
                ) && 
                (
                    this.beneficiary_country_code == input.beneficiary_country_code ||
                    (this.beneficiary_country_code != null &&
                    this.beneficiary_country_code.Equals(input.beneficiary_country_code))
                ) && 
                (
                    this.beneficiary_address == input.beneficiary_address ||
                    (this.beneficiary_address != null &&
                    this.beneficiary_address.Equals(input.beneficiary_address))
                ) && 
                (
                    this.beneficiary_city == input.beneficiary_city ||
                    (this.beneficiary_city != null &&
                    this.beneficiary_city.Equals(input.beneficiary_city))
                ) && 
                (
                    this.beneficiary_state == input.beneficiary_state ||
                    (this.beneficiary_state != null &&
                    this.beneficiary_state.Equals(input.beneficiary_state))
                ) && 
                (
                    this.beneficiary_postal_code == input.beneficiary_postal_code ||
                    (this.beneficiary_postal_code != null &&
                    this.beneficiary_postal_code.Equals(input.beneficiary_postal_code))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringbeneficiary_email) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringbeneficiary_email);
            if (deserializedJsonString.ContainsKey("beneficiary_email")) {
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
                if (this.beneficiary_email != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_email.GetHashCode();
                }
                if (this.beneficiary_phone != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_phone.GetHashCode();
                }
                if (this.beneficiary_country_code != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_country_code.GetHashCode();
                }
                if (this.beneficiary_address != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_address.GetHashCode();
                }
                if (this.beneficiary_city != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_city.GetHashCode();
                }
                if (this.beneficiary_state != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_state.GetHashCode();
                }
                if (this.beneficiary_postal_code != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_postal_code.GetHashCode();
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
            yield break;
        }
    }

}
