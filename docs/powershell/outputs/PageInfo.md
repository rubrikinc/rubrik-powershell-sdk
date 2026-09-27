### PageInfo
General information about a page of results.

- startCursor: System.String
  - An opaque cursor that identifies the first edge in the current page. Pass this value verbatim as the before argument in subsequent queries to paginate to the previous page.
- endCursor: System.String
  - An opaque cursor that identifies the last edge in the current page. Pass this value verbatim as the after argument in subsequent queries to paginate to the next page.
- hasPreviousPage: System.Boolean
  - Specifies whether edges exist prior to the current page.
- hasNextPage: System.Boolean
  - Specifies whether edges exist following the current page.
