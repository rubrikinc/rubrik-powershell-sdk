### WindowsRbsHostUserConfigInput
Supported in v6.0+

- httpsThumbprint: System.String
  - The thumbprint of the HTTPS certificate. This field is required to
        validate the HTTPS certificate thumbprint.
- password: System.String
  - Supported in v6.0+
        Password associated with the username that has access to the host.
- operationTimeout: System.Int64
  - Supported in v6.0+
        Number of seconds after which the operation is terminated if the
        execution is not completed. Default value is 600 seconds.
- name: System.String
  - Required. Supported in v6.0+
          IP address or hostname of the host.
- username: System.String
  - Required. Supported in v6.0+
          Name of the user account that has sudo/admin privileges on the RBS host.
          This is required to install/uninstall/upgrade RBS packages on the RBS
          host.
