// ManagedVolumeExportConfig.cs
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
    #region ManagedVolumeExportConfig
    public class ManagedVolumeExportConfig: BaseType
    {
        #region members

        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        [JsonProperty("shareType")]
        public ManagedVolumeShareType? ShareType { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        [JsonProperty("managedVolumePatchConfig")]
        public ManagedVolumePatchConfig? ManagedVolumePatchConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedVolumeExportConfig";
    }

    public ManagedVolumeExportConfig Set(
        ManagedVolumeShareType? ShareType = null,
        System.String? Subnet = null,
        ManagedVolumePatchConfig? ManagedVolumePatchConfig = null
    ) 
    {
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( ManagedVolumePatchConfig != null ) {
            this.ManagedVolumePatchConfig = ManagedVolumePatchConfig;
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
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        if (this.ShareType != null) {
            s += ind + "shareType\n" ;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet != null) {
            s += ind + "subnet\n" ;
        }
        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        if (this.ManagedVolumePatchConfig != null) {
            var fspec = this.ManagedVolumePatchConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "managedVolumePatchConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        if (this.ShareType == null && ec.Includes("shareType",true))
        {
            this.ShareType = new ManagedVolumeShareType();
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet == null && ec.Includes("subnet",true))
        {
            this.Subnet = "FETCH";
        }
        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        if (this.ManagedVolumePatchConfig == null && ec.Includes("managedVolumePatchConfig",false))
        {
            this.ManagedVolumePatchConfig = new ManagedVolumePatchConfig();
            this.ManagedVolumePatchConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumePatchConfig"));
        }
    }


    #endregion

    } // class ManagedVolumeExportConfig
    
    #endregion

    public static class ListManagedVolumeExportConfigExtensions
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
            this List<ManagedVolumeExportConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeExportConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeExportConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ManagedVolumeExportConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types