### ClusterWebCertAndIpmi
Web certificate and IPMI details for a cluster.

- error: System.String
  - Error message, in the case of an error.
- clusterUuid: System.String
  - ID of the Rubrik cluster.
- ipmiInfo: ModifyIpmiReply
  - IPMI details.
- certInfo: ClusterWebSignedCertificateReply
  - Web server certificate.
