// AzureAdObjects.cs
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
    #region AzureAdObjects
    public class AzureAdObjects: BaseType
    {
        #region members

        //      C# -> AzureAdAccessReviewScheduleDefinition? AzureAdAccessReviewScheduleDefinition
        // GraphQL -> azureAdAccessReviewScheduleDefinition: AzureAdAccessReviewScheduleDefinition (type)
        [JsonProperty("azureAdAccessReviewScheduleDefinition")]
        public AzureAdAccessReviewScheduleDefinition? AzureAdAccessReviewScheduleDefinition { get; set; }

        //      C# -> AzureAdAdministrativeUnit? AzureAdAdministrativeUnit
        // GraphQL -> azureAdAdministrativeUnit: AzureAdAdministrativeUnit (type)
        [JsonProperty("azureAdAdministrativeUnit")]
        public AzureAdAdministrativeUnit? AzureAdAdministrativeUnit { get; set; }

        //      C# -> AzureAdAppRoleAssignment? AzureAdAppRoleAssignment
        // GraphQL -> azureAdAppRoleAssignment: AzureAdAppRoleAssignment (type)
        [JsonProperty("azureAdAppRoleAssignment")]
        public AzureAdAppRoleAssignment? AzureAdAppRoleAssignment { get; set; }

        //      C# -> AzureAdApplication? AzureAdApplication
        // GraphQL -> azureAdApplication: AzureAdApplication (type)
        [JsonProperty("azureAdApplication")]
        public AzureAdApplication? AzureAdApplication { get; set; }

        //      C# -> AzureAdAuthenticationContext? AzureAdAuthenticationContext
        // GraphQL -> azureAdAuthenticationContext: AzureAdAuthenticationContext (type)
        [JsonProperty("azureAdAuthenticationContext")]
        public AzureAdAuthenticationContext? AzureAdAuthenticationContext { get; set; }

        //      C# -> AzureAdAuthenticationStrength? AzureAdAuthenticationStrength
        // GraphQL -> azureAdAuthenticationStrength: AzureAdAuthenticationStrength (type)
        [JsonProperty("azureAdAuthenticationStrength")]
        public AzureAdAuthenticationStrength? AzureAdAuthenticationStrength { get; set; }

        //      C# -> AzureAdBitLockerKey? AzureAdBitLockerKey
        // GraphQL -> azureAdBitLockerKey: AzureAdBitLockerKey (type)
        [JsonProperty("azureAdBitLockerKey")]
        public AzureAdBitLockerKey? AzureAdBitLockerKey { get; set; }

        //      C# -> AzureAdConditionalAccessPolicy? AzureAdConditionalAccessPolicy
        // GraphQL -> azureAdConditionalAccessPolicy: AzureAdConditionalAccessPolicy (type)
        [JsonProperty("azureAdConditionalAccessPolicy")]
        public AzureAdConditionalAccessPolicy? AzureAdConditionalAccessPolicy { get; set; }

        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        [JsonProperty("azureAdDevice")]
        public AzureAdDevice? AzureAdDevice { get; set; }

        //      C# -> AzureAdEmAccessPackage? AzureAdEmAccessPackage
        // GraphQL -> azureAdEmAccessPackage: AzureAdEmAccessPackage (type)
        [JsonProperty("azureAdEmAccessPackage")]
        public AzureAdEmAccessPackage? AzureAdEmAccessPackage { get; set; }

        //      C# -> AzureAdEmAssignment? AzureAdEmAssignment
        // GraphQL -> azureAdEmAssignment: AzureAdEmAssignment (type)
        [JsonProperty("azureAdEmAssignment")]
        public AzureAdEmAssignment? AzureAdEmAssignment { get; set; }

        //      C# -> AzureAdEmAssignmentPolicy? AzureAdEmAssignmentPolicy
        // GraphQL -> azureAdEmAssignmentPolicy: AzureAdEmAssignmentPolicy (type)
        [JsonProperty("azureAdEmAssignmentPolicy")]
        public AzureAdEmAssignmentPolicy? AzureAdEmAssignmentPolicy { get; set; }

        //      C# -> AzureAdEmCatalog? AzureAdEmCatalog
        // GraphQL -> azureAdEmCatalog: AzureAdEmCatalog (type)
        [JsonProperty("azureAdEmCatalog")]
        public AzureAdEmCatalog? AzureAdEmCatalog { get; set; }

        //      C# -> AzureAdEmCatalogResource? AzureAdEmCatalogResource
        // GraphQL -> azureAdEmCatalogResource: AzureAdEmCatalogResource (type)
        [JsonProperty("azureAdEmCatalogResource")]
        public AzureAdEmCatalogResource? AzureAdEmCatalogResource { get; set; }

        //      C# -> AzureAdEmCatalogRoleAssignment? AzureAdEmCatalogRoleAssignment
        // GraphQL -> azureAdEmCatalogRoleAssignment: AzureAdEmCatalogRoleAssignment (type)
        [JsonProperty("azureAdEmCatalogRoleAssignment")]
        public AzureAdEmCatalogRoleAssignment? AzureAdEmCatalogRoleAssignment { get; set; }

        //      C# -> AzureAdEmIncompatibilities? AzureAdEmIncompatibilities
        // GraphQL -> azureAdEmIncompatibilities: AzureAdEmIncompatibilities (type)
        [JsonProperty("azureAdEmIncompatibilities")]
        public AzureAdEmIncompatibilities? AzureAdEmIncompatibilities { get; set; }

        //      C# -> AzureAdEmResourceRoleScope? AzureAdEmResourceRoleScope
        // GraphQL -> azureAdEmResourceRoleScope: AzureAdEmResourceRoleScope (type)
        [JsonProperty("azureAdEmResourceRoleScope")]
        public AzureAdEmResourceRoleScope? AzureAdEmResourceRoleScope { get; set; }

        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        [JsonProperty("azureAdGroup")]
        public AzureAdGroup? AzureAdGroup { get; set; }

        //      C# -> AzureAdGroupActiveAssignment? AzureAdGroupActiveAssignment
        // GraphQL -> azureAdGroupActiveAssignment: AzureAdGroupActiveAssignment (type)
        [JsonProperty("azureAdGroupActiveAssignment")]
        public AzureAdGroupActiveAssignment? AzureAdGroupActiveAssignment { get; set; }

        //      C# -> AzureAdGroupEligibleAssignment? AzureAdGroupEligibleAssignment
        // GraphQL -> azureAdGroupEligibleAssignment: AzureAdGroupEligibleAssignment (type)
        [JsonProperty("azureAdGroupEligibleAssignment")]
        public AzureAdGroupEligibleAssignment? AzureAdGroupEligibleAssignment { get; set; }

        //      C# -> AzureAdLocalAdminPassword? AzureAdLocalAdminPassword
        // GraphQL -> azureAdLocalAdminPassword: AzureAdLocalAdminPassword (type)
        [JsonProperty("azureAdLocalAdminPassword")]
        public AzureAdLocalAdminPassword? AzureAdLocalAdminPassword { get; set; }

        //      C# -> AzureAdNamedLocation? AzureAdNamedLocation
        // GraphQL -> azureAdNamedLocation: AzureAdNamedLocation (type)
        [JsonProperty("azureAdNamedLocation")]
        public AzureAdNamedLocation? AzureAdNamedLocation { get; set; }

        //      C# -> AzureAdRole? AzureAdRole
        // GraphQL -> azureAdRole: AzureAdRole (type)
        [JsonProperty("azureAdRole")]
        public AzureAdRole? AzureAdRole { get; set; }

        //      C# -> AzureAdRoleAssignment? AzureAdRoleAssignment
        // GraphQL -> azureAdRoleAssignment: AzureAdRoleAssignment (type)
        [JsonProperty("azureAdRoleAssignment")]
        public AzureAdRoleAssignment? AzureAdRoleAssignment { get; set; }

        //      C# -> AzureAdRoleEligibleAssignment? AzureAdRoleEligibleAssignment
        // GraphQL -> azureAdRoleEligibleAssignment: AzureAdRoleEligibleAssignment (type)
        [JsonProperty("azureAdRoleEligibleAssignment")]
        public AzureAdRoleEligibleAssignment? AzureAdRoleEligibleAssignment { get; set; }

        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        [JsonProperty("azureAdServicePrincipal")]
        public AzureAdServicePrincipal? AzureAdServicePrincipal { get; set; }

        //      C# -> AzureAdTermsOfUse? AzureAdTermsOfUse
        // GraphQL -> azureAdTermsOfUse: AzureAdTermsOfUse (type)
        [JsonProperty("azureAdTermsOfUse")]
        public AzureAdTermsOfUse? AzureAdTermsOfUse { get; set; }

        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        [JsonProperty("azureAdUser")]
        public AzureAdUser? AzureAdUser { get; set; }

        //      C# -> IntuneAppProtectionPolicy? IntuneAppProtectionPolicy
        // GraphQL -> intuneAppProtectionPolicy: IntuneAppProtectionPolicy (type)
        [JsonProperty("intuneAppProtectionPolicy")]
        public IntuneAppProtectionPolicy? IntuneAppProtectionPolicy { get; set; }

        //      C# -> IntuneAssignmentFilter? IntuneAssignmentFilter
        // GraphQL -> intuneAssignmentFilter: IntuneAssignmentFilter (type)
        [JsonProperty("intuneAssignmentFilter")]
        public IntuneAssignmentFilter? IntuneAssignmentFilter { get; set; }

        //      C# -> IntuneAutopilotDeploymentProfile? IntuneAutopilotDeploymentProfile
        // GraphQL -> intuneAutopilotDeploymentProfile: IntuneAutopilotDeploymentProfile (type)
        [JsonProperty("intuneAutopilotDeploymentProfile")]
        public IntuneAutopilotDeploymentProfile? IntuneAutopilotDeploymentProfile { get; set; }

        //      C# -> IntuneCompliancePolicy? IntuneCompliancePolicy
        // GraphQL -> intuneCompliancePolicy: IntuneCompliancePolicy (type)
        [JsonProperty("intuneCompliancePolicy")]
        public IntuneCompliancePolicy? IntuneCompliancePolicy { get; set; }

        //      C# -> IntuneCompliancePolicyAction? IntuneCompliancePolicyAction
        // GraphQL -> intuneCompliancePolicyAction: IntuneCompliancePolicyAction (type)
        [JsonProperty("intuneCompliancePolicyAction")]
        public IntuneCompliancePolicyAction? IntuneCompliancePolicyAction { get; set; }

        //      C# -> IntuneCompliancePolicyAssignment? IntuneCompliancePolicyAssignment
        // GraphQL -> intuneCompliancePolicyAssignment: IntuneCompliancePolicyAssignment (type)
        [JsonProperty("intuneCompliancePolicyAssignment")]
        public IntuneCompliancePolicyAssignment? IntuneCompliancePolicyAssignment { get; set; }

        //      C# -> IntuneComplianceScript? IntuneComplianceScript
        // GraphQL -> intuneComplianceScript: IntuneComplianceScript (type)
        [JsonProperty("intuneComplianceScript")]
        public IntuneComplianceScript? IntuneComplianceScript { get; set; }

        //      C# -> IntuneDeviceManagementPolicy? IntuneDeviceManagementPolicy
        // GraphQL -> intuneDeviceManagementPolicy: IntuneDeviceManagementPolicy (type)
        [JsonProperty("intuneDeviceManagementPolicy")]
        public IntuneDeviceManagementPolicy? IntuneDeviceManagementPolicy { get; set; }

        //      C# -> IntuneEndpointSecurityReusableSetting? IntuneEndpointSecurityReusableSetting
        // GraphQL -> intuneEndpointSecurityReusableSetting: IntuneEndpointSecurityReusableSetting (type)
        [JsonProperty("intuneEndpointSecurityReusableSetting")]
        public IntuneEndpointSecurityReusableSetting? IntuneEndpointSecurityReusableSetting { get; set; }

        //      C# -> IntuneNotificationTemplate? IntuneNotificationTemplate
        // GraphQL -> intuneNotificationTemplate: IntuneNotificationTemplate (type)
        [JsonProperty("intuneNotificationTemplate")]
        public IntuneNotificationTemplate? IntuneNotificationTemplate { get; set; }

        //      C# -> IntunePolicyAssignment? IntunePolicyAssignment
        // GraphQL -> intunePolicyAssignment: IntunePolicyAssignment (type)
        [JsonProperty("intunePolicyAssignment")]
        public IntunePolicyAssignment? IntunePolicyAssignment { get; set; }

        //      C# -> IntuneRoleAssignment? IntuneRoleAssignment
        // GraphQL -> intuneRoleAssignment: IntuneRoleAssignment (type)
        [JsonProperty("intuneRoleAssignment")]
        public IntuneRoleAssignment? IntuneRoleAssignment { get; set; }

        //      C# -> IntuneRoleDefinition? IntuneRoleDefinition
        // GraphQL -> intuneRoleDefinition: IntuneRoleDefinition (type)
        [JsonProperty("intuneRoleDefinition")]
        public IntuneRoleDefinition? IntuneRoleDefinition { get; set; }

        //      C# -> IntuneScopeTag? IntuneScopeTag
        // GraphQL -> intuneScopeTag: IntuneScopeTag (type)
        [JsonProperty("intuneScopeTag")]
        public IntuneScopeTag? IntuneScopeTag { get; set; }

        //      C# -> IntuneScopeTagAssignment? IntuneScopeTagAssignment
        // GraphQL -> intuneScopeTagAssignment: IntuneScopeTagAssignment (type)
        [JsonProperty("intuneScopeTagAssignment")]
        public IntuneScopeTagAssignment? IntuneScopeTagAssignment { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdObjects";
    }

    public AzureAdObjects Set(
        AzureAdAccessReviewScheduleDefinition? AzureAdAccessReviewScheduleDefinition = null,
        AzureAdAdministrativeUnit? AzureAdAdministrativeUnit = null,
        AzureAdAppRoleAssignment? AzureAdAppRoleAssignment = null,
        AzureAdApplication? AzureAdApplication = null,
        AzureAdAuthenticationContext? AzureAdAuthenticationContext = null,
        AzureAdAuthenticationStrength? AzureAdAuthenticationStrength = null,
        AzureAdBitLockerKey? AzureAdBitLockerKey = null,
        AzureAdConditionalAccessPolicy? AzureAdConditionalAccessPolicy = null,
        AzureAdDevice? AzureAdDevice = null,
        AzureAdEmAccessPackage? AzureAdEmAccessPackage = null,
        AzureAdEmAssignment? AzureAdEmAssignment = null,
        AzureAdEmAssignmentPolicy? AzureAdEmAssignmentPolicy = null,
        AzureAdEmCatalog? AzureAdEmCatalog = null,
        AzureAdEmCatalogResource? AzureAdEmCatalogResource = null,
        AzureAdEmCatalogRoleAssignment? AzureAdEmCatalogRoleAssignment = null,
        AzureAdEmIncompatibilities? AzureAdEmIncompatibilities = null,
        AzureAdEmResourceRoleScope? AzureAdEmResourceRoleScope = null,
        AzureAdGroup? AzureAdGroup = null,
        AzureAdGroupActiveAssignment? AzureAdGroupActiveAssignment = null,
        AzureAdGroupEligibleAssignment? AzureAdGroupEligibleAssignment = null,
        AzureAdLocalAdminPassword? AzureAdLocalAdminPassword = null,
        AzureAdNamedLocation? AzureAdNamedLocation = null,
        AzureAdRole? AzureAdRole = null,
        AzureAdRoleAssignment? AzureAdRoleAssignment = null,
        AzureAdRoleEligibleAssignment? AzureAdRoleEligibleAssignment = null,
        AzureAdServicePrincipal? AzureAdServicePrincipal = null,
        AzureAdTermsOfUse? AzureAdTermsOfUse = null,
        AzureAdUser? AzureAdUser = null,
        IntuneAppProtectionPolicy? IntuneAppProtectionPolicy = null,
        IntuneAssignmentFilter? IntuneAssignmentFilter = null,
        IntuneAutopilotDeploymentProfile? IntuneAutopilotDeploymentProfile = null,
        IntuneCompliancePolicy? IntuneCompliancePolicy = null,
        IntuneCompliancePolicyAction? IntuneCompliancePolicyAction = null,
        IntuneCompliancePolicyAssignment? IntuneCompliancePolicyAssignment = null,
        IntuneComplianceScript? IntuneComplianceScript = null,
        IntuneDeviceManagementPolicy? IntuneDeviceManagementPolicy = null,
        IntuneEndpointSecurityReusableSetting? IntuneEndpointSecurityReusableSetting = null,
        IntuneNotificationTemplate? IntuneNotificationTemplate = null,
        IntunePolicyAssignment? IntunePolicyAssignment = null,
        IntuneRoleAssignment? IntuneRoleAssignment = null,
        IntuneRoleDefinition? IntuneRoleDefinition = null,
        IntuneScopeTag? IntuneScopeTag = null,
        IntuneScopeTagAssignment? IntuneScopeTagAssignment = null
    ) 
    {
        if ( AzureAdAccessReviewScheduleDefinition != null ) {
            this.AzureAdAccessReviewScheduleDefinition = AzureAdAccessReviewScheduleDefinition;
        }
        if ( AzureAdAdministrativeUnit != null ) {
            this.AzureAdAdministrativeUnit = AzureAdAdministrativeUnit;
        }
        if ( AzureAdAppRoleAssignment != null ) {
            this.AzureAdAppRoleAssignment = AzureAdAppRoleAssignment;
        }
        if ( AzureAdApplication != null ) {
            this.AzureAdApplication = AzureAdApplication;
        }
        if ( AzureAdAuthenticationContext != null ) {
            this.AzureAdAuthenticationContext = AzureAdAuthenticationContext;
        }
        if ( AzureAdAuthenticationStrength != null ) {
            this.AzureAdAuthenticationStrength = AzureAdAuthenticationStrength;
        }
        if ( AzureAdBitLockerKey != null ) {
            this.AzureAdBitLockerKey = AzureAdBitLockerKey;
        }
        if ( AzureAdConditionalAccessPolicy != null ) {
            this.AzureAdConditionalAccessPolicy = AzureAdConditionalAccessPolicy;
        }
        if ( AzureAdDevice != null ) {
            this.AzureAdDevice = AzureAdDevice;
        }
        if ( AzureAdEmAccessPackage != null ) {
            this.AzureAdEmAccessPackage = AzureAdEmAccessPackage;
        }
        if ( AzureAdEmAssignment != null ) {
            this.AzureAdEmAssignment = AzureAdEmAssignment;
        }
        if ( AzureAdEmAssignmentPolicy != null ) {
            this.AzureAdEmAssignmentPolicy = AzureAdEmAssignmentPolicy;
        }
        if ( AzureAdEmCatalog != null ) {
            this.AzureAdEmCatalog = AzureAdEmCatalog;
        }
        if ( AzureAdEmCatalogResource != null ) {
            this.AzureAdEmCatalogResource = AzureAdEmCatalogResource;
        }
        if ( AzureAdEmCatalogRoleAssignment != null ) {
            this.AzureAdEmCatalogRoleAssignment = AzureAdEmCatalogRoleAssignment;
        }
        if ( AzureAdEmIncompatibilities != null ) {
            this.AzureAdEmIncompatibilities = AzureAdEmIncompatibilities;
        }
        if ( AzureAdEmResourceRoleScope != null ) {
            this.AzureAdEmResourceRoleScope = AzureAdEmResourceRoleScope;
        }
        if ( AzureAdGroup != null ) {
            this.AzureAdGroup = AzureAdGroup;
        }
        if ( AzureAdGroupActiveAssignment != null ) {
            this.AzureAdGroupActiveAssignment = AzureAdGroupActiveAssignment;
        }
        if ( AzureAdGroupEligibleAssignment != null ) {
            this.AzureAdGroupEligibleAssignment = AzureAdGroupEligibleAssignment;
        }
        if ( AzureAdLocalAdminPassword != null ) {
            this.AzureAdLocalAdminPassword = AzureAdLocalAdminPassword;
        }
        if ( AzureAdNamedLocation != null ) {
            this.AzureAdNamedLocation = AzureAdNamedLocation;
        }
        if ( AzureAdRole != null ) {
            this.AzureAdRole = AzureAdRole;
        }
        if ( AzureAdRoleAssignment != null ) {
            this.AzureAdRoleAssignment = AzureAdRoleAssignment;
        }
        if ( AzureAdRoleEligibleAssignment != null ) {
            this.AzureAdRoleEligibleAssignment = AzureAdRoleEligibleAssignment;
        }
        if ( AzureAdServicePrincipal != null ) {
            this.AzureAdServicePrincipal = AzureAdServicePrincipal;
        }
        if ( AzureAdTermsOfUse != null ) {
            this.AzureAdTermsOfUse = AzureAdTermsOfUse;
        }
        if ( AzureAdUser != null ) {
            this.AzureAdUser = AzureAdUser;
        }
        if ( IntuneAppProtectionPolicy != null ) {
            this.IntuneAppProtectionPolicy = IntuneAppProtectionPolicy;
        }
        if ( IntuneAssignmentFilter != null ) {
            this.IntuneAssignmentFilter = IntuneAssignmentFilter;
        }
        if ( IntuneAutopilotDeploymentProfile != null ) {
            this.IntuneAutopilotDeploymentProfile = IntuneAutopilotDeploymentProfile;
        }
        if ( IntuneCompliancePolicy != null ) {
            this.IntuneCompliancePolicy = IntuneCompliancePolicy;
        }
        if ( IntuneCompliancePolicyAction != null ) {
            this.IntuneCompliancePolicyAction = IntuneCompliancePolicyAction;
        }
        if ( IntuneCompliancePolicyAssignment != null ) {
            this.IntuneCompliancePolicyAssignment = IntuneCompliancePolicyAssignment;
        }
        if ( IntuneComplianceScript != null ) {
            this.IntuneComplianceScript = IntuneComplianceScript;
        }
        if ( IntuneDeviceManagementPolicy != null ) {
            this.IntuneDeviceManagementPolicy = IntuneDeviceManagementPolicy;
        }
        if ( IntuneEndpointSecurityReusableSetting != null ) {
            this.IntuneEndpointSecurityReusableSetting = IntuneEndpointSecurityReusableSetting;
        }
        if ( IntuneNotificationTemplate != null ) {
            this.IntuneNotificationTemplate = IntuneNotificationTemplate;
        }
        if ( IntunePolicyAssignment != null ) {
            this.IntunePolicyAssignment = IntunePolicyAssignment;
        }
        if ( IntuneRoleAssignment != null ) {
            this.IntuneRoleAssignment = IntuneRoleAssignment;
        }
        if ( IntuneRoleDefinition != null ) {
            this.IntuneRoleDefinition = IntuneRoleDefinition;
        }
        if ( IntuneScopeTag != null ) {
            this.IntuneScopeTag = IntuneScopeTag;
        }
        if ( IntuneScopeTagAssignment != null ) {
            this.IntuneScopeTagAssignment = IntuneScopeTagAssignment;
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
        //      C# -> AzureAdAccessReviewScheduleDefinition? AzureAdAccessReviewScheduleDefinition
        // GraphQL -> azureAdAccessReviewScheduleDefinition: AzureAdAccessReviewScheduleDefinition (type)
        if (this.AzureAdAccessReviewScheduleDefinition != null) {
            var fspec = this.AzureAdAccessReviewScheduleDefinition.AsFieldSpec(conf.Child("azureAdAccessReviewScheduleDefinition"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdAccessReviewScheduleDefinition" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdAdministrativeUnit? AzureAdAdministrativeUnit
        // GraphQL -> azureAdAdministrativeUnit: AzureAdAdministrativeUnit (type)
        if (this.AzureAdAdministrativeUnit != null) {
            var fspec = this.AzureAdAdministrativeUnit.AsFieldSpec(conf.Child("azureAdAdministrativeUnit"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdAdministrativeUnit" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdAppRoleAssignment? AzureAdAppRoleAssignment
        // GraphQL -> azureAdAppRoleAssignment: AzureAdAppRoleAssignment (type)
        if (this.AzureAdAppRoleAssignment != null) {
            var fspec = this.AzureAdAppRoleAssignment.AsFieldSpec(conf.Child("azureAdAppRoleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdAppRoleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdApplication? AzureAdApplication
        // GraphQL -> azureAdApplication: AzureAdApplication (type)
        if (this.AzureAdApplication != null) {
            var fspec = this.AzureAdApplication.AsFieldSpec(conf.Child("azureAdApplication"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdApplication" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdAuthenticationContext? AzureAdAuthenticationContext
        // GraphQL -> azureAdAuthenticationContext: AzureAdAuthenticationContext (type)
        if (this.AzureAdAuthenticationContext != null) {
            var fspec = this.AzureAdAuthenticationContext.AsFieldSpec(conf.Child("azureAdAuthenticationContext"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdAuthenticationContext" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdAuthenticationStrength? AzureAdAuthenticationStrength
        // GraphQL -> azureAdAuthenticationStrength: AzureAdAuthenticationStrength (type)
        if (this.AzureAdAuthenticationStrength != null) {
            var fspec = this.AzureAdAuthenticationStrength.AsFieldSpec(conf.Child("azureAdAuthenticationStrength"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdAuthenticationStrength" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdBitLockerKey? AzureAdBitLockerKey
        // GraphQL -> azureAdBitLockerKey: AzureAdBitLockerKey (type)
        if (this.AzureAdBitLockerKey != null) {
            var fspec = this.AzureAdBitLockerKey.AsFieldSpec(conf.Child("azureAdBitLockerKey"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdBitLockerKey" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdConditionalAccessPolicy? AzureAdConditionalAccessPolicy
        // GraphQL -> azureAdConditionalAccessPolicy: AzureAdConditionalAccessPolicy (type)
        if (this.AzureAdConditionalAccessPolicy != null) {
            var fspec = this.AzureAdConditionalAccessPolicy.AsFieldSpec(conf.Child("azureAdConditionalAccessPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdConditionalAccessPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        if (this.AzureAdDevice != null) {
            var fspec = this.AzureAdDevice.AsFieldSpec(conf.Child("azureAdDevice"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdDevice" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmAccessPackage? AzureAdEmAccessPackage
        // GraphQL -> azureAdEmAccessPackage: AzureAdEmAccessPackage (type)
        if (this.AzureAdEmAccessPackage != null) {
            var fspec = this.AzureAdEmAccessPackage.AsFieldSpec(conf.Child("azureAdEmAccessPackage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmAccessPackage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmAssignment? AzureAdEmAssignment
        // GraphQL -> azureAdEmAssignment: AzureAdEmAssignment (type)
        if (this.AzureAdEmAssignment != null) {
            var fspec = this.AzureAdEmAssignment.AsFieldSpec(conf.Child("azureAdEmAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmAssignmentPolicy? AzureAdEmAssignmentPolicy
        // GraphQL -> azureAdEmAssignmentPolicy: AzureAdEmAssignmentPolicy (type)
        if (this.AzureAdEmAssignmentPolicy != null) {
            var fspec = this.AzureAdEmAssignmentPolicy.AsFieldSpec(conf.Child("azureAdEmAssignmentPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmAssignmentPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmCatalog? AzureAdEmCatalog
        // GraphQL -> azureAdEmCatalog: AzureAdEmCatalog (type)
        if (this.AzureAdEmCatalog != null) {
            var fspec = this.AzureAdEmCatalog.AsFieldSpec(conf.Child("azureAdEmCatalog"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmCatalog" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmCatalogResource? AzureAdEmCatalogResource
        // GraphQL -> azureAdEmCatalogResource: AzureAdEmCatalogResource (type)
        if (this.AzureAdEmCatalogResource != null) {
            var fspec = this.AzureAdEmCatalogResource.AsFieldSpec(conf.Child("azureAdEmCatalogResource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmCatalogResource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmCatalogRoleAssignment? AzureAdEmCatalogRoleAssignment
        // GraphQL -> azureAdEmCatalogRoleAssignment: AzureAdEmCatalogRoleAssignment (type)
        if (this.AzureAdEmCatalogRoleAssignment != null) {
            var fspec = this.AzureAdEmCatalogRoleAssignment.AsFieldSpec(conf.Child("azureAdEmCatalogRoleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmCatalogRoleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmIncompatibilities? AzureAdEmIncompatibilities
        // GraphQL -> azureAdEmIncompatibilities: AzureAdEmIncompatibilities (type)
        if (this.AzureAdEmIncompatibilities != null) {
            var fspec = this.AzureAdEmIncompatibilities.AsFieldSpec(conf.Child("azureAdEmIncompatibilities"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmIncompatibilities" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdEmResourceRoleScope? AzureAdEmResourceRoleScope
        // GraphQL -> azureAdEmResourceRoleScope: AzureAdEmResourceRoleScope (type)
        if (this.AzureAdEmResourceRoleScope != null) {
            var fspec = this.AzureAdEmResourceRoleScope.AsFieldSpec(conf.Child("azureAdEmResourceRoleScope"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdEmResourceRoleScope" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (this.AzureAdGroup != null) {
            var fspec = this.AzureAdGroup.AsFieldSpec(conf.Child("azureAdGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdGroupActiveAssignment? AzureAdGroupActiveAssignment
        // GraphQL -> azureAdGroupActiveAssignment: AzureAdGroupActiveAssignment (type)
        if (this.AzureAdGroupActiveAssignment != null) {
            var fspec = this.AzureAdGroupActiveAssignment.AsFieldSpec(conf.Child("azureAdGroupActiveAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdGroupActiveAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdGroupEligibleAssignment? AzureAdGroupEligibleAssignment
        // GraphQL -> azureAdGroupEligibleAssignment: AzureAdGroupEligibleAssignment (type)
        if (this.AzureAdGroupEligibleAssignment != null) {
            var fspec = this.AzureAdGroupEligibleAssignment.AsFieldSpec(conf.Child("azureAdGroupEligibleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdGroupEligibleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdLocalAdminPassword? AzureAdLocalAdminPassword
        // GraphQL -> azureAdLocalAdminPassword: AzureAdLocalAdminPassword (type)
        if (this.AzureAdLocalAdminPassword != null) {
            var fspec = this.AzureAdLocalAdminPassword.AsFieldSpec(conf.Child("azureAdLocalAdminPassword"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdLocalAdminPassword" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdNamedLocation? AzureAdNamedLocation
        // GraphQL -> azureAdNamedLocation: AzureAdNamedLocation (type)
        if (this.AzureAdNamedLocation != null) {
            var fspec = this.AzureAdNamedLocation.AsFieldSpec(conf.Child("azureAdNamedLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdNamedLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdRole? AzureAdRole
        // GraphQL -> azureAdRole: AzureAdRole (type)
        if (this.AzureAdRole != null) {
            var fspec = this.AzureAdRole.AsFieldSpec(conf.Child("azureAdRole"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdRole" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdRoleAssignment? AzureAdRoleAssignment
        // GraphQL -> azureAdRoleAssignment: AzureAdRoleAssignment (type)
        if (this.AzureAdRoleAssignment != null) {
            var fspec = this.AzureAdRoleAssignment.AsFieldSpec(conf.Child("azureAdRoleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdRoleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdRoleEligibleAssignment? AzureAdRoleEligibleAssignment
        // GraphQL -> azureAdRoleEligibleAssignment: AzureAdRoleEligibleAssignment (type)
        if (this.AzureAdRoleEligibleAssignment != null) {
            var fspec = this.AzureAdRoleEligibleAssignment.AsFieldSpec(conf.Child("azureAdRoleEligibleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdRoleEligibleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        if (this.AzureAdServicePrincipal != null) {
            var fspec = this.AzureAdServicePrincipal.AsFieldSpec(conf.Child("azureAdServicePrincipal"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdServicePrincipal" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdTermsOfUse? AzureAdTermsOfUse
        // GraphQL -> azureAdTermsOfUse: AzureAdTermsOfUse (type)
        if (this.AzureAdTermsOfUse != null) {
            var fspec = this.AzureAdTermsOfUse.AsFieldSpec(conf.Child("azureAdTermsOfUse"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdTermsOfUse" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (this.AzureAdUser != null) {
            var fspec = this.AzureAdUser.AsFieldSpec(conf.Child("azureAdUser"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdUser" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneAppProtectionPolicy? IntuneAppProtectionPolicy
        // GraphQL -> intuneAppProtectionPolicy: IntuneAppProtectionPolicy (type)
        if (this.IntuneAppProtectionPolicy != null) {
            var fspec = this.IntuneAppProtectionPolicy.AsFieldSpec(conf.Child("intuneAppProtectionPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneAppProtectionPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneAssignmentFilter? IntuneAssignmentFilter
        // GraphQL -> intuneAssignmentFilter: IntuneAssignmentFilter (type)
        if (this.IntuneAssignmentFilter != null) {
            var fspec = this.IntuneAssignmentFilter.AsFieldSpec(conf.Child("intuneAssignmentFilter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneAssignmentFilter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneAutopilotDeploymentProfile? IntuneAutopilotDeploymentProfile
        // GraphQL -> intuneAutopilotDeploymentProfile: IntuneAutopilotDeploymentProfile (type)
        if (this.IntuneAutopilotDeploymentProfile != null) {
            var fspec = this.IntuneAutopilotDeploymentProfile.AsFieldSpec(conf.Child("intuneAutopilotDeploymentProfile"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneAutopilotDeploymentProfile" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneCompliancePolicy? IntuneCompliancePolicy
        // GraphQL -> intuneCompliancePolicy: IntuneCompliancePolicy (type)
        if (this.IntuneCompliancePolicy != null) {
            var fspec = this.IntuneCompliancePolicy.AsFieldSpec(conf.Child("intuneCompliancePolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneCompliancePolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneCompliancePolicyAction? IntuneCompliancePolicyAction
        // GraphQL -> intuneCompliancePolicyAction: IntuneCompliancePolicyAction (type)
        if (this.IntuneCompliancePolicyAction != null) {
            var fspec = this.IntuneCompliancePolicyAction.AsFieldSpec(conf.Child("intuneCompliancePolicyAction"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneCompliancePolicyAction" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneCompliancePolicyAssignment? IntuneCompliancePolicyAssignment
        // GraphQL -> intuneCompliancePolicyAssignment: IntuneCompliancePolicyAssignment (type)
        if (this.IntuneCompliancePolicyAssignment != null) {
            var fspec = this.IntuneCompliancePolicyAssignment.AsFieldSpec(conf.Child("intuneCompliancePolicyAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneCompliancePolicyAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneComplianceScript? IntuneComplianceScript
        // GraphQL -> intuneComplianceScript: IntuneComplianceScript (type)
        if (this.IntuneComplianceScript != null) {
            var fspec = this.IntuneComplianceScript.AsFieldSpec(conf.Child("intuneComplianceScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneComplianceScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneDeviceManagementPolicy? IntuneDeviceManagementPolicy
        // GraphQL -> intuneDeviceManagementPolicy: IntuneDeviceManagementPolicy (type)
        if (this.IntuneDeviceManagementPolicy != null) {
            var fspec = this.IntuneDeviceManagementPolicy.AsFieldSpec(conf.Child("intuneDeviceManagementPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneDeviceManagementPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneEndpointSecurityReusableSetting? IntuneEndpointSecurityReusableSetting
        // GraphQL -> intuneEndpointSecurityReusableSetting: IntuneEndpointSecurityReusableSetting (type)
        if (this.IntuneEndpointSecurityReusableSetting != null) {
            var fspec = this.IntuneEndpointSecurityReusableSetting.AsFieldSpec(conf.Child("intuneEndpointSecurityReusableSetting"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneEndpointSecurityReusableSetting" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneNotificationTemplate? IntuneNotificationTemplate
        // GraphQL -> intuneNotificationTemplate: IntuneNotificationTemplate (type)
        if (this.IntuneNotificationTemplate != null) {
            var fspec = this.IntuneNotificationTemplate.AsFieldSpec(conf.Child("intuneNotificationTemplate"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneNotificationTemplate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntunePolicyAssignment? IntunePolicyAssignment
        // GraphQL -> intunePolicyAssignment: IntunePolicyAssignment (type)
        if (this.IntunePolicyAssignment != null) {
            var fspec = this.IntunePolicyAssignment.AsFieldSpec(conf.Child("intunePolicyAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intunePolicyAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneRoleAssignment? IntuneRoleAssignment
        // GraphQL -> intuneRoleAssignment: IntuneRoleAssignment (type)
        if (this.IntuneRoleAssignment != null) {
            var fspec = this.IntuneRoleAssignment.AsFieldSpec(conf.Child("intuneRoleAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneRoleAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneRoleDefinition? IntuneRoleDefinition
        // GraphQL -> intuneRoleDefinition: IntuneRoleDefinition (type)
        if (this.IntuneRoleDefinition != null) {
            var fspec = this.IntuneRoleDefinition.AsFieldSpec(conf.Child("intuneRoleDefinition"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneRoleDefinition" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneScopeTag? IntuneScopeTag
        // GraphQL -> intuneScopeTag: IntuneScopeTag (type)
        if (this.IntuneScopeTag != null) {
            var fspec = this.IntuneScopeTag.AsFieldSpec(conf.Child("intuneScopeTag"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneScopeTag" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IntuneScopeTagAssignment? IntuneScopeTagAssignment
        // GraphQL -> intuneScopeTagAssignment: IntuneScopeTagAssignment (type)
        if (this.IntuneScopeTagAssignment != null) {
            var fspec = this.IntuneScopeTagAssignment.AsFieldSpec(conf.Child("intuneScopeTagAssignment"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "intuneScopeTagAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdAccessReviewScheduleDefinition? AzureAdAccessReviewScheduleDefinition
        // GraphQL -> azureAdAccessReviewScheduleDefinition: AzureAdAccessReviewScheduleDefinition (type)
        if (ec.Includes("azureAdAccessReviewScheduleDefinition",false))
        {
            if(this.AzureAdAccessReviewScheduleDefinition == null) {

                this.AzureAdAccessReviewScheduleDefinition = new AzureAdAccessReviewScheduleDefinition();
                this.AzureAdAccessReviewScheduleDefinition.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAccessReviewScheduleDefinition"));

            } else {

                this.AzureAdAccessReviewScheduleDefinition.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAccessReviewScheduleDefinition"));

            }
        }
        else if (this.AzureAdAccessReviewScheduleDefinition != null && ec.Excludes("azureAdAccessReviewScheduleDefinition",false))
        {
            this.AzureAdAccessReviewScheduleDefinition = null;
        }
        //      C# -> AzureAdAdministrativeUnit? AzureAdAdministrativeUnit
        // GraphQL -> azureAdAdministrativeUnit: AzureAdAdministrativeUnit (type)
        if (ec.Includes("azureAdAdministrativeUnit",false))
        {
            if(this.AzureAdAdministrativeUnit == null) {

                this.AzureAdAdministrativeUnit = new AzureAdAdministrativeUnit();
                this.AzureAdAdministrativeUnit.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAdministrativeUnit"));

            } else {

                this.AzureAdAdministrativeUnit.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAdministrativeUnit"));

            }
        }
        else if (this.AzureAdAdministrativeUnit != null && ec.Excludes("azureAdAdministrativeUnit",false))
        {
            this.AzureAdAdministrativeUnit = null;
        }
        //      C# -> AzureAdAppRoleAssignment? AzureAdAppRoleAssignment
        // GraphQL -> azureAdAppRoleAssignment: AzureAdAppRoleAssignment (type)
        if (ec.Includes("azureAdAppRoleAssignment",false))
        {
            if(this.AzureAdAppRoleAssignment == null) {

                this.AzureAdAppRoleAssignment = new AzureAdAppRoleAssignment();
                this.AzureAdAppRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAppRoleAssignment"));

            } else {

                this.AzureAdAppRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAppRoleAssignment"));

            }
        }
        else if (this.AzureAdAppRoleAssignment != null && ec.Excludes("azureAdAppRoleAssignment",false))
        {
            this.AzureAdAppRoleAssignment = null;
        }
        //      C# -> AzureAdApplication? AzureAdApplication
        // GraphQL -> azureAdApplication: AzureAdApplication (type)
        if (ec.Includes("azureAdApplication",false))
        {
            if(this.AzureAdApplication == null) {

                this.AzureAdApplication = new AzureAdApplication();
                this.AzureAdApplication.ApplyExploratoryFieldSpec(ec.NewChild("azureAdApplication"));

            } else {

                this.AzureAdApplication.ApplyExploratoryFieldSpec(ec.NewChild("azureAdApplication"));

            }
        }
        else if (this.AzureAdApplication != null && ec.Excludes("azureAdApplication",false))
        {
            this.AzureAdApplication = null;
        }
        //      C# -> AzureAdAuthenticationContext? AzureAdAuthenticationContext
        // GraphQL -> azureAdAuthenticationContext: AzureAdAuthenticationContext (type)
        if (ec.Includes("azureAdAuthenticationContext",false))
        {
            if(this.AzureAdAuthenticationContext == null) {

                this.AzureAdAuthenticationContext = new AzureAdAuthenticationContext();
                this.AzureAdAuthenticationContext.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAuthenticationContext"));

            } else {

                this.AzureAdAuthenticationContext.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAuthenticationContext"));

            }
        }
        else if (this.AzureAdAuthenticationContext != null && ec.Excludes("azureAdAuthenticationContext",false))
        {
            this.AzureAdAuthenticationContext = null;
        }
        //      C# -> AzureAdAuthenticationStrength? AzureAdAuthenticationStrength
        // GraphQL -> azureAdAuthenticationStrength: AzureAdAuthenticationStrength (type)
        if (ec.Includes("azureAdAuthenticationStrength",false))
        {
            if(this.AzureAdAuthenticationStrength == null) {

                this.AzureAdAuthenticationStrength = new AzureAdAuthenticationStrength();
                this.AzureAdAuthenticationStrength.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAuthenticationStrength"));

            } else {

                this.AzureAdAuthenticationStrength.ApplyExploratoryFieldSpec(ec.NewChild("azureAdAuthenticationStrength"));

            }
        }
        else if (this.AzureAdAuthenticationStrength != null && ec.Excludes("azureAdAuthenticationStrength",false))
        {
            this.AzureAdAuthenticationStrength = null;
        }
        //      C# -> AzureAdBitLockerKey? AzureAdBitLockerKey
        // GraphQL -> azureAdBitLockerKey: AzureAdBitLockerKey (type)
        if (ec.Includes("azureAdBitLockerKey",false))
        {
            if(this.AzureAdBitLockerKey == null) {

                this.AzureAdBitLockerKey = new AzureAdBitLockerKey();
                this.AzureAdBitLockerKey.ApplyExploratoryFieldSpec(ec.NewChild("azureAdBitLockerKey"));

            } else {

                this.AzureAdBitLockerKey.ApplyExploratoryFieldSpec(ec.NewChild("azureAdBitLockerKey"));

            }
        }
        else if (this.AzureAdBitLockerKey != null && ec.Excludes("azureAdBitLockerKey",false))
        {
            this.AzureAdBitLockerKey = null;
        }
        //      C# -> AzureAdConditionalAccessPolicy? AzureAdConditionalAccessPolicy
        // GraphQL -> azureAdConditionalAccessPolicy: AzureAdConditionalAccessPolicy (type)
        if (ec.Includes("azureAdConditionalAccessPolicy",false))
        {
            if(this.AzureAdConditionalAccessPolicy == null) {

                this.AzureAdConditionalAccessPolicy = new AzureAdConditionalAccessPolicy();
                this.AzureAdConditionalAccessPolicy.ApplyExploratoryFieldSpec(ec.NewChild("azureAdConditionalAccessPolicy"));

            } else {

                this.AzureAdConditionalAccessPolicy.ApplyExploratoryFieldSpec(ec.NewChild("azureAdConditionalAccessPolicy"));

            }
        }
        else if (this.AzureAdConditionalAccessPolicy != null && ec.Excludes("azureAdConditionalAccessPolicy",false))
        {
            this.AzureAdConditionalAccessPolicy = null;
        }
        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        if (ec.Includes("azureAdDevice",false))
        {
            if(this.AzureAdDevice == null) {

                this.AzureAdDevice = new AzureAdDevice();
                this.AzureAdDevice.ApplyExploratoryFieldSpec(ec.NewChild("azureAdDevice"));

            } else {

                this.AzureAdDevice.ApplyExploratoryFieldSpec(ec.NewChild("azureAdDevice"));

            }
        }
        else if (this.AzureAdDevice != null && ec.Excludes("azureAdDevice",false))
        {
            this.AzureAdDevice = null;
        }
        //      C# -> AzureAdEmAccessPackage? AzureAdEmAccessPackage
        // GraphQL -> azureAdEmAccessPackage: AzureAdEmAccessPackage (type)
        if (ec.Includes("azureAdEmAccessPackage",false))
        {
            if(this.AzureAdEmAccessPackage == null) {

                this.AzureAdEmAccessPackage = new AzureAdEmAccessPackage();
                this.AzureAdEmAccessPackage.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAccessPackage"));

            } else {

                this.AzureAdEmAccessPackage.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAccessPackage"));

            }
        }
        else if (this.AzureAdEmAccessPackage != null && ec.Excludes("azureAdEmAccessPackage",false))
        {
            this.AzureAdEmAccessPackage = null;
        }
        //      C# -> AzureAdEmAssignment? AzureAdEmAssignment
        // GraphQL -> azureAdEmAssignment: AzureAdEmAssignment (type)
        if (ec.Includes("azureAdEmAssignment",false))
        {
            if(this.AzureAdEmAssignment == null) {

                this.AzureAdEmAssignment = new AzureAdEmAssignment();
                this.AzureAdEmAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAssignment"));

            } else {

                this.AzureAdEmAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAssignment"));

            }
        }
        else if (this.AzureAdEmAssignment != null && ec.Excludes("azureAdEmAssignment",false))
        {
            this.AzureAdEmAssignment = null;
        }
        //      C# -> AzureAdEmAssignmentPolicy? AzureAdEmAssignmentPolicy
        // GraphQL -> azureAdEmAssignmentPolicy: AzureAdEmAssignmentPolicy (type)
        if (ec.Includes("azureAdEmAssignmentPolicy",false))
        {
            if(this.AzureAdEmAssignmentPolicy == null) {

                this.AzureAdEmAssignmentPolicy = new AzureAdEmAssignmentPolicy();
                this.AzureAdEmAssignmentPolicy.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAssignmentPolicy"));

            } else {

                this.AzureAdEmAssignmentPolicy.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmAssignmentPolicy"));

            }
        }
        else if (this.AzureAdEmAssignmentPolicy != null && ec.Excludes("azureAdEmAssignmentPolicy",false))
        {
            this.AzureAdEmAssignmentPolicy = null;
        }
        //      C# -> AzureAdEmCatalog? AzureAdEmCatalog
        // GraphQL -> azureAdEmCatalog: AzureAdEmCatalog (type)
        if (ec.Includes("azureAdEmCatalog",false))
        {
            if(this.AzureAdEmCatalog == null) {

                this.AzureAdEmCatalog = new AzureAdEmCatalog();
                this.AzureAdEmCatalog.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalog"));

            } else {

                this.AzureAdEmCatalog.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalog"));

            }
        }
        else if (this.AzureAdEmCatalog != null && ec.Excludes("azureAdEmCatalog",false))
        {
            this.AzureAdEmCatalog = null;
        }
        //      C# -> AzureAdEmCatalogResource? AzureAdEmCatalogResource
        // GraphQL -> azureAdEmCatalogResource: AzureAdEmCatalogResource (type)
        if (ec.Includes("azureAdEmCatalogResource",false))
        {
            if(this.AzureAdEmCatalogResource == null) {

                this.AzureAdEmCatalogResource = new AzureAdEmCatalogResource();
                this.AzureAdEmCatalogResource.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalogResource"));

            } else {

                this.AzureAdEmCatalogResource.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalogResource"));

            }
        }
        else if (this.AzureAdEmCatalogResource != null && ec.Excludes("azureAdEmCatalogResource",false))
        {
            this.AzureAdEmCatalogResource = null;
        }
        //      C# -> AzureAdEmCatalogRoleAssignment? AzureAdEmCatalogRoleAssignment
        // GraphQL -> azureAdEmCatalogRoleAssignment: AzureAdEmCatalogRoleAssignment (type)
        if (ec.Includes("azureAdEmCatalogRoleAssignment",false))
        {
            if(this.AzureAdEmCatalogRoleAssignment == null) {

                this.AzureAdEmCatalogRoleAssignment = new AzureAdEmCatalogRoleAssignment();
                this.AzureAdEmCatalogRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalogRoleAssignment"));

            } else {

                this.AzureAdEmCatalogRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmCatalogRoleAssignment"));

            }
        }
        else if (this.AzureAdEmCatalogRoleAssignment != null && ec.Excludes("azureAdEmCatalogRoleAssignment",false))
        {
            this.AzureAdEmCatalogRoleAssignment = null;
        }
        //      C# -> AzureAdEmIncompatibilities? AzureAdEmIncompatibilities
        // GraphQL -> azureAdEmIncompatibilities: AzureAdEmIncompatibilities (type)
        if (ec.Includes("azureAdEmIncompatibilities",false))
        {
            if(this.AzureAdEmIncompatibilities == null) {

                this.AzureAdEmIncompatibilities = new AzureAdEmIncompatibilities();
                this.AzureAdEmIncompatibilities.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmIncompatibilities"));

            } else {

                this.AzureAdEmIncompatibilities.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmIncompatibilities"));

            }
        }
        else if (this.AzureAdEmIncompatibilities != null && ec.Excludes("azureAdEmIncompatibilities",false))
        {
            this.AzureAdEmIncompatibilities = null;
        }
        //      C# -> AzureAdEmResourceRoleScope? AzureAdEmResourceRoleScope
        // GraphQL -> azureAdEmResourceRoleScope: AzureAdEmResourceRoleScope (type)
        if (ec.Includes("azureAdEmResourceRoleScope",false))
        {
            if(this.AzureAdEmResourceRoleScope == null) {

                this.AzureAdEmResourceRoleScope = new AzureAdEmResourceRoleScope();
                this.AzureAdEmResourceRoleScope.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmResourceRoleScope"));

            } else {

                this.AzureAdEmResourceRoleScope.ApplyExploratoryFieldSpec(ec.NewChild("azureAdEmResourceRoleScope"));

            }
        }
        else if (this.AzureAdEmResourceRoleScope != null && ec.Excludes("azureAdEmResourceRoleScope",false))
        {
            this.AzureAdEmResourceRoleScope = null;
        }
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (ec.Includes("azureAdGroup",false))
        {
            if(this.AzureAdGroup == null) {

                this.AzureAdGroup = new AzureAdGroup();
                this.AzureAdGroup.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroup"));

            } else {

                this.AzureAdGroup.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroup"));

            }
        }
        else if (this.AzureAdGroup != null && ec.Excludes("azureAdGroup",false))
        {
            this.AzureAdGroup = null;
        }
        //      C# -> AzureAdGroupActiveAssignment? AzureAdGroupActiveAssignment
        // GraphQL -> azureAdGroupActiveAssignment: AzureAdGroupActiveAssignment (type)
        if (ec.Includes("azureAdGroupActiveAssignment",false))
        {
            if(this.AzureAdGroupActiveAssignment == null) {

                this.AzureAdGroupActiveAssignment = new AzureAdGroupActiveAssignment();
                this.AzureAdGroupActiveAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroupActiveAssignment"));

            } else {

                this.AzureAdGroupActiveAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroupActiveAssignment"));

            }
        }
        else if (this.AzureAdGroupActiveAssignment != null && ec.Excludes("azureAdGroupActiveAssignment",false))
        {
            this.AzureAdGroupActiveAssignment = null;
        }
        //      C# -> AzureAdGroupEligibleAssignment? AzureAdGroupEligibleAssignment
        // GraphQL -> azureAdGroupEligibleAssignment: AzureAdGroupEligibleAssignment (type)
        if (ec.Includes("azureAdGroupEligibleAssignment",false))
        {
            if(this.AzureAdGroupEligibleAssignment == null) {

                this.AzureAdGroupEligibleAssignment = new AzureAdGroupEligibleAssignment();
                this.AzureAdGroupEligibleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroupEligibleAssignment"));

            } else {

                this.AzureAdGroupEligibleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroupEligibleAssignment"));

            }
        }
        else if (this.AzureAdGroupEligibleAssignment != null && ec.Excludes("azureAdGroupEligibleAssignment",false))
        {
            this.AzureAdGroupEligibleAssignment = null;
        }
        //      C# -> AzureAdLocalAdminPassword? AzureAdLocalAdminPassword
        // GraphQL -> azureAdLocalAdminPassword: AzureAdLocalAdminPassword (type)
        if (ec.Includes("azureAdLocalAdminPassword",false))
        {
            if(this.AzureAdLocalAdminPassword == null) {

                this.AzureAdLocalAdminPassword = new AzureAdLocalAdminPassword();
                this.AzureAdLocalAdminPassword.ApplyExploratoryFieldSpec(ec.NewChild("azureAdLocalAdminPassword"));

            } else {

                this.AzureAdLocalAdminPassword.ApplyExploratoryFieldSpec(ec.NewChild("azureAdLocalAdminPassword"));

            }
        }
        else if (this.AzureAdLocalAdminPassword != null && ec.Excludes("azureAdLocalAdminPassword",false))
        {
            this.AzureAdLocalAdminPassword = null;
        }
        //      C# -> AzureAdNamedLocation? AzureAdNamedLocation
        // GraphQL -> azureAdNamedLocation: AzureAdNamedLocation (type)
        if (ec.Includes("azureAdNamedLocation",false))
        {
            if(this.AzureAdNamedLocation == null) {

                this.AzureAdNamedLocation = new AzureAdNamedLocation();
                this.AzureAdNamedLocation.ApplyExploratoryFieldSpec(ec.NewChild("azureAdNamedLocation"));

            } else {

                this.AzureAdNamedLocation.ApplyExploratoryFieldSpec(ec.NewChild("azureAdNamedLocation"));

            }
        }
        else if (this.AzureAdNamedLocation != null && ec.Excludes("azureAdNamedLocation",false))
        {
            this.AzureAdNamedLocation = null;
        }
        //      C# -> AzureAdRole? AzureAdRole
        // GraphQL -> azureAdRole: AzureAdRole (type)
        if (ec.Includes("azureAdRole",false))
        {
            if(this.AzureAdRole == null) {

                this.AzureAdRole = new AzureAdRole();
                this.AzureAdRole.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRole"));

            } else {

                this.AzureAdRole.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRole"));

            }
        }
        else if (this.AzureAdRole != null && ec.Excludes("azureAdRole",false))
        {
            this.AzureAdRole = null;
        }
        //      C# -> AzureAdRoleAssignment? AzureAdRoleAssignment
        // GraphQL -> azureAdRoleAssignment: AzureAdRoleAssignment (type)
        if (ec.Includes("azureAdRoleAssignment",false))
        {
            if(this.AzureAdRoleAssignment == null) {

                this.AzureAdRoleAssignment = new AzureAdRoleAssignment();
                this.AzureAdRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRoleAssignment"));

            } else {

                this.AzureAdRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRoleAssignment"));

            }
        }
        else if (this.AzureAdRoleAssignment != null && ec.Excludes("azureAdRoleAssignment",false))
        {
            this.AzureAdRoleAssignment = null;
        }
        //      C# -> AzureAdRoleEligibleAssignment? AzureAdRoleEligibleAssignment
        // GraphQL -> azureAdRoleEligibleAssignment: AzureAdRoleEligibleAssignment (type)
        if (ec.Includes("azureAdRoleEligibleAssignment",false))
        {
            if(this.AzureAdRoleEligibleAssignment == null) {

                this.AzureAdRoleEligibleAssignment = new AzureAdRoleEligibleAssignment();
                this.AzureAdRoleEligibleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRoleEligibleAssignment"));

            } else {

                this.AzureAdRoleEligibleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("azureAdRoleEligibleAssignment"));

            }
        }
        else if (this.AzureAdRoleEligibleAssignment != null && ec.Excludes("azureAdRoleEligibleAssignment",false))
        {
            this.AzureAdRoleEligibleAssignment = null;
        }
        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        if (ec.Includes("azureAdServicePrincipal",false))
        {
            if(this.AzureAdServicePrincipal == null) {

                this.AzureAdServicePrincipal = new AzureAdServicePrincipal();
                this.AzureAdServicePrincipal.ApplyExploratoryFieldSpec(ec.NewChild("azureAdServicePrincipal"));

            } else {

                this.AzureAdServicePrincipal.ApplyExploratoryFieldSpec(ec.NewChild("azureAdServicePrincipal"));

            }
        }
        else if (this.AzureAdServicePrincipal != null && ec.Excludes("azureAdServicePrincipal",false))
        {
            this.AzureAdServicePrincipal = null;
        }
        //      C# -> AzureAdTermsOfUse? AzureAdTermsOfUse
        // GraphQL -> azureAdTermsOfUse: AzureAdTermsOfUse (type)
        if (ec.Includes("azureAdTermsOfUse",false))
        {
            if(this.AzureAdTermsOfUse == null) {

                this.AzureAdTermsOfUse = new AzureAdTermsOfUse();
                this.AzureAdTermsOfUse.ApplyExploratoryFieldSpec(ec.NewChild("azureAdTermsOfUse"));

            } else {

                this.AzureAdTermsOfUse.ApplyExploratoryFieldSpec(ec.NewChild("azureAdTermsOfUse"));

            }
        }
        else if (this.AzureAdTermsOfUse != null && ec.Excludes("azureAdTermsOfUse",false))
        {
            this.AzureAdTermsOfUse = null;
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (ec.Includes("azureAdUser",false))
        {
            if(this.AzureAdUser == null) {

                this.AzureAdUser = new AzureAdUser();
                this.AzureAdUser.ApplyExploratoryFieldSpec(ec.NewChild("azureAdUser"));

            } else {

                this.AzureAdUser.ApplyExploratoryFieldSpec(ec.NewChild("azureAdUser"));

            }
        }
        else if (this.AzureAdUser != null && ec.Excludes("azureAdUser",false))
        {
            this.AzureAdUser = null;
        }
        //      C# -> IntuneAppProtectionPolicy? IntuneAppProtectionPolicy
        // GraphQL -> intuneAppProtectionPolicy: IntuneAppProtectionPolicy (type)
        if (ec.Includes("intuneAppProtectionPolicy",false))
        {
            if(this.IntuneAppProtectionPolicy == null) {

                this.IntuneAppProtectionPolicy = new IntuneAppProtectionPolicy();
                this.IntuneAppProtectionPolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneAppProtectionPolicy"));

            } else {

                this.IntuneAppProtectionPolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneAppProtectionPolicy"));

            }
        }
        else if (this.IntuneAppProtectionPolicy != null && ec.Excludes("intuneAppProtectionPolicy",false))
        {
            this.IntuneAppProtectionPolicy = null;
        }
        //      C# -> IntuneAssignmentFilter? IntuneAssignmentFilter
        // GraphQL -> intuneAssignmentFilter: IntuneAssignmentFilter (type)
        if (ec.Includes("intuneAssignmentFilter",false))
        {
            if(this.IntuneAssignmentFilter == null) {

                this.IntuneAssignmentFilter = new IntuneAssignmentFilter();
                this.IntuneAssignmentFilter.ApplyExploratoryFieldSpec(ec.NewChild("intuneAssignmentFilter"));

            } else {

                this.IntuneAssignmentFilter.ApplyExploratoryFieldSpec(ec.NewChild("intuneAssignmentFilter"));

            }
        }
        else if (this.IntuneAssignmentFilter != null && ec.Excludes("intuneAssignmentFilter",false))
        {
            this.IntuneAssignmentFilter = null;
        }
        //      C# -> IntuneAutopilotDeploymentProfile? IntuneAutopilotDeploymentProfile
        // GraphQL -> intuneAutopilotDeploymentProfile: IntuneAutopilotDeploymentProfile (type)
        if (ec.Includes("intuneAutopilotDeploymentProfile",false))
        {
            if(this.IntuneAutopilotDeploymentProfile == null) {

                this.IntuneAutopilotDeploymentProfile = new IntuneAutopilotDeploymentProfile();
                this.IntuneAutopilotDeploymentProfile.ApplyExploratoryFieldSpec(ec.NewChild("intuneAutopilotDeploymentProfile"));

            } else {

                this.IntuneAutopilotDeploymentProfile.ApplyExploratoryFieldSpec(ec.NewChild("intuneAutopilotDeploymentProfile"));

            }
        }
        else if (this.IntuneAutopilotDeploymentProfile != null && ec.Excludes("intuneAutopilotDeploymentProfile",false))
        {
            this.IntuneAutopilotDeploymentProfile = null;
        }
        //      C# -> IntuneCompliancePolicy? IntuneCompliancePolicy
        // GraphQL -> intuneCompliancePolicy: IntuneCompliancePolicy (type)
        if (ec.Includes("intuneCompliancePolicy",false))
        {
            if(this.IntuneCompliancePolicy == null) {

                this.IntuneCompliancePolicy = new IntuneCompliancePolicy();
                this.IntuneCompliancePolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicy"));

            } else {

                this.IntuneCompliancePolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicy"));

            }
        }
        else if (this.IntuneCompliancePolicy != null && ec.Excludes("intuneCompliancePolicy",false))
        {
            this.IntuneCompliancePolicy = null;
        }
        //      C# -> IntuneCompliancePolicyAction? IntuneCompliancePolicyAction
        // GraphQL -> intuneCompliancePolicyAction: IntuneCompliancePolicyAction (type)
        if (ec.Includes("intuneCompliancePolicyAction",false))
        {
            if(this.IntuneCompliancePolicyAction == null) {

                this.IntuneCompliancePolicyAction = new IntuneCompliancePolicyAction();
                this.IntuneCompliancePolicyAction.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicyAction"));

            } else {

                this.IntuneCompliancePolicyAction.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicyAction"));

            }
        }
        else if (this.IntuneCompliancePolicyAction != null && ec.Excludes("intuneCompliancePolicyAction",false))
        {
            this.IntuneCompliancePolicyAction = null;
        }
        //      C# -> IntuneCompliancePolicyAssignment? IntuneCompliancePolicyAssignment
        // GraphQL -> intuneCompliancePolicyAssignment: IntuneCompliancePolicyAssignment (type)
        if (ec.Includes("intuneCompliancePolicyAssignment",false))
        {
            if(this.IntuneCompliancePolicyAssignment == null) {

                this.IntuneCompliancePolicyAssignment = new IntuneCompliancePolicyAssignment();
                this.IntuneCompliancePolicyAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicyAssignment"));

            } else {

                this.IntuneCompliancePolicyAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneCompliancePolicyAssignment"));

            }
        }
        else if (this.IntuneCompliancePolicyAssignment != null && ec.Excludes("intuneCompliancePolicyAssignment",false))
        {
            this.IntuneCompliancePolicyAssignment = null;
        }
        //      C# -> IntuneComplianceScript? IntuneComplianceScript
        // GraphQL -> intuneComplianceScript: IntuneComplianceScript (type)
        if (ec.Includes("intuneComplianceScript",false))
        {
            if(this.IntuneComplianceScript == null) {

                this.IntuneComplianceScript = new IntuneComplianceScript();
                this.IntuneComplianceScript.ApplyExploratoryFieldSpec(ec.NewChild("intuneComplianceScript"));

            } else {

                this.IntuneComplianceScript.ApplyExploratoryFieldSpec(ec.NewChild("intuneComplianceScript"));

            }
        }
        else if (this.IntuneComplianceScript != null && ec.Excludes("intuneComplianceScript",false))
        {
            this.IntuneComplianceScript = null;
        }
        //      C# -> IntuneDeviceManagementPolicy? IntuneDeviceManagementPolicy
        // GraphQL -> intuneDeviceManagementPolicy: IntuneDeviceManagementPolicy (type)
        if (ec.Includes("intuneDeviceManagementPolicy",false))
        {
            if(this.IntuneDeviceManagementPolicy == null) {

                this.IntuneDeviceManagementPolicy = new IntuneDeviceManagementPolicy();
                this.IntuneDeviceManagementPolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneDeviceManagementPolicy"));

            } else {

                this.IntuneDeviceManagementPolicy.ApplyExploratoryFieldSpec(ec.NewChild("intuneDeviceManagementPolicy"));

            }
        }
        else if (this.IntuneDeviceManagementPolicy != null && ec.Excludes("intuneDeviceManagementPolicy",false))
        {
            this.IntuneDeviceManagementPolicy = null;
        }
        //      C# -> IntuneEndpointSecurityReusableSetting? IntuneEndpointSecurityReusableSetting
        // GraphQL -> intuneEndpointSecurityReusableSetting: IntuneEndpointSecurityReusableSetting (type)
        if (ec.Includes("intuneEndpointSecurityReusableSetting",false))
        {
            if(this.IntuneEndpointSecurityReusableSetting == null) {

                this.IntuneEndpointSecurityReusableSetting = new IntuneEndpointSecurityReusableSetting();
                this.IntuneEndpointSecurityReusableSetting.ApplyExploratoryFieldSpec(ec.NewChild("intuneEndpointSecurityReusableSetting"));

            } else {

                this.IntuneEndpointSecurityReusableSetting.ApplyExploratoryFieldSpec(ec.NewChild("intuneEndpointSecurityReusableSetting"));

            }
        }
        else if (this.IntuneEndpointSecurityReusableSetting != null && ec.Excludes("intuneEndpointSecurityReusableSetting",false))
        {
            this.IntuneEndpointSecurityReusableSetting = null;
        }
        //      C# -> IntuneNotificationTemplate? IntuneNotificationTemplate
        // GraphQL -> intuneNotificationTemplate: IntuneNotificationTemplate (type)
        if (ec.Includes("intuneNotificationTemplate",false))
        {
            if(this.IntuneNotificationTemplate == null) {

                this.IntuneNotificationTemplate = new IntuneNotificationTemplate();
                this.IntuneNotificationTemplate.ApplyExploratoryFieldSpec(ec.NewChild("intuneNotificationTemplate"));

            } else {

                this.IntuneNotificationTemplate.ApplyExploratoryFieldSpec(ec.NewChild("intuneNotificationTemplate"));

            }
        }
        else if (this.IntuneNotificationTemplate != null && ec.Excludes("intuneNotificationTemplate",false))
        {
            this.IntuneNotificationTemplate = null;
        }
        //      C# -> IntunePolicyAssignment? IntunePolicyAssignment
        // GraphQL -> intunePolicyAssignment: IntunePolicyAssignment (type)
        if (ec.Includes("intunePolicyAssignment",false))
        {
            if(this.IntunePolicyAssignment == null) {

                this.IntunePolicyAssignment = new IntunePolicyAssignment();
                this.IntunePolicyAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intunePolicyAssignment"));

            } else {

                this.IntunePolicyAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intunePolicyAssignment"));

            }
        }
        else if (this.IntunePolicyAssignment != null && ec.Excludes("intunePolicyAssignment",false))
        {
            this.IntunePolicyAssignment = null;
        }
        //      C# -> IntuneRoleAssignment? IntuneRoleAssignment
        // GraphQL -> intuneRoleAssignment: IntuneRoleAssignment (type)
        if (ec.Includes("intuneRoleAssignment",false))
        {
            if(this.IntuneRoleAssignment == null) {

                this.IntuneRoleAssignment = new IntuneRoleAssignment();
                this.IntuneRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneRoleAssignment"));

            } else {

                this.IntuneRoleAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneRoleAssignment"));

            }
        }
        else if (this.IntuneRoleAssignment != null && ec.Excludes("intuneRoleAssignment",false))
        {
            this.IntuneRoleAssignment = null;
        }
        //      C# -> IntuneRoleDefinition? IntuneRoleDefinition
        // GraphQL -> intuneRoleDefinition: IntuneRoleDefinition (type)
        if (ec.Includes("intuneRoleDefinition",false))
        {
            if(this.IntuneRoleDefinition == null) {

                this.IntuneRoleDefinition = new IntuneRoleDefinition();
                this.IntuneRoleDefinition.ApplyExploratoryFieldSpec(ec.NewChild("intuneRoleDefinition"));

            } else {

                this.IntuneRoleDefinition.ApplyExploratoryFieldSpec(ec.NewChild("intuneRoleDefinition"));

            }
        }
        else if (this.IntuneRoleDefinition != null && ec.Excludes("intuneRoleDefinition",false))
        {
            this.IntuneRoleDefinition = null;
        }
        //      C# -> IntuneScopeTag? IntuneScopeTag
        // GraphQL -> intuneScopeTag: IntuneScopeTag (type)
        if (ec.Includes("intuneScopeTag",false))
        {
            if(this.IntuneScopeTag == null) {

                this.IntuneScopeTag = new IntuneScopeTag();
                this.IntuneScopeTag.ApplyExploratoryFieldSpec(ec.NewChild("intuneScopeTag"));

            } else {

                this.IntuneScopeTag.ApplyExploratoryFieldSpec(ec.NewChild("intuneScopeTag"));

            }
        }
        else if (this.IntuneScopeTag != null && ec.Excludes("intuneScopeTag",false))
        {
            this.IntuneScopeTag = null;
        }
        //      C# -> IntuneScopeTagAssignment? IntuneScopeTagAssignment
        // GraphQL -> intuneScopeTagAssignment: IntuneScopeTagAssignment (type)
        if (ec.Includes("intuneScopeTagAssignment",false))
        {
            if(this.IntuneScopeTagAssignment == null) {

                this.IntuneScopeTagAssignment = new IntuneScopeTagAssignment();
                this.IntuneScopeTagAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneScopeTagAssignment"));

            } else {

                this.IntuneScopeTagAssignment.ApplyExploratoryFieldSpec(ec.NewChild("intuneScopeTagAssignment"));

            }
        }
        else if (this.IntuneScopeTagAssignment != null && ec.Excludes("intuneScopeTagAssignment",false))
        {
            this.IntuneScopeTagAssignment = null;
        }
    }


    #endregion

    } // class AzureAdObjects
    
    #endregion

    public static class ListAzureAdObjectsExtensions
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
            this List<AzureAdObjects> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdObjects> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdObjects> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdObjects());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdObjects> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types