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

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolumeExportConfig
    public class ManagedVolumeExportConfig: IFragment
    {
        #region members
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
        // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
        [JsonProperty("managedVolumePatchConfig")]
        public ManagedVolumePatchConfig? ManagedVolumePatchConfig { get; set; }

        //      C# -> ManagedVolumeShareType? ShareType
        // GraphQL -> shareType: ManagedVolumeShareType (enum)
        [JsonProperty("shareType")]
        public ManagedVolumeShareType? ShareType { get; set; }

        #endregion

    #region methods

    public ManagedVolumeExportConfig Set(
        System.String? Subnet = null,
        ManagedVolumePatchConfig? ManagedVolumePatchConfig = null,
        ManagedVolumeShareType? ShareType = null
    ) 
    {
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( ManagedVolumePatchConfig != null ) {
            this.ManagedVolumePatchConfig = ManagedVolumePatchConfig;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet != null)
            {
                 s += ind + "subnet\n";

            }
            //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
            // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
            if (this.ManagedVolumePatchConfig != null)
            {
                 s += ind + "managedVolumePatchConfig\n";

                 s += ind + "{\n" + 
                 this.ManagedVolumePatchConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeShareType? ShareType
            // GraphQL -> shareType: ManagedVolumeShareType (enum)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet == null && Exploration.Includes(parent + ".subnet$"))
            {
                this.Subnet = new System.String("FETCH");
            }
            //      C# -> ManagedVolumePatchConfig? ManagedVolumePatchConfig
            // GraphQL -> managedVolumePatchConfig: ManagedVolumePatchConfig (type)
            if (this.ManagedVolumePatchConfig == null && Exploration.Includes(parent + ".managedVolumePatchConfig"))
            {
                this.ManagedVolumePatchConfig = new ManagedVolumePatchConfig();
                this.ManagedVolumePatchConfig.ApplyExploratoryFragment(parent + ".managedVolumePatchConfig");
            }
            //      C# -> ManagedVolumeShareType? ShareType
            // GraphQL -> shareType: ManagedVolumeShareType (enum)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new ManagedVolumeShareType();
            }
        }


    #endregion

    } // class ManagedVolumeExportConfig
    #endregion

    public static class ListManagedVolumeExportConfigExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ManagedVolumeExportConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeExportConfig> list, 
            String parent = "")
        {
            var item = new ManagedVolumeExportConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types