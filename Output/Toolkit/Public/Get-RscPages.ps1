#Requires -Version 3
function Get-RscPages {
    <#
    .SYNOPSIS
    Fetch all pages of a paginated GraphQL query and return one list.

    .DESCRIPTION
    This cmdlet is used to fetch all pages of a paginated query
    (a "Connection" in GraphQL).
    It invokes the query that returns a page of results, and continues
    to invoke it until there are no more pages to fetch.

    It commandeers the variables in the passed-in query object to
    keep track of the page to fetch next.

    A side effect is that any passed in Var.First or Var.After
    will be overwritten. So for example: if you pass in a query
    with Var.First = 10, and there are 100 items,
    Get-RscPages will fetch all 100 items, not just the first 10.

    To compensate for this, Get-RscPages itself takes a -First
    parameter, which can be used to limit the number of items
    returned.

    .EXAMPLE
    $query = New-RscQueryCluster -Op List
    $nodes = Get-RscPages $query

    Retrieves all clusters attached to the Rubrik Security Cloud deployment.

    .EXAMPLE
    $query = New-RscQueryCluster -Op List
    $nodes = Get-RscPages $query -First 10

    Retrieves the first 10 clusters attached to the Rubrik Security Cloud deployment.
    #>
    [CmdletBinding()]
    param (
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true,
            HelpMessage = "Query to fetch pages of"
        )]
        [RubrikSecurityCloud.RscQuery]$Query,

        [Parameter(
            Mandatory = $false,
            HelpMessage = "Page size to use when fetching pages"
        )]
        [ValidateNotNull()]
        [ValidateNotNullOrEmpty()]
        [Int] $PageSize = [RubrikSecurityCloud.Config]::ConnectionMaxPageSize,

        [Parameter(
            Mandatory = $false,
            HelpMessage = "Only return N items. Default is 0, which means return all items.")]
        [Int]$First = 0
    )
    begin {
        # Initialize an empty array to hold all results
        $nodes = @()

        # Prep query for fetching first page
        # NOTA BENE: we're modifying the query object that was passed in
        $Query.Var.First = $null
        if ($PageSize -gt 0) {
            $Query.Var.First = $PageSize
            if ($First -gt 0 -and $First -lt $PageSize) {
                $Query.Var.First = $First
            }
        } elseif ($First -gt 0) {
            $Query.Var.First = $First
        }
        $Query.Var.After = $null
    }

    process {
        do {
            
            # Log the args being used for fetching
            Write-Verbose ("Fetching page with vars: $($Query.Var)")

            # Call the script block that invokes the cmdlet
            $page = Invoke-Rsc $Query -ErrorAction Stop -Verbose

            # If no page was returned (that is: $page doesn't have a
            # Nodes property), just return as-is.
            # (This is lenient behavior to allow for Get-RscPages
            # to be used with cmdlets that don't return a Connection.)
            if (-not $page.Nodes) {
                return $page
            }
        
            # Add the nodes from the page to the array
            $nodes += $page.Nodes
            Write-Verbose("Fetched page with $($page.Nodes.Count) items, total items fetched: $($nodes.Count), hasNextPage: $($page.PageInfo.HasNextPage)")

            # If there is a next page,
            # prepare the after arg for the next loop iteration
            if ($page.PageInfo.HasNextPage) {
                $Query.Var.After = $page.PageInfo.EndCursor
            }

            # If the user specified a First argument,
            # and we've fetched that many items,
            # stop fetching
            if ($First -gt 0 -and $nodes.Count -ge $First) {
                # Truncate $nodes to $First items
                $nodes = $nodes[0..($First - 1)]
                break
            }
        } while ($page.PageInfo.HasNextPage) # Continue fetching as long as there's a next page
    }

    end {
        # Return all fetched nodes
        return $nodes
    }
}
