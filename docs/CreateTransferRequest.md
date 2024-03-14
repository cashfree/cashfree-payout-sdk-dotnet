# cashfree_payout.Model.CreateTransferRequest
Standard Transfer V2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transfer_id** | **string** | It is the unique ID you create to identify the transfer. You can use a maximum of 40 characters to create a transfer_id.  Alphanumeric and underscore ( _ ) are allowed. | 
**transfer_amount** | **double** | It is the transfer amount. Decimal values are allowed. The minimum value should be equal to or greater than 1.00. (&gt;&#x3D; 1.00) | 
**transfer_currency** | **string** | It is the currency of the transfer amount. The default value is INR. | [optional] 
**transfer_mode** | **string** | It is the mode of transfer. Allowed values are banktransfer, imps, neft, rtgs, upi, paytm, amazonpay, card. The default transfer_mode is banktransfer. | [optional] 
**beneficiary_details** | [**CreateTransferRequestBeneficiaryDetails**](CreateTransferRequestBeneficiaryDetails.md) |  | [optional] 
**transfer_remarks** | **string** | It can contain any additional remarks for the transfer. Alphanumeric and whitespaces are allowed. The maximum character limit is 70. | [optional] 
**fundsource_id** | **string** | It is the ID of the fund source from which the transfer amount will be debited. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

