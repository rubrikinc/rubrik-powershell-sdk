// ManagedVolumeExport.cs
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
    #region ManagedVolumeExport
    public class ManagedVolumeExport: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        [JsonProperty("channels")]
        public List<ManagedVolumeChannelConfig>? Channels { get; set; }

        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        [JsonProperty("config")]
        public ManagedVolumeExportConfig? Config { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeExport";
    }

    public ManagedVolumeExport Set(
        System.Boolean? IsActive = null,
        List<ManagedVolumeChannelConfig>? Channels = null,
        ManagedVolumeExportConfig? Config = null
    ) 
    {
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( Channels != null ) {
            this.Channels = Channels;
        }
        if ( Config != null ) {
            this.Config = Config;
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
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            s += ind + "isActive\n" ;
        }
        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        if (this.Channels != null) {
            var fspec = this.Channels.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "channels {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "config {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive == null && Exploration.Includes(parent + ".isActive", true))
        {
            this.IsActive = true;
        }
        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        if (this.Channels == null && Exploration.Includes(parent + ".channels"))
        {
            this.Channels = new List<ManagedVolumeChannelConfig>();
            this.Channels.ApplyExploratoryFieldSpec(parent + ".channels");
        }
        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        if (this.Config == null && Exploration.Includes(parent + ".config"))
        {
            this.Config = new ManagedVolumeExportConfig();
            this.Config.ApplyExploratoryFieldSpec(parent + ".config");
        }
    }


    #endregion

    } // class ManagedVolumeExport
    
    #endregion

    public static class ListManagedVolumeExportExtensions
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
            this List<ManagedVolumeExport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExport> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExport());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types