### HostRegisterInput
Supported in v5.0+

- hasAgent: System.Boolean
  - Supported in v5.0+
- nasConfig: NasConfigInput
  - Supported in v5.0+
- oracleQueryUser: System.String
  - Supported in v5.0+
      Specifies the Oracle username for an account with query privileges. The account must have query privileges for a specified Oracle installation to enable Oracle discovery queries for that installation.
- oracleSysDbaUser: System.String
  - Supported in v5.0+
      v5.0: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable backup and recovery of Oracle databases for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
      v5.1+: Specifies the Oracle username for an account with sysdba privileges. The account must have sysdba privileges for a specified Oracle installation to enable Oracle discovery queries for that installation. This field overrides the configured global sysdba user for the specified Oracle installation.
- organizationId: System.String
  - Supported in v5.0+
      v5.0-v8.0: The ID of the organization to which the host is assigned.
      v8.1: The ID of the CDM organization to which the host is assigned. For RSC driven host registration, this field should be set to None, and host will be added to CDM global org. For CDM driven host registration, this field should be set to the Org the host belongs to.
      v9.0: The ID of the organization to which the host is assigned.
      v9.1: The ID of the CDM organization to which the host is assigned. For RSC driven host registration, this field should be set to None, and host will be added to CDM global org. For CDM driven host registration, this field should be set to the Org the host belongs to.
- alias: System.String
  - Supported in v5.1+
      A user-specified string that returns this host in searches.
- hdfsConfig: HdfsConfigInput
  - Supported in v5.2+
- isOracleHost: System.Boolean
  - Supported in v5.2+
      A Boolean that specifies whether to discover Oracle information at registration. A value of 'true' discovers Oracle information at registration.
- orgNetworkId: System.String
  - Supported in v8.1, v9.1
      v8.1: The ID of the RSC orgNetwork to which the host is assigned. This field should only be set when the host registration is called by RSC and the host belongs to a RSC orgNetwork. This field should always be set to None in other cases. 1) The call is from CDM; or 2) the call is from RSC but the host does not belong to an orgNetwork.
      v9.1: The ID of the RSC orgNetwork to which the host is assigned. This field should only be set when the host registration is called by RSC and the host belongs to a RSC orgNetwork. This field should always be set to None in other cases. 1) The call is from CDM; or 2) the call is from RSC but the host does not belong to an orgNetwork.
- hostname: System.String
  - Required. Supported in v5.0+
