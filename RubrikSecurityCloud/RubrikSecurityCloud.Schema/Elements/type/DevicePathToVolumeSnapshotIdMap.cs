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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList
        // GraphQL -> devicePathToVolumeSnapshotIdList: [DevicePathToVolumeSnapshotId!]! (type)
        if (this.DevicePathToVolumeSnapshotIdList != null) {
            var fspec = this.DevicePathToVolumeSnapshotIdList.AsFieldSpec(conf.Child("devicePathToVolumeSnapshotIdList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "devicePathToVolumeSnapshotIdList {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DevicePathToVolumeSnapshotId>? DevicePathToVolumeSnapshotIdList
        // GraphQL -> devicePathToVolumeSnapshotIdList: [DevicePathToVolumeSnapshotId!]! (type)
        if (ec.Includes("devicePathToVolumeSnapshotIdList",false))
        {
            if(this.DevicePathToVolumeSnapshotIdList == null) {

                this.DevicePathToVolumeSnapshotIdList = new List<DevicePathToVolumeSnapshotId>();
                this.DevicePathToVolumeSnapshotIdList.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdList"));

            } else {

                this.DevicePathToVolumeSnapshotIdList.ApplyExploratoryFieldSpec(ec.NewChild("devicePathToVolumeSnapshotIdList"));

            }
        }
        else if (this.DevicePathToVolumeSnapshotIdList != null && ec.Excludes("devicePathToVolumeSnapshotIdList",false))
        {
            this.DevicePathToVolumeSnapshotIdList = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DevicePathToVolumeSnapshotIdMap> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<DevicePathToVolumeSnapshotIdMap> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types