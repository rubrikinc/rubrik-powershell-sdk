// AwsCloudAccountFeatureVersion.cs
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
    #region AwsCloudAccountFeatureVersion
    public class AwsCloudAccountFeatureVersion: IFragment
    {
        #region members
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        #endregion

    #region methods

    public AwsCloudAccountFeatureVersion Set(
        System.Int32? Version = null,
        CloudAccountFeature? Feature = null
    ) 
    {
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Feature != null ) {
            this.Feature = Feature;
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
            //      C# -> System.Int32? Version
            // GraphQL -> version: Int! (scalar)
            if (this.Version != null)
            {
                 s += ind + "version\n";

            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature != null)
            {
                 s += ind + "feature\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Version
            // GraphQL -> version: Int! (scalar)
            if (this.Version == null && Exploration.Includes(parent + ".version$"))
            {
                this.Version = new System.Int32();
            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature == null && Exploration.Includes(parent + ".feature$"))
            {
                this.Feature = new CloudAccountFeature();
            }
        }


    #endregion

    } // class AwsCloudAccountFeatureVersion
    #endregion

    public static class ListAwsCloudAccountFeatureVersionExtensions
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
            this List<AwsCloudAccountFeatureVersion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCloudAccountFeatureVersion> list, 
            String parent = "")
        {
            var item = new AwsCloudAccountFeatureVersion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types