// ObjectStatus.cs
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
    #region ObjectStatus
    public class ObjectStatus: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        [JsonProperty("latestSnapshotResult")]
        public SnapshotResult? LatestSnapshotResult { get; set; }

        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        [JsonProperty("policyStatuses")]
        public List<PolicyStatus>? PolicyStatuses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectStatus";
    }

    public ObjectStatus Set(
        System.String? Id = null,
        SnapshotResult? LatestSnapshotResult = null,
        List<PolicyStatus>? PolicyStatuses = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LatestSnapshotResult != null ) {
            this.LatestSnapshotResult = LatestSnapshotResult;
        }
        if ( PolicyStatuses != null ) {
            this.PolicyStatuses = PolicyStatuses;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        if (this.LatestSnapshotResult != null) {
            var fspec = this.LatestSnapshotResult.AsFieldSpec(conf.Child("latestSnapshotResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestSnapshotResult {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        if (this.PolicyStatuses != null) {
            var fspec = this.PolicyStatuses.AsFieldSpec(conf.Child("policyStatuses"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyStatuses {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> SnapshotResult? LatestSnapshotResult
        // GraphQL -> latestSnapshotResult: SnapshotResult (type)
        if (ec.Includes("latestSnapshotResult",false))
        {
            if(this.LatestSnapshotResult == null) {

                this.LatestSnapshotResult = new SnapshotResult();
                this.LatestSnapshotResult.ApplyExploratoryFieldSpec(ec.NewChild("latestSnapshotResult"));

            } else {

                this.LatestSnapshotResult.ApplyExploratoryFieldSpec(ec.NewChild("latestSnapshotResult"));

            }
        }
        else if (this.LatestSnapshotResult != null && ec.Excludes("latestSnapshotResult",false))
        {
            this.LatestSnapshotResult = null;
        }
        //      C# -> List<PolicyStatus>? PolicyStatuses
        // GraphQL -> policyStatuses: [PolicyStatus!]! (type)
        if (ec.Includes("policyStatuses",false))
        {
            if(this.PolicyStatuses == null) {

                this.PolicyStatuses = new List<PolicyStatus>();
                this.PolicyStatuses.ApplyExploratoryFieldSpec(ec.NewChild("policyStatuses"));

            } else {

                this.PolicyStatuses.ApplyExploratoryFieldSpec(ec.NewChild("policyStatuses"));

            }
        }
        else if (this.PolicyStatuses != null && ec.Excludes("policyStatuses",false))
        {
            this.PolicyStatuses = null;
        }
    }


    #endregion

    } // class ObjectStatus
    
    #endregion

    public static class ListObjectStatusExtensions
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
            this List<ObjectStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types