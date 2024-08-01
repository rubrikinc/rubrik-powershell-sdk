### SharepointOperationalRecoverySpec
SharePoint operational recovery specification.

- shouldSkipItemPermission: System.Boolean
  - Specify whether to skip the item-level permission restore for SharePoint during the restore process.
- siteOwnerEmail: System.String
  - Specifies the site owner email. It will only be used when the original site owner does not exist any more.
- lastModifiedTimeFilter: LastModifiedTimeFilter
  - Last modified time range for SharePoint restore for operational recovery.
- targetSiteCollectionUrl: System.String
  - Specify the target site collection URL to restore the full site.
