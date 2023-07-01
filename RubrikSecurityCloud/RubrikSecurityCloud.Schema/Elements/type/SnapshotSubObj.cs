// SnapshotSubObj.cs
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
    #region SnapshotSubObj
    public class SnapshotSubObj: BaseType
    {
        #region members

        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        [JsonProperty("volumeGroupSubObj")]
        public VolumeGroupSubObject? VolumeGroupSubObj { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotSubObj";
    }

    public SnapshotSubObj Set(
        VolumeGroupSubObject? VolumeGroupSubObj = null
    ) 
    {
        if ( VolumeGroupSubObj != null ) {
            this.VolumeGroupSubObj = VolumeGroupSubObj;
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
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (this.VolumeGroupSubObj != null) {
            var fspec = this.VolumeGroupSubObj.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "volumeGroupSubObj {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (this.VolumeGroupSubObj == null && Exploration.Includes(parent + ".volumeGroupSubObj"))
        {
            this.VolumeGroupSubObj = new VolumeGroupSubObject();
            this.VolumeGroupSubObj.ApplyExploratoryFieldSpec(parent + ".volumeGroupSubObj");
        }
    }


    #endregion

    } // class SnapshotSubObj
    
    #endregion

    public static class ListSnapshotSubObjExtensions
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
            this List<SnapshotSubObj> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSubObj> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSubObj());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types