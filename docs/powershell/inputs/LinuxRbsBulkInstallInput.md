### LinuxRbsBulkInstallInput
Configuration for bulk installation of RBS on Linux hosts.

- clusterUuid: System.String
  - Required. UUID used to identify the Rubrik cluster the request
          goes to.
- request: LinuxBulkRbsInstallRequestInput
  - Required. Configuration parameters to install RBS on multiple
          linux hosts.
