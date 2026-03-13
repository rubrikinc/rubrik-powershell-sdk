#Requires -Version 3
function Get-RscEventSeries {
    <#
    .SYNOPSIS
    Retrieves event series (activity logs) from Rubrik Security Cloud.

    .DESCRIPTION
    Returns event series that track backup, replication, archival, and other
    activities in RSC. By default returns the first 50 events. Use -First to
    control page size, -Id to retrieve a specific event, and -Detail for
    additional fields.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER Id
    The RSC event series ID.

    .PARAMETER First
    Return only the first N results.

    .PARAMETER Detail
    Return additional fields beyond the default set.

  .PARAMETER AsQuery
  Return the query object instead of running the query.
  Preliminary read-only queries may still run to gather IDs or
  other data needed to build the main query.

    .EXAMPLE
    # Get the 3 most recent events
    Get-RscEventSeries -First 3

    .EXAMPLE
    # Get a specific event series with full details
    Get-RscEventSeries -Id "a17b691d-3935-4e1f-8abf-82f3229e836f" -Detail

  .EXAMPLE
  Get-RscEventSeries -First 3
  Id IsCancelable IsPolarisEventSeries LastActivityStatus
  -- ------------ -------------------- ------------------
  24738        False                 True            SUCCESS
  24736        False                 True            SUCCESS
  24731        False                 True            SUCCESS

  This example lists the first 3 events.

  .EXAMPLE
  (Get-RscEventSeries -First 3).ActivitySeriesId
  a17b691d-3935-4e1f-8abf-82f3229e836f
  36081adp-148e-4c19-9896-3f9b2f3b3026
  5ce92d82-9ce7-4fdf-9d4f-97ed7eb93a71
  
  This example lists the first 3 events, and only gets their ids.

  .EXAMPLE
  $firstId = (Get-RscEventSeries -First 1).ActivitySeriesId

  Saves the first id.

  .EXAMPLE
  Get-RscEventSeries -Id $firstId -Detail

  Retrieves an event series by ID.

  .EXAMPLE
  ActivitySeriesId     : e4c274e5-a096-4464-89a4-4771492baf00
  ClusterName          : Polaris
  ClusterUuid          : 00000000-0000-0000-0000-000000000000
  Fid                  : e4c274e5-a096-4464-89a4-4771492baf00
  Id                   : 24738
  IsCancelable         : False
  IsPolarisEventSeries : True
  LastEventAddedAt     : 4/12/2023 10:18:06 PM
  LastUpdated          : 4/12/2023 10:18:06 PM
  Location             : 
  ObjectId             : e4c274e5-a096-4464-89a4-4771492baf00
  ObjectName           : cdm-cluster-fvvvch-rrjkitw
  OrgName              : 
  Progress             : 100%
  StartTime            : 4/12/2023 10:02:17 PM
  LastActivityStatus   : SUCCESS
  LastActivityType     : CONFIGURATION
  ObjectType           : CLUSTER
  Severity             : INFO

  Retrieves an event series by ID, with details.

  .EXAMPLE
  Return back just the query that would run instead of running the query and returning the results.
  Get-RscEventSeries -AsQuery

  #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # Id parameter set: show event from ID
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$Id,
      
        # List parameter set: list event series
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$List,
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Int]$First = 50,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
  
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }

        # Create query:
        $gqlQuery = "activitySeriesConnection"
        if ( $Id ) {
            $gqlQuery = "activitySeries"
        }
        $query = (New-RscQuery -Gql $gqlQuery -FieldProfile $fieldProfile)

        # Customize query:
        if ( $Id ) {
            $activitySeriesInput = Get-RscType -Name "ActivitySeriesInput" -InitialValues @{"activitySeriesId" = $Id }
            $query.Var.input = $activitySeriesInput
        }
        else {
            if ( $First -gt 0 ) {
                $query.Var.first = $First
            }
            $query.Field.Count = $null
        }

        # Skip sending, return query object:
        if ( $AsQuery ) {
            return $query
        }

        # Send request to the API server
        $result = Invoke-Rsc $query

        # Filter results
        # the response's `Nodes` field contains the list
        if ( $PSCmdlet.ParameterSetName -eq "List" ) {
            $result = $result.Nodes
        }

        # Filter out null values:
        # fields that weren't requested
        # come back as nulls in the `$result` object,
        # but that's not interesting to display
        $result | Remove-NullProperties
    } 
}
