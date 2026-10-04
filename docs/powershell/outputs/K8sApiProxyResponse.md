### K8sApiProxyResponse
Supported in v9.6+
Response from the K8s API proxy endpoint. Wraps the HTTP status code and JSON body returned by the target cluster's K8s API server. CDM errors (invalid path, disabled feature flag) are returned as HTTP 422; K8s API responses are always returned as HTTP 200 with the K8s status code in this envelope.

- body: System.String
  - Supported in v9.6+
JSON response body from the K8s API server.
- statusCode: System.Int32
  - Required. Supported in v9.6+
HTTP status code from the K8s API server (e.g. 200 for success, 404 for not found).
