// StartGitHubAppSetupReply.cs
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
    #region StartGitHubAppSetupReply
    public class StartGitHubAppSetupReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsOrgPublicalyDiscoverable
        // GraphQL -> isOrgPublicalyDiscoverable: Boolean! (scalar)
        [JsonProperty("isOrgPublicalyDiscoverable")]
        public System.Boolean? IsOrgPublicalyDiscoverable { get; set; }

        //      C# -> System.Boolean? OrgAlreadyAdded
        // GraphQL -> orgAlreadyAdded: Boolean! (scalar)
        [JsonProperty("orgAlreadyAdded")]
        public System.Boolean? OrgAlreadyAdded { get; set; }

        //      C# -> List<GitHubAppSetupInfo>? AppSetupInfo
        // GraphQL -> appSetupInfo: [GitHubAppSetupInfo!]! (type)
        [JsonProperty("appSetupInfo")]
        public List<GitHubAppSetupInfo>? AppSetupInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "StartGitHubAppSetupReply";
    }

    public StartGitHubAppSetupReply Set(
        System.Boolean? IsOrgPublicalyDiscoverable = null,
        System.Boolean? OrgAlreadyAdded = null,
        List<GitHubAppSetupInfo>? AppSetupInfo = null
    ) 
    {
        if ( IsOrgPublicalyDiscoverable != null ) {
            this.IsOrgPublicalyDiscoverable = IsOrgPublicalyDiscoverable;
        }
        if ( OrgAlreadyAdded != null ) {
            this.OrgAlreadyAdded = OrgAlreadyAdded;
        }
        if ( AppSetupInfo != null ) {
            this.AppSetupInfo = AppSetupInfo;
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
        //      C# -> System.Boolean? IsOrgPublicalyDiscoverable
        // GraphQL -> isOrgPublicalyDiscoverable: Boolean! (scalar)
        if (this.IsOrgPublicalyDiscoverable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOrgPublicalyDiscoverable\n" ;
            } else {
                s += ind + "isOrgPublicalyDiscoverable\n" ;
            }
        }
        //      C# -> System.Boolean? OrgAlreadyAdded
        // GraphQL -> orgAlreadyAdded: Boolean! (scalar)
        if (this.OrgAlreadyAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgAlreadyAdded\n" ;
            } else {
                s += ind + "orgAlreadyAdded\n" ;
            }
        }
        //      C# -> List<GitHubAppSetupInfo>? AppSetupInfo
        // GraphQL -> appSetupInfo: [GitHubAppSetupInfo!]! (type)
        if (this.AppSetupInfo != null) {
            var fspec = this.AppSetupInfo.AsFieldSpec(conf.Child("appSetupInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "appSetupInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsOrgPublicalyDiscoverable
        // GraphQL -> isOrgPublicalyDiscoverable: Boolean! (scalar)
        if (ec.Includes("isOrgPublicalyDiscoverable",true))
        {
            if(this.IsOrgPublicalyDiscoverable == null) {

                this.IsOrgPublicalyDiscoverable = true;

            } else {


            }
        }
        else if (this.IsOrgPublicalyDiscoverable != null && ec.Excludes("isOrgPublicalyDiscoverable",true))
        {
            this.IsOrgPublicalyDiscoverable = null;
        }
        //      C# -> System.Boolean? OrgAlreadyAdded
        // GraphQL -> orgAlreadyAdded: Boolean! (scalar)
        if (ec.Includes("orgAlreadyAdded",true))
        {
            if(this.OrgAlreadyAdded == null) {

                this.OrgAlreadyAdded = true;

            } else {


            }
        }
        else if (this.OrgAlreadyAdded != null && ec.Excludes("orgAlreadyAdded",true))
        {
            this.OrgAlreadyAdded = null;
        }
        //      C# -> List<GitHubAppSetupInfo>? AppSetupInfo
        // GraphQL -> appSetupInfo: [GitHubAppSetupInfo!]! (type)
        if (ec.Includes("appSetupInfo",false))
        {
            if(this.AppSetupInfo == null) {

                this.AppSetupInfo = new List<GitHubAppSetupInfo>();
                this.AppSetupInfo.ApplyExploratoryFieldSpec(ec.NewChild("appSetupInfo"));

            } else {

                this.AppSetupInfo.ApplyExploratoryFieldSpec(ec.NewChild("appSetupInfo"));

            }
        }
        else if (this.AppSetupInfo != null && ec.Excludes("appSetupInfo",false))
        {
            this.AppSetupInfo = null;
        }
    }


    #endregion

    } // class StartGitHubAppSetupReply
    
    #endregion

    public static class ListStartGitHubAppSetupReplyExtensions
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
            this List<StartGitHubAppSetupReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<StartGitHubAppSetupReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<StartGitHubAppSetupReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new StartGitHubAppSetupReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<StartGitHubAppSetupReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types