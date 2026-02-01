// IntuneCompliancePolicy.cs
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
    #region IntuneCompliancePolicy
    public class IntuneCompliancePolicy: BaseType
    {
        #region members

        //      C# -> IntuneCompliancePolicyPlatform? Platform
        // GraphQL -> platform: IntuneCompliancePolicyPlatform! (enum)
        [JsonProperty("platform")]
        public IntuneCompliancePolicyPlatform? Platform { get; set; }

        //      C# -> IntuneCompliancePolicyType? PolicyType
        // GraphQL -> policyType: IntuneCompliancePolicyType! (enum)
        [JsonProperty("policyType")]
        public IntuneCompliancePolicyType? PolicyType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        [JsonProperty("lastModifiedTime")]
        public DateTime? LastModifiedTime { get; set; }

        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        [JsonProperty("roleScopeTags")]
        public List<System.String>? RoleScopeTags { get; set; }

        //      C# -> System.String? ScriptName
        // GraphQL -> scriptName: String (scalar)
        [JsonProperty("scriptName")]
        public System.String? ScriptName { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IntuneCompliancePolicy";
    }

    public IntuneCompliancePolicy Set(
        IntuneCompliancePolicyPlatform? Platform = null,
        IntuneCompliancePolicyType? PolicyType = null,
        System.String? DisplayName = null,
        DateTime? LastModifiedTime = null,
        List<System.String>? RoleScopeTags = null,
        System.String? ScriptName = null,
        System.String? Version = null
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
        if ( LastModifiedTime != null ) {
            this.LastModifiedTime = LastModifiedTime;
        }
        if ( RoleScopeTags != null ) {
            this.RoleScopeTags = RoleScopeTags;
        }
        if ( ScriptName != null ) {
            this.ScriptName = ScriptName;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> IntuneCompliancePolicyPlatform? Platform
        // GraphQL -> platform: IntuneCompliancePolicyPlatform! (enum)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> IntuneCompliancePolicyType? PolicyType
        // GraphQL -> policyType: IntuneCompliancePolicyType! (enum)
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
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (this.LastModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastModifiedTime\n" ;
            } else {
                s += ind + "lastModifiedTime\n" ;
            }
        }
        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        if (this.RoleScopeTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "roleScopeTags\n" ;
            } else {
                s += ind + "roleScopeTags\n" ;
            }
        }
        //      C# -> System.String? ScriptName
        // GraphQL -> scriptName: String (scalar)
        if (this.ScriptName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "scriptName\n" ;
            } else {
                s += ind + "scriptName\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IntuneCompliancePolicyPlatform? Platform
        // GraphQL -> platform: IntuneCompliancePolicyPlatform! (enum)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = new IntuneCompliancePolicyPlatform();

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> IntuneCompliancePolicyType? PolicyType
        // GraphQL -> policyType: IntuneCompliancePolicyType! (enum)
        if (ec.Includes("policyType",true))
        {
            if(this.PolicyType == null) {

                this.PolicyType = new IntuneCompliancePolicyType();

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
        //      C# -> DateTime? LastModifiedTime
        // GraphQL -> lastModifiedTime: DateTime (scalar)
        if (ec.Includes("lastModifiedTime",true))
        {
            if(this.LastModifiedTime == null) {

                this.LastModifiedTime = new DateTime();

            } else {


            }
        }
        else if (this.LastModifiedTime != null && ec.Excludes("lastModifiedTime",true))
        {
            this.LastModifiedTime = null;
        }
        //      C# -> List<System.String>? RoleScopeTags
        // GraphQL -> roleScopeTags: [String!]! (scalar)
        if (ec.Includes("roleScopeTags",true))
        {
            if(this.RoleScopeTags == null) {

                this.RoleScopeTags = new List<System.String>();

            } else {


            }
        }
        else if (this.RoleScopeTags != null && ec.Excludes("roleScopeTags",true))
        {
            this.RoleScopeTags = null;
        }
        //      C# -> System.String? ScriptName
        // GraphQL -> scriptName: String (scalar)
        if (ec.Includes("scriptName",true))
        {
            if(this.ScriptName == null) {

                this.ScriptName = "FETCH";

            } else {


            }
        }
        else if (this.ScriptName != null && ec.Excludes("scriptName",true))
        {
            this.ScriptName = null;
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
    }


    #endregion

    } // class IntuneCompliancePolicy
    
    #endregion

    public static class ListIntuneCompliancePolicyExtensions
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
            this List<IntuneCompliancePolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IntuneCompliancePolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IntuneCompliancePolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IntuneCompliancePolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IntuneCompliancePolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types