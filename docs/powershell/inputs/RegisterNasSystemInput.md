### RegisterNasSystemInput
Input for registering a new NAS System.

- nasSystem: NasSystemRegisterInput
  - Required. Registration definition for a NAS system. This contains parameters needed to protect the NAS system such as a hostname or the cluster management IP address, and login credentials to access the system.
- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
