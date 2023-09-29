# New-RscMutationCertificate
## Subcommands
### addclustercertificate
Import a certificate

Supported in v5.1+
Import a certificate.

- There is a single argument of type AddClusterCertificateInput.
- Returns AddClusterCertificateReply.
### delete
Delete Certificate.

- There is a single argument of type System.Int64.
- Returns System.Boolean.
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
### updatehost
- There is a single argument of type UpdateCertificateHostInput.
- Returns UpdateCertificateHostReply.
