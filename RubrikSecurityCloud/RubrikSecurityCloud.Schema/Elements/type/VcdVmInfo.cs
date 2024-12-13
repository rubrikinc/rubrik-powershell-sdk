// VcdVmInfo.cs
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
    #region VcdVmInfo
    public class VcdVmInfo: BaseType
    {
        #region members

        //      C# -> System.String? CdmVmId
        // GraphQL -> cdmVmId: String! (scalar)
        [JsonProperty("cdmVmId")]
        public System.String? CdmVmId { get; set; }

        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }

        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        [JsonProperty("vcdVmMoid")]
        public System.String? VcdVmMoid { get; set; }

        //      C# -> System.String? VcdVmName
        // GraphQL -> vcdVmName: String! (scalar)
        [JsonProperty("vcdVmName")]
        public System.String? VcdVmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcdVmInfo";
    }

    public VcdVmInfo Set(
        System.String? CdmVmId = null,
        System.Boolean? IsExcludedFromSnapshot = null,
        System.String? VcdVmMoid = null,
        System.String? VcdVmName = null
    ) 
    {
        if ( CdmVmId != null ) {
            this.CdmVmId = CdmVmId;
        }
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( VcdVmMoid != null ) {
            this.VcdVmMoid = VcdVmMoid;
        }
        if ( VcdVmName != null ) {
            this.VcdVmName = VcdVmName;
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
        //      C# -> System.String? CdmVmId
        // GraphQL -> cdmVmId: String! (scalar)
        if (this.CdmVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVmId\n" ;
            } else {
                s += ind + "cdmVmId\n" ;
            }
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcludedFromSnapshot\n" ;
            } else {
                s += ind + "isExcludedFromSnapshot\n" ;
            }
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdVmMoid\n" ;
            } else {
                s += ind + "vcdVmMoid\n" ;
            }
        }
        //      C# -> System.String? VcdVmName
        // GraphQL -> vcdVmName: String! (scalar)
        if (this.VcdVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcdVmName\n" ;
            } else {
                s += ind + "vcdVmName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmVmId
        // GraphQL -> cdmVmId: String! (scalar)
        if (ec.Includes("cdmVmId",true))
        {
            if(this.CdmVmId == null) {

                this.CdmVmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmVmId != null && ec.Excludes("cdmVmId",true))
        {
            this.CdmVmId = null;
        }
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (ec.Includes("isExcludedFromSnapshot",true))
        {
            if(this.IsExcludedFromSnapshot == null) {

                this.IsExcludedFromSnapshot = true;

            } else {


            }
        }
        else if (this.IsExcludedFromSnapshot != null && ec.Excludes("isExcludedFromSnapshot",true))
        {
            this.IsExcludedFromSnapshot = null;
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (ec.Includes("vcdVmMoid",true))
        {
            if(this.VcdVmMoid == null) {

                this.VcdVmMoid = "FETCH";

            } else {


            }
        }
        else if (this.VcdVmMoid != null && ec.Excludes("vcdVmMoid",true))
        {
            this.VcdVmMoid = null;
        }
        //      C# -> System.String? VcdVmName
        // GraphQL -> vcdVmName: String! (scalar)
        if (ec.Includes("vcdVmName",true))
        {
            if(this.VcdVmName == null) {

                this.VcdVmName = "FETCH";

            } else {


            }
        }
        else if (this.VcdVmName != null && ec.Excludes("vcdVmName",true))
        {
            this.VcdVmName = null;
        }
    }


    #endregion

    } // class VcdVmInfo
    
    #endregion

    public static class ListVcdVmInfoExtensions
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
            this List<VcdVmInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VcdVmInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VcdVmInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VcdVmInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types