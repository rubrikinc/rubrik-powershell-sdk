### CdmApiMetric
Information about Rubrik REST API calls to Rubrik CDM.

- requestUri: System.String
  - The request URI for the Rubrik REST API call.
- method: HttpMethod
  - The HTTP method used for making the Rubrik REST API call.
- referrer: System.String
  - The entity from which the Rubrik REST API calls originated.
- recentRequestTimestamp: DateTime
  - The latest request timestamp for the rest API.
- mandatory: System.String
  - Describes whether it's mandatory to migrate the script using this API.
- clusterUuid: System.String
  - UUID of the Rubrik cluster.
