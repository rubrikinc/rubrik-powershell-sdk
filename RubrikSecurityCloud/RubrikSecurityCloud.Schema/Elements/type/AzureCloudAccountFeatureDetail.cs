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

        //      C# -> System.String? CustomerFeatureId
        // GraphQL -> customerFeatureId: UUID! (scalar)
        [JsonProperty("customerFeatureId")]
        public System.String? CustomerFeatureId { get; set; }

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

        //      C# -> List<AzureRole>? Roles
        // GraphQL -> roles: [AzureRole!]! (type)
        [JsonProperty("roles")]
        public List<AzureRole>? Roles { get; set; }

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
        System.String? CustomerFeatureId = null,
        PersistentStorage? PersistentStorage = null,
        AzureResourceGroup? ResourceGroup = null,
        AzureRole? Role = null,
        List<AzureRole>? Roles = null,
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
        if ( CustomerFeatureId != null ) {
            this.CustomerFeatureId = CustomerFeatureId;
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
        if ( Roles != null ) {
            this.Roles = Roles;
        }
        if ( UserAssignedManagedIdentity != null ) {
            this.UserAssignedManagedIdentity = UserAssignedManagedIdentity;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        if (this.Regions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regions\n" ;
            } else {
                s += ind + "regions\n" ;
            }
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? CustomerFeatureId
        // GraphQL -> customerFeatureId: UUID! (scalar)
        if (this.CustomerFeatureId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customerFeatureId\n" ;
            } else {
                s += ind + "customerFeatureId\n" ;
            }
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (this.PersistentStorage != null) {
            var fspec = this.PersistentStorage.AsFieldSpec(conf.Child("persistentStorage"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "persistentStorage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureResourceGroup! (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(conf.Child("resourceGroup"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureRole? Role
        // GraphQL -> role: AzureRole! (type)
        if (this.Role != null) {
            var fspec = this.Role.AsFieldSpec(conf.Child("role"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "role" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureRole>? Roles
        // GraphQL -> roles: [AzureRole!]! (type)
        if (this.Roles != null) {
            var fspec = this.Roles.AsFieldSpec(conf.Child("roles"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "roles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
        // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
        if (this.UserAssignedManagedIdentity != null) {
            var fspec = this.UserAssignedManagedIdentity.AsFieldSpec(conf.Child("userAssignedManagedIdentity"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "userAssignedManagedIdentity" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> List<AzureCloudAccountRegion>? Regions
        // GraphQL -> regions: [AzureCloudAccountRegion!]! (enum)
        if (ec.Includes("regions",true))
        {
            if(this.Regions == null) {

                this.Regions = new List<AzureCloudAccountRegion>();

            } else {


            }
        }
        else if (this.Regions != null && ec.Excludes("regions",true))
        {
            this.Regions = null;
        }
        //      C# -> CloudAccountStatus? Status
        // GraphQL -> status: CloudAccountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CloudAccountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? CustomerFeatureId
        // GraphQL -> customerFeatureId: UUID! (scalar)
        if (ec.Includes("customerFeatureId",true))
        {
            if(this.CustomerFeatureId == null) {

                this.CustomerFeatureId = "FETCH";

            } else {


            }
        }
        else if (this.CustomerFeatureId != null && ec.Excludes("customerFeatureId",true))
        {
            this.CustomerFeatureId = null;
        }
        //      C# -> PersistentStorage? PersistentStorage
        // GraphQL -> persistentStorage: PersistentStorage (type)
        if (ec.Includes("persistentStorage",false))
        {
            if(this.PersistentStorage == null) {

                this.PersistentStorage = new PersistentStorage();
                this.PersistentStorage.ApplyExploratoryFieldSpec(ec.NewChild("persistentStorage"));

            } else {

                this.PersistentStorage.ApplyExploratoryFieldSpec(ec.NewChild("persistentStorage"));

            }
        }
        else if (this.PersistentStorage != null && ec.Excludes("persistentStorage",false))
        {
            this.PersistentStorage = null;
        }
        //      C# -> AzureResourceGroup? ResourceGroup
        // GraphQL -> resourceGroup: AzureResourceGroup! (type)
        if (ec.Includes("resourceGroup",false))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = new AzureResourceGroup();
                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            } else {

                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",false))
        {
            this.ResourceGroup = null;
        }
        //      C# -> AzureRole? Role
        // GraphQL -> role: AzureRole! (type)
        if (ec.Includes("role",false))
        {
            if(this.Role == null) {

                this.Role = new AzureRole();
                this.Role.ApplyExploratoryFieldSpec(ec.NewChild("role"));

            } else {

                this.Role.ApplyExploratoryFieldSpec(ec.NewChild("role"));

            }
        }
        else if (this.Role != null && ec.Excludes("role",false))
        {
            this.Role = null;
        }
        //      C# -> List<AzureRole>? Roles
        // GraphQL -> roles: [AzureRole!]! (type)
        if (ec.Includes("roles",false))
        {
            if(this.Roles == null) {

                this.Roles = new List<AzureRole>();
                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            } else {

                this.Roles.ApplyExploratoryFieldSpec(ec.NewChild("roles"));

            }
        }
        else if (this.Roles != null && ec.Excludes("roles",false))
        {
            this.Roles = null;
        }
        //      C# -> AzureUserAssignedManagedIdentity? UserAssignedManagedIdentity
        // GraphQL -> userAssignedManagedIdentity: AzureUserAssignedManagedIdentity (type)
        if (ec.Includes("userAssignedManagedIdentity",false))
        {
            if(this.UserAssignedManagedIdentity == null) {

                this.UserAssignedManagedIdentity = new AzureUserAssignedManagedIdentity();
                this.UserAssignedManagedIdentity.ApplyExploratoryFieldSpec(ec.NewChild("userAssignedManagedIdentity"));

            } else {

                this.UserAssignedManagedIdentity.ApplyExploratoryFieldSpec(ec.NewChild("userAssignedManagedIdentity"));

            }
        }
        else if (this.UserAssignedManagedIdentity != null && ec.Excludes("userAssignedManagedIdentity",false))
        {
            this.UserAssignedManagedIdentity = null;
        }
    }


    #endregion

    } // class AzureCloudAccountFeatureDetail
    
    #endregion

    public static class ListAzureCloudAccountFeatureDetailExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureCloudAccountFeatureDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountFeatureDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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