### CreateMultiClusterPcInput
Input for creating the Multi Cluster Nutanix Prism Central object.

- prismCentralConfig: NutanixPrismCentralConfigInput
  - Configuration parameters for creating the Multi Cluster Nutanix Prism Central object.
- prismElementCdmTuple: list of PrismElementCdmTuples
  - A one-to-one mapping between each Prism Element and the corresponding Rubrik cluster to use while adding the Multi Cluster Nutanix Prism Central object.
- isDrEnabled: System.Boolean
  - Specifies whether Nutanix DR support is enabled for the Prism Central object.
