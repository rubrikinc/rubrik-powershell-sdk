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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureCloudAccountFeatureDetail
    public class AzureCloudAccountFeatureDetail: BaseType
    {
        #region members

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountFeatureDetail";
    }

    public AzureCloudAccountFeatureDetail Set(
        CloudAccountFeature? Feature = null,
        List<AzureCloudAccountRegion>? Regions = null,
        CloudAccountStatus? Status = null,
        PersistentStorage? PersistentStorage = null,
        AzureResourceGroup? ResourceGroup = null,
        AzureRole? Role = null,
        AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( Regions != null ) {
            this.Regions = Regions;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            s += ind + "feature\n" ;
        }
        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        if (this.Regions != null) {
            s += ind + "regions\n" ;
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (this.PersistentStorage != null) {
            var fspec = this.PersistentStorage.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "persistentStorage {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureResourceGroup! (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resourceGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureRole? Role
        // GraphQL -> role: AzureRole! (type)
        if (this.Role != null) {
            var fspec = this.Role.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "role {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
        // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
        if (this.UserAssignedManagedIdentity != null) {
            var fspec = this.UserAssignedManagedIdentity.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "userAssignedManagedIdentity {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature == null && ec.Includes("feature",true))
        {
            this.Feature = new CloudAccountFeature();
        }
        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        if (this.Regions == null && ec.Includes("regions",true))
        {
            this.Regions = new List<AzureCloudAccountRegion>();
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new CloudAccountStatus();
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (this.PersistentStorage == null && ec.Includes("persistentStorage",false))
        {
            this.PersistentStorage = new PersistentStorage();
            this.PersistentStorage.ApplyExploratoryFieldSpec(ec.NewChild("persistentStorage"));
        }
        //      C# -> AzureResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureResourceGroup! (type)
        if (this.ResourceGroup == null && ec.Includes("resourceGroup",false))
        {
            this.ResourceGroup = new AzureResourceGroup();
            this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));
        }
        //      C# -> AzureRole? Role
        // GraphQL -> role: AzureRole! (type)
        if (this.Role == null && ec.Includes("role",false))
        {
            this.Role = new AzureRole();
            this.Role.ApplyExploratoryFieldSpec(ec.NewChild("role"));
        }
        //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
        // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
        if (this.UserAssignedManagedIdentity == null && ec.Includes("userAssignedManagedIdentity",false))
        {
            this.UserAssignedManagedIdentity = new AzureUserAssignedManagedIdentity();
            this.UserAssignedManagedIdentity.ApplyExploratoryFieldSpec(ec.NewChild("userAssignedManagedIdentity"));
        }
    }


    #endregion

    } // class AzureCloudAccountFeatureDetail
    
    #endregion

    public static class ListAzureCloudAccountFeatureDetailExtensions
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
            this List<AzureCloudAccountFeatureDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountFeatureDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountFeatureDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountFeatureDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types