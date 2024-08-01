### UpdateMultiClusterPcInput
Input for updating the Multi Cluster Nutanix Prism Central object.

- fid: System.String
  - The ID of the Multi Cluster Nutanix Prism Central object to update.
- caCerts: System.String
  - Optional caCerts field that can be used to update the Multi Cluster Prism Central object.
- hostname: System.String
  - Optional hostname field that can be used to update the Multi Cluster Prism Central object.
- password: System.String
  - Optional password field that can be used to update the Multi Cluster Prism Central object.
- username: System.String
  - Optional username field that can be used to update the Multi Cluster Prism Central object.
- isDrEnabled: System.Boolean
  - Specifies whether Nutanix DR support is enabled for the Prism Central object.
- prismElementCdmTuple: list of PrismElementCdmTuples
  - A one-to-one mapping between the new Prism Elements and the corresponding Rubrik cluster to use while updating the Multi Cluster Nutanix Prism Central object.
