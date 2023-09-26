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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isActive\n" ;
            } else {
                s += ind + "isActive\n" ;
            }
        }
        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        if (this.Channels != null) {
            var fspec = this.Channels.AsFieldSpec(conf.Child("channels"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "channels {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(conf.Child("config"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "config {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (ec.Includes("isActive",true))
        {
            if(this.IsActive == null) {

                this.IsActive = true;

            } else {


            }
        }
        else if (this.IsActive != null && ec.Excludes("isActive",true))
        {
            this.IsActive = null;
        }
        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        if (ec.Includes("channels",false))
        {
            if(this.Channels == null) {

                this.Channels = new List<ManagedVolumeChannelConfig>();
                this.Channels.ApplyExploratoryFieldSpec(ec.NewChild("channels"));

            } else {

                this.Channels.ApplyExploratoryFieldSpec(ec.NewChild("channels"));

            }
        }
        else if (this.Channels != null && ec.Excludes("channels",false))
        {
            this.Channels = null;
        }
        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        if (ec.Includes("config",false))
        {
            if(this.Config == null) {

                this.Config = new ManagedVolumeExportConfig();
                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            } else {

                this.Config.ApplyExploratoryFieldSpec(ec.NewChild("config"));

            }
        }
        else if (this.Config != null && ec.Excludes("config",false))
        {
            this.Config = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExport> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedVolumeExport> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types