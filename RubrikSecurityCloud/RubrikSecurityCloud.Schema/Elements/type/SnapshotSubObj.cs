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

        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        [JsonProperty("vmwareVmSubObj")]
        public VmwareVmSubObject? VmwareVmSubObj { get; set; }

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
        VmwareVmSubObject? VmwareVmSubObj = null,
        VolumeGroupSubObject? VolumeGroupSubObj = null
    ) 
    {
        if ( VmwareVmSubObj != null ) {
            this.VmwareVmSubObj = VmwareVmSubObj;
        }
        if ( VolumeGroupSubObj != null ) {
            this.VolumeGroupSubObj = VolumeGroupSubObj;
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
        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        if (this.VmwareVmSubObj != null) {
            var fspec = this.VmwareVmSubObj.AsFieldSpec(conf.Child("vmwareVmSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVmSubObj {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (this.VolumeGroupSubObj != null) {
            var fspec = this.VolumeGroupSubObj.AsFieldSpec(conf.Child("volumeGroupSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeGroupSubObj {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        if (ec.Includes("vmwareVmSubObj",false))
        {
            if(this.VmwareVmSubObj == null) {

                this.VmwareVmSubObj = new VmwareVmSubObject();
                this.VmwareVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmSubObj"));

            } else {

                this.VmwareVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmSubObj"));

            }
        }
        else if (this.VmwareVmSubObj != null && ec.Excludes("vmwareVmSubObj",false))
        {
            this.VmwareVmSubObj = null;
        }
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (ec.Includes("volumeGroupSubObj",false))
        {
            if(this.VolumeGroupSubObj == null) {

                this.VolumeGroupSubObj = new VolumeGroupSubObject();
                this.VolumeGroupSubObj.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSubObj"));

            } else {

                this.VolumeGroupSubObj.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSubObj"));

            }
        }
        else if (this.VolumeGroupSubObj != null && ec.Excludes("volumeGroupSubObj",false))
        {
            this.VolumeGroupSubObj = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SnapshotSubObj> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSubObj> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSubObj());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSubObj> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types