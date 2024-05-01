// O365App.cs
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
    #region O365App
 
    public class O365App: BaseType, O365AppObject
    {
        #region members

        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        [JsonProperty("appAuthStatus")]
        public AppAuthStatus? AppAuthStatus { get; set; }

        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        [JsonProperty("addedAt")]
        public DateTime? AddedAt { get; set; }

        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        [JsonProperty("appAuthVersion")]
        public System.Int32? AppAuthVersion { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        [JsonProperty("appOwner")]
        public System.String? AppOwner { get; set; }

        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        [JsonProperty("appType")]
        public System.String? AppType { get; set; }

        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        [JsonProperty("isAuthenticated")]
        public System.Boolean? IsAuthenticated { get; set; }

        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        [JsonProperty("subscription")]
        public System.String? Subscription { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365App";
    }

    public O365App Set(
        AppAuthStatus? AppAuthStatus = null,
        DateTime? AddedAt = null,
        System.Int32? AppAuthVersion = null,
        System.String? AppId = null,
        System.String? AppOwner = null,
        System.String? AppType = null,
        System.Boolean? IsAuthenticated = null,
        System.String? Subscription = null,
        System.String? SubscriptionId = null
    ) 
    {
        if ( AppAuthStatus != null ) {
            this.AppAuthStatus = AppAuthStatus;
        }
        if ( AddedAt != null ) {
            this.AddedAt = AddedAt;
        }
        if ( AppAuthVersion != null ) {
            this.AppAuthVersion = AppAuthVersion;
        }
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppOwner != null ) {
            this.AppOwner = AppOwner;
        }
        if ( AppType != null ) {
            this.AppType = AppType;
        }
        if ( IsAuthenticated != null ) {
            this.IsAuthenticated = IsAuthenticated;
        }
        if ( Subscription != null ) {
            this.Subscription = Subscription;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        if (this.AppAuthStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appAuthStatus\n" ;
            } else {
                s += ind + "appAuthStatus\n" ;
            }
        }
        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        if (this.AddedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "addedAt\n" ;
            } else {
                s += ind + "addedAt\n" ;
            }
        }
        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        if (this.AppAuthVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appAuthVersion\n" ;
            } else {
                s += ind + "appAuthVersion\n" ;
            }
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        if (this.AppOwner != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appOwner\n" ;
            } else {
                s += ind + "appOwner\n" ;
            }
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (this.AppType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appType\n" ;
            } else {
                s += ind + "appType\n" ;
            }
        }
        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        if (this.IsAuthenticated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAuthenticated\n" ;
            } else {
                s += ind + "isAuthenticated\n" ;
            }
        }
        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        if (this.Subscription != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscription\n" ;
            } else {
                s += ind + "subscription\n" ;
            }
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        if (ec.Includes("appAuthStatus",true))
        {
            if(this.AppAuthStatus == null) {

                this.AppAuthStatus = new AppAuthStatus();

            } else {


            }
        }
        else if (this.AppAuthStatus != null && ec.Excludes("appAuthStatus",true))
        {
            this.AppAuthStatus = null;
        }
        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        if (ec.Includes("addedAt",true))
        {
            if(this.AddedAt == null) {

                this.AddedAt = new DateTime();

            } else {


            }
        }
        else if (this.AddedAt != null && ec.Excludes("addedAt",true))
        {
            this.AddedAt = null;
        }
        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        if (ec.Includes("appAuthVersion",true))
        {
            if(this.AppAuthVersion == null) {

                this.AppAuthVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.AppAuthVersion != null && ec.Excludes("appAuthVersion",true))
        {
            this.AppAuthVersion = null;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        if (ec.Includes("appOwner",true))
        {
            if(this.AppOwner == null) {

                this.AppOwner = "FETCH";

            } else {


            }
        }
        else if (this.AppOwner != null && ec.Excludes("appOwner",true))
        {
            this.AppOwner = null;
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (ec.Includes("appType",true))
        {
            if(this.AppType == null) {

                this.AppType = "FETCH";

            } else {


            }
        }
        else if (this.AppType != null && ec.Excludes("appType",true))
        {
            this.AppType = null;
        }
        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        if (ec.Includes("isAuthenticated",true))
        {
            if(this.IsAuthenticated == null) {

                this.IsAuthenticated = true;

            } else {


            }
        }
        else if (this.IsAuthenticated != null && ec.Excludes("isAuthenticated",true))
        {
            this.IsAuthenticated = null;
        }
        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        if (ec.Includes("subscription",true))
        {
            if(this.Subscription == null) {

                this.Subscription = "FETCH";

            } else {


            }
        }
        else if (this.Subscription != null && ec.Excludes("subscription",true))
        {
            this.Subscription = null;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
    }


    #endregion

    } // class O365App
    
    #endregion

    public static class ListO365AppExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365App> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365App> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365App> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365App());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365App> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types