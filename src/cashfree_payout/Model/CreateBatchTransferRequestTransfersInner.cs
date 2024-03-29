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
    /// CreateBatchTransferRequestTransfersInner
    /// </summary>
    [DataContract(Name = "CreateBatchTransferRequest_transfers_inner")]
    public class CreateBatchTransferRequestTransfersInner : IEquatable<CreateBatchTransferRequestTransfersInner>, IValidatableObject
    {
        /// <summary>
        /// It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer.
        /// </summary>
        /// <value>It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferModeEnum
        {
            /// <summary>
            /// Enum Banktransfer for value: banktransfer
            /// </summary>
            [EnumMember(Value = "banktransfer")]
            Banktransfer = 1,

            /// <summary>
            /// Enum Imps for value: imps
            /// </summary>
            [EnumMember(Value = "imps")]
            Imps = 2,

            /// <summary>
            /// Enum Neft for value: neft
            /// </summary>
            [EnumMember(Value = "neft")]
            Neft = 3,

            /// <summary>
            /// Enum Rtgs for value: rtgs
            /// </summary>
            [EnumMember(Value = "rtgs")]
            Rtgs = 4,

            /// <summary>
            /// Enum Upi for value: upi
            /// </summary>
            [EnumMember(Value = "upi")]
            Upi = 5,

            /// <summary>
            /// Enum Paytm for value: paytm
            /// </summary>
            [EnumMember(Value = "paytm")]
            Paytm = 6,

            /// <summary>
            /// Enum Amazonpay for value: amazonpay
            /// </summary>
            [EnumMember(Value = "amazonpay")]
            Amazonpay = 7,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 8,

            /// <summary>
            /// Enum Cardupi for value: cardupi
            /// </summary>
            [EnumMember(Value = "cardupi")]
            Cardupi = 9
        }


        /// <summary>
        /// It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer.
        /// </summary>
        /// <value>It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer.</value>
        [DataMember(Name = "transfer_mode", EmitDefaultValue = false)]
        public TransferModeEnum? transfer_mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchTransferRequestTransfersInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateBatchTransferRequestTransfersInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchTransferRequestTransfersInner" /> class.
        /// </summary>
        /// <param name="transferId">It is the unique ID you create to identify the transfer. You can use a maximum of 40 characters to create a transfer_id.  Alphanumeric and underscore ( _ ) are allowed. (required).</param>
        /// <param name="transferAmount">It is the transfer amount. Decimal values are allowed. The minimum value should be equal to or greater than 1.00. (&gt;&#x3D; 1.00) (required).</param>
        /// <param name="transferCurrency">It is the currency of the transfer amount. The default value is INR..</param>
        /// <param name="transferMode">It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer..</param>
        /// <param name="beneficiaryDetails">beneficiaryDetails.</param>
        /// <param name="transferRemarks">It can contain any additional remarks for the transfer. Alphanumeric and whitespaces are allowed. The maximum character limit is 70..</param>
        /// <param name="fundsourceId">It is the ID of the fund source from where you want to debit the transfer amount..</param>
        public CreateBatchTransferRequestTransfersInner(string transferId = default(string), double transferAmount = default(double), string transferCurrency = default(string), TransferModeEnum? transferMode = default(TransferModeEnum?), CreateBatchTransferRequestTransfersInnerBeneficiaryDetails beneficiaryDetails = default(CreateBatchTransferRequestTransfersInnerBeneficiaryDetails), string transferRemarks = default(string), string fundsourceId = default(string))
        {
            // to ensure "transferId" is required (not null)
            if (transferId == null)
            {
                throw new ArgumentNullException("transferId is a required property for CreateBatchTransferRequestTransfersInner and cannot be null");
            }
            this.transfer_id = transferId;
            this.transfer_amount = transferAmount;
            this.transfer_currency = transferCurrency;
            this.transfer_mode = transferMode;
            this.beneficiary_details = beneficiaryDetails;
            this.transfer_remarks = transferRemarks;
            this.fundsource_id = fundsourceId;
        }

        /// <summary>
        /// It is the unique ID you create to identify the transfer. You can use a maximum of 40 characters to create a transfer_id.  Alphanumeric and underscore ( _ ) are allowed.
        /// </summary>
        /// <value>It is the unique ID you create to identify the transfer. You can use a maximum of 40 characters to create a transfer_id.  Alphanumeric and underscore ( _ ) are allowed.</value>
        [DataMember(Name = "transfer_id", IsRequired = true, EmitDefaultValue = true)]
        public string transfer_id { get; set; }

        /// <summary>
        /// It is the transfer amount. Decimal values are allowed. The minimum value should be equal to or greater than 1.00. (&gt;&#x3D; 1.00)
        /// </summary>
        /// <value>It is the transfer amount. Decimal values are allowed. The minimum value should be equal to or greater than 1.00. (&gt;&#x3D; 1.00)</value>
        [DataMember(Name = "transfer_amount", IsRequired = true, EmitDefaultValue = true)]
        public double transfer_amount { get; set; }

        /// <summary>
        /// It is the currency of the transfer amount. The default value is INR.
        /// </summary>
        /// <value>It is the currency of the transfer amount. The default value is INR.</value>
        [DataMember(Name = "transfer_currency", EmitDefaultValue = false)]
        public string transfer_currency { get; set; }

        /// <summary>
        /// Gets or Sets beneficiary_details
        /// </summary>
        [DataMember(Name = "beneficiary_details", EmitDefaultValue = false)]
        public CreateBatchTransferRequestTransfersInnerBeneficiaryDetails beneficiary_details { get; set; }

        /// <summary>
        /// It can contain any additional remarks for the transfer. Alphanumeric and whitespaces are allowed. The maximum character limit is 70.
        /// </summary>
        /// <value>It can contain any additional remarks for the transfer. Alphanumeric and whitespaces are allowed. The maximum character limit is 70.</value>
        [DataMember(Name = "transfer_remarks", EmitDefaultValue = false)]
        public string transfer_remarks { get; set; }

        /// <summary>
        /// It is the ID of the fund source from where you want to debit the transfer amount.
        /// </summary>
        /// <value>It is the ID of the fund source from where you want to debit the transfer amount.</value>
        [DataMember(Name = "fundsource_id", EmitDefaultValue = false)]
        public string fundsource_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateBatchTransferRequestTransfersInner {\n");
            sb.Append("  transfer_id: ").Append(transfer_id).Append("\n");
            sb.Append("  transfer_amount: ").Append(transfer_amount).Append("\n");
            sb.Append("  transfer_currency: ").Append(transfer_currency).Append("\n");
            sb.Append("  transfer_mode: ").Append(transfer_mode).Append("\n");
            sb.Append("  beneficiary_details: ").Append(beneficiary_details).Append("\n");
            sb.Append("  transfer_remarks: ").Append(transfer_remarks).Append("\n");
            sb.Append("  fundsource_id: ").Append(fundsource_id).Append("\n");
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
            return this.Equals(input as CreateBatchTransferRequestTransfersInner);
        }

        /// <summary>
        /// Returns true if CreateBatchTransferRequestTransfersInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateBatchTransferRequestTransfersInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateBatchTransferRequestTransfersInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.transfer_id == input.transfer_id ||
                    (this.transfer_id != null &&
                    this.transfer_id.Equals(input.transfer_id))
                ) && 
                (
                    this.transfer_amount == input.transfer_amount ||
                    this.transfer_amount.Equals(input.transfer_amount)
                ) && 
                (
                    this.transfer_currency == input.transfer_currency ||
                    (this.transfer_currency != null &&
                    this.transfer_currency.Equals(input.transfer_currency))
                ) && 
                (
                    this.transfer_mode == input.transfer_mode ||
                    this.transfer_mode.Equals(input.transfer_mode)
                ) && 
                (
                    this.beneficiary_details == input.beneficiary_details ||
                    (this.beneficiary_details != null &&
                    this.beneficiary_details.Equals(input.beneficiary_details))
                ) && 
                (
                    this.transfer_remarks == input.transfer_remarks ||
                    (this.transfer_remarks != null &&
                    this.transfer_remarks.Equals(input.transfer_remarks))
                ) && 
                (
                    this.fundsource_id == input.fundsource_id ||
                    (this.fundsource_id != null &&
                    this.fundsource_id.Equals(input.fundsource_id))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringtransfer_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringtransfer_id);
            if (deserializedJsonString.ContainsKey("transfer_id")) {
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
                if (this.transfer_id != null)
                {
                    hashCode = (hashCode * 59) + this.transfer_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.transfer_amount.GetHashCode();
                if (this.transfer_currency != null)
                {
                    hashCode = (hashCode * 59) + this.transfer_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.transfer_mode.GetHashCode();
                if (this.beneficiary_details != null)
                {
                    hashCode = (hashCode * 59) + this.beneficiary_details.GetHashCode();
                }
                if (this.transfer_remarks != null)
                {
                    hashCode = (hashCode * 59) + this.transfer_remarks.GetHashCode();
                }
                if (this.fundsource_id != null)
                {
                    hashCode = (hashCode * 59) + this.fundsource_id.GetHashCode();
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
            // transfer_id (string) maxLength
            if (this.transfer_id != null && this.transfer_id.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for transfer_id, length must be less than 40.", new [] { "transfer_id" });
            }

            // transfer_remarks (string) maxLength
            if (this.transfer_remarks != null && this.transfer_remarks.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for transfer_remarks, length must be less than 70.", new [] { "transfer_remarks" });
            }

            yield break;
        }
    }

}
