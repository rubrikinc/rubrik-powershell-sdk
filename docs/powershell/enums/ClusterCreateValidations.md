### ClusterCreateValidations
List of all validations to perform.

- NO_CHECKS - Skip all checks.
- ALL_CHECKS - Perform all checks.
- CLUSTER_NAME_CHECK - Check if a cluster exists with the same name.
- DNS_SERVERS_CHECK - Validate DNS servers in the request.
- NTP_SERVERS_CHECK - Validate NTP servers in the request.
- NODE_COUNT_CHECK - Check if the node count is supported for the cluster type and version.
- OBJECT_STORE_CHECK - Check if the selected object store is supported by the cloud cluster.
- IMMUTABILITY_CHECK - Check if the immutability config is valid in the request.
- AWS_INSTANCE_PROFILE_CHECK - Check if the instance profile is valid.
- AWS_NETWORK_CONFIG_CHECK - Check if the AWS network config is valid, if passed.
- AZURE_VM_IMAGE_CHECK - Check if names of the VMs to be created on Azure are valid.
- AZURE_AVAILABILITY_ZONE_CHECK - Check if the availability zone exists in the specified Azure region.
- AZURE_QUOTA_CHECK - Check if sufficient quota is available to launch the cluster nodes.
- AZURE_MI_CHECK - Check if the managed identity is valid and supported.
- CLOUD_ACCOUNT_CHECK - Check if the selected cloud account supports cluster provisioning.
- GCP_NETWORK_CONFIG_CHECK - Check if the GCP network configuration is valid.
- GCP_SERVICE_ACCOUNT_CHECK - Check if the GCP service account is valid.
- GCP_INSTANCE_LABEL_KEY_CHECK - Check if the GCP instance label key is valid.
- GCP_CLUSTER_NAME_LENGTH_CHECK - Check if the cluster name is too long.
