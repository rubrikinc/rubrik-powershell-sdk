### AksOutboundType
Outbound (egress) type of an AKS cluster.

- AKS_OUTBOUND_TYPE_UNSPECIFIED - The outbound type is not specified. It is derived from the deprecated
enableUserDefinedRouting flag, and is the load balancer if that is unset
too.
- AKS_OUTBOUND_TYPE_LOAD_BALANCER - Egress through the AKS-managed Standard load balancer.
- AKS_OUTBOUND_TYPE_USER_DEFINED_ROUTING - Egress through a customer route table (firewall or virtual appliance).
- AKS_OUTBOUND_TYPE_USER_ASSIGNED_NAT_GATEWAY - Egress through a customer-owned NAT gateway attached to the AKS subnet.
