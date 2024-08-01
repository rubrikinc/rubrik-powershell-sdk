# New-RscMutationSmb
## Subcommands
### addandjoindomain
Add a new domain

Supported in v5.0+
Add a new domain manually and join Active Directory.

- There is a single argument of type AddAndJoinSmbDomainInput.
- Returns AddAndJoinSmbDomainReply.
### deletedomain
Delete Active Directory from Rubrik

Supported in v5.0+
Delete Active Directory from Rubrik.

- There is a single argument of type DeleteSmbDomainInput.
- Returns System.String.
### joindomain
Join Active Directory

Supported in v5.0+
Join Active Directory.

- There is a single argument of type JoinSmbDomainInput.
- Returns System.String.
### putconfiguration
SMB configuration

Supported in v5.0+
SMB configuration.

- There is a single argument of type PutSmbConfigurationInput.
- Returns PutSmbConfigurationReply.
