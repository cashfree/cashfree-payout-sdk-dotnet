# cashfree_payout.Model.CreateBeneficiaryRequestBeneficiaryContactDetails
It should contain the contact details of the beneficiary.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**beneficiary_email** | **string** | It is the email address of the beneficiary. The maximum character limit is 200. It should contain dot (.) and at the rate of (@). | [optional] 
**beneficiary_phone** | **string** | It is the phone number of the beneficiary. Only reigstered Indian phone numbers are allowed. The value should be between 8 and 12 characters after stripping +91. | [optional] 
**beneficiary_country_code** | **string** | It is the country code (+91) of the beneficiary&#39;s phone number | [optional] 
**beneficiary_address** | **string** | It is the address information of the beneficiary. | [optional] 
**beneficiary_city** | **string** | It is the name of the city as present in the beneficiary&#39;s address. | [optional] 
**beneficiary_state** | **string** | It is the name of the state as present in the beneficiary&#39;s address. | [optional] 
**beneficiary_postal_code** | **string** | It is the PIN code information as present in the beneficiary&#39;s address. The maximum character limit is 6. Only numbers are allowed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

