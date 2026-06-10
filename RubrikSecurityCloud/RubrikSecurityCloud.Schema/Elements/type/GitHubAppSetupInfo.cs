// GitHubAppSetupInfo.cs
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
    #region GitHubAppSetupInfo
    public class GitHubAppSetupInfo: BaseType
    {
        #region members

        //      C# -> PermissionsGroup? AppPurpose
        // GraphQL -> appPurpose: PermissionsGroup! (enum)
        [JsonProperty("appPurpose")]
        public PermissionsGroup? AppPurpose { get; set; }

        //      C# -> GitHubAppStatus? AppStatus
        // GraphQL -> appStatus: GitHubAppStatus! (enum)
        [JsonProperty("appStatus")]
        public GitHubAppStatus? AppStatus { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        //      C# -> GitHubAppStatusInfo? StatusInfo
        // GraphQL -> statusInfo: GitHubAppStatusInfo (type)
        [JsonProperty("statusInfo")]
        public GitHubAppStatusInfo? StatusInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GitHubAppSetupInfo";
    }

    public GitHubAppSetupInfo Set(
        PermissionsGroup? AppPurpose = null,
        GitHubAppStatus? AppStatus = null,
        System.String? SessionId = null,
        GitHubAppStatusInfo? StatusInfo = null
    ) 
    {
        if ( AppPurpose != null ) {
            this.AppPurpose = AppPurpose;
        }
        if ( AppStatus != null ) {
            this.AppStatus = AppStatus;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
        }
        if ( StatusInfo != null ) {
            this.StatusInfo = StatusInfo;
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
        //      C# -> PermissionsGroup? AppPurpose
        // GraphQL -> appPurpose: PermissionsGroup! (enum)
        if (this.AppPurpose != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appPurpose\n" ;
            } else {
                s += ind + "appPurpose\n" ;
            }
        }
        //      C# -> GitHubAppStatus? AppStatus
        // GraphQL -> appStatus: GitHubAppStatus! (enum)
        if (this.AppStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appStatus\n" ;
            } else {
                s += ind + "appStatus\n" ;
            }
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (this.SessionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sessionId\n" ;
            } else {
                s += ind + "sessionId\n" ;
            }
        }
        //      C# -> GitHubAppStatusInfo? StatusInfo
        // GraphQL -> statusInfo: GitHubAppStatusInfo (type)
        if (this.StatusInfo != null) {
            var fspec = this.StatusInfo.AsFieldSpec(conf.Child("statusInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PermissionsGroup? AppPurpose
        // GraphQL -> appPurpose: PermissionsGroup! (enum)
        if (ec.Includes("appPurpose",true))
        {
            if(this.AppPurpose == null) {

                this.AppPurpose = new PermissionsGroup();

            } else {


            }
        }
        else if (this.AppPurpose != null && ec.Excludes("appPurpose",true))
        {
            this.AppPurpose = null;
        }
        //      C# -> GitHubAppStatus? AppStatus
        // GraphQL -> appStatus: GitHubAppStatus! (enum)
        if (ec.Includes("appStatus",true))
        {
            if(this.AppStatus == null) {

                this.AppStatus = new GitHubAppStatus();

            } else {


            }
        }
        else if (this.AppStatus != null && ec.Excludes("appStatus",true))
        {
            this.AppStatus = null;
        }
        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        if (ec.Includes("sessionId",true))
        {
            if(this.SessionId == null) {

                this.SessionId = "FETCH";

            } else {


            }
        }
        else if (this.SessionId != null && ec.Excludes("sessionId",true))
        {
            this.SessionId = null;
        }
        //      C# -> GitHubAppStatusInfo? StatusInfo
        // GraphQL -> statusInfo: GitHubAppStatusInfo (type)
        if (ec.Includes("statusInfo",false))
        {
            if(this.StatusInfo == null) {

                this.StatusInfo = new GitHubAppStatusInfo();
                this.StatusInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusInfo"));

            } else {

                this.StatusInfo.ApplyExploratoryFieldSpec(ec.NewChild("statusInfo"));

            }
        }
        else if (this.StatusInfo != null && ec.Excludes("statusInfo",false))
        {
            this.StatusInfo = null;
        }
    }


    #endregion

    } // class GitHubAppSetupInfo
    
    #endregion

    public static class ListGitHubAppSetupInfoExtensions
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
            this List<GitHubAppSetupInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GitHubAppSetupInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GitHubAppSetupInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GitHubAppSetupInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GitHubAppSetupInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types