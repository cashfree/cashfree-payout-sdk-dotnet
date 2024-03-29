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
    /// It should contain the contact details of the beneficiary.
    /// </summary>
    [DataContract(Name = "CreateTransferRequest_beneficiary_details_beneficiary_contact_details")]
    public class CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails : IEquatable<CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails" /> class.
        /// </summary>
        /// <param name="beneficiaryEmail">It is the email address of the beneficiary. The maximum character limit is 200. It should contain dot (.) and at the rate of (@)..</param>
        /// <param name="beneficiaryPhone">It is the phone number of the beneficiary. Only registered Indian phone numbers are allowed. The value should be between 8 and 12 characters after stripping +91..</param>
        /// <param name="beneficiaryCountryCode">It is the country code (+91) of the beneficiary&#39;s phone number..</param>
        /// <param name="beneficiaryAddress">It should contain the address of the beneficiary. The maximum character limit is 150. Alphanumeric characters and whitespaces are allowed..</param>
        /// <param name="beneficiaryCity">It is the name of the city as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed..</param>
        /// <param name="beneficiaryState">It is the name of the state as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed..</param>
        /// <param name="beneficiaryPostalCode">It is the PIN code as present in the address. It should be a 6 character numeric value..</param>
        public CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails(string beneficiaryEmail = default(string), string beneficiaryPhone = default(string), string beneficiaryCountryCode = default(string), string beneficiaryAddress = default(string), string beneficiaryCity = default(string), string beneficiaryState = default(string), string beneficiaryPostalCode = default(string))
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
        /// It is the email address of the beneficiary. The maximum character limit is 200. It should contain dot (.) and at the rate of (@).
        /// </summary>
        /// <value>It is the email address of the beneficiary. The maximum character limit is 200. It should contain dot (.) and at the rate of (@).</value>
        [DataMember(Name = "beneficiary_email", EmitDefaultValue = false)]
        public string beneficiary_email { get; set; }

        /// <summary>
        /// It is the phone number of the beneficiary. Only registered Indian phone numbers are allowed. The value should be between 8 and 12 characters after stripping +91.
        /// </summary>
        /// <value>It is the phone number of the beneficiary. Only registered Indian phone numbers are allowed. The value should be between 8 and 12 characters after stripping +91.</value>
        [DataMember(Name = "beneficiary_phone", EmitDefaultValue = false)]
        public string beneficiary_phone { get; set; }

        /// <summary>
        /// It is the country code (+91) of the beneficiary&#39;s phone number.
        /// </summary>
        /// <value>It is the country code (+91) of the beneficiary&#39;s phone number.</value>
        [DataMember(Name = "beneficiary_country_code", EmitDefaultValue = false)]
        public string beneficiary_country_code { get; set; }

        /// <summary>
        /// It should contain the address of the beneficiary. The maximum character limit is 150. Alphanumeric characters and whitespaces are allowed.
        /// </summary>
        /// <value>It should contain the address of the beneficiary. The maximum character limit is 150. Alphanumeric characters and whitespaces are allowed.</value>
        [DataMember(Name = "beneficiary_address", EmitDefaultValue = false)]
        public string beneficiary_address { get; set; }

        /// <summary>
        /// It is the name of the city as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed.
        /// </summary>
        /// <value>It is the name of the city as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed.</value>
        [DataMember(Name = "beneficiary_city", EmitDefaultValue = false)]
        public string beneficiary_city { get; set; }

        /// <summary>
        /// It is the name of the state as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed.
        /// </summary>
        /// <value>It is the name of the state as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed.</value>
        [DataMember(Name = "beneficiary_state", EmitDefaultValue = false)]
        public string beneficiary_state { get; set; }

        /// <summary>
        /// It is the PIN code as present in the address. It should be a 6 character numeric value.
        /// </summary>
        /// <value>It is the PIN code as present in the address. It should be a 6 character numeric value.</value>
        [DataMember(Name = "beneficiary_postal_code", EmitDefaultValue = false)]
        public string beneficiary_postal_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails {\n");
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
            return this.Equals(input as CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails);
        }

        /// <summary>
        /// Returns true if CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails input)
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
