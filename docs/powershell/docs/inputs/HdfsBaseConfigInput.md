### HdfsBaseConfigInput
Supported in v5.2+

- apiToken: System.String
  - Supported in v5.2+
      API token to access Hdfs.
- kerberosTicket: System.String
  - Supported in v5.2+
      Ticket Cache Path of Kerberos Ticket.
- nameservices: System.String
  - Supported in v5.2+
      Logical name for nameservice for Hdfs HA.
- username: System.String
  - Supported in v5.2+
      Username to access Hdfs API.
- hosts: list of HdfsHostInputs
  - Required. Supported in v5.2+
      List of Hdfs Namenode Hosts.
