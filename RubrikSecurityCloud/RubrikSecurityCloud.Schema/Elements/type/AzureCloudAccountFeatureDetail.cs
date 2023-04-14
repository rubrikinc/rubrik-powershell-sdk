// AzureCloudAccountFeatureDetail.cs
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
    #region AzureCloudAccountFeatureDetail
    public class AzureCloudAccountFeatureDetail: IFragment
    {
        #region members
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        [JsonProperty("persistentStorage")]
        public PersistentStorage? PersistentStorage { get; set; }

        //      C# -> AzureResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureResourceGroup! (type)
        [JsonProperty("resourceGroup")]
        public AzureResourceGroup? ResourceGroup { get; set; }

        //      C# -> AzureRole? Role
        // GraphQL -> role: AzureRole! (type)
        [JsonProperty("role")]
        public AzureRole? Role { get; set; }

        //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
        // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
        [JsonProperty("userAssignedManagedIdentity")]
        public AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        [JsonProperty("regions")]
        public List<AzureCloudAccountRegion>? Regions { get; set; }

        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        [JsonProperty("status")]
        public CloudAccountStatus? Status { get; set; }

        #endregion

    #region methods

    public AzureCloudAccountFeatureDetail Set(
        PersistentStorage? PersistentStorage = null,
        AzureResourceGroup? ResourceGroup = null,
        AzureRole? Role = null,
        AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity = null,
        CloudAccountFeature? Feature = null,
        List<AzureCloudAccountRegion>? Regions = null,
        CloudAccountStatus? Status = null
    ) 
    {
        if ( PersistentStorage != null ) {
            this.PersistentStorage = PersistentStorage;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( UserAssignedManagedIdentity != null ) {
            this.UserAssignedManagedIdentity = UserAssignedManagedIdentity;
        }
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Regions != null ) {
            this.Regions = Regions;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> PersistentStorage? PersistentStorage
            // GraphQL -> persistentStorage: PersistentStorage (type)
            if (this.PersistentStorage != null)
            {
                 s += ind + "persistentStorage\n";

                 s += ind + "{\n" + 
                 this.PersistentStorage.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: AzureResourceGroup! (type)
            if (this.ResourceGroup != null)
            {
                 s += ind + "resourceGroup\n";

                 s += ind + "{\n" + 
                 this.ResourceGroup.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureRole? Role
            // GraphQL -> role: AzureRole! (type)
            if (this.Role != null)
            {
                 s += ind + "role\n";

                 s += ind + "{\n" + 
                 this.Role.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
            // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
            if (this.UserAssignedManagedIdentity != null)
            {
                 s += ind + "userAssignedManagedIdentity\n";

                 s += ind + "{\n" + 
                 this.UserAssignedManagedIdentity.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature != null)
            {
                 s += ind + "feature\n";

            }
            //      C# -> List<AzureCloudAccountRegion>? Regions
            // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
            if (this.Regions != null)
            {
                 s += ind + "regions\n";

            }
            //      C# -> CloudAccountStatus? Status
            // GraphQL -> status: CloudAccountStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> PersistentStorage? PersistentStorage
            // GraphQL -> persistentStorage: PersistentStorage (type)
            if (this.PersistentStorage == null && Exploration.Includes(parent + ".persistentStorage"))
            {
                this.PersistentStorage = new PersistentStorage();
                this.PersistentStorage.ApplyExploratoryFragment(parent + ".persistentStorage");
            }
            //      C# -> AzureResourceGroup? ResourceGroup
            // GraphQL -> resourceGroup: AzureResourceGroup! (type)
            if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
            {
                this.ResourceGroup = new AzureResourceGroup();
                this.ResourceGroup.ApplyExploratoryFragment(parent + ".resourceGroup");
            }
            //      C# -> AzureRole? Role
            // GraphQL -> role: AzureRole! (type)
            if (this.Role == null && Exploration.Includes(parent + ".role"))
            {
                this.Role = new AzureRole();
                this.Role.ApplyExploratoryFragment(parent + ".role");
            }
            //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
            // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
            if (this.UserAssignedManagedIdentity == null && Exploration.Includes(parent + ".userAssignedManagedIdentity"))
            {
                this.UserAssignedManagedIdentity = new AzureUserAssignedManagedIdentity();
                this.UserAssignedManagedIdentity.ApplyExploratoryFragment(parent + ".userAssignedManagedIdentity");
            }
            //      C# -> CloudAccountFeature? Feature
            // GraphQL -> feature: CloudAccountFeature! (enum)
            if (this.Feature == null && Exploration.Includes(parent + ".feature$"))
            {
                this.Feature = new CloudAccountFeature();
            }
            //      C# -> List<AzureCloudAccountRegion>? Regions
            // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
            if (this.Regions == null && Exploration.Includes(parent + ".regions$"))
            {
                this.Regions = new List<AzureCloudAccountRegion>();
            }
            //      C# -> CloudAccountStatus? Status
            // GraphQL -> status: CloudAccountStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new CloudAccountStatus();
            }
        }


    #endregion

    } // class AzureCloudAccountFeatureDetail
    #endregion

    public static class ListAzureCloudAccountFeatureDetailExtensions
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
            this List<AzureCloudAccountFeatureDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureCloudAccountFeatureDetail> list, 
            String parent = "")
        {
            var item = new AzureCloudAccountFeatureDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types