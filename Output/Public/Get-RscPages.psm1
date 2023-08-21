#Requires -Version 3
function Get-RscPages {
    <#
    .SYNOPSIS
    Fetch all pages of a paginated GraphQL query

    .DESCRIPTION
    This cmdlet is used to fetch all pages of a paginated GraphQL query. It takes a script block that invokes a cmdlet that returns a page of results, and it will continue to fetch pages until there are no more pages to fetch.

    The cmdlet called in the script block must have a list output
    (a "Connection" in GraphQL). The script block is given the pagination
    arguments via the PowerShell automatic variable $args.

    .EXAMPLE
    $nodes = Get-RscPages { Invoke-RscQueryCluster -List -Arg $args[0] }

    Retrieves all clusters in the Rubrik cluster.
    #>
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [scriptblock]$InvokePageCmdlet,
        [Parameter(Mandatory=$false)]
        [ValidateNotNull()]
        [ValidateNotNullOrEmpty()]
        [int] $PageSize = 100
    )
    begin {
        # Initialize an empty array to hold all results
        $allNodes = @()

        # Set initial args
        $cmdletArgs = @{ first = $PageSize }
    }

    process {
        do {
            
            # Log the args being used for fetching
            Write-Verbose ("Fetching page with args: " + $($cmdletArgs.GetEnumerator() | ForEach-Object { "$($_.Key)=$($_.Value)" }))

            # Call the script block that invokes the cmdlet
            $page = & $InvokePageCmdlet $cmdletArgs

            # Add page to all pages
            $allNodes += $page.Nodes
            Write-Verbose("Fetched page with $($page.Nodes.Count) items, total items fetched: $($allNodes.Count)")

            # If there is a next page, prepare the after arg for the next loop iteration
            if ($page.PageInfo.HasNextPage) {
                $cmdletArgs.after = $page.PageInfo.EndCursor
            }
        } while ($page.PageInfo.HasNextPage) # Continue fetching as long as there's a next page
    }

    end {
        # Return all fetched nodes
        return $allNodes
    }
}
