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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "SonarReportRow";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        if (this.PolicyStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyStatus\n" ;
            } else {
                s += ind + "policyStatus\n" ;
            }
        }
        //      C# -> System.Int32? NumHighRiskLocations
        // GraphQL -> numHighRiskLocations: Int! (scalar)
        if (this.NumHighRiskLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numHighRiskLocations\n" ;
            } else {
                s += ind + "numHighRiskLocations\n" ;
            }
        }
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (this.NumObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numObjects\n" ;
            } else {
                s += ind + "numObjects\n" ;
            }
        }
        //      C# -> System.Int32? NumViolatedFiles
        // GraphQL -> numViolatedFiles: Int! (scalar)
        if (this.NumViolatedFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numViolatedFiles\n" ;
            } else {
                s += ind + "numViolatedFiles\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (this.PolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyName\n" ;
            } else {
                s += ind + "policyName\n" ;
            }
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violations\n" ;
            } else {
                s += ind + "violations\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DiscoveryReportTablePolicyStatus? PolicyStatus
        // GraphQL -> policyStatus: DiscoveryReportTablePolicyStatus! (enum)
        if (ec.Includes("policyStatus",true))
        {
            if(this.PolicyStatus == null) {

                this.PolicyStatus = new DiscoveryReportTablePolicyStatus();

            } else {


            }
        }
        else if (this.PolicyStatus != null && ec.Excludes("policyStatus",true))
        {
            this.PolicyStatus = null;
        }
        //      C# -> System.Int32? NumHighRiskLocations
        // GraphQL -> numHighRiskLocations: Int! (scalar)
        if (ec.Includes("numHighRiskLocations",true))
        {
            if(this.NumHighRiskLocations == null) {

                this.NumHighRiskLocations = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumHighRiskLocations != null && ec.Excludes("numHighRiskLocations",true))
        {
            this.NumHighRiskLocations = null;
        }
        //      C# -> System.Int32? NumObjects
        // GraphQL -> numObjects: Int! (scalar)
        if (ec.Includes("numObjects",true))
        {
            if(this.NumObjects == null) {

                this.NumObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumObjects != null && ec.Excludes("numObjects",true))
        {
            this.NumObjects = null;
        }
        //      C# -> System.Int32? NumViolatedFiles
        // GraphQL -> numViolatedFiles: Int! (scalar)
        if (ec.Includes("numViolatedFiles",true))
        {
            if(this.NumViolatedFiles == null) {

                this.NumViolatedFiles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumViolatedFiles != null && ec.Excludes("numViolatedFiles",true))
        {
            this.NumViolatedFiles = null;
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? PolicyName
        // GraphQL -> policyName: String! (scalar)
        if (ec.Includes("policyName",true))
        {
            if(this.PolicyName == null) {

                this.PolicyName = "FETCH";

            } else {


            }
        }
        else if (this.PolicyName != null && ec.Excludes("policyName",true))
        {
            this.PolicyName = null;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (ec.Includes("violations",true))
        {
            if(this.Violations == null) {

                this.Violations = Int32.MinValue;

            } else {


            }
        }
        else if (this.Violations != null && ec.Excludes("violations",true))
        {
            this.Violations = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SonarReportRow> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SonarReportRow> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarReportRow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SonarReportRow> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types