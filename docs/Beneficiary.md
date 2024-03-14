# cashfree_payout.Model.Beneficiary
Contains the information of the created beneficiary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**beneficiary_id** | **string** | It displays the unique Id you created to identify the beneficiary. | [optional] 
**beneficiary_name** | **string** | It displays the name of the beneficiary. | [optional] 
**beneficiary_instrument_details** | [**BeneficiaryBeneficiaryInstrumentDetails**](BeneficiaryBeneficiaryInstrumentDetails.md) |  | [optional] 
**beneficiary_contact_details** | [**BeneficiaryBeneficiaryContactDetails**](BeneficiaryBeneficiaryContactDetails.md) |  | [optional] 
**beneficiary_status** | **string** | It displays the current status of the beneficiary. Possible values are as follows - &#x60;VERIFIED&#x60;: Beneficiary is verified and is available for payouts - &#x60;INVALID&#x60;: Beneficiary is invalid - &#x60;INITIATED&#x60;: Beneficiary verification initiated - &#x60;CANCELLED&#x60;: Beneficiary verification cancelled - &#x60;FAILED&#x60;: Failed to verify beneficiary - &#x60;DELETED&#x60;: Beneficiary is deleted | [optional] 
**added_on** | **string** | It displays the time of the addition of the beneficiary in UTC. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

