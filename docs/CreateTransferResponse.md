# cashfree_payout.Model.CreateTransferResponse
Standard Transfer V2 Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transfer_id** | **string** | It displays the unique ID you created to identify the transfer. | [optional] 
**cf_transfer_id** | **string** | It displays the unique ID created by Cashfree Payments. You receive this ID in the response after initiating the standard transfer request. | [optional] 
**status** | **string** | It displays the status of the transfer. | [optional] 
**beneficiary_details** | [**CreateTransferResponseBeneficiaryDetails**](CreateTransferResponseBeneficiaryDetails.md) |  | [optional] 
**transfer_amount** | **double** | It displays the transfer amount initiated in the request. | [optional] 
**transfer_service_charge** | **double** | It displays the service charge applicable for the successful transfer request. | [optional] 
**transfer_service_tax** | **double** | It displays the service tax applicable for the successful transfer request. | [optional] 
**transfer_mode** | **string** | It displays the mode of the transfer. | [optional] 
**transfer_utr** | **string** | It displays the unique number that is generated to recognise any fund transfer that is created by the bank that facilitates the transfer. | [optional] 
**fundsource_id** | **string** | It displays the ID of the fund source from where the money was debited for this transfer request. | [optional] 
**added_on** | **string** | It displays the time of when the transfer request was added to the system. | [optional] 
**updated_on** | **string** | It displays the updated time for the transfer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

