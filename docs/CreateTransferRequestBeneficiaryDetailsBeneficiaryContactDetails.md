# cashfree_payout.Model.CreateTransferRequestBeneficiaryDetailsBeneficiaryContactDetails
It should contain the contact details of the beneficiary.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**beneficiary_email** | **string** | It is the email address of the beneficiary. The maximum character limit is 200. It should contain dot (.) and at the rate of (@). | [optional] 
**beneficiary_phone** | **string** | It is the phone number of the beneficiary. Only registered Indian phone numbers are allowed. The value should be between 8 and 12 characters after stripping +91. | [optional] 
**beneficiary_country_code** | **string** | It is the country code (+91) of the beneficiary&#39;s phone number. | [optional] 
**beneficiary_address** | **string** | It should contain the address of the beneficiary. The maximum character limit is 150. Alphanumeric characters and whitespaces are allowed. | [optional] 
**beneficiary_city** | **string** | It is the name of the city as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed. | [optional] 
**beneficiary_state** | **string** | It is the name of the state as present in the beneficiary address. The maximum character limit is 50. Alphanumeric characters and whitespaces are allowed. | [optional] 
**beneficiary_postal_code** | **string** | It is the PIN code as present in the address. It should be a 6 character numeric value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

