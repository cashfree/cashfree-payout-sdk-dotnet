# cashfree_payout.Model.CreateTransferRequestBeneficiaryDetailsBeneficiaryInstrumentDetailsCardDetails
It should contain the card details of the beneficiary.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_token** | **string** | It is the tokenised card number or card token for this transfer. | [optional] 
**card_network_type** | **string** | It is the network type of the card - VISA/MASTERCARD. | [optional] 
**card_cryptogram** | **string** | It is the formatted chip/cryptogram data relating to the token cryptogram. The maximum character limit is 600. It is optional for MASTERCARD and not required for VISA. | [optional] 
**card_token_expiry** | **string** | It is applicable only for MASTERCARD. The format for the valid token expiry date should be YYYY-MM. It cannot be null. Provide a valid tokenExpiry if collected from the customers. If unavailable, populate a static value with a forward year and month in the correct format (YYYY-MM). The maximum character limit is 10. | [optional] 
**card_type** | **string** | It is the type of the card. DEBIT and CREDIT are the only values allowed. The default value is CREDIT if the parameter does not exist or not specified. | [optional] 
**card_token_PAN_sequence_number** | **string** | A maximum of 3 alphanumeric characters are allowed. It is an optional parameter for MASTERCARD. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

