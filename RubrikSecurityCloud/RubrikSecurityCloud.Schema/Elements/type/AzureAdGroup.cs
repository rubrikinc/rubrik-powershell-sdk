// AzureAdGroup.cs
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
    #region AzureAdGroup
    public class AzureAdGroup: BaseType
    {
        #region members

        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        [JsonProperty("onPremSyncStatus")]
        public AzureAdOnPremSyncStatus? OnPremSyncStatus { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        [JsonProperty("groupType")]
        public System.String? GroupType { get; set; }

        //      C# -> System.Boolean? IsPimEnabled
        // GraphQL -> isPimEnabled: Boolean! (scalar)
        [JsonProperty("isPimEnabled")]
        public System.Boolean? IsPimEnabled { get; set; }

        //      C# -> AzureAdPimPolicy? MemberPolicy
        // GraphQL -> memberPolicy: AzureAdPimPolicy (type)
        [JsonProperty("memberPolicy")]
        public AzureAdPimPolicy? MemberPolicy { get; set; }

        //      C# -> AzureAdOnPremSyncInfo? OnPremSyncInfo
        // GraphQL -> onPremSyncInfo: AzureAdOnPremSyncInfo (type)
        [JsonProperty("onPremSyncInfo")]
        public AzureAdOnPremSyncInfo? OnPremSyncInfo { get; set; }

        //      C# -> AzureAdPimPolicy? OwnerPolicy
        // GraphQL -> ownerPolicy: AzureAdPimPolicy (type)
        [JsonProperty("ownerPolicy")]
        public AzureAdPimPolicy? OwnerPolicy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdGroup";
    }

    public AzureAdGroup Set(
        AzureAdOnPremSyncStatus? OnPremSyncStatus = null,
        System.String? DisplayName = null,
        System.String? Email = null,
        System.String? GroupType = null,
        System.Boolean? IsPimEnabled = null,
        AzureAdPimPolicy? MemberPolicy = null,
        AzureAdOnPremSyncInfo? OnPremSyncInfo = null,
        AzureAdPimPolicy? OwnerPolicy = null
    ) 
    {
        if ( OnPremSyncStatus != null ) {
            this.OnPremSyncStatus = OnPremSyncStatus;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( Email != null ) {
            this.Email = Email;
        }
        if ( GroupType != null ) {
            this.GroupType = GroupType;
        }
        if ( IsPimEnabled != null ) {
            this.IsPimEnabled = IsPimEnabled;
        }
        if ( MemberPolicy != null ) {
            this.MemberPolicy = MemberPolicy;
        }
        if ( OnPremSyncInfo != null ) {
            this.OnPremSyncInfo = OnPremSyncInfo;
        }
        if ( OwnerPolicy != null ) {
            this.OwnerPolicy = OwnerPolicy;
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
        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        if (this.OnPremSyncStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremSyncStatus\n" ;
            } else {
                s += ind + "onPremSyncStatus\n" ;
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
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (this.Email != null) {
            if (conf.Flat) {
                s += conf.Prefix + "email\n" ;
            } else {
                s += ind + "email\n" ;
            }
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (this.GroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupType\n" ;
            } else {
                s += ind + "groupType\n" ;
            }
        }
        //      C# -> System.Boolean? IsPimEnabled
        // GraphQL -> isPimEnabled: Boolean! (scalar)
        if (this.IsPimEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPimEnabled\n" ;
            } else {
                s += ind + "isPimEnabled\n" ;
            }
        }
        //      C# -> AzureAdPimPolicy? MemberPolicy
        // GraphQL -> memberPolicy: AzureAdPimPolicy (type)
        if (this.MemberPolicy != null) {
            var fspec = this.MemberPolicy.AsFieldSpec(conf.Child("memberPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "memberPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdOnPremSyncInfo? OnPremSyncInfo
        // GraphQL -> onPremSyncInfo: AzureAdOnPremSyncInfo (type)
        if (this.OnPremSyncInfo != null) {
            var fspec = this.OnPremSyncInfo.AsFieldSpec(conf.Child("onPremSyncInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onPremSyncInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdPimPolicy? OwnerPolicy
        // GraphQL -> ownerPolicy: AzureAdPimPolicy (type)
        if (this.OwnerPolicy != null) {
            var fspec = this.OwnerPolicy.AsFieldSpec(conf.Child("ownerPolicy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ownerPolicy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        if (ec.Includes("onPremSyncStatus",true))
        {
            if(this.OnPremSyncStatus == null) {

                this.OnPremSyncStatus = new AzureAdOnPremSyncStatus();

            } else {


            }
        }
        else if (this.OnPremSyncStatus != null && ec.Excludes("onPremSyncStatus",true))
        {
            this.OnPremSyncStatus = null;
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
        //      C# -> System.String? Email
        // GraphQL -> email: String! (scalar)
        if (ec.Includes("email",true))
        {
            if(this.Email == null) {

                this.Email = "FETCH";

            } else {


            }
        }
        else if (this.Email != null && ec.Excludes("email",true))
        {
            this.Email = null;
        }
        //      C# -> System.String? GroupType
        // GraphQL -> groupType: String! (scalar)
        if (ec.Includes("groupType",true))
        {
            if(this.GroupType == null) {

                this.GroupType = "FETCH";

            } else {


            }
        }
        else if (this.GroupType != null && ec.Excludes("groupType",true))
        {
            this.GroupType = null;
        }
        //      C# -> System.Boolean? IsPimEnabled
        // GraphQL -> isPimEnabled: Boolean! (scalar)
        if (ec.Includes("isPimEnabled",true))
        {
            if(this.IsPimEnabled == null) {

                this.IsPimEnabled = true;

            } else {


            }
        }
        else if (this.IsPimEnabled != null && ec.Excludes("isPimEnabled",true))
        {
            this.IsPimEnabled = null;
        }
        //      C# -> AzureAdPimPolicy? MemberPolicy
        // GraphQL -> memberPolicy: AzureAdPimPolicy (type)
        if (ec.Includes("memberPolicy",false))
        {
            if(this.MemberPolicy == null) {

                this.MemberPolicy = new AzureAdPimPolicy();
                this.MemberPolicy.ApplyExploratoryFieldSpec(ec.NewChild("memberPolicy"));

            } else {

                this.MemberPolicy.ApplyExploratoryFieldSpec(ec.NewChild("memberPolicy"));

            }
        }
        else if (this.MemberPolicy != null && ec.Excludes("memberPolicy",false))
        {
            this.MemberPolicy = null;
        }
        //      C# -> AzureAdOnPremSyncInfo? OnPremSyncInfo
        // GraphQL -> onPremSyncInfo: AzureAdOnPremSyncInfo (type)
        if (ec.Includes("onPremSyncInfo",false))
        {
            if(this.OnPremSyncInfo == null) {

                this.OnPremSyncInfo = new AzureAdOnPremSyncInfo();
                this.OnPremSyncInfo.ApplyExploratoryFieldSpec(ec.NewChild("onPremSyncInfo"));

            } else {

                this.OnPremSyncInfo.ApplyExploratoryFieldSpec(ec.NewChild("onPremSyncInfo"));

            }
        }
        else if (this.OnPremSyncInfo != null && ec.Excludes("onPremSyncInfo",false))
        {
            this.OnPremSyncInfo = null;
        }
        //      C# -> AzureAdPimPolicy? OwnerPolicy
        // GraphQL -> ownerPolicy: AzureAdPimPolicy (type)
        if (ec.Includes("ownerPolicy",false))
        {
            if(this.OwnerPolicy == null) {

                this.OwnerPolicy = new AzureAdPimPolicy();
                this.OwnerPolicy.ApplyExploratoryFieldSpec(ec.NewChild("ownerPolicy"));

            } else {

                this.OwnerPolicy.ApplyExploratoryFieldSpec(ec.NewChild("ownerPolicy"));

            }
        }
        else if (this.OwnerPolicy != null && ec.Excludes("ownerPolicy",false))
        {
            this.OwnerPolicy = null;
        }
    }


    #endregion

    } // class AzureAdGroup
    
    #endregion

    public static class ListAzureAdGroupExtensions
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
            this List<AzureAdGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdGroup> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types