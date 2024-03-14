# cashfree_payout.Model.CreateBatchTransferRequestTransfersInnerBeneficiaryDetailsBeneficiaryInstrumentDetails
It should contain the details of where the beneficiary will receive the money. You input these details if you haven't added the beneficiary in the Payouts dashboard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**bank_account_number** | **string** | It is the beneficiary bank account number. The value should be between 9 and 18 characters. Alphanumeric characters are allowed. This value is required if beneficiary_id is not present and if the transfer_mode is banktransfer, imps, neft, rtgs mode. | [optional] 
**bank_ifsc** | **string** | It is the IFSC information of the beneficiary&#39;s bank account in the standard IFSC format. The value should be 11 characters. (The first 4 characters should be alphabets, the 5th character should be a 0, and the remaining 6 characters should be numerals.) | [optional] 
**vpa** | **string** | It is the UPI VPA information of the beneficiary. Only valid UPI VPA information is accepted. It can be an Alphanumeric value with only period (.), hyphen (-), underscore ( _ ), and at the rate of (@). Hyphen (-) is accepted only before at the rate of (@). This value is required if the transfer_mode is upi. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

