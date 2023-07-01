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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? SourceNicAdapterType
        // GraphQL -> sourceNicAdapterType: String! (scalar)
        if (this.SourceNicAdapterType != null) {
            s += ind + "sourceNicAdapterType\n" ;
        }
        //      C# -> System.String? SourceNicId
        // GraphQL -> sourceNicId: String! (scalar)
        if (this.SourceNicId != null) {
            s += ind + "sourceNicId\n" ;
        }
        //      C# -> System.String? TargetNicId
        // GraphQL -> targetNicId: String! (scalar)
        if (this.TargetNicId != null) {
            s += ind + "targetNicId\n" ;
        }
        //      C# -> VmNic? SourceNic
        // GraphQL -> sourceNic: VmNic (type)
        if (this.SourceNic != null) {
            var fspec = this.SourceNic.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceNic {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SourceNicAdapterType
        // GraphQL -> sourceNicAdapterType: String! (scalar)
        if (this.SourceNicAdapterType == null && Exploration.Includes(parent + ".sourceNicAdapterType", true))
        {
            this.SourceNicAdapterType = "FETCH";
        }
        //      C# -> System.String? SourceNicId
        // GraphQL -> sourceNicId: String! (scalar)
        if (this.SourceNicId == null && Exploration.Includes(parent + ".sourceNicId", true))
        {
            this.SourceNicId = "FETCH";
        }
        //      C# -> System.String? TargetNicId
        // GraphQL -> targetNicId: String! (scalar)
        if (this.TargetNicId == null && Exploration.Includes(parent + ".targetNicId", true))
        {
            this.TargetNicId = "FETCH";
        }
        //      C# -> VmNic? SourceNic
        // GraphQL -> sourceNic: VmNic (type)
        if (this.SourceNic == null && Exploration.Includes(parent + ".sourceNic"))
        {
            this.SourceNic = new VmNic();
            this.SourceNic.ApplyExploratoryFieldSpec(parent + ".sourceNic");
        }
    }


    #endregion

    } // class VmNicMapEntry
    
    #endregion

    public static class ListVmNicMapEntryExtensions
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
            this List<VmNicMapEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmNicMapEntry> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmNicMapEntry());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types