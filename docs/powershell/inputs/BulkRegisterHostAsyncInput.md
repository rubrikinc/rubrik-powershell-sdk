### BulkRegisterHostAsyncInput
Input for registering multiple hosts in the background.

- hosts: list of HostRegisterInputs
  - Required. Registration definition for each host.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
