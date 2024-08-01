// VmNic.cs
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
    #region VmNic
    public class VmNic: BaseType
    {
        #region members

        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        [JsonProperty("nicId")]
        public System.String? NicId { get; set; }

        //      C# -> System.String? NicMoid
        // GraphQL -> nicMoid: String! (scalar)
        [JsonProperty("nicMoid")]
        public System.String? NicMoid { get; set; }

        //      C# -> System.String? NicName
        // GraphQL -> nicName: String! (scalar)
        [JsonProperty("nicName")]
        public System.String? NicName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmNic";
    }

    public VmNic Set(
        System.String? NicId = null,
        System.String? NicMoid = null,
        System.String? NicName = null
    ) 
    {
        if ( NicId != null ) {
            this.NicId = NicId;
        }
        if ( NicMoid != null ) {
            this.NicMoid = NicMoid;
        }
        if ( NicName != null ) {
            this.NicName = NicName;
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
        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        if (this.NicId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicId\n" ;
            } else {
                s += ind + "nicId\n" ;
            }
        }
        //      C# -> System.String? NicMoid
        // GraphQL -> nicMoid: String! (scalar)
        if (this.NicMoid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicMoid\n" ;
            } else {
                s += ind + "nicMoid\n" ;
            }
        }
        //      C# -> System.String? NicName
        // GraphQL -> nicName: String! (scalar)
        if (this.NicName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nicName\n" ;
            } else {
                s += ind + "nicName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        if (ec.Includes("nicId",true))
        {
            if(this.NicId == null) {

                this.NicId = "FETCH";

            } else {


            }
        }
        else if (this.NicId != null && ec.Excludes("nicId",true))
        {
            this.NicId = null;
        }
        //      C# -> System.String? NicMoid
        // GraphQL -> nicMoid: String! (scalar)
        if (ec.Includes("nicMoid",true))
        {
            if(this.NicMoid == null) {

                this.NicMoid = "FETCH";

            } else {


            }
        }
        else if (this.NicMoid != null && ec.Excludes("nicMoid",true))
        {
            this.NicMoid = null;
        }
        //      C# -> System.String? NicName
        // GraphQL -> nicName: String! (scalar)
        if (ec.Includes("nicName",true))
        {
            if(this.NicName == null) {

                this.NicName = "FETCH";

            } else {


            }
        }
        else if (this.NicName != null && ec.Excludes("nicName",true))
        {
            this.NicName = null;
        }
    }


    #endregion

    } // class VmNic
    
    #endregion

    public static class ListVmNicExtensions
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
            this List<VmNic> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmNic> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmNic> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNic());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmNic> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types