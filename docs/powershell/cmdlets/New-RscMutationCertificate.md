# New-RscMutationCertificate
## Subcommands
### addclustercertificate
Import a certificate

Supported in v5.1+
Import a certificate.

- There is a single argument of type AddClusterCertificateInput.
- Returns AddClusterCertificateReply.
### addglobal
Add a global certificate.

- There is a single argument of type AddGlobalCertificateInput.
- Returns AddGlobalCertificateReply.
### delete
Delete Certificate.

- There is a single argument of type System.Int64.
- Returns System.Boolean.
### deleteglobal
Delete an existing global certificate.

- There is a single argument of type DeleteGlobalCertificateInput.
- Returns DeleteGlobalCertificateReply.
### markagentsecondary
Mark a secondary cluster certificate to be asynchronously synced to all Rubrik Backup Service instances for which this cluster is the primary.

- There is a single argument of type MarkAgentSecondaryCertificateInput.
- Returns MarkAgentSecondaryCertificateReply.
### setsso
Set User defined SSO certs.

- There is a single argument of type SetSsoCertificateInput.
- Returns System.String.
### setwebsigned
Set a signed certificate for Web server

Supported in v5.3+
Setting the given certificate for each node's web server to use.

- There is a single argument of type SetWebSignedCertificateInput.
- Returns AsyncRequestStatus.
### update
Edit Certificate.

- There are 4 arguments.
    - certificateId - System.Int64: Certificate ID.
    - name - System.String: Certificate name.
    - description - System.String: Certificate description.
    - certificate - System.String: Certificate.
- Returns System.Boolean.
### updateglobal
Edit an existing global certificate.

- There is a single argument of type UpdateGlobalCertificateInput.
- Returns UpdateGlobalCertificateReply.
### updatehost
- There is a single argument of type UpdateCertificateHostInput.
- Returns UpdateCertificateHostReply.
