### HypervAzureLocalTargetInput
Recovery target representing an Azure Local cluster (Arc virtual machine
export path).
See SPARK-914317.

hyperv_cluster_id, resource_group and nics are the only caller inputs. Every
Azure coordinate below is resolved from the onboarded Azure Local cluster
that hyperv_cluster_id names, within the caller's account, and is never
accepted from the caller: authorization is enforced on RSC object IDs, and a
caller able to name a cluster and separately name a subscription could
authorize against one cluster and export into another.

- resourceGroup: System.String
  - Resource group name in the destination subscription, chosen by the user
from the resource groups the destination cluster's subscription offers.
- hypervClusterId: System.String
  - RSC object ID of the Hyper-V cluster backing this Azure Local cluster.
Used to resolve the cluster to a CDM cluster ID via CRS, and the object
the target-side recovery authorization is enforced on.
- nics: list of HypervAzureLocalNicSpecInputs
  - Per-NIC target mapping. Positional: nics[i].source_nic_index is the
0-based index of the source virtual machine NIC that maps to
nics[i].logical_network_id.

Optional on input because a network_preservation_mode of REMOVE_ALL
recovers a virtual machine with no network devices, for which an empty
mapping is the correct request rather than a missing one.
