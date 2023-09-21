// New-RscMutationActivitySeries.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Mutations for the 'Activity series' API domain.
    /// </summary>
    /// <description>
    /// New-RscMutationActivitySeries is the cmdlet to work with operations in the {self.noun} API domain. It is a dynamic cmdlet that accepts any {self.noun} API operation as its first parameter:  {sc_names}.
    /// </description>
    /// <example>
    /// <code>New-RscMutationActivitySeries -Cancel [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationActivitySeries",
        DefaultParameterSetName = "Cancel")
    ]
    public class New_RscMutationActivitySeries : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// Cancel parameter set
        ///
        /// [GraphQL: cancelActivitySeries]
        /// </summary>
        [Parameter(
            ParameterSetName = "Cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cancel an activity series.
[GraphQL: cancelActivitySeries]",
            Position = 0
        )]
        public SwitchParameter Cancel { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "Cancel":
                        this.ProcessRecord_Cancel();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // cancelActivitySeries.
        internal void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Create new graphql operation cancelActivitySeries
            InitMutationCancelActivitySeries();
        }


        // Create new GraphQL Mutation:
        // cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        internal void InitMutationCancelActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationCancelActivitySeries",
                "($input: CancelActivitySeriesInput!)",
                "System.Boolean",
                Mutation.CancelActivitySeries_ObjectFieldSpec,
                Mutation.CancelActivitySeriesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
}"
            );
        }


    } // class New_RscMutationActivitySeries
}