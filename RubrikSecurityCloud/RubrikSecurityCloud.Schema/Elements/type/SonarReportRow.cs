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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region SonarReportRow
    public class SonarReportRow: BaseType
    {
        #region members

        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        [JsonProperty("policyStatus")]
        public DiscoveryReportTablePolicyStatus? PolicyStatus { get; set; }

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


        #endregion

    #region methods

    public SonarReportRow Set(
        DiscoveryReportTablePolicyStatus? PolicyStatus = null,
        System.Int32? NumHighRiskLocations = null,
        System.Int32? NumObjects = null,
        System.Int32? NumViolatedFiles = null,
        System.String? PolicyId = null,
        System.String? PolicyName = null,
        System.Int32? Violations = null
    ) 
    {
        if ( PolicyStatus != null ) {
            this.PolicyStatus = PolicyStatus;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        if (this.PolicyStatus != null) {
            s += ind + "policyStatus\n" ;
        }
        //      C# -> System.Int32? NumHighRiskLocations
        // GraphQL -> numHighRiskLocations: Int! (scalar)
        if (this.NumHighRiskLocations != null) {
            s += ind + "numHighRiskLocations\n" ;
        }
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (this.NumObjects != null) {
            s += ind + "numObjects\n" ;
        }
        //      C# -> System.Int32? NumViolatedFiles
        // GraphQL -> numViolatedFiles: Int! (scalar)
        if (this.NumViolatedFiles != null) {
            s += ind + "numViolatedFiles\n" ;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            s += ind + "policyId\n" ;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            s += ind + "policyName\n" ;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            s += ind + "violations\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        if (this.PolicyStatus == null && Exploration.Includes(parent + ".policyStatus", true))
        {
            this.PolicyStatus = new DiscoveryReportTablePolicyStatus();
        }
        //      C# -> System.Int32? NumHighRiskLocations
        // GraphQL -> numHighRiskLocations: Int! (scalar)
        if (this.NumHighRiskLocations == null && Exploration.Includes(parent + ".numHighRiskLocations", true))
        {
            this.NumHighRiskLocations = new System.Int32();
        }
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (this.NumObjects == null && Exploration.Includes(parent + ".numObjects", true))
        {
            this.NumObjects = new System.Int32();
        }
        //      C# -> System.Int32? NumViolatedFiles
        // GraphQL -> numViolatedFiles: Int! (scalar)
        if (this.NumViolatedFiles == null && Exploration.Includes(parent + ".numViolatedFiles", true))
        {
            this.NumViolatedFiles = new System.Int32();
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId == null && Exploration.Includes(parent + ".policyId", true))
        {
            this.PolicyId = new System.String("FETCH");
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName == null && Exploration.Includes(parent + ".policyName", true))
        {
            this.PolicyName = new System.String("FETCH");
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations == null && Exploration.Includes(parent + ".violations", true))
        {
            this.Violations = new System.Int32();
        }
    }


    #endregion

    } // class SonarReportRow
    
    #endregion

    public static class ListSonarReportRowExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SonarReportRow> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SonarReportRow> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarReportRow());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types