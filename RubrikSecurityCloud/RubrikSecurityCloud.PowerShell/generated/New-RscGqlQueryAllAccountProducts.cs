// New-RscGqlQueryAllAccountProducts.cs
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
    /// Create new GraphQL Query allAccountProducts
    /// allAccountProducts(
    ///     nameFilter: [ProductName!]!
    ///     typeFilter: [ProductType!]!
    ///     stateFilter: [ProductState!]!
    ///     startDateArg: DateTime
    ///     endDateArg: DateTime
    ///   ): [AccountProduct!]!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryAllAccountProducts")
    ]
    public class New_RscGqlQueryAllAccountProducts : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("allAccountProducts");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query allAccountProducts
        /// allAccountProducts(
        ///     nameFilter: [ProductName!]!
        ///     typeFilter: [ProductType!]!
        ///     stateFilter: [ProductState!]!
        ///     startDateArg: DateTime
        ///     endDateArg: DateTime
        ///   ): [AccountProduct!]!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_allAccountProducts();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_allAccountProducts()
        {
            this._logger.name += " -allAccountProducts";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("nameFilter", "[ProductName!]!"),
                Tuple.Create("typeFilter", "[ProductType!]!"),
                Tuple.Create("stateFilter", "[ProductState!]!"),
                Tuple.Create("startDateArg", "DateTime"),
                Tuple.Create("endDateArg", "DateTime"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllAccountProducts",
                "($nameFilter: [ProductName!]!,$typeFilter: [ProductType!]!,$stateFilter: [ProductState!]!,$startDateArg: DateTime,$endDateArg: DateTime)",
                "List<AccountProduct>",
                Query.AllAccountProducts_ObjectFieldSpec,
                Query.AllAccountProductsFieldSpec,
                @"# REQUIRED
$inputs.Var.nameFilter = @(
	<ProductName> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductName]) for enum values.
)
# REQUIRED
$inputs.Var.typeFilter = @(
	<ProductType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductType]) for enum values.
)
# REQUIRED
$inputs.Var.stateFilter = @(
	<ProductState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductState]) for enum values.
)
# OPTIONAL
$inputs.Var.startDateArg = <DateTime>
# OPTIONAL
$inputs.Var.endDateArg = <DateTime>"
            );
        }

    } // class New-RscGqlQueryAllAccountProducts
}