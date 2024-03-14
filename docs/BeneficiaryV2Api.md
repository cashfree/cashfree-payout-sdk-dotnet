# cashfree_payout.Api.BeneficiaryV2Api

All URIs are relative to *https://sandbox.cashfree.com/payout*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PayoutCreateBeneficiary**](BeneficiaryV2Api.md#payoutcreatebeneficiary) | **POST** /beneficiary | Create Beneficiary V2 |
| [**PayoutDeleteBeneficiary**](BeneficiaryV2Api.md#payoutdeletebeneficiary) | **DELETE** /beneficiary | Remove Beneficiary V2 |
| [**PayoutFetchBeneficiary**](BeneficiaryV2Api.md#payoutfetchbeneficiary) | **GET** /beneficiary | Get Beneficiary V2 |

<a id="payoutcreatebeneficiary"></a>
# **PayoutCreateBeneficiary**
> Beneficiary PayoutCreateBeneficiary (string xApiVersion, string? xRequestId = null, CreateBeneficiaryRequest? createBeneficiaryRequest = null)

Create Beneficiary V2

Use this API to add a beneficiary to your Cashfree Payments account by providing the bank account number, IFSC, and other required details. Ensure the successful creation of the benficiary in your account before initiating a transfer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutCreateBeneficiaryExample
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
            var createBeneficiaryRequest = new CreateBeneficiaryRequest?(); // CreateBeneficiaryRequest? | Find the request parameters to create a beneficiary (optional) 

            try
            {
                // Create Beneficiary V2
                Beneficiary result = cashfree.PayoutCreateBeneficiary(xApiVersion, xRequestId, createBeneficiaryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BeneficiaryV2Api.PayoutCreateBeneficiary: " + e.Message);
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
| **createBeneficiaryRequest** | [**CreateBeneficiaryRequest?**](CreateBeneficiaryRequest?.md) | Find the request parameters to create a beneficiary | [optional]  |

### Return type

[**Beneficiary**](Beneficiary.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |
| **400** | Bad request error |  -  |
| **403** | Forbidden error |  -  |
| **409** | Duplicate error |  -  |
| **422** | Unprocessable error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="payoutdeletebeneficiary"></a>
# **PayoutDeleteBeneficiary**
> Beneficiary PayoutDeleteBeneficiary (string xApiVersion, string? xRequestId = null, string? beneficiaryId = null)

Remove Beneficiary V2

Use this API to remove an existing beneficiary from the list of added beneficiaries.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutDeleteBeneficiaryExample
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
            var beneficiaryId = sample_test;  // string? | It is the unique ID you create to identify the beneficiary. The maximum character limit is 50. Only alphabets and whitespaces are allowed. (optional) 

            try
            {
                // Remove Beneficiary V2
                Beneficiary result = cashfree.PayoutDeleteBeneficiary(xApiVersion, xRequestId, beneficiaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BeneficiaryV2Api.PayoutDeleteBeneficiary: " + e.Message);
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
| **beneficiaryId** | **string?** | It is the unique ID you create to identify the beneficiary. The maximum character limit is 50. Only alphabets and whitespaces are allowed. | [optional]  |

### Return type

[**Beneficiary**](Beneficiary.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-request-id -  <br>  |
| **400** | Bad request error |  -  |
| **403** | Forbidden error |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="payoutfetchbeneficiary"></a>
# **PayoutFetchBeneficiary**
> Beneficiary PayoutFetchBeneficiary (string xApiVersion, string? xRequestId = null, string? beneficiaryId = null, string? bankAccountNumber = null, string? bankIfsc = null)

Get Beneficiary V2

Use this API to get the details of a particular beneficiary from your account. You can pass either beneficiary_id or the combination of bank_account_number and bank_ifsc to fetch the details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_payout.Client;
using cashfree_payout.Model;

namespace Example
{
    public class PayoutFetchBeneficiaryExample
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
            var beneficiaryId = JOHN18011343;  // string? | It is the unique ID you created to identify the beneficiary while creating the beneficiary. (optional) 
            var bankAccountNumber = 00001111222233;  // string? | It is the bank account number of the beneficiary. If bank_account_number is passed in query, bank_ifsc should also be passed. (optional) 
            var bankIfsc = HDFC0000001;  // string? | It is the IFSC information as present in the beneficiary's bank account information. If bank_ifsc is passed in query, bank_account_number should also be passed. (optional) 

            try
            {
                // Get Beneficiary V2
                Beneficiary result = cashfree.PayoutFetchBeneficiary(xApiVersion, xRequestId, beneficiaryId, bankAccountNumber, bankIfsc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BeneficiaryV2Api.PayoutFetchBeneficiary: " + e.Message);
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
| **beneficiaryId** | **string?** | It is the unique ID you created to identify the beneficiary while creating the beneficiary. | [optional]  |
| **bankAccountNumber** | **string?** | It is the bank account number of the beneficiary. If bank_account_number is passed in query, bank_ifsc should also be passed. | [optional]  |
| **bankIfsc** | **string?** | It is the IFSC information as present in the beneficiary&#39;s bank account information. If bank_ifsc is passed in query, bank_account_number should also be passed. | [optional]  |

### Return type

[**Beneficiary**](Beneficiary.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-request-id -  <br>  |
| **400** | Bad request |  * x-request-id -  <br>  |
| **403** | Forbidden error |  -  |
| **404** | Resource not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

