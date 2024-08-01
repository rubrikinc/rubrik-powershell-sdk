// VmNicMapEntry.cs
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
    #region VmNicMapEntry
    public class VmNicMapEntry: BaseType
    {
        #region members

        //      C# -> System.String? SourceNicAdapterType
        // GraphQL -> sourceNicAdapterType: String! (scalar)
        [JsonProperty("sourceNicAdapterType")]
        public System.String? SourceNicAdapterType { get; set; }

        //      C# -> System.String? SourceNicId
        // GraphQL -> sourceNicId: String! (scalar)
        [JsonProperty("sourceNicId")]
        public System.String? SourceNicId { get; set; }

        //      C# -> System.String? TargetNicId
        // GraphQL -> targetNicId: String! (scalar)
        [JsonProperty("targetNicId")]
        public System.String? TargetNicId { get; set; }

        //      C# -> VmNic? SourceNic
        // GraphQL -> sourceNic: VmNic (type)
        [JsonProperty("sourceNic")]
        public VmNic? SourceNic { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmNicMapEntry";
    }

    public VmNicMapEntry Set(
        System.String? SourceNicAdapterType = null,
        System.String? SourceNicId = null,
        System.String? TargetNicId = null,
        VmNic? SourceNic = null
    ) 
    {
        if ( SourceNicAdapterType != null ) {
            this.SourceNicAdapterType = SourceNicAdapterType;
        }
        if ( SourceNicId != null ) {
            this.SourceNicId = SourceNicId;
        }
        if ( TargetNicId != null ) {
            this.TargetNicId = TargetNicId;
        }
        if ( SourceNic != null ) {
            this.SourceNic = SourceNic;
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
        //      C# -> System.String? SourceNicAdapterType
        // GraphQL -> sourceNicAdapterType: String! (scalar)
        if (this.SourceNicAdapterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceNicAdapterType\n" ;
            } else {
                s += ind + "sourceNicAdapterType\n" ;
            }
        }
        //      C# -> System.String? SourceNicId
        // GraphQL -> sourceNicId: String! (scalar)
        if (this.SourceNicId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceNicId\n" ;
            } else {
                s += ind + "sourceNicId\n" ;
            }
        }
        //      C# -> System.String? TargetNicId
        // GraphQL -> targetNicId: String! (scalar)
        if (this.TargetNicId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetNicId\n" ;
            } else {
                s += ind + "targetNicId\n" ;
            }
        }
        //      C# -> VmNic? SourceNic
        // GraphQL -> sourceNic: VmNic (type)
        if (this.SourceNic != null) {
            var fspec = this.SourceNic.AsFieldSpec(conf.Child("sourceNic"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceNic" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? SourceNicAdapterType
        // GraphQL -> sourceNicAdapterType: String! (scalar)
        if (ec.Includes("sourceNicAdapterType",true))
        {
            if(this.SourceNicAdapterType == null) {

                this.SourceNicAdapterType = "FETCH";

            } else {


            }
        }
        else if (this.SourceNicAdapterType != null && ec.Excludes("sourceNicAdapterType",true))
        {
            this.SourceNicAdapterType = null;
        }
        //      C# -> System.String? SourceNicId
        // GraphQL -> sourceNicId: String! (scalar)
        if (ec.Includes("sourceNicId",true))
        {
            if(this.SourceNicId == null) {

                this.SourceNicId = "FETCH";

            } else {


            }
        }
        else if (this.SourceNicId != null && ec.Excludes("sourceNicId",true))
        {
            this.SourceNicId = null;
        }
        //      C# -> System.String? TargetNicId
        // GraphQL -> targetNicId: String! (scalar)
        if (ec.Includes("targetNicId",true))
        {
            if(this.TargetNicId == null) {

                this.TargetNicId = "FETCH";

            } else {


            }
        }
        else if (this.TargetNicId != null && ec.Excludes("targetNicId",true))
        {
            this.TargetNicId = null;
        }
        //      C# -> VmNic? SourceNic
        // GraphQL -> sourceNic: VmNic (type)
        if (ec.Includes("sourceNic",false))
        {
            if(this.SourceNic == null) {

                this.SourceNic = new VmNic();
                this.SourceNic.ApplyExploratoryFieldSpec(ec.NewChild("sourceNic"));

            } else {

                this.SourceNic.ApplyExploratoryFieldSpec(ec.NewChild("sourceNic"));

            }
        }
        else if (this.SourceNic != null && ec.Excludes("sourceNic",false))
        {
            this.SourceNic = null;
        }
    }


    #endregion

    } // class VmNicMapEntry
    
    #endregion

    public static class ListVmNicMapEntryExtensions
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
            this List<VmNicMapEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmNicMapEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmNicMapEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNicMapEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmNicMapEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types