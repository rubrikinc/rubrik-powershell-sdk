// AzureArmTemplateByFeature.cs
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
    #region AzureArmTemplateByFeature
    public class AzureArmTemplateByFeature: BaseType
    {
        #region members

        //      C# -> ArmTemplateDeploymentLevel? DeploymentLevel
        // GraphQL -> deploymentLevel: ArmTemplateDeploymentLevel! (enum)
        [JsonProperty("deploymentLevel")]
        public ArmTemplateDeploymentLevel? DeploymentLevel { get; set; }

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> System.String? RoleDefinitionAssignmentTemplate
        // GraphQL -> roleDefinitionAssignmentTemplate: String! (scalar)
        [JsonProperty("roleDefinitionAssignmentTemplate")]
        public System.String? RoleDefinitionAssignmentTemplate { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        [JsonProperty("permissionsGroupVersions")]
        public List<PermissionsGroupWithVersion>? PermissionsGroupVersions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureArmTemplateByFeature";
    }

    public AzureArmTemplateByFeature Set(
        ArmTemplateDeploymentLevel? DeploymentLevel = null,
        CloudAccountFeature? Feature = null,
        System.String? RoleDefinitionAssignmentTemplate = null,
        System.Int32? Version = null,
        List<PermissionsGroupWithVersion>? PermissionsGroupVersions = null
    ) 
    {
        if ( DeploymentLevel != null ) {
            this.DeploymentLevel = DeploymentLevel;
        }
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( RoleDefinitionAssignmentTemplate != null ) {
            this.RoleDefinitionAssignmentTemplate = RoleDefinitionAssignmentTemplate;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( PermissionsGroupVersions != null ) {
            this.PermissionsGroupVersions = PermissionsGroupVersions;
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
        //      C# -> ArmTemplateDeploymentLevel? DeploymentLevel
        // GraphQL -> deploymentLevel: ArmTemplateDeploymentLevel! (enum)
        if (this.DeploymentLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deploymentLevel\n" ;
            } else {
                s += ind + "deploymentLevel\n" ;
            }
        }
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> System.String? RoleDefinitionAssignmentTemplate
        // GraphQL -> roleDefinitionAssignmentTemplate: String! (scalar)
        if (this.RoleDefinitionAssignmentTemplate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleDefinitionAssignmentTemplate\n" ;
            } else {
                s += ind + "roleDefinitionAssignmentTemplate\n" ;
            }
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (this.PermissionsGroupVersions != null) {
            var fspec = this.PermissionsGroupVersions.AsFieldSpec(conf.Child("permissionsGroupVersions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissionsGroupVersions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ArmTemplateDeploymentLevel? DeploymentLevel
        // GraphQL -> deploymentLevel: ArmTemplateDeploymentLevel! (enum)
        if (ec.Includes("deploymentLevel",true))
        {
            if(this.DeploymentLevel == null) {

                this.DeploymentLevel = new ArmTemplateDeploymentLevel();

            } else {


            }
        }
        else if (this.DeploymentLevel != null && ec.Excludes("deploymentLevel",true))
        {
            this.DeploymentLevel = null;
        }
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
        //      C# -> System.String? RoleDefinitionAssignmentTemplate
        // GraphQL -> roleDefinitionAssignmentTemplate: String! (scalar)
        if (ec.Includes("roleDefinitionAssignmentTemplate",true))
        {
            if(this.RoleDefinitionAssignmentTemplate == null) {

                this.RoleDefinitionAssignmentTemplate = "FETCH";

            } else {


            }
        }
        else if (this.RoleDefinitionAssignmentTemplate != null && ec.Excludes("roleDefinitionAssignmentTemplate",true))
        {
            this.RoleDefinitionAssignmentTemplate = null;
        }
        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = Int32.MinValue;

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<PermissionsGroupWithVersion>? PermissionsGroupVersions
        // GraphQL -> permissionsGroupVersions: [PermissionsGroupWithVersion!]! (type)
        if (ec.Includes("permissionsGroupVersions",false))
        {
            if(this.PermissionsGroupVersions == null) {

                this.PermissionsGroupVersions = new List<PermissionsGroupWithVersion>();
                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            } else {

                this.PermissionsGroupVersions.ApplyExploratoryFieldSpec(ec.NewChild("permissionsGroupVersions"));

            }
        }
        else if (this.PermissionsGroupVersions != null && ec.Excludes("permissionsGroupVersions",false))
        {
            this.PermissionsGroupVersions = null;
        }
    }


    #endregion

    } // class AzureArmTemplateByFeature
    
    #endregion

    public static class ListAzureArmTemplateByFeatureExtensions
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
            this List<AzureArmTemplateByFeature> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureArmTemplateByFeature> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureArmTemplateByFeature> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureArmTemplateByFeature());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureArmTemplateByFeature> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types