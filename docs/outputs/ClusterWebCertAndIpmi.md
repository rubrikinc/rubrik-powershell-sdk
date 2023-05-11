### ClusterWebCertAndIpmi
Web certificate and IPMI details for a cluster.

- certInfo: ClusterWebSignedCertificateReply
  - Web server certificate.
- clusterUuid: System.String
  - ID of the Rubrik cluster.
- error: System.String
  - Error message, in the case of an error.
- ipmiInfo: ModifyIpmiReply
  - IPMI details.
