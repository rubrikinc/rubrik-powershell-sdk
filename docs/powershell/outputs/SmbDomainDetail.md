### SmbDomainDetail
Supported in v5.0+

- isStickySmbService: System.Boolean
  - Required. Supported in v5.0+
A Boolean value that determines whether to run the SMB service when no shares are exposed. When this value is 'true,' the SMB service runs even when no shares are exposed. When this value is 'false,' the SMB service does not run when no shares are exposed.
- name: System.String
  - Required. Supported in v5.0+
Specifies name to identify Active Directory domain for SMB authentication.
- serviceAccount: System.String
  - Supported in v5.0+
Specifies the service principal name (SPN) used for joining the Active Directory domain.
- status: SmbDomainStatus
  - Required. Supported in v5.0+
State of the domain.
- allowTrustedDomain: System.Boolean
  - Supported in v9.5+
A Boolean value that determines whether to allow trusted domains in SMB configuration. When this value is 'true,' trusted domains are allowed. When this value is 'false,' trusted domains are not allowed. The default value is 'false.'
