### ClusterConfigInput
ClusterConfig for new CDM cloud cluster.

- userEmail: System.String
  - Email of the admin account for the cluster.
- adminPassword: System.String
  - Password of the admin account for the cluster.
- clusterName: System.String
  - Name of the cluster.
- numNodes: System.Int32
  - Number of nodes in the cluster.
- dnsNameServers: list of System.Strings
  - Array of DNS server names.
- dnsSearchDomains: list of System.Strings
  - Array of DNS search domains for CDM clusters.
- ntpServers: list of System.Strings
  - Array of NTP servers.
- azureEsConfig: AzureEsConfigInput
  - Azure storage container details.
- awsEsConfig: AwsEsConfigInput
  - AWS S3 bucket details.
- ociEsConfig: OciEsConfigInput
  - OCI bucket details.
- gcpEsConfig: GcpEsConfigInput
  - GCP storage bucket details.
