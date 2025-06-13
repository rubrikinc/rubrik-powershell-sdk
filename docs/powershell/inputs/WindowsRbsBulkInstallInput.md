### WindowsRbsBulkInstallInput
Configuration for bulk installation of RBS on Windows hosts.

- clusterUuid: System.String
  - Required. UUID used to identify the Rubrik cluster the request
          goes to.
- request: WindowsBulkRbsInstallRequestInput
  - Required. Configuration parameters to install RBS on multiple
          windows hosts.
