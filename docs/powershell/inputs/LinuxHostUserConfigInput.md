### LinuxHostUserConfigInput
Supported in v6.0+

- password: System.String
  - Supported in v6.0+
        Password associated with the username that has access to the host.
- hostSshPublicKey: System.String
  - Supported in v7.0+
        The SSH public key of the RBS host. The Rubrik cluster uses this SSH
        key to verify the authenticity of the RBS host. Using the SSH key
        establishes a secure connection between the Rubrik cluster and the RBS
        host. When the SSH key is not configured, the Rubrik cluster
        establishes the first connection with the RBS host by authentication
        using the login credentials. At the time of this connection, Rubrik CDM
        reads the SSH key from the RBS host and stores it on the cluster. For
        subsequent connections with the RBS host, the Rubrik cluster uses this
        key to verify the identity of the RBS host. This field is not
        applicable to Windows hosts.
- operationTimeout: System.Int64
  - Supported in v6.0+
        Number of seconds after which the operation is terminated if the
        execution is not completed. Default value is 600 seconds.
- name: System.String
  - Required. Supported in v6.0+
          IP address or hostname of the host.
- username: System.String
  - Required. Supported in v6.0+
          Name of the user account that has sudo or admin privileges on the RBS host.
          This is required to install, uninstall or upgrade RBS packages on the RBS
          host.
