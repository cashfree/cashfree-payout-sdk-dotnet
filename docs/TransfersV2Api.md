# cashfree_payout.Api.TransfersV2Api

All URIs are relative to *https://sandbox.cashfree.com/payout*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PayoutFetchBatchTransfer**](TransfersV2Api.md#payoutfetchbatchtransfer) | **GET** /transfers/batch | Get Batch Transfer Status V2 |
| [**PayoutFetchTransfer**](TransfersV2Api.md#payoutfetchtransfer) | **GET** /transfers | Get Transfer Status V2 |
| [**PayoutInitiateBatchTransfer**](TransfersV2Api.md#payoutinitiatebatchtransfer) | **POST** /transfers/batch | Batch Transfer V2 |
| [**PayoutInitiateTransfer**](TransfersV2Api.md#payoutinitiatetransfer) | **POST** /transfers | Standard Transfer V2 |

<a id="payoutfetchbatchtransfer"></a>
# **PayoutFetchBatchTransfer**
> FetchBatchTransferResponse PayoutFetchBatchTransfer (string xApiVersion, string? xRequestId = null, string? cfBatchTransferId = null, string? batchTransferId = null)

Get Batch Transfer Status V2

Use this API to get the status of the initiated batch transfer. You can use either the batch_transfer_id or cf_batch_transfer_id to fetch the details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutFetchBatchTransferExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2024-01-01;  // string | It is the API version to be used. The accepted format is YYYY-MM-DD. (default to "2024-01-01")
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. (optional) 
            var cfBatchTransferId = 10023;  // string? | It is the unique ID created by Cashfree Payments. You receive it in the response of the initiated batch transfer request. (Either cf_batch_transfer_id or batch_transfer_id is mandatory) (optional) 
            var batchTransferId = Sample_test;  // string? | It is the unique ID you created to identify the batch transfer request. (optional) 

            try
            {
                // Get Batch Transfer Status V2
                FetchBatchTransferResponse result = cashfree.PayoutFetchBatchTransfer(xApiVersion, xRequestId, cfBatchTransferId, batchTransferId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersV2Api.PayoutFetchBatchTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | It is the API version to be used. The accepted format is YYYY-MM-DD. | [default to &quot;2024-01-01&quot;] |
| **xRequestId** | **string?** | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. | [optional]  |
| **cfBatchTransferId** | **string?** | It is the unique ID created by Cashfree Payments. You receive it in the response of the initiated batch transfer request. (Either cf_batch_transfer_id or batch_transfer_id is mandatory) | [optional]  |
| **batchTransferId** | **string?** | It is the unique ID you created to identify the batch transfer request. | [optional]  |

### Return type

[**FetchBatchTransferResponse**](FetchBatchTransferResponse.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-request-id -  <br>  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="payoutfetchtransfer"></a>
# **PayoutFetchTransfer**
> CreateTransferResponse PayoutFetchTransfer (string xApiVersion, string? xRequestId = null, string? cfTransferId = null, string? transferId = null)

Get Transfer Status V2

Use this API to get the status of the initiated transfer. You can use either the transfer_id or cf_transfer_id to fetch the details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutFetchTransferExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2024-01-01;  // string | It is the API version to be used. The accepted format is YYYY-MM-DD. (default to "2024-01-01")
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. (optional) 
            var cfTransferId = 10023;  // string? | It is the unique ID created by Cashfree Payments. You receive it in the response of the initiated standard transfer request. (Either cf_transfer_id or transfer_id is mandatory) (optional) 
            var transferId = Sample_test;  // string? | It is the unique ID you created to identify the standard transfer request. (optional) 

            try
            {
                // Get Transfer Status V2
                CreateTransferResponse result = cashfree.PayoutFetchTransfer(xApiVersion, xRequestId, cfTransferId, transferId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersV2Api.PayoutFetchTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | It is the API version to be used. The accepted format is YYYY-MM-DD. | [default to &quot;2024-01-01&quot;] |
| **xRequestId** | **string?** | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. | [optional]  |
| **cfTransferId** | **string?** | It is the unique ID created by Cashfree Payments. You receive it in the response of the initiated standard transfer request. (Either cf_transfer_id or transfer_id is mandatory) | [optional]  |
| **transferId** | **string?** | It is the unique ID you created to identify the standard transfer request. | [optional]  |

### Return type

[**CreateTransferResponse**](CreateTransferResponse.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-request-id -  <br>  |
| **403** | Forbidden error |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="payoutinitiatebatchtransfer"></a>
# **PayoutInitiateBatchTransfer**
> CreateBatchTransferResponse PayoutInitiateBatchTransfer (string xApiVersion, string? xRequestId = null, CreateBatchTransferRequest? createBatchTransferRequest = null)

Batch Transfer V2

Use this API to initiate a batch transfer request at Cashfree Payments. You can transfer money to multiple beneficiaries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutInitiateBatchTransferExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2024-01-01;  // string | It is the API version to be used. The accepted format is YYYY-MM-DD. (default to "2024-01-01")
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. (optional) 
            var createBatchTransferRequest = new CreateBatchTransferRequest?(); // CreateBatchTransferRequest? | Find the request parameters of the API request to transfer money to multiple beneficiaries. (optional) 

            try
            {
                // Batch Transfer V2
                CreateBatchTransferResponse result = cashfree.PayoutInitiateBatchTransfer(xApiVersion, xRequestId, createBatchTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersV2Api.PayoutInitiateBatchTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | It is the API version to be used. The accepted format is YYYY-MM-DD. | [default to &quot;2024-01-01&quot;] |
| **xRequestId** | **string?** | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. | [optional]  |
| **createBatchTransferRequest** | [**CreateBatchTransferRequest?**](CreateBatchTransferRequest?.md) | Find the request parameters of the API request to transfer money to multiple beneficiaries. | [optional]  |

### Return type

[**CreateBatchTransferResponse**](CreateBatchTransferResponse.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-request-id -  <br>  |
| **400** | Invalid request |  -  |
| **409** | Batch transfer_id already exists |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="payoutinitiatetransfer"></a>
# **PayoutInitiateTransfer**
> CreateTransferResponse PayoutInitiateTransfer (string xApiVersion, string? xRequestId = null, CreateTransferRequest? createTransferRequest = null)

Standard Transfer V2

Use this API to initiate an amount transfer at Cashfree Payments. It is an async request by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutInitiateTransferExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2024-01-01;  // string | It is the API version to be used. The accepted format is YYYY-MM-DD. (default to "2024-01-01")
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. (optional) 
            var createTransferRequest = new CreateTransferRequest?(); // CreateTransferRequest? | Find the request parameters of the API request to transfer money to a beneficiary. (optional) 

            try
            {
                // Standard Transfer V2
                CreateTransferResponse result = cashfree.PayoutInitiateTransfer(xApiVersion, xRequestId, createTransferRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransfersV2Api.PayoutInitiateTransfer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | It is the API version to be used. The accepted format is YYYY-MM-DD. | [default to &quot;2024-01-01&quot;] |
| **xRequestId** | **string?** | It is the request ID for the API call. This ID can be used to resolve tech realted issues. Communicate this in your tech related queries to Cashfree Payments. | [optional]  |
| **createTransferRequest** | [**CreateTransferRequest?**](CreateTransferRequest?.md) | Find the request parameters of the API request to transfer money to a beneficiary. | [optional]  |

### Return type

[**CreateTransferResponse**](CreateTransferResponse.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-request-id -  <br>  |
| **400** | invalid request |  -  |
| **403** | Forbidden error |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

