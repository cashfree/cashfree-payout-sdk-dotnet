# cashfree_payout.Model.CreateTransferRequestBeneficiaryDetails
It should contain the details of the beneficiary who receives the transfer amount.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**beneficiary_id** | **string** | It is the unique ID you created to identify the beneficiary. Alphanumeric characters are allowed. | [optional] 
**beneficiary_name** | **string** | It is the name of the beneficiary. The maximum character limit is 100.  Only alphabets and whitespaces are allowed. It is required if beneficiary_id is not present. | [optional] 
**beneficiary_instrument_details** | [**CreateTransferRequestBeneficiaryDetailsBeneficiaryInstrumentDetails**](CreateTransferRequestBeneficiaryDetailsBeneficiaryInstrumentDetails.md) |  | [optional] 
**beneficiary_contact_details** | [**CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails**](CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

