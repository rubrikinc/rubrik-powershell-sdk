// GitHubAppStatusInfo.cs
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
    #region GitHubAppStatusInfo
    public class GitHubAppStatusInfo: BaseType
    {
        #region members

        //      C# -> GitHubAppInstallationInfo? InstallationInfo
        // GraphQL -> installationInfo: GitHubAppInstallationInfo (type)
        [JsonProperty("installationInfo")]
        public GitHubAppInstallationInfo? InstallationInfo { get; set; }

        //      C# -> GitHubAppRegistrationInfo? RegistrationInfo
        // GraphQL -> registrationInfo: GitHubAppRegistrationInfo (type)
        [JsonProperty("registrationInfo")]
        public GitHubAppRegistrationInfo? RegistrationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GitHubAppStatusInfo";
    }

    public GitHubAppStatusInfo Set(
        GitHubAppInstallationInfo? InstallationInfo = null,
        GitHubAppRegistrationInfo? RegistrationInfo = null
    ) 
    {
        if ( InstallationInfo != null ) {
            this.InstallationInfo = InstallationInfo;
        }
        if ( RegistrationInfo != null ) {
            this.RegistrationInfo = RegistrationInfo;
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
        //      C# -> GitHubAppInstallationInfo? InstallationInfo
        // GraphQL -> installationInfo: GitHubAppInstallationInfo (type)
        if (this.InstallationInfo != null) {
            var fspec = this.InstallationInfo.AsFieldSpec(conf.Child("installationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "installationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> GitHubAppRegistrationInfo? RegistrationInfo
        // GraphQL -> registrationInfo: GitHubAppRegistrationInfo (type)
        if (this.RegistrationInfo != null) {
            var fspec = this.RegistrationInfo.AsFieldSpec(conf.Child("registrationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "registrationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> GitHubAppInstallationInfo? InstallationInfo
        // GraphQL -> installationInfo: GitHubAppInstallationInfo (type)
        if (ec.Includes("installationInfo",false))
        {
            if(this.InstallationInfo == null) {

                this.InstallationInfo = new GitHubAppInstallationInfo();
                this.InstallationInfo.ApplyExploratoryFieldSpec(ec.NewChild("installationInfo"));

            } else {

                this.InstallationInfo.ApplyExploratoryFieldSpec(ec.NewChild("installationInfo"));

            }
        }
        else if (this.InstallationInfo != null && ec.Excludes("installationInfo",false))
        {
            this.InstallationInfo = null;
        }
        //      C# -> GitHubAppRegistrationInfo? RegistrationInfo
        // GraphQL -> registrationInfo: GitHubAppRegistrationInfo (type)
        if (ec.Includes("registrationInfo",false))
        {
            if(this.RegistrationInfo == null) {

                this.RegistrationInfo = new GitHubAppRegistrationInfo();
                this.RegistrationInfo.ApplyExploratoryFieldSpec(ec.NewChild("registrationInfo"));

            } else {

                this.RegistrationInfo.ApplyExploratoryFieldSpec(ec.NewChild("registrationInfo"));

            }
        }
        else if (this.RegistrationInfo != null && ec.Excludes("registrationInfo",false))
        {
            this.RegistrationInfo = null;
        }
    }


    #endregion

    } // class GitHubAppStatusInfo
    
    #endregion

    public static class ListGitHubAppStatusInfoExtensions
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
            this List<GitHubAppStatusInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GitHubAppStatusInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GitHubAppStatusInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GitHubAppStatusInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GitHubAppStatusInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types