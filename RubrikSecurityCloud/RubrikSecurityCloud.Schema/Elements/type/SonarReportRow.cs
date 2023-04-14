// SonarReportRow.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region SonarReportRow
    public class SonarReportRow: IFragment
    {
        #region members
        //      C# -> System.Int32? NumHighRiskLocations
        // GraphQL -> numHighRiskLocations: Int! (scalar)
        [JsonProperty("numHighRiskLocations")]
        public System.Int32? NumHighRiskLocations { get; set; }

        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        [JsonProperty("numObjects")]
        public System.Int32? NumObjects { get; set; }

        //      C# -> System.Int32? NumViolatedFiles
        // GraphQL -> numViolatedFiles: Int! (scalar)
        [JsonProperty("numViolatedFiles")]
        public System.Int32? NumViolatedFiles { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        [JsonProperty("policyName")]
        public System.String? PolicyName { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        [JsonProperty("policyStatus")]
        public DiscoveryReportTablePolicyStatus? PolicyStatus { get; set; }

        #endregion

    #region methods

    public SonarReportRow Set(
        System.Int32? NumHighRiskLocations = null,
        System.Int32? NumObjects = null,
        System.Int32? NumViolatedFiles = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        System.Int32? Violations = null,
        DiscoveryReportTablePolicyStatus? PolicyStatus = null
    ) 
    {
        if ( NumHighRiskLocations != null ) {
            this.NumHighRiskLocations = NumHighRiskLocations;
        }
        if ( NumObjects != null ) {
            this.NumObjects = NumObjects;
        }
        if ( NumViolatedFiles != null ) {
            this.NumViolatedFiles = NumViolatedFiles;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( PolicyStatus != null ) {
            this.PolicyStatus = PolicyStatus;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? NumHighRiskLocations
            // GraphQL -> numHighRiskLocations: Int! (scalar)
            if (this.NumHighRiskLocations != null)
            {
                 s += ind + "numHighRiskLocations\n";

            }
            //      C# -> System.Int32? NumObjects
            // GraphQL -> numObjects: Int! (scalar)
            if (this.NumObjects != null)
            {
                 s += ind + "numObjects\n";

            }
            //      C# -> System.Int32? NumViolatedFiles
            // GraphQL -> numViolatedFiles: Int! (scalar)
            if (this.NumViolatedFiles != null)
            {
                 s += ind + "numViolatedFiles\n";

            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId != null)
            {
                 s += ind + "policyId\n";

            }
            //      C# -> System.String? PolicyName
            // GraphQL -> policyName: String! (scalar)
            if (this.PolicyName != null)
            {
                 s += ind + "policyName\n";

            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations != null)
            {
                 s += ind + "violations\n";

            }
            //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
            // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
            if (this.PolicyStatus != null)
            {
                 s += ind + "policyStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? NumHighRiskLocations
            // GraphQL -> numHighRiskLocations: Int! (scalar)
            if (this.NumHighRiskLocations == null && Exploration.Includes(parent + ".numHighRiskLocations$"))
            {
                this.NumHighRiskLocations = new System.Int32();
            }
            //      C# -> System.Int32? NumObjects
            // GraphQL -> numObjects: Int! (scalar)
            if (this.NumObjects == null && Exploration.Includes(parent + ".numObjects$"))
            {
                this.NumObjects = new System.Int32();
            }
            //      C# -> System.Int32? NumViolatedFiles
            // GraphQL -> numViolatedFiles: Int! (scalar)
            if (this.NumViolatedFiles == null && Exploration.Includes(parent + ".numViolatedFiles$"))
            {
                this.NumViolatedFiles = new System.Int32();
            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId == null && Exploration.Includes(parent + ".policyId$"))
            {
                this.PolicyId = new System.String("FETCH");
            }
            //      C# -> System.String? PolicyName
            // GraphQL -> policyName: String! (scalar)
            if (this.PolicyName == null && Exploration.Includes(parent + ".policyName$"))
            {
                this.PolicyName = new System.String("FETCH");
            }
            //      C# -> System.Int32? Violations
            // GraphQL -> violations: Int! (scalar)
            if (this.Violations == null && Exploration.Includes(parent + ".violations$"))
            {
                this.Violations = new System.Int32();
            }
            //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
            // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
            if (this.PolicyStatus == null && Exploration.Includes(parent + ".policyStatus$"))
            {
                this.PolicyStatus = new DiscoveryReportTablePolicyStatus();
            }
        }


    #endregion

    } // class SonarReportRow
    #endregion

    public static class ListSonarReportRowExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<SonarReportRow> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SonarReportRow> list, 
            String parent = "")
        {
            var item = new SonarReportRow();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types