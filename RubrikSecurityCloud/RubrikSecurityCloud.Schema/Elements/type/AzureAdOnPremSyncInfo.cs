// AzureAdOnPremSyncInfo.cs
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
    #region AzureAdOnPremSyncInfo
    public class AzureAdOnPremSyncInfo: BaseType
    {
        #region members

        //      C# -> AzureAdOnPremSyncStatus? OnPremSyncStatus
        // GraphQL -> onPremSyncStatus: AzureAdOnPremSyncStatus! (enum)
        [JsonProperty("onPremSyncStatus")]
        public AzureAdOnPremSyncStatus? OnPremSyncStatus { get; set; }

        //      C# -> System.Boolean? IsSourceOnPremAdProtected
        // GraphQL -> isSourceOnPremAdProtected: Boolean! (scalar)
        [JsonProperty("isSourceOnPremAdProtected")]
        public System.Boolean? IsSourceOnPremAdProtected { get; set; }

        //      C# -> System.String? OnPremAdDomainName
        // GraphQL -> onPremAdDomainName: String! (scalar)
        [JsonProperty("onPremAdDomainName")]
        public System.String? OnPremAdDomainName { get; set; }

        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        [JsonProperty("onPremAdSecurityId")]
        public System.String? OnPremAdSecurityId { get; set; }

        //      C# -> DateTime? OnPremLastSyncTime
        // GraphQL -> onPremLastSyncTime: DateTime (scalar)
        [JsonProperty("onPremLastSyncTime")]
        public DateTime? OnPremLastSyncTime { get; set; }

        //      C# -> System.String? OnPremSecurityId
        // GraphQL -> onPremSecurityId: String! (scalar)
        [JsonProperty("onPremSecurityId")]
        public System.String? OnPremSecurityId { get; set; }

        //      C# -> System.String? OnPremUserPrincipalName
        // GraphQL -> onPremUserPrincipalName: String! (scalar)
        [JsonProperty("onPremUserPrincipalName")]
        public System.String? OnPremUserPrincipalName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdOnPremSyncInfo";
    }

    public AzureAdOnPremSyncInfo Set(
        AzureAdOnPremSyncStatus? OnPremSyncStatus = null,
        System.Boolean? IsSourceOnPremAdProtected = null,
        System.String? OnPremAdDomainName = null,
        System.String? OnPremAdSecurityId = null,
        DateTime? OnPremLastSyncTime = null,
        System.String? OnPremSecurityId = null,
        System.String? OnPremUserPrincipalName = null
    ) 
    {
        if ( OnPremSyncStatus != null ) {
            this.OnPremSyncStatus = OnPremSyncStatus;
        }
        if ( IsSourceOnPremAdProtected != null ) {
            this.IsSourceOnPremAdProtected = IsSourceOnPremAdProtected;
        }
        if ( OnPremAdDomainName != null ) {
            this.OnPremAdDomainName = OnPremAdDomainName;
        }
        if ( OnPremAdSecurityId != null ) {
            this.OnPremAdSecurityId = OnPremAdSecurityId;
        }
        if ( OnPremLastSyncTime != null ) {
            this.OnPremLastSyncTime = OnPremLastSyncTime;
        }
        if ( OnPremSecurityId != null ) {
            this.OnPremSecurityId = OnPremSecurityId;
        }
        if ( OnPremUserPrincipalName != null ) {
            this.OnPremUserPrincipalName = OnPremUserPrincipalName;
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
        //      C# -> System.Boolean? IsSourceOnPremAdProtected
        // GraphQL -> isSourceOnPremAdProtected: Boolean! (scalar)
        if (this.IsSourceOnPremAdProtected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSourceOnPremAdProtected\n" ;
            } else {
                s += ind + "isSourceOnPremAdProtected\n" ;
            }
        }
        //      C# -> System.String? OnPremAdDomainName
        // GraphQL -> onPremAdDomainName: String! (scalar)
        if (this.OnPremAdDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremAdDomainName\n" ;
            } else {
                s += ind + "onPremAdDomainName\n" ;
            }
        }
        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        if (this.OnPremAdSecurityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremAdSecurityId\n" ;
            } else {
                s += ind + "onPremAdSecurityId\n" ;
            }
        }
        //      C# -> DateTime? OnPremLastSyncTime
        // GraphQL -> onPremLastSyncTime: DateTime (scalar)
        if (this.OnPremLastSyncTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremLastSyncTime\n" ;
            } else {
                s += ind + "onPremLastSyncTime\n" ;
            }
        }
        //      C# -> System.String? OnPremSecurityId
        // GraphQL -> onPremSecurityId: String! (scalar)
        if (this.OnPremSecurityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremSecurityId\n" ;
            } else {
                s += ind + "onPremSecurityId\n" ;
            }
        }
        //      C# -> System.String? OnPremUserPrincipalName
        // GraphQL -> onPremUserPrincipalName: String! (scalar)
        if (this.OnPremUserPrincipalName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onPremUserPrincipalName\n" ;
            } else {
                s += ind + "onPremUserPrincipalName\n" ;
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
        //      C# -> System.Boolean? IsSourceOnPremAdProtected
        // GraphQL -> isSourceOnPremAdProtected: Boolean! (scalar)
        if (ec.Includes("isSourceOnPremAdProtected",true))
        {
            if(this.IsSourceOnPremAdProtected == null) {

                this.IsSourceOnPremAdProtected = true;

            } else {


            }
        }
        else if (this.IsSourceOnPremAdProtected != null && ec.Excludes("isSourceOnPremAdProtected",true))
        {
            this.IsSourceOnPremAdProtected = null;
        }
        //      C# -> System.String? OnPremAdDomainName
        // GraphQL -> onPremAdDomainName: String! (scalar)
        if (ec.Includes("onPremAdDomainName",true))
        {
            if(this.OnPremAdDomainName == null) {

                this.OnPremAdDomainName = "FETCH";

            } else {


            }
        }
        else if (this.OnPremAdDomainName != null && ec.Excludes("onPremAdDomainName",true))
        {
            this.OnPremAdDomainName = null;
        }
        //      C# -> System.String? OnPremAdSecurityId
        // GraphQL -> onPremAdSecurityId: String! (scalar)
        if (ec.Includes("onPremAdSecurityId",true))
        {
            if(this.OnPremAdSecurityId == null) {

                this.OnPremAdSecurityId = "FETCH";

            } else {


            }
        }
        else if (this.OnPremAdSecurityId != null && ec.Excludes("onPremAdSecurityId",true))
        {
            this.OnPremAdSecurityId = null;
        }
        //      C# -> DateTime? OnPremLastSyncTime
        // GraphQL -> onPremLastSyncTime: DateTime (scalar)
        if (ec.Includes("onPremLastSyncTime",true))
        {
            if(this.OnPremLastSyncTime == null) {

                this.OnPremLastSyncTime = new DateTime();

            } else {


            }
        }
        else if (this.OnPremLastSyncTime != null && ec.Excludes("onPremLastSyncTime",true))
        {
            this.OnPremLastSyncTime = null;
        }
        //      C# -> System.String? OnPremSecurityId
        // GraphQL -> onPremSecurityId: String! (scalar)
        if (ec.Includes("onPremSecurityId",true))
        {
            if(this.OnPremSecurityId == null) {

                this.OnPremSecurityId = "FETCH";

            } else {


            }
        }
        else if (this.OnPremSecurityId != null && ec.Excludes("onPremSecurityId",true))
        {
            this.OnPremSecurityId = null;
        }
        //      C# -> System.String? OnPremUserPrincipalName
        // GraphQL -> onPremUserPrincipalName: String! (scalar)
        if (ec.Includes("onPremUserPrincipalName",true))
        {
            if(this.OnPremUserPrincipalName == null) {

                this.OnPremUserPrincipalName = "FETCH";

            } else {


            }
        }
        else if (this.OnPremUserPrincipalName != null && ec.Excludes("onPremUserPrincipalName",true))
        {
            this.OnPremUserPrincipalName = null;
        }
    }


    #endregion

    } // class AzureAdOnPremSyncInfo
    
    #endregion

    public static class ListAzureAdOnPremSyncInfoExtensions
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
            this List<AzureAdOnPremSyncInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdOnPremSyncInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdOnPremSyncInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdOnPremSyncInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdOnPremSyncInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types