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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configFileInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<HypervVirtualDiskInfo>? VirtualDiskInfo
        // GraphQL -> virtualDiskInfo: [HypervVirtualDiskInfo!]! (type)
        if (this.VirtualDiskInfo != null) {
            var fspec = this.VirtualDiskInfo.AsFieldSpec(conf.Child("virtualDiskInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "virtualDiskInfo" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HypervVirtualMachineSnapshotFileDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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