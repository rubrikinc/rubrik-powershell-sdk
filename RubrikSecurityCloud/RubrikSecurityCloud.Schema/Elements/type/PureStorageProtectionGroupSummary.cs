// PureStorageProtectionGroupSummary.cs
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
    #region PureStorageProtectionGroupSummary
    public class PureStorageProtectionGroupSummary: BaseType
    {
        #region members

        //      C# -> PureStorageProtectionGroupSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: PureStorageProtectionGroupSummarySnapshotConsistencyMandate (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public PureStorageProtectionGroupSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> List<QuiesceTarget>? QuiesceTargets
        // GraphQL -> quiesceTargets: [QuiesceTarget!]! (type)
        [JsonProperty("quiesceTargets")]
        public List<QuiesceTarget>? QuiesceTargets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PureStorageProtectionGroupSummary";
    }

    public PureStorageProtectionGroupSummary Set(
        PureStorageProtectionGroupSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null,
        List<QuiesceTarget>? QuiesceTargets = null
    ) 
    {
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( QuiesceTargets != null ) {
            this.QuiesceTargets = QuiesceTargets;
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
        //      C# -> PureStorageProtectionGroupSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: PureStorageProtectionGroupSummarySnapshotConsistencyMandate (enum)
        if (this.SnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistencyMandate\n" ;
            } else {
                s += ind + "snapshotConsistencyMandate\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> List<QuiesceTarget>? QuiesceTargets
        // GraphQL -> quiesceTargets: [QuiesceTarget!]! (type)
        if (this.QuiesceTargets != null) {
            var fspec = this.QuiesceTargets.AsFieldSpec(conf.Child("quiesceTargets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "quiesceTargets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PureStorageProtectionGroupSummarySnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: PureStorageProtectionGroupSummarySnapshotConsistencyMandate (enum)
        if (ec.Includes("snapshotConsistencyMandate",true))
        {
            if(this.SnapshotConsistencyMandate == null) {

                this.SnapshotConsistencyMandate = new PureStorageProtectionGroupSummarySnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.SnapshotConsistencyMandate != null && ec.Excludes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = null;
        }
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> List<QuiesceTarget>? QuiesceTargets
        // GraphQL -> quiesceTargets: [QuiesceTarget!]! (type)
        if (ec.Includes("quiesceTargets",false))
        {
            if(this.QuiesceTargets == null) {

                this.QuiesceTargets = new List<QuiesceTarget>();
                this.QuiesceTargets.ApplyExploratoryFieldSpec(ec.NewChild("quiesceTargets"));

            } else {

                this.QuiesceTargets.ApplyExploratoryFieldSpec(ec.NewChild("quiesceTargets"));

            }
        }
        else if (this.QuiesceTargets != null && ec.Excludes("quiesceTargets",false))
        {
            this.QuiesceTargets = null;
        }
    }


    #endregion

    } // class PureStorageProtectionGroupSummary
    
    #endregion

    public static class ListPureStorageProtectionGroupSummaryExtensions
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
            this List<PureStorageProtectionGroupSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PureStorageProtectionGroupSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PureStorageProtectionGroupSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PureStorageProtectionGroupSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PureStorageProtectionGroupSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types