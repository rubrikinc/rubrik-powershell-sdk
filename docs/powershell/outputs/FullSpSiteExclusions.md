### FullSpSiteExclusions
SharePoint objects excluded under a site collection. Used as GraphQL input
`O365FullSpSiteExclusions` and output `FullSpSiteExclusions`.

- siteFid: System.String
  - The fid of the SharePoint site collection.
- excludedObjects: list of FullSpObjectExclusions
  - The objects to be excluded under the site collection.
