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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        if (this.AppAuthStatus != null) {
            s += ind + "appAuthStatus\n" ;
        }
        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        if (this.AddedAt != null) {
            s += ind + "addedAt\n" ;
        }
        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        if (this.AppAuthVersion != null) {
            s += ind + "appAuthVersion\n" ;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            s += ind + "appId\n" ;
        }
        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        if (this.AppOwner != null) {
            s += ind + "appOwner\n" ;
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (this.AppType != null) {
            s += ind + "appType\n" ;
        }
        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        if (this.IsAuthenticated != null) {
            s += ind + "isAuthenticated\n" ;
        }
        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        if (this.Subscription != null) {
            s += ind + "subscription\n" ;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            s += ind + "subscriptionId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AppAuthStatus? AppAuthStatus
        // GraphQL -> appAuthStatus: AppAuthStatus! (enum)
        if (this.AppAuthStatus == null && ec.Includes("appAuthStatus",true))
        {
            this.AppAuthStatus = new AppAuthStatus();
        }
        //      C# -> DateTime? AddedAt
        // GraphQL -> addedAt: DateTime! (scalar)
        if (this.AddedAt == null && ec.Includes("addedAt",true))
        {
            this.AddedAt = new DateTime();
        }
        //      C# -> System.Int32? AppAuthVersion
        // GraphQL -> appAuthVersion: Int! (scalar)
        if (this.AppAuthVersion == null && ec.Includes("appAuthVersion",true))
        {
            this.AppAuthVersion = Int32.MinValue;
        }
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId == null && ec.Includes("appId",true))
        {
            this.AppId = "FETCH";
        }
        //      C# -> System.String? AppOwner
        // GraphQL -> appOwner: String! (scalar)
        if (this.AppOwner == null && ec.Includes("appOwner",true))
        {
            this.AppOwner = "FETCH";
        }
        //      C# -> System.String? AppType
        // GraphQL -> appType: String! (scalar)
        if (this.AppType == null && ec.Includes("appType",true))
        {
            this.AppType = "FETCH";
        }
        //      C# -> System.Boolean? IsAuthenticated
        // GraphQL -> isAuthenticated: Boolean! (scalar)
        if (this.IsAuthenticated == null && ec.Includes("isAuthenticated",true))
        {
            this.IsAuthenticated = true;
        }
        //      C# -> System.String? Subscription
        // GraphQL -> subscription: String! (scalar)
        if (this.Subscription == null && ec.Includes("subscription",true))
        {
            this.Subscription = "FETCH";
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId == null && ec.Includes("subscriptionId",true))
        {
            this.SubscriptionId = "FETCH";
        }
    }


    #endregion

    } // class O365App
    
    #endregion

    public static class ListO365AppExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<O365App> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<O365App> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types