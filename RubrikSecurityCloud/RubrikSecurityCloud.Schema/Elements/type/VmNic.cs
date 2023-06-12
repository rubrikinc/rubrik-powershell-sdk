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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        if (this.NicId != null) {
            s += ind + "nicId\n" ;
        }
        //      C# -> System.String? NicMoid
        // GraphQL -> nicMoid: String! (scalar)
        if (this.NicMoid != null) {
            s += ind + "nicMoid\n" ;
        }
        //      C# -> System.String? NicName
        // GraphQL -> nicName: String! (scalar)
        if (this.NicName != null) {
            s += ind + "nicName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NicId
        // GraphQL -> nicId: String! (scalar)
        if (this.NicId == null && Exploration.Includes(parent + ".nicId", true))
        {
            this.NicId = "FETCH";
        }
        //      C# -> System.String? NicMoid
        // GraphQL -> nicMoid: String! (scalar)
        if (this.NicMoid == null && Exploration.Includes(parent + ".nicMoid", true))
        {
            this.NicMoid = "FETCH";
        }
        //      C# -> System.String? NicName
        // GraphQL -> nicName: String! (scalar)
        if (this.NicName == null && Exploration.Includes(parent + ".nicName", true))
        {
            this.NicName = "FETCH";
        }
    }


    #endregion

    } // class VmNic
    
    #endregion

    public static class ListVmNicExtensions
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
            this List<VmNic> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmNic> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNic());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types