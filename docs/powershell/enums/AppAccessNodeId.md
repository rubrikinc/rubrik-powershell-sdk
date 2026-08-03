### AppAccessNodeId
Closed set of slot roles that can appear in AppAccessGraph.nodes.
Each value appears at most once per response.
Slots with no content are omitted entirely.

- APP_ACCESS_NODE_ID_UNSPECIFIED - Unspecified node slot; not used in replies.
- APP_ACCESS_NODE_ID_USER - The principal user at the center of the graph.
- APP_ACCESS_NODE_ID_DIRECT_APPLICATIONS - Applications the user accesses directly without group membership.
- APP_ACCESS_NODE_ID_INDIRECT_GROUPS - Groups through which the user has indirect application access.
- APP_ACCESS_NODE_ID_INDIRECT_APPLICATIONS - Applications the user reaches via group membership.
- APP_ACCESS_NODE_ID_IMPACTED_GROUPS - Groups changed by the selected activity.
- APP_ACCESS_NODE_ID_IMPACTED_APPS_ACCESS_CHANGED - Apps the user gained or lost access to due to the activity.
- APP_ACCESS_NODE_ID_IMPACTED_APPS_PATH_CHANGED - Apps whose access path changed but effective access is retained.
