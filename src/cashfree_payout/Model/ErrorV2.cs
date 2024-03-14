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
    /// Error Response for non-2XX cases
    /// </summary>
    [DataContract(Name = "ErrorV2")]
    public class ErrorV2 : IEquatable<ErrorV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorV2" /> class.
        /// </summary>
        /// <param name="type">Type of the error received.</param>
        /// <param name="code">Code of the error received.</param>
        /// <param name="message">Detailed message explaining the response.</param>
        public ErrorV2(string type = default(string), string code = default(string), string message = default(string))
        {
            this.type = type;
            this.code = code;
            this.message = message;
        }

        /// <summary>
        /// Type of the error received
        /// </summary>
        /// <value>Type of the error received</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string type { get; set; }

        /// <summary>
        /// Code of the error received
        /// </summary>
        /// <value>Code of the error received</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string code { get; set; }

        /// <summary>
        /// Detailed message explaining the response
        /// </summary>
        /// <value>Detailed message explaining the response</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorV2 {\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  code: ").Append(code).Append("\n");
            sb.Append("  message: ").Append(message).Append("\n");
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
            return this.Equals(input as ErrorV2);
        }

        /// <summary>
        /// Returns true if ErrorV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorV2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.code == input.code ||
                    (this.code != null &&
                    this.code.Equals(input.code))
                ) && 
                (
                    this.message == input.message ||
                    (this.message != null &&
                    this.message.Equals(input.message))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringtype) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringtype);
            if (deserializedJsonString.ContainsKey("type")) {
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
                if (this.type != null)
                {
                    hashCode = (hashCode * 59) + this.type.GetHashCode();
                }
                if (this.code != null)
                {
                    hashCode = (hashCode * 59) + this.code.GetHashCode();
                }
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
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