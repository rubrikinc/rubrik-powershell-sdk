# New-RscQueryCertificate
## Subcommands
### assignableglobal
Global certificates that can be assigned to an organization.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - GlobalCertificateSortBy: Field on which to sort the certificates.
    - input - GlobalCertificatesQueryInput: Input to list global certificates.
- Returns GlobalCertificateConnection.
### certificate
Browse certificates.

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - CertMgmtSortBy: Certificate manager argument to sort by.
    - searchTerm - System.String: Search for a certificate.
- Returns CertificateConnection.
### cluster
Get all certificates

Supported in v5.1+
Get all certificates.

- There is a single argument of type QueryCertificatesInput.
- Returns CertificateSummaryListResponse.
### clusterwebsigned
Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.

- There is a single argument of type ClusterWebSignedCertificateInput.
- Returns ClusterWebSignedCertificateReply.
### global
Global certificate.

- There is a single argument of type System.String.
- Returns GlobalCertificate.
### info
Metadata of a certificate.

- There is a single argument of type GetCertificateInfoInput.
- Returns GetCertificateInfoReply.
### signingrequest
Get Certificate Signing Request (CSR).

- There is a single argument of type GetCsrInput.
- Returns Csr.
### signingrequests
Browse Certificate Signing Requests (CSRs).

- There are 7 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - last - System.Int32: Returns the last n elements from the list.
    - before - System.String: Returns the elements in the list that come before the specified cursor.
    - sortOrder - SortOrder: Sorting order for the results.
    - sortBy - CertMgmtSortBy: Certificate manager argument to sort by.
    - searchTerm - System.String: Search for a CSR.
- Returns CsrConnection.
### withkey
Certificates having private key.

- The withkey subcommand takes no arguments.
- Returns CertificateConnection.
