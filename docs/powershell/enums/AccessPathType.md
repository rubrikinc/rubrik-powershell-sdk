### AccessPathType
AccessPathType specifies which access paths to include in results.

- ACCESS_PATH_TYPE_UNSPECIFIED - Unspecified access path type (no filter, all paths included).
- ACCESS_PATH_TYPE_DIRECT - ACCESS_PATH_TYPE_DIRECT filters to only direct access paths
(user ->app_role ->app).
- ACCESS_PATH_TYPE_INDIRECT - ACCESS_PATH_TYPE_INDIRECT filters to only indirect access paths via groups
(user ->group ->app_role ->app).
- ACCESS_PATH_TYPE_IMPACTED - Reply-only label applied to edges in the impacted lane of the response.
Distinguishes impacted edges from persistent direct or indirect edges in the
same reply.
