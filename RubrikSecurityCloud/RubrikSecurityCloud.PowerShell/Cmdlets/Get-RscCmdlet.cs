using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using RubrikSecurityCloud;
using RubrikSecurityCloud.PowerShell.Models;
using RubrikSecurityCloud.PowerShell.Private;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Return info about SDK cmdlets
    /// </summary>
    /// <description>
    /// Look up a GraphQL Operation and
    /// return info about the cmdlet that implements it.
    /// </description>
    /// <example>
    /// Retrieve the name of the cmdlet that implements the
    /// GraphQL query clusterConnection
    /// <code>
    /// PS> Get-RscCmdlet clusterConnection
    /// </code>
    /// </example>
    /// <example>
    /// Retrieve info for a GraphQL operation that is
    /// not implemented by a cmdlet.
    /// <code>
    /// PS> Get-RscCmdlet notImplementedOperation
    /// </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "RscCmdlet", DefaultParameterSetName = "LookupExistingGqlRootField")]
    public class Get_RscCmdlet : RscBasePSCmdlet
    {
        /// <summary>
        /// The name of the GraphQL Operation to look up.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "LookupExistingGqlRootField")]
        [ValidateNotNullOrEmpty]
        public SchemaMeta.GqlRootFieldName ExistingGqlRootFieldName { get; set; } = SchemaMeta.GqlRootFieldName.Unknown;

        /// <summary>
        /// The name of the GraphQL Operation to look up.
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 0,
            ValueFromPipeline = true,
            ParameterSetName = "LookupAnyGqlRootField")]
        [ValidateNotNullOrEmpty]
        public string AnyGqlRootFieldName { get; set; }

        /// <summary>
        /// Info about the various locations the SDK uses
        /// </summary>
        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipeline = true,
            ParameterSetName = "Locations")]
        public SwitchParameter Locations { get; set; }

    #pragma warning disable 1591 // ignore warning 'Missing XML comment'

        public Get_RscCmdlet() : base(retrieveConnection: false)
        {
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch (ParameterSetName)
                {
                    case "LookupExistingGqlRootField":
                        LookupExistingGqlRootField();
                        break;
                    case "LookupAnyGqlRootField":
                        LookupAnyGqlRootField();
                        break;
                    case "Locations":
                        GetLocations();
                        break;
                }
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        protected void LookupExistingGqlRootField()
        {
            if (ExistingGqlRootFieldName != SchemaMeta.GqlRootFieldName.Unknown)
            {
                var rscOp = SchemaMeta.RscOpLookupByGqlRootField(
                    ExistingGqlRootFieldName
                );
                WriteObject(rscOp);
                return;
            }

            var rscOps = Enum
                .GetValues(typeof(SchemaMeta.GqlRootFieldName))
                .Cast<SchemaMeta.GqlRootFieldName>()
                .Where(value => value != SchemaMeta.GqlRootFieldName.Unknown)  // Skip 'Unknown'
                .Select(value =>
                    SchemaMeta.RscOpLookupByGqlRootField(value))
                .ToArray();

            WriteObject(rscOps, /*enumerateCollection=*/ true);
        }

        protected void LookupAnyGqlRootField()
        {
            var rscOp = SchemaMeta.RscOpLookupByGqlRootField(
                AnyGqlRootFieldName
            );
            WriteObject(rscOp);
        }

        protected void GetLocations()
        {
            var locations = new Hashtable();
            var customDir = this.GetCustomDir();
            locations.Add("CustomDir", customDir);
            // retrieve the list of *.gql files that's in
            // this.GetCustomDir():
            var opList = new List<string>();
            foreach (var file in System.IO.Directory.GetFiles(customDir, "*.gql"))
            {
                opList.Add(System.IO.Path.GetFileNameWithoutExtension(file));
            }
            locations.Add("CustomOperations", opList);
            locations.Add("ProfileDir", this.GetProfileDir());
            locations.Add("AssemblyDir", Files.GetAssemblyDir());
            WriteObject(locations, /*enumerateCollection=*/ true);
        }

    }
}

