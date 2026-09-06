### NodeTunnelFilter
Restricts the nodes returned by the tunnel status query to those whose
support tunnel is in a given state.

- NODE_TUNNEL_FILTER_UNSPECIFIED - No filter; every node of the Rubrik cluster is returned.
- NODE_TUNNEL_FILTER_OPEN - Only nodes whose support tunnel is open.
- NODE_TUNNEL_FILTER_CLOSED - Only nodes whose support tunnel is closed.
