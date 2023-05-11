### BulkRegisterHostInput
Input for registering multiple hosts.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- hosts: a list of HostRegisterInputs
  - Required. Array containing a registration definition for each host.
