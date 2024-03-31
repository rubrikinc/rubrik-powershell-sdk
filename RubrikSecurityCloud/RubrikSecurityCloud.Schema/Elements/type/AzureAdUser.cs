// AzureAdUser.cs
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
    #region AzureAdUser
    public class AzureAdUser: BaseType
    {
        #region members

        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        [JsonProperty("onPremSyncStatus")]
        public AzureAdOnPremSyncStatus? OnPremSyncStatus { get; set; }

        //      C# -> System.String? CreationType
        // GraphQL -> creationType: String! (scalar)
        [JsonProperty("creationType")]
        public System.String? CreationType { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        [JsonProperty("principalUserName")]
        public System.String? PrincipalUserName { get; set; }

        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        [JsonProperty("userType")]
        public System.String? UserType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdUser";
    }

    public AzureAdUser Set(
        AzureAdOnPremSyncStatus? OnPremSyncStatus = null,
        System.String? CreationType = null,
        System.String? DisplayName = null,
        System.String? PrincipalUserName = null,
        System.String? UserType = null
    ) 
    {
        if ( OnPremSyncStatus != null ) {
            this.OnPremSyncStatus = OnPremSyncStatus;
        }
        if ( CreationType != null ) {
            this.CreationType = CreationType;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( PrincipalUserName != null ) {
            this.PrincipalUserName = PrincipalUserName;
        }
        if ( UserType != null ) {
            this.UserType = UserType;
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
        //      C# -> System.String? CreationType
        // GraphQL -> creationType: String! (scalar)
        if (this.CreationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationType\n" ;
            } else {
                s += ind + "creationType\n" ;
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
        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        if (this.PrincipalUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalUserName\n" ;
            } else {
                s += ind + "principalUserName\n" ;
            }
        }
        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        if (this.UserType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userType\n" ;
            } else {
                s += ind + "userType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> System.String? CreationType
        // GraphQL -> creationType: String! (scalar)
        if (ec.Includes("creationType",true))
        {
            if(this.CreationType == null) {

                this.CreationType = "FETCH";

            } else {


            }
        }
        else if (this.CreationType != null && ec.Excludes("creationType",true))
        {
            this.CreationType = null;
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
        //      C# -> System.String? PrincipalUserName
        // GraphQL -> principalUserName: String! (scalar)
        if (ec.Includes("principalUserName",true))
        {
            if(this.PrincipalUserName == null) {

                this.PrincipalUserName = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalUserName != null && ec.Excludes("principalUserName",true))
        {
            this.PrincipalUserName = null;
        }
        //      C# -> System.String? UserType
        // GraphQL -> userType: String! (scalar)
        if (ec.Includes("userType",true))
        {
            if(this.UserType == null) {

                this.UserType = "FETCH";

            } else {


            }
        }
        else if (this.UserType != null && ec.Excludes("userType",true))
        {
            this.UserType = null;
        }
    }


    #endregion

    } // class AzureAdUser
    
    #endregion

    public static class ListAzureAdUserExtensions
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
            this List<AzureAdUser> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdUser> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdUser> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdUser());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdUser> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types