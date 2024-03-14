# cashfree_payout.Model.CreateBeneficiaryRequestBeneficiaryInstrumentDetails
Beneficiary instrument details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bank_account_number** | **string** | It is the beneficiary bank account number. The value should be between 9 and 18 characters. Alphanumeric characters are allowed. You need to input bank_ifsc if bank_account_number is passed. | [optional] 
**bank_ifsc** | **string** | It is the IFSC information of the beneficiary&#39;s bank account in the standard IFSC format. The value should be 11 characters. (The first 4 characters should be alphabets, the 5th character should be a 0, and the remaining 6 characters should be numerals.). You need to input bank_account_number if bank_ifsc is passed. | [optional] 
**vpa** | **string** | It is the UPI VPA information of the beneficiary. Only valid UPI VPA information is accepted. It can be an Alphanumeric value with only period (.), hyphen (-), underscore ( _ ), and at the rate of (@). Hyphen (-) is accepted only before at the rate of (@). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

