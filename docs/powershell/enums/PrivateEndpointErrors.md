### PrivateEndpointErrors
Error codes for RCV private endpoint workflows.

- ERR_UNSPECIFIED - Unspecified error.
- INTERNAL - Internal service error while processing/validating the RCV private endpoint request.
- AZURE_ERR - Failure while interacting with Azure for private endpoint or storage account operations.
- NO_PENDING_PE - No pending private endpoint approval request was found for the given location and endpoint.
- INVALID_REQ_MSG - The approval request message for the RCV private endpoint is expired or invalid.
- NO_ERR - Operation succeeded with no error.
