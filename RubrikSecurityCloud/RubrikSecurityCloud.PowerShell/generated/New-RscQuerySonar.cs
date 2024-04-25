// New-RscQuerySonar.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 2
    /// operations in the 'Sonar' API domain:
    /// UserGroups, or Users.
    /// </summary>
    /// <description>
    /// New-RscQuerySonar creates a new
    /// query object for operations
    /// in the 'Sonar' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 2 operations
    /// in the 'Sonar' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: UserGroups, or Users.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySonar -UserGroups).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySonar -UserGroups).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the UserGroups operation
    /// of the 'Sonar' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sonar
    /// # API Operation: UserGroups
    /// 
    /// $query = New-RscQuerySonar -UserGroups
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	groupName = $someString
    /// 	# OPTIONAL
    /// 	userId = $someString
    /// }
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AccessGroupConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Users operation
    /// of the 'Sonar' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sonar
    /// # API Operation: Users
    /// 
    /// $query = New-RscQuerySonar -Users
    /// 
    /// # OPTIONAL
    /// $query.Var.sort = @{
    /// 	# OPTIONAL
    /// 	sortBy = $someListAccessUsersSort # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListAccessUsersSort]) for enum values.
    /// 	# OPTIONAL
    /// 	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	groupsIds = @(
    /// 		$someString
    /// 	)
    /// 	# OPTIONAL
    /// 	search = $someString
    /// 	# REQUIRED
    /// 	timeRange = @{
    /// 		# OPTIONAL
    /// 		startTime = $someString
    /// 		# OPTIONAL
    /// 		endTime = $someString
    /// 		# OPTIONAL
    /// 		timezone = $someString
    /// 	}
    /// }
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AccessUserConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQuerySonar",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySonar : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "UserGroups",
                "Users",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "UserGroups":
                        this.ProcessRecord_UserGroups();
                        break;
                    case "Users":
                        this.ProcessRecord_Users();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // sonarUserGroups.
        internal void ProcessRecord_UserGroups()
        {
            this._logger.name += " -UserGroups";
            // Create new graphql operation sonarUserGroups
            InitQuerySonarUserGroups();
        }

        // This parameter set invokes a single graphql operation:
        // sonarUsers.
        internal void ProcessRecord_Users()
        {
            this._logger.name += " -Users";
            // Create new graphql operation sonarUsers
            InitQuerySonarUsers();
        }


        // Create new GraphQL Query:
        // sonarUserGroups(
        //     filter: ListAccessGroupsFilterInput
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): AccessGroupConnection!
        internal void InitQuerySonarUserGroups()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "ListAccessGroupsFilterInput"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarUserGroups",
                "($filter: ListAccessGroupsFilterInput,$first: Int,$after: String,$last: Int,$before: String)",
                "AccessGroupConnection",
                Query.SonarUserGroups,
                Query.SonarUserGroupsFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	groupName = $someString
	# OPTIONAL
	userId = $someString
}
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // sonarUsers(
        //     sort: ListAccessUsersSortInput
        //     filter: ListAccessUsersFilterInput
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): AccessUserConnection!
        internal void InitQuerySonarUsers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("sort", "ListAccessUsersSortInput"),
                Tuple.Create("filter", "ListAccessUsersFilterInput"),
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySonarUsers",
                "($sort: ListAccessUsersSortInput,$filter: ListAccessUsersFilterInput,$first: Int,$after: String,$last: Int,$before: String)",
                "AccessUserConnection",
                Query.SonarUsers,
                Query.SonarUsersFieldSpec,
                @"# OPTIONAL
$query.Var.sort = @{
	# OPTIONAL
	sortBy = $someListAccessUsersSort # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ListAccessUsersSort]) for enum values.
	# OPTIONAL
	sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	groupsIds = @(
		$someString
	)
	# OPTIONAL
	search = $someString
	# REQUIRED
	timeRange = @{
		# OPTIONAL
		startTime = $someString
		# OPTIONAL
		endTime = $someString
		# OPTIONAL
		timezone = $someString
	}
}
# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }


    } // class New_RscQuerySonar
}