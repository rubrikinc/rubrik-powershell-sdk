### DeleteClusterRouteInput
Input for deleting a static route on a CDM cluster.

- clusterUuid: System.String
  - Required. UUID used to identify to which Rubrik cluster the request goes.
- routeConfig: RouteDeletionConfigInput
  - Required. Network and netmask.
