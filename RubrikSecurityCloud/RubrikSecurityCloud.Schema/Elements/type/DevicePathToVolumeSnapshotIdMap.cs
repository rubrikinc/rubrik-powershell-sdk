// DevicePathToVolumeSnapshotIdMap.cs
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
    #region DevicePathToVolumeSnapshotIdMap
    public class DevicePathToVolumeSnapshotIdMap: BaseType
    {
        #region members

        //      C# -> List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList
        // GraphQL -> devicePathToVolumeSnapshotIdList: [DevicePathToVolumeSnapshotId!]! (type)
        [JsonProperty("devicePathToVolumeSnapshotIdList")]
        public List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DevicePathToVolumeSnapshotIdMap";
    }

    public DevicePathToVolumeSnapshotIdMap Set(
        List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList = null
    ) 
    {
        if ( DevicePathToVolumeSnapshotIdList != null ) {
            this.DevicePathToVolumeSnapshotIdList = DevicePathToVolumeSnapshotIdList;
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
        //      C# -> List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList
        // GraphQL -> devicePathToVolumeSnapshotIdList: [DevicePathToVolumeSnapshotId!]! (type)
        if (this.DevicePathToVolumeSnapshotIdList != null) {
            var fspec = this.DevicePathToVolumeSnapshotIdList.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "devicePathToVolumeSnapshotIdList {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList
        // GraphQL -> devicePathToVolumeSnapshotIdList: [DevicePathToVolumeSnapshotId!]! (type)
        if (this.DevicePathToVolumeSnapshotIdList == null && ec.Includes("devicePathToVolumeSnapshotIdList",false))
        {
            this.DevicePathToVolumeSnapshotIdList = new List<DevicePathToVolumeSnapshotId>();
            this.DevicePathToVolumeSnapshotIdList.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdList"));
        }
    }


    #endregion

    } // class DevicePathToVolumeSnapshotIdMap
    
    #endregion

    public static class ListDevicePathToVolumeSnapshotIdMapExtensions
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
            this List<DevicePathToVolumeSnapshotIdMap> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DevicePathToVolumeSnapshotIdMap> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DevicePathToVolumeSnapshotIdMap());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DevicePathToVolumeSnapshotIdMap> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types