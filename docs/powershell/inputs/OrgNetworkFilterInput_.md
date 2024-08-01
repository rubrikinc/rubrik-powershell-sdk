### OrgNetworkFilterInput
Filter for organization networks.

- name: System.String
  - Filter by organization network name.
- rubrikCluster: list of System.Strings
  - Filter by Rubrik cluster IDs.
- mappedOrganization: list of System.Strings
  - Filter by mapped organization names.
- envoyConnection: list of EnvoyConnectionFields
  - Filter by Envoy connection statuses.
