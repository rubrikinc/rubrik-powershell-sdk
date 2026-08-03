### AppAccessEdgeAnnotation
What the selected activity did to a particular edge.
One value per AppAccessEdge. NONE on every non-IMPACTED edge.

- EDGE_ANNOTATION_UNSPECIFIED - Zero-value sentinel; not used in valid responses.
- EDGE_ANNOTATION_NONE - No activity annotation; edge belongs to the persistent access graph.
- EDGE_ANNOTATION_ACCESS_GRANTED - The activity granted the user access to the application on this path.
- EDGE_ANNOTATION_ACCESS_REVOKED - The activity revoked the user's access to the application on this path.
- EDGE_ANNOTATION_PATH_ADDED - The activity introduced a new access path without changing effective access.
- EDGE_ANNOTATION_PATH_REMOVED - The activity removed an access path without revoking effective access.
- EDGE_ANNOTATION_MEMBERSHIP_ADDED - The activity added the user to the group on this edge.
- EDGE_ANNOTATION_MEMBERSHIP_REMOVED - The activity removed the user from the group on this edge.
- EDGE_ANNOTATION_TARGET_DELETED - The target of this activity was deleted.
