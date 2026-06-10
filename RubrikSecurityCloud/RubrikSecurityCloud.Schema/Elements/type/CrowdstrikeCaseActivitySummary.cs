// CrowdstrikeCaseActivitySummary.cs
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
    #region CrowdstrikeCaseActivitySummary
    public class CrowdstrikeCaseActivitySummary: BaseType
    {
        #region members

        //      C# -> List<System.String>? ImpactedIdentityProviders
        // GraphQL -> impactedIdentityProviders: [String!]! (scalar)
        [JsonProperty("impactedIdentityProviders")]
        public List<System.String>? ImpactedIdentityProviders { get; set; }

        //      C# -> DateTime? LatestActionTime
        // GraphQL -> latestActionTime: DateTime (scalar)
        [JsonProperty("latestActionTime")]
        public DateTime? LatestActionTime { get; set; }

        //      C# -> System.String? RecoveryUrl
        // GraphQL -> recoveryUrl: String (scalar)
        [JsonProperty("recoveryUrl")]
        public System.String? RecoveryUrl { get; set; }

        //      C# -> System.Int32? TotalActors
        // GraphQL -> totalActors: Int! (scalar)
        [JsonProperty("totalActors")]
        public System.Int32? TotalActors { get; set; }

        //      C# -> System.Int32? TotalRelatedActions
        // GraphQL -> totalRelatedActions: Int! (scalar)
        [JsonProperty("totalRelatedActions")]
        public System.Int32? TotalRelatedActions { get; set; }

        //      C# -> System.Int32? TotalTargetEntities
        // GraphQL -> totalTargetEntities: Int! (scalar)
        [JsonProperty("totalTargetEntities")]
        public System.Int32? TotalTargetEntities { get; set; }

        //      C# -> System.Int32? TotalViolations
        // GraphQL -> totalViolations: Int (scalar)
        [JsonProperty("totalViolations")]
        public System.Int32? TotalViolations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrowdstrikeCaseActivitySummary";
    }

    public CrowdstrikeCaseActivitySummary Set(
        List<System.String>? ImpactedIdentityProviders = null,
        DateTime? LatestActionTime = null,
        System.String? RecoveryUrl = null,
        System.Int32? TotalActors = null,
        System.Int32? TotalRelatedActions = null,
        System.Int32? TotalTargetEntities = null,
        System.Int32? TotalViolations = null
    ) 
    {
        if ( ImpactedIdentityProviders != null ) {
            this.ImpactedIdentityProviders = ImpactedIdentityProviders;
        }
        if ( LatestActionTime != null ) {
            this.LatestActionTime = LatestActionTime;
        }
        if ( RecoveryUrl != null ) {
            this.RecoveryUrl = RecoveryUrl;
        }
        if ( TotalActors != null ) {
            this.TotalActors = TotalActors;
        }
        if ( TotalRelatedActions != null ) {
            this.TotalRelatedActions = TotalRelatedActions;
        }
        if ( TotalTargetEntities != null ) {
            this.TotalTargetEntities = TotalTargetEntities;
        }
        if ( TotalViolations != null ) {
            this.TotalViolations = TotalViolations;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? ImpactedIdentityProviders
        // GraphQL -> impactedIdentityProviders: [String!]! (scalar)
        if (this.ImpactedIdentityProviders != null) {
            if (conf.Flat) {
                s += conf.Prefix + "impactedIdentityProviders\n" ;
            } else {
                s += ind + "impactedIdentityProviders\n" ;
            }
        }
        //      C# -> DateTime? LatestActionTime
        // GraphQL -> latestActionTime: DateTime (scalar)
        if (this.LatestActionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestActionTime\n" ;
            } else {
                s += ind + "latestActionTime\n" ;
            }
        }
        //      C# -> System.String? RecoveryUrl
        // GraphQL -> recoveryUrl: String (scalar)
        if (this.RecoveryUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryUrl\n" ;
            } else {
                s += ind + "recoveryUrl\n" ;
            }
        }
        //      C# -> System.Int32? TotalActors
        // GraphQL -> totalActors: Int! (scalar)
        if (this.TotalActors != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalActors\n" ;
            } else {
                s += ind + "totalActors\n" ;
            }
        }
        //      C# -> System.Int32? TotalRelatedActions
        // GraphQL -> totalRelatedActions: Int! (scalar)
        if (this.TotalRelatedActions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalRelatedActions\n" ;
            } else {
                s += ind + "totalRelatedActions\n" ;
            }
        }
        //      C# -> System.Int32? TotalTargetEntities
        // GraphQL -> totalTargetEntities: Int! (scalar)
        if (this.TotalTargetEntities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalTargetEntities\n" ;
            } else {
                s += ind + "totalTargetEntities\n" ;
            }
        }
        //      C# -> System.Int32? TotalViolations
        // GraphQL -> totalViolations: Int (scalar)
        if (this.TotalViolations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalViolations\n" ;
            } else {
                s += ind + "totalViolations\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ImpactedIdentityProviders
        // GraphQL -> impactedIdentityProviders: [String!]! (scalar)
        if (ec.Includes("impactedIdentityProviders",true))
        {
            if(this.ImpactedIdentityProviders == null) {

                this.ImpactedIdentityProviders = new List<System.String>();

            } else {


            }
        }
        else if (this.ImpactedIdentityProviders != null && ec.Excludes("impactedIdentityProviders",true))
        {
            this.ImpactedIdentityProviders = null;
        }
        //      C# -> DateTime? LatestActionTime
        // GraphQL -> latestActionTime: DateTime (scalar)
        if (ec.Includes("latestActionTime",true))
        {
            if(this.LatestActionTime == null) {

                this.LatestActionTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestActionTime != null && ec.Excludes("latestActionTime",true))
        {
            this.LatestActionTime = null;
        }
        //      C# -> System.String? RecoveryUrl
        // GraphQL -> recoveryUrl: String (scalar)
        if (ec.Includes("recoveryUrl",true))
        {
            if(this.RecoveryUrl == null) {

                this.RecoveryUrl = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryUrl != null && ec.Excludes("recoveryUrl",true))
        {
            this.RecoveryUrl = null;
        }
        //      C# -> System.Int32? TotalActors
        // GraphQL -> totalActors: Int! (scalar)
        if (ec.Includes("totalActors",true))
        {
            if(this.TotalActors == null) {

                this.TotalActors = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalActors != null && ec.Excludes("totalActors",true))
        {
            this.TotalActors = null;
        }
        //      C# -> System.Int32? TotalRelatedActions
        // GraphQL -> totalRelatedActions: Int! (scalar)
        if (ec.Includes("totalRelatedActions",true))
        {
            if(this.TotalRelatedActions == null) {

                this.TotalRelatedActions = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalRelatedActions != null && ec.Excludes("totalRelatedActions",true))
        {
            this.TotalRelatedActions = null;
        }
        //      C# -> System.Int32? TotalTargetEntities
        // GraphQL -> totalTargetEntities: Int! (scalar)
        if (ec.Includes("totalTargetEntities",true))
        {
            if(this.TotalTargetEntities == null) {

                this.TotalTargetEntities = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalTargetEntities != null && ec.Excludes("totalTargetEntities",true))
        {
            this.TotalTargetEntities = null;
        }
        //      C# -> System.Int32? TotalViolations
        // GraphQL -> totalViolations: Int (scalar)
        if (ec.Includes("totalViolations",true))
        {
            if(this.TotalViolations == null) {

                this.TotalViolations = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalViolations != null && ec.Excludes("totalViolations",true))
        {
            this.TotalViolations = null;
        }
    }


    #endregion

    } // class CrowdstrikeCaseActivitySummary
    
    #endregion

    public static class ListCrowdstrikeCaseActivitySummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CrowdstrikeCaseActivitySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrowdstrikeCaseActivitySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrowdstrikeCaseActivitySummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrowdstrikeCaseActivitySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrowdstrikeCaseActivitySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types