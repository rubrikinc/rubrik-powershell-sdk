### HdfsBaseConfigInput
Supported in v5.2-v9.1

- apiToken: System.String
  - Supported in v5.2-v9.1
      API token to access Hdfs.
- kerberosTicket: System.String
  - Supported in v5.2-v9.1
      Ticket Cache Path of Kerberos Ticket.
- nameservices: System.String
  - Supported in v5.2-v9.1
      Logical name for nameservice for Hdfs HA.
- username: System.String
  - Supported in v5.2-v9.1
      Username to access Hdfs API.
- hosts: list of HdfsHostInputs
  - Required. Supported in v5.2-v9.1
      List of Hdfs Namenode Hosts.
