// Webhook.cs
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
    #region Webhook
    public class Webhook: BaseType
    {
        #region members

        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        [JsonProperty("authType")]
        public AuthenticationType? AuthType { get; set; }

        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        [JsonProperty("providerType")]
        public ProviderType? ProviderType { get; set; }

        //      C# -> WebhookStatus? Status
        // GraphQL -> status: WebhookStatus! (enum)
        [JsonProperty("status")]
        public WebhookStatus? Status { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        [JsonProperty("createdBy")]
        public System.String? CreatedBy { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        [JsonProperty("serverCertificate")]
        public System.String? ServerCertificate { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> ErrorInfo? LastFailedErrorInfo
        // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
        [JsonProperty("lastFailedErrorInfo")]
        public ErrorInfo? LastFailedErrorInfo { get; set; }

        //      C# -> SubscriptionSeverity? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
        [JsonProperty("subscriptionSeverity")]
        public SubscriptionSeverity? SubscriptionSeverity { get; set; }

        //      C# -> SubscriptionType? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionType! (type)
        [JsonProperty("subscriptionType")]
        public SubscriptionType? SubscriptionType { get; set; }


        #endregion

    #region methods

    public Webhook Set(
        AuthenticationType? AuthType = null,
        ProviderType? ProviderType = null,
        WebhookStatus? Status = null,
        DateTime? CreatedAt = null,
        System.String? CreatedBy = null,
        System.String? Description = null,
        System.Int32? Id = null,
        System.String? Name = null,
        System.String? ServerCertificate = null,
        DateTime? UpdatedAt = null,
        System.String? Url = null,
        ErrorInfo? LastFailedErrorInfo = null,
        SubscriptionSeverity? SubscriptionSeverity = null,
        SubscriptionType? SubscriptionType = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( ProviderType != null ) {
            this.ProviderType = ProviderType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ServerCertificate != null ) {
            this.ServerCertificate = ServerCertificate;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( Url != null ) {
            this.Url = Url;
        }
        if ( LastFailedErrorInfo != null ) {
            this.LastFailedErrorInfo = LastFailedErrorInfo;
        }
        if ( SubscriptionSeverity != null ) {
            this.SubscriptionSeverity = SubscriptionSeverity;
        }
        if ( SubscriptionType != null ) {
            this.SubscriptionType = SubscriptionType;
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
        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        if (this.AuthType != null) {
            s += ind + "authType\n" ;
        }
        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        if (this.ProviderType != null) {
            s += ind + "providerType\n" ;
        }
        //      C# -> WebhookStatus? Status
        // GraphQL -> status: WebhookStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            s += ind + "createdAt\n" ;
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (this.CreatedBy != null) {
            s += ind + "createdBy\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (this.ServerCertificate != null) {
            s += ind + "serverCertificate\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (this.Url != null) {
            s += ind + "url\n" ;
        }
        //      C# -> ErrorInfo? LastFailedErrorInfo
        // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
        if (this.LastFailedErrorInfo != null) {
            var fspec = this.LastFailedErrorInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lastFailedErrorInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SubscriptionSeverity? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
        if (this.SubscriptionSeverity != null) {
            var fspec = this.SubscriptionSeverity.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscriptionSeverity {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SubscriptionType? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionType! (type)
        if (this.SubscriptionType != null) {
            var fspec = this.SubscriptionType.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscriptionType {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        if (this.AuthType == null && Exploration.Includes(parent + ".authType", true))
        {
            this.AuthType = new AuthenticationType();
        }
        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        if (this.ProviderType == null && Exploration.Includes(parent + ".providerType", true))
        {
            this.ProviderType = new ProviderType();
        }
        //      C# -> WebhookStatus? Status
        // GraphQL -> status: WebhookStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new WebhookStatus();
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt", true))
        {
            this.CreatedAt = new DateTime();
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (this.CreatedBy == null && Exploration.Includes(parent + ".createdBy", true))
        {
            this.CreatedBy = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (this.ServerCertificate == null && Exploration.Includes(parent + ".serverCertificate", true))
        {
            this.ServerCertificate = "FETCH";
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (this.Url == null && Exploration.Includes(parent + ".url", true))
        {
            this.Url = "FETCH";
        }
        //      C# -> ErrorInfo? LastFailedErrorInfo
        // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
        if (this.LastFailedErrorInfo == null && Exploration.Includes(parent + ".lastFailedErrorInfo"))
        {
            this.LastFailedErrorInfo = new ErrorInfo();
            this.LastFailedErrorInfo.ApplyExploratoryFieldSpec(parent + ".lastFailedErrorInfo");
        }
        //      C# -> SubscriptionSeverity? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
        if (this.SubscriptionSeverity == null && Exploration.Includes(parent + ".subscriptionSeverity"))
        {
            this.SubscriptionSeverity = new SubscriptionSeverity();
            this.SubscriptionSeverity.ApplyExploratoryFieldSpec(parent + ".subscriptionSeverity");
        }
        //      C# -> SubscriptionType? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionType! (type)
        if (this.SubscriptionType == null && Exploration.Includes(parent + ".subscriptionType"))
        {
            this.SubscriptionType = new SubscriptionType();
            this.SubscriptionType.ApplyExploratoryFieldSpec(parent + ".subscriptionType");
        }
    }


    #endregion

    } // class Webhook
    
    #endregion

    public static class ListWebhookExtensions
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
            this List<Webhook> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Webhook> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Webhook());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types