// HypervVirtualMachineSnapshotFileDetails.cs
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
    #region HypervVirtualMachineSnapshotFileDetails
    public class HypervVirtualMachineSnapshotFileDetails: BaseType
    {
        #region members

        //      C# -> List<HypervConfigurationFileInfo>? ConfigFileInfo
        // GraphQL -> configFileInfo: [HypervConfigurationFileInfo!]! (type)
        [JsonProperty("configFileInfo")]
        public List<HypervConfigurationFileInfo>? ConfigFileInfo { get; set; }

        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        [JsonProperty("virtualDiskInfo")]
        public List<HypervVirtualDiskInfo>? VirtualDiskInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervVirtualMachineSnapshotFileDetails";
    }

    public HypervVirtualMachineSnapshotFileDetails Set(
        List<HypervConfigurationFileInfo>? ConfigFileInfo = null,
        List<HypervVirtualDiskInfo>? VirtualDiskInfo = null
    ) 
    {
        if ( ConfigFileInfo != null ) {
            this.ConfigFileInfo = ConfigFileInfo;
        }
        if ( VirtualDiskInfo != null ) {
            this.VirtualDiskInfo = VirtualDiskInfo;
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
        //      C# -> List<HypervConfigurationFileInfo>? ConfigFileInfo
        // GraphQL -> configFileInfo: [HypervConfigurationFileInfo!]! (type)
        if (this.ConfigFileInfo != null) {
            var fspec = this.ConfigFileInfo.AsFieldSpec(conf.Child("configFileInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configFileInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (this.VirtualDiskInfo != null) {
            var fspec = this.VirtualDiskInfo.AsFieldSpec(conf.Child("virtualDiskInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualDiskInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HypervConfigurationFileInfo>? ConfigFileInfo
        // GraphQL -> configFileInfo: [HypervConfigurationFileInfo!]! (type)
        if (ec.Includes("configFileInfo",false))
        {
            if(this.ConfigFileInfo == null) {

                this.ConfigFileInfo = new List<HypervConfigurationFileInfo>();
                this.ConfigFileInfo.ApplyExploratoryFieldSpec(ec.NewChild("configFileInfo"));

            } else {

                this.ConfigFileInfo.ApplyExploratoryFieldSpec(ec.NewChild("configFileInfo"));

            }
        }
        else if (this.ConfigFileInfo != null && ec.Excludes("configFileInfo",false))
        {
            this.ConfigFileInfo = null;
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (ec.Includes("virtualDiskInfo",false))
        {
            if(this.VirtualDiskInfo == null) {

                this.VirtualDiskInfo = new List<HypervVirtualDiskInfo>();
                this.VirtualDiskInfo.ApplyExploratoryFieldSpec(ec.NewChild("virtualDiskInfo"));

            } else {

                this.VirtualDiskInfo.ApplyExploratoryFieldSpec(ec.NewChild("virtualDiskInfo"));

            }
        }
        else if (this.VirtualDiskInfo != null && ec.Excludes("virtualDiskInfo",false))
        {
            this.VirtualDiskInfo = null;
        }
    }


    #endregion

    } // class HypervVirtualMachineSnapshotFileDetails
    
    #endregion

    public static class ListHypervVirtualMachineSnapshotFileDetailsExtensions
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
            this List<HypervVirtualMachineSnapshotFileDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HypervVirtualMachineSnapshotFileDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervVirtualMachineSnapshotFileDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervVirtualMachineSnapshotFileDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervVirtualMachineSnapshotFileDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types