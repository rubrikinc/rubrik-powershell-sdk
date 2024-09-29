# New-RscQueryFileset
## Subcommands
### linux
Information about a Linux fileset.

- There is a single argument of type System.String.
- Returns LinuxFileset.
### requeststatus
Get details about an async request

Supported in v5.0+
Get details about a fileset related async request.

- There is a single argument of type GetFilesetAsyncRequestStatusInput.
- Returns AsyncRequestStatus.
### share
Information about a NAS share fileset.

- There is a single argument of type System.String.
- Returns ShareFileset.
### template
- There is a single argument of type System.String.
- Returns FilesetTemplate.
### templates
Get a summary of all fileset templates.

- There are 6 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - sortBy - HierarchySortByField: Sort hierarchy objects according to the hierarchy field.
    - sortOrder - SortOrder: Sorts the order of results.
    - filter - list of Filters: The hierarchy object filter.
    - hostRoot - HostRoot: Host root type.
- Returns FilesetTemplateConnection.
### windows
Information about a Windows fileset.

- There is a single argument of type System.String.
- Returns WindowsFileset.
