# Samples

Sample scripts and query files for the Rubrik Security Cloud PowerShell SDK.

## Prerequisites

```powershell
Install-Module RubrikSecurityCloud
Set-RscServiceAccountFile /path/to/service_account.json   # one-time setup
```

## PowerShell Scripts (.ps1)

Interactive, step-by-step scripts. Each connects to RSC, walks through
a topic, shows the code used at every step, and waits for a keypress
between steps.

| Script                   | Topic                                                              |
|--------------------------|--------------------------------------------------------------------|
| `connection.ps1`         | Minimal "hello world" — connect, query, disconnect                 |
| `clusters.ps1`           | List clusters, limit with `-First`, low-level `clusterConnection`  |
| `pagination.ps1`         | Auto-pagination, limiting results, manual cursor-based pagination  |
| `field_customization.ps1`| Field profiles (DEFAULT/DETAIL/EMPTY), `-AddField`, `-RemoveField` |
| `snapshots.ps1`          | List snapshots via Toolkit and low-level query; on-demand snapshot  |
| `sla_lifecycle.ps1`      | Full SLA CRUD: create, list, get, modify, delete, pause/resume     |
| `sla_browser.ps1`        | Interactive TUI for browsing SLAs with sort, filter, pagination    |

Run any script with:

```powershell
./Samples/connection.ps1
```

`SampleUtils.ps1` is a shared helper (display formatting, TUI drawing).
It is not meant to be run directly.

## GraphQL Query Files (.gql)

Raw GraphQL queries with an optional `/* Variables: {...} */` header.
`Invoke-Rsc` parses this header automatically, so the variables are
sent along with the query without extra code.

| File                     | What it does                                              |
|--------------------------|-----------------------------------------------------------|
| `queryAccountOwners.gql` | List all account owners (email, username, status)         |
| `queryClusterList.gql`   | Retrieve clusters (default: `first=1`, override with `-Var`) |

### How to use .gql files

```powershell
# Pipe the file content to Invoke-Rsc — variables from the header are used:
Get-Content -Path Samples/queryAccountOwners.gql -Raw | Invoke-Rsc

# Same thing, as a parameter:
$gql = Get-Content -Path Samples/queryClusterList.gql -Raw
Invoke-Rsc -Gql $gql

# Override the embedded variables from the command line:
$gql = Get-Content -Path Samples/queryClusterList.gql -Raw
Invoke-Rsc -Gql $gql -Var @{ first = 5 }
```

## JSON Query Files (.query.json)

A JSON envelope containing a `"query"` key with the GraphQL string.
This is the same format used by most GraphQL clients and tools
(e.g. Postman, Insomnia, curl).

| File                          | What it does                          |
|-------------------------------|---------------------------------------|
| `GetVsphereVmList.query.json` | List all vSphere VMs (id and name)   |

### How to use .query.json files

```powershell
# Read the JSON and pass the whole string to Invoke-Rsc:
Invoke-Rsc -Gql (Get-Content -Path Samples/GetVsphereVmList.query.json -Raw)

# Or extract the query and add variables separately:
$json  = Get-Content -Path Samples/GetVsphereVmList.query.json -Raw | ConvertFrom-Json
$result = Invoke-Rsc -Gql $json.query
$result.Nodes | Format-Table Id, Name
```
