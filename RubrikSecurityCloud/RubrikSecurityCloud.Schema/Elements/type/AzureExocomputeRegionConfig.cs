// AzureExocomputeRegionConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    #region AzureExocomputeRegionConfig
    public class AzureExocomputeRegionConfig: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String! (scalar)
        [JsonProperty("podSubnetNativeId")]
        public System.String? PodSubnetNativeId { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        #endregion

    #region methods

    public AzureExocomputeRegionConfig Set(
        System.Boolean? IsRscManaged = null,
        System.String? PodSubnetNativeId = null,
        System.String? SubnetNativeId = null,
        AzureCloudAccountRegion? Region = null
    ) 
    {
        if ( IsRscManaged != null ) {
            this.IsRscManaged = IsRscManaged;
        }
        if ( PodSubnetNativeId != null ) {
            this.PodSubnetNativeId = PodSubnetNativeId;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
        }
        if ( Region != null ) {
            this.Region = Region;
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
            //      C# -> System.Boolean? IsRscManaged
            // GraphQL -> isRscManaged: Boolean! (scalar)
            if (this.IsRscManaged != null)
            {
                 s += ind + "isRscManaged\n";

            }
            //      C# -> System.String? PodSubnetNativeId
            // GraphQL -> podSubnetNativeId: String! (scalar)
            if (this.PodSubnetNativeId != null)
            {
                 s += ind + "podSubnetNativeId\n";

            }
            //      C# -> System.String? SubnetNativeId
            // GraphQL -> subnetNativeId: String! (scalar)
            if (this.SubnetNativeId != null)
            {
                 s += ind + "subnetNativeId\n";

            }
            //      C# -> AzureCloudAccountRegion? Region
            // GraphQL -> region: AzureCloudAccountRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsRscManaged
            // GraphQL -> isRscManaged: Boolean! (scalar)
            if (this.IsRscManaged == null && Exploration.Includes(parent + ".isRscManaged$"))
            {
                this.IsRscManaged = new System.Boolean();
            }
            //      C# -> System.String? PodSubnetNativeId
            // GraphQL -> podSubnetNativeId: String! (scalar)
            if (this.PodSubnetNativeId == null && Exploration.Includes(parent + ".podSubnetNativeId$"))
            {
                this.PodSubnetNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? SubnetNativeId
            // GraphQL -> subnetNativeId: String! (scalar)
            if (this.SubnetNativeId == null && Exploration.Includes(parent + ".subnetNativeId$"))
            {
                this.SubnetNativeId = new System.String("FETCH");
            }
            //      C# -> AzureCloudAccountRegion? Region
            // GraphQL -> region: AzureCloudAccountRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AzureCloudAccountRegion();
            }
        }


    #endregion

    } // class AzureExocomputeRegionConfig
    #endregion

    public static class ListAzureExocomputeRegionConfigExtensions
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
            this List<AzureExocomputeRegionConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureExocomputeRegionConfig> list, 
            String parent = "")
        {
            var item = new AzureExocomputeRegionConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types