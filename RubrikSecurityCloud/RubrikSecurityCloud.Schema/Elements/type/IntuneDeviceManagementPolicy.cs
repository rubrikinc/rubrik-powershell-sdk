// IntuneDeviceManagementPolicy.cs
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
    #region IntuneDeviceManagementPolicy
    public class IntuneDeviceManagementPolicy: BaseType
    {
        #region members

        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        [JsonProperty("platform")]
        public IntuneDevicePlatformType? Platform { get; set; }

        //      C# -> IntuneDeviceManagementPolicyType? PolicyType
        // GraphQL -> policyType: IntuneDeviceManagementPolicyType! (enum)
        [JsonProperty("policyType")]
        public IntuneDeviceManagementPolicyType? PolicyType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.Int32? FeatureDeferral
        // GraphQL -> featureDeferral: Int! (scalar)
        [JsonProperty("featureDeferral")]
        public System.Int32? FeatureDeferral { get; set; }

        //      C# -> System.String? FeatureUpdateStatus
        // GraphQL -> featureUpdateStatus: String! (scalar)
        [JsonProperty("featureUpdateStatus")]
        public System.String? FeatureUpdateStatus { get; set; }

        //      C# -> System.Boolean? IsAssigned
        // GraphQL -> isAssigned: Boolean! (scalar)
        [JsonProperty("isAssigned")]
        public System.Boolean? IsAssigned { get; set; }

        //      C# -> DateTime? LastModifiedDateTime
        // GraphQL -> lastModifiedDateTime: DateTime (scalar)
        [JsonProperty("lastModifiedDateTime")]
        public DateTime? LastModifiedDateTime { get; set; }

        //      C# -> System.Int32? QualityDeferral
        // GraphQL -> qualityDeferral: Int! (scalar)
        [JsonProperty("qualityDeferral")]
        public System.Int32? QualityDeferral { get; set; }

        //      C# -> System.String? QualityUpdateStatus
        // GraphQL -> qualityUpdateStatus: String! (scalar)
        [JsonProperty("qualityUpdateStatus")]
        public System.String? QualityUpdateStatus { get; set; }

        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        [JsonProperty("roleScopeTagIds")]
        public List<System.String>? RoleScopeTagIds { get; set; }

        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        [JsonProperty("roleScopeTagNames")]
        public List<System.String>? RoleScopeTagNames { get; set; }

        //      C# -> System.String? Target
        // GraphQL -> target: String! (scalar)
        [JsonProperty("target")]
        public System.String? Target { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<IntuneDeviceManagementSecretSetting>? SecretSettings
        // GraphQL -> secretSettings: [IntuneDeviceManagementSecretSetting!]! (type)
        [JsonProperty("secretSettings")]
        public List<IntuneDeviceManagementSecretSetting>? SecretSettings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneDeviceManagementPolicy";
    }

    public IntuneDeviceManagementPolicy Set(
        IntuneDevicePlatformType? Platform = null,
        IntuneDeviceManagementPolicyType? PolicyType = null,
        System.String? DisplayName = null,
        System.Int32? FeatureDeferral = null,
        System.String? FeatureUpdateStatus = null,
        System.Boolean? IsAssigned = null,
        DateTime? LastModifiedDateTime = null,
        System.Int32? QualityDeferral = null,
        System.String? QualityUpdateStatus = null,
        List<System.String>? RoleScopeTagIds = null,
        List<System.String>? RoleScopeTagNames = null,
        System.String? Target = null,
        System.String? Version = null,
        List<IntuneDeviceManagementSecretSetting>? SecretSettings = null
    ) 
    {
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( PolicyType != null ) {
            this.PolicyType = PolicyType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( FeatureDeferral != null ) {
            this.FeatureDeferral = FeatureDeferral;
        }
        if ( FeatureUpdateStatus != null ) {
            this.FeatureUpdateStatus = FeatureUpdateStatus;
        }
        if ( IsAssigned != null ) {
            this.IsAssigned = IsAssigned;
        }
        if ( LastModifiedDateTime != null ) {
            this.LastModifiedDateTime = LastModifiedDateTime;
        }
        if ( QualityDeferral != null ) {
            this.QualityDeferral = QualityDeferral;
        }
        if ( QualityUpdateStatus != null ) {
            this.QualityUpdateStatus = QualityUpdateStatus;
        }
        if ( RoleScopeTagIds != null ) {
            this.RoleScopeTagIds = RoleScopeTagIds;
        }
        if ( RoleScopeTagNames != null ) {
            this.RoleScopeTagNames = RoleScopeTagNames;
        }
        if ( Target != null ) {
            this.Target = Target;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( SecretSettings != null ) {
            this.SecretSettings = SecretSettings;
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
        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> IntuneDeviceManagementPolicyType? PolicyType
        // GraphQL -> policyType: IntuneDeviceManagementPolicyType! (enum)
        if (this.PolicyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyType\n" ;
            } else {
                s += ind + "policyType\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.Int32? FeatureDeferral
        // GraphQL -> featureDeferral: Int! (scalar)
        if (this.FeatureDeferral != null) {
            if (conf.Flat) {
                s += conf.Prefix + "featureDeferral\n" ;
            } else {
                s += ind + "featureDeferral\n" ;
            }
        }
        //      C# -> System.String? FeatureUpdateStatus
        // GraphQL -> featureUpdateStatus: String! (scalar)
        if (this.FeatureUpdateStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "featureUpdateStatus\n" ;
            } else {
                s += ind + "featureUpdateStatus\n" ;
            }
        }
        //      C# -> System.Boolean? IsAssigned
        // GraphQL -> isAssigned: Boolean! (scalar)
        if (this.IsAssigned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAssigned\n" ;
            } else {
                s += ind + "isAssigned\n" ;
            }
        }
        //      C# -> DateTime? LastModifiedDateTime
        // GraphQL -> lastModifiedDateTime: DateTime (scalar)
        if (this.LastModifiedDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedDateTime\n" ;
            } else {
                s += ind + "lastModifiedDateTime\n" ;
            }
        }
        //      C# -> System.Int32? QualityDeferral
        // GraphQL -> qualityDeferral: Int! (scalar)
        if (this.QualityDeferral != null) {
            if (conf.Flat) {
                s += conf.Prefix + "qualityDeferral\n" ;
            } else {
                s += ind + "qualityDeferral\n" ;
            }
        }
        //      C# -> System.String? QualityUpdateStatus
        // GraphQL -> qualityUpdateStatus: String! (scalar)
        if (this.QualityUpdateStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "qualityUpdateStatus\n" ;
            } else {
                s += ind + "qualityUpdateStatus\n" ;
            }
        }
        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        if (this.RoleScopeTagIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTagIds\n" ;
            } else {
                s += ind + "roleScopeTagIds\n" ;
            }
        }
        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        if (this.RoleScopeTagNames != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTagNames\n" ;
            } else {
                s += ind + "roleScopeTagNames\n" ;
            }
        }
        //      C# -> System.String? Target
        // GraphQL -> target: String! (scalar)
        if (this.Target != null) {
            if (conf.Flat) {
                s += conf.Prefix + "target\n" ;
            } else {
                s += ind + "target\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<IntuneDeviceManagementSecretSetting>? SecretSettings
        // GraphQL -> secretSettings: [IntuneDeviceManagementSecretSetting!]! (type)
        if (this.SecretSettings != null) {
            var fspec = this.SecretSettings.AsFieldSpec(conf.Child("secretSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secretSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneDevicePlatformType? Platform
        // GraphQL -> platform: IntuneDevicePlatformType! (enum)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = new IntuneDevicePlatformType();

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> IntuneDeviceManagementPolicyType? PolicyType
        // GraphQL -> policyType: IntuneDeviceManagementPolicyType! (enum)
        if (ec.Includes("policyType",true))
        {
            if(this.PolicyType == null) {

                this.PolicyType = new IntuneDeviceManagementPolicyType();

            } else {


            }
        }
        else if (this.PolicyType != null && ec.Excludes("policyType",true))
        {
            this.PolicyType = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.Int32? FeatureDeferral
        // GraphQL -> featureDeferral: Int! (scalar)
        if (ec.Includes("featureDeferral",true))
        {
            if(this.FeatureDeferral == null) {

                this.FeatureDeferral = Int32.MinValue;

            } else {


            }
        }
        else if (this.FeatureDeferral != null && ec.Excludes("featureDeferral",true))
        {
            this.FeatureDeferral = null;
        }
        //      C# -> System.String? FeatureUpdateStatus
        // GraphQL -> featureUpdateStatus: String! (scalar)
        if (ec.Includes("featureUpdateStatus",true))
        {
            if(this.FeatureUpdateStatus == null) {

                this.FeatureUpdateStatus = "FETCH";

            } else {


            }
        }
        else if (this.FeatureUpdateStatus != null && ec.Excludes("featureUpdateStatus",true))
        {
            this.FeatureUpdateStatus = null;
        }
        //      C# -> System.Boolean? IsAssigned
        // GraphQL -> isAssigned: Boolean! (scalar)
        if (ec.Includes("isAssigned",true))
        {
            if(this.IsAssigned == null) {

                this.IsAssigned = true;

            } else {


            }
        }
        else if (this.IsAssigned != null && ec.Excludes("isAssigned",true))
        {
            this.IsAssigned = null;
        }
        //      C# -> DateTime? LastModifiedDateTime
        // GraphQL -> lastModifiedDateTime: DateTime (scalar)
        if (ec.Includes("lastModifiedDateTime",true))
        {
            if(this.LastModifiedDateTime == null) {

                this.LastModifiedDateTime = new DateTime();

            } else {


            }
        }
        else if (this.LastModifiedDateTime != null && ec.Excludes("lastModifiedDateTime",true))
        {
            this.LastModifiedDateTime = null;
        }
        //      C# -> System.Int32? QualityDeferral
        // GraphQL -> qualityDeferral: Int! (scalar)
        if (ec.Includes("qualityDeferral",true))
        {
            if(this.QualityDeferral == null) {

                this.QualityDeferral = Int32.MinValue;

            } else {


            }
        }
        else if (this.QualityDeferral != null && ec.Excludes("qualityDeferral",true))
        {
            this.QualityDeferral = null;
        }
        //      C# -> System.String? QualityUpdateStatus
        // GraphQL -> qualityUpdateStatus: String! (scalar)
        if (ec.Includes("qualityUpdateStatus",true))
        {
            if(this.QualityUpdateStatus == null) {

                this.QualityUpdateStatus = "FETCH";

            } else {


            }
        }
        else if (this.QualityUpdateStatus != null && ec.Excludes("qualityUpdateStatus",true))
        {
            this.QualityUpdateStatus = null;
        }
        //      C# -> List<System.String>? RoleScopeTagIds
        // GraphQL -> roleScopeTagIds: [String!]! (scalar)
        if (ec.Includes("roleScopeTagIds",true))
        {
            if(this.RoleScopeTagIds == null) {

                this.RoleScopeTagIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTagIds != null && ec.Excludes("roleScopeTagIds",true))
        {
            this.RoleScopeTagIds = null;
        }
        //      C# -> List<System.String>? RoleScopeTagNames
        // GraphQL -> roleScopeTagNames: [String!]! (scalar)
        if (ec.Includes("roleScopeTagNames",true))
        {
            if(this.RoleScopeTagNames == null) {

                this.RoleScopeTagNames = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTagNames != null && ec.Excludes("roleScopeTagNames",true))
        {
            this.RoleScopeTagNames = null;
        }
        //      C# -> System.String? Target
        // GraphQL -> target: String! (scalar)
        if (ec.Includes("target",true))
        {
            if(this.Target == null) {

                this.Target = "FETCH";

            } else {


            }
        }
        else if (this.Target != null && ec.Excludes("target",true))
        {
            this.Target = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<IntuneDeviceManagementSecretSetting>? SecretSettings
        // GraphQL -> secretSettings: [IntuneDeviceManagementSecretSetting!]! (type)
        if (ec.Includes("secretSettings",false))
        {
            if(this.SecretSettings == null) {

                this.SecretSettings = new List<IntuneDeviceManagementSecretSetting>();
                this.SecretSettings.ApplyExploratoryFieldSpec(ec.NewChild("secretSettings"));

            } else {

                this.SecretSettings.ApplyExploratoryFieldSpec(ec.NewChild("secretSettings"));

            }
        }
        else if (this.SecretSettings != null && ec.Excludes("secretSettings",false))
        {
            this.SecretSettings = null;
        }
    }


    #endregion

    } // class IntuneDeviceManagementPolicy
    
    #endregion

    public static class ListIntuneDeviceManagementPolicyExtensions
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
            this List<IntuneDeviceManagementPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneDeviceManagementPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneDeviceManagementPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneDeviceManagementPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneDeviceManagementPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types