### ClusterConfigInput
ClusterConfig for new CDM cloud cluster.

- userEmail: System.String
  - Cloud account ID.
- adminPassword: System.String
  - Cloud account ID.
- clusterName: System.String
  - Cloud account ID.
- numNodes: System.Int32
  - Cloud account ID.
- dnsSearchDomains: list of System.Strings
  - Array of DNS search domains for CDM clusters.
- dnsNameServers: list of System.Strings
  - Array of DNS server names.
- ntpServers: list of System.Strings
  - Array of NTP servers.
- azureEsConfig: AzureEsConfigInput
  - Azure storage container details.
- awsEsConfig: AwsEsConfigInput
  - AWS S3 bucket details.
