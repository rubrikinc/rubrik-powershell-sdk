// CloudNativeRegion.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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
    #region CloudNativeRegion
    public class CloudNativeRegion: IFragment
    {
        #region members
        //      C# -> GcpNativeRegion? GcpRegion
        // GraphQL -> gcpRegion: GcpNativeRegion (type)
        [JsonProperty("gcpRegion")]
        public GcpNativeRegion? GcpRegion { get; set; }

        //      C# -> AwsNativeRegion? AwsRegion
        // GraphQL -> awsRegion: AwsNativeRegion (enum)
        [JsonProperty("awsRegion")]
        public AwsNativeRegion? AwsRegion { get; set; }

        //      C# -> AzureNativeRegion? AzureRegion
        // GraphQL -> azureRegion: AzureNativeRegion (enum)
        [JsonProperty("azureRegion")]
        public AzureNativeRegion? AzureRegion { get; set; }

        #endregion

    #region methods

    public CloudNativeRegion Set(
        GcpNativeRegion? GcpRegion = null,
        AwsNativeRegion? AwsRegion = null,
        AzureNativeRegion? AzureRegion = null
    ) 
    {
        if ( GcpRegion != null ) {
            this.GcpRegion = GcpRegion;
        }
        if ( AwsRegion != null ) {
            this.AwsRegion = AwsRegion;
        }
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
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
            //      C# -> GcpNativeRegion? GcpRegion
            // GraphQL -> gcpRegion: GcpNativeRegion (type)
            if (this.GcpRegion != null)
            {
                 s += ind + "gcpRegion\n";

                 s += ind + "{\n" + 
                 this.GcpRegion.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsNativeRegion? AwsRegion
            // GraphQL -> awsRegion: AwsNativeRegion (enum)
            if (this.AwsRegion != null)
            {
                 s += ind + "awsRegion\n";

            }
            //      C# -> AzureNativeRegion? AzureRegion
            // GraphQL -> azureRegion: AzureNativeRegion (enum)
            if (this.AzureRegion != null)
            {
                 s += ind + "azureRegion\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> GcpNativeRegion? GcpRegion
            // GraphQL -> gcpRegion: GcpNativeRegion (type)
            if (this.GcpRegion == null && Exploration.Includes(parent + ".gcpRegion"))
            {
                this.GcpRegion = new GcpNativeRegion();
                this.GcpRegion.ApplyExploratoryFragment(parent + ".gcpRegion");
            }
            //      C# -> AwsNativeRegion? AwsRegion
            // GraphQL -> awsRegion: AwsNativeRegion (enum)
            if (this.AwsRegion == null && Exploration.Includes(parent + ".awsRegion$"))
            {
                this.AwsRegion = new AwsNativeRegion();
            }
            //      C# -> AzureNativeRegion? AzureRegion
            // GraphQL -> azureRegion: AzureNativeRegion (enum)
            if (this.AzureRegion == null && Exploration.Includes(parent + ".azureRegion$"))
            {
                this.AzureRegion = new AzureNativeRegion();
            }
        }


    #endregion

    } // class CloudNativeRegion
    #endregion

    public static class ListCloudNativeRegionExtensions
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
            this List<CloudNativeRegion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudNativeRegion> list, 
            String parent = "")
        {
            var item = new CloudNativeRegion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types