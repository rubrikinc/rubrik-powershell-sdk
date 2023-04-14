// CloudAccountFeaturePermission.cs
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
    #region CloudAccountFeaturePermission
    public class CloudAccountFeaturePermission: IFragment
    {
        #region members
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> List<FeaturePermission>? FeaturePermissions
        // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
        [JsonProperty("featurePermissions")]
        public List<FeaturePermission>? FeaturePermissions { get; set; }

        #endregion

    #region methods

    public CloudAccountFeaturePermission Set(
        System.String? CloudAccountId = null,
        List<FeaturePermission>? FeaturePermissions = null
    ) 
    {
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( FeaturePermissions != null ) {
            this.FeaturePermissions = FeaturePermissions;
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
            //      C# -> System.String? CloudAccountId
            // GraphQL -> cloudAccountId: String! (scalar)
            if (this.CloudAccountId != null)
            {
                 s += ind + "cloudAccountId\n";

            }
            //      C# -> List<FeaturePermission>? FeaturePermissions
            // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
            if (this.FeaturePermissions != null)
            {
                 s += ind + "featurePermissions\n";

                 s += ind + "{\n" + 
                 this.FeaturePermissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CloudAccountId
            // GraphQL -> cloudAccountId: String! (scalar)
            if (this.CloudAccountId == null && Exploration.Includes(parent + ".cloudAccountId$"))
            {
                this.CloudAccountId = new System.String("FETCH");
            }
            //      C# -> List<FeaturePermission>? FeaturePermissions
            // GraphQL -> featurePermissions: [FeaturePermission!]! (type)
            if (this.FeaturePermissions == null && Exploration.Includes(parent + ".featurePermissions"))
            {
                this.FeaturePermissions = new List<FeaturePermission>();
                this.FeaturePermissions.ApplyExploratoryFragment(parent + ".featurePermissions");
            }
        }


    #endregion

    } // class CloudAccountFeaturePermission
    #endregion

    public static class ListCloudAccountFeaturePermissionExtensions
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
            this List<CloudAccountFeaturePermission> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CloudAccountFeaturePermission> list, 
            String parent = "")
        {
            var item = new CloudAccountFeaturePermission();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types