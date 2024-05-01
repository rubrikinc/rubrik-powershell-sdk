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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnet\n" ;
            } else {
                s += ind + "subnet\n" ;
            }
        }
        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        if (this.ManagedVolumePatchConfig != null) {
            var fspec = this.ManagedVolumePatchConfig.AsFieldSpec(conf.Child("managedVolumePatchConfig"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumePatchConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = new ManagedVolumeShareType();

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (ec.Includes("subnet",true))
        {
            if(this.Subnet == null) {

                this.Subnet = "FETCH";

            } else {


            }
        }
        else if (this.Subnet != null && ec.Excludes("subnet",true))
        {
            this.Subnet = null;
        }
        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        if (ec.Includes("managedVolumePatchConfig",false))
        {
            if(this.ManagedVolumePatchConfig == null) {

                this.ManagedVolumePatchConfig = new ManagedVolumePatchConfig();
                this.ManagedVolumePatchConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumePatchConfig"));

            } else {

                this.ManagedVolumePatchConfig.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumePatchConfig"));

            }
        }
        else if (this.ManagedVolumePatchConfig != null && ec.Excludes("managedVolumePatchConfig",false))
        {
            this.ManagedVolumePatchConfig = null;
        }
    }


    #endregion

    } // class ManagedVolumeExportConfig
    
    #endregion

    public static class ListManagedVolumeExportConfigExtensions
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
            this List<ManagedVolumeExportConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedVolumeExportConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<ManagedVolumeExportConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types