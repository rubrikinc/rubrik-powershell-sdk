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
        System.Boolean? IsExcludedFromSnapshot = null,
        System.String? VcdVmMoid = null,
        System.String? VcdVmName = null
    ) 
    {
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot != null) {
            s += ind + "isExcludedFromSnapshot\n" ;
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid != null) {
            s += ind + "vcdVmMoid\n" ;
        }
        //      C# -> System.String? VcdVmName
        // GraphQL -> vcdVmName: String! (scalar)
        if (this.VcdVmName != null) {
            s += ind + "vcdVmName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        if (this.IsExcludedFromSnapshot == null && Exploration.Includes(parent + ".isExcludedFromSnapshot", true))
        {
            this.IsExcludedFromSnapshot = true;
        }
        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        if (this.VcdVmMoid == null && Exploration.Includes(parent + ".vcdVmMoid", true))
        {
            this.VcdVmMoid = "FETCH";
        }
        //      C# -> System.String? VcdVmName
        // GraphQL -> vcdVmName: String! (scalar)
        if (this.VcdVmName == null && Exploration.Includes(parent + ".vcdVmName", true))
        {
            this.VcdVmName = "FETCH";
        }
    }


    #endregion

    } // class VcdVmInfo
    
    #endregion

    public static class ListVcdVmInfoExtensions
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
            this List<VcdVmInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdVmInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVmInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types