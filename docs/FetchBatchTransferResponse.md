# cashfree_payout.Model.FetchBatchTransferResponse
Batch Transfer Status V2 Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**batch_transfer_id** | **string** | It displays the unique ID you created to identify the batch transfer. | [optional] 
**cf_batch_transfer_id** | **string** | It displays the unique ID created by Cashfree Payments. You receive this ID in the response after initiating the batch transfer request. | [optional] 
**status** | **string** | It displays the status of the batch transfer. | [optional] 
**transfers** | [**List&lt;CreateTransferResponse&gt;**](CreateTransferResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

