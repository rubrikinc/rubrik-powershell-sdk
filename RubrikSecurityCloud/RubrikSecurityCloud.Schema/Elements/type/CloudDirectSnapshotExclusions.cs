// CloudDirectSnapshotExclusions.cs
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
    #region CloudDirectSnapshotExclusions
    public class CloudDirectSnapshotExclusions: BaseType
    {
        #region members

        //      C# -> List<CloudDirectExclusionObject>? Exclusions
        // GraphQL -> exclusions: [CloudDirectExclusionObject!]! (type)
        [JsonProperty("exclusions")]
        public List<CloudDirectExclusionObject>? Exclusions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSnapshotExclusions";
    }

    public CloudDirectSnapshotExclusions Set(
        List<CloudDirectExclusionObject>? Exclusions = null
    ) 
    {
        if ( Exclusions != null ) {
            this.Exclusions = Exclusions;
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
        //      C# -> List<CloudDirectExclusionObject>? Exclusions
        // GraphQL -> exclusions: [CloudDirectExclusionObject!]! (type)
        if (this.Exclusions != null) {
            var fspec = this.Exclusions.AsFieldSpec(conf.Child("exclusions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exclusions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<CloudDirectExclusionObject>? Exclusions
        // GraphQL -> exclusions: [CloudDirectExclusionObject!]! (type)
        if (ec.Includes("exclusions",false))
        {
            if(this.Exclusions == null) {

                this.Exclusions = new List<CloudDirectExclusionObject>();
                this.Exclusions.ApplyExploratoryFieldSpec(ec.NewChild("exclusions"));

            } else {

                this.Exclusions.ApplyExploratoryFieldSpec(ec.NewChild("exclusions"));

            }
        }
        else if (this.Exclusions != null && ec.Excludes("exclusions",false))
        {
            this.Exclusions = null;
        }
    }


    #endregion

    } // class CloudDirectSnapshotExclusions
    
    #endregion

    public static class ListCloudDirectSnapshotExclusionsExtensions
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
            this List<CloudDirectSnapshotExclusions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectSnapshotExclusions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSnapshotExclusions> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSnapshotExclusions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSnapshotExclusions> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types