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

        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        [JsonProperty("serviceAccountId")]
        public System.String? ServiceAccountId { get; set; }

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

    public override string GetGqlTypeName() {
        return "Webhook";
    }

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
        System.String? ServiceAccountId = null,
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
        if ( ServiceAccountId != null ) {
            this.ServiceAccountId = ServiceAccountId;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        if (this.AuthType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authType\n" ;
            } else {
                s += ind + "authType\n" ;
            }
        }
        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        if (this.ProviderType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "providerType\n" ;
            } else {
                s += ind + "providerType\n" ;
            }
        }
        //      C# -> WebhookStatus? Status
        // GraphQL -> status: WebhookStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (this.CreatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdBy\n" ;
            } else {
                s += ind + "createdBy\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (this.ServerCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serverCertificate\n" ;
            } else {
                s += ind + "serverCertificate\n" ;
            }
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        if (this.ServiceAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceAccountId\n" ;
            } else {
                s += ind + "serviceAccountId\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        //      C# -> ErrorInfo? LastFailedErrorInfo
        // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
        if (this.LastFailedErrorInfo != null) {
            var fspec = this.LastFailedErrorInfo.AsFieldSpec(conf.Child("lastFailedErrorInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastFailedErrorInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SubscriptionSeverity? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
        if (this.SubscriptionSeverity != null) {
            var fspec = this.SubscriptionSeverity.AsFieldSpec(conf.Child("subscriptionSeverity"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptionSeverity {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SubscriptionType? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionType! (type)
        if (this.SubscriptionType != null) {
            var fspec = this.SubscriptionType.AsFieldSpec(conf.Child("subscriptionType"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptionType {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AuthenticationType? AuthType
        // GraphQL -> authType: AuthenticationType! (enum)
        if (ec.Includes("authType",true))
        {
            if(this.AuthType == null) {

                this.AuthType = new AuthenticationType();

            } else {


            }
        }
        else if (this.AuthType != null && ec.Excludes("authType",true))
        {
            this.AuthType = null;
        }
        //      C# -> ProviderType? ProviderType
        // GraphQL -> providerType: ProviderType! (enum)
        if (ec.Includes("providerType",true))
        {
            if(this.ProviderType == null) {

                this.ProviderType = new ProviderType();

            } else {


            }
        }
        else if (this.ProviderType != null && ec.Excludes("providerType",true))
        {
            this.ProviderType = null;
        }
        //      C# -> WebhookStatus? Status
        // GraphQL -> status: WebhookStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new WebhookStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (ec.Includes("createdBy",true))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = "FETCH";

            } else {


            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",true))
        {
            this.CreatedBy = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = Int32.MinValue;

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? ServerCertificate
        // GraphQL -> serverCertificate: String (scalar)
        if (ec.Includes("serverCertificate",true))
        {
            if(this.ServerCertificate == null) {

                this.ServerCertificate = "FETCH";

            } else {


            }
        }
        else if (this.ServerCertificate != null && ec.Excludes("serverCertificate",true))
        {
            this.ServerCertificate = null;
        }
        //      C# -> System.String? ServiceAccountId
        // GraphQL -> serviceAccountId: String (scalar)
        if (ec.Includes("serviceAccountId",true))
        {
            if(this.ServiceAccountId == null) {

                this.ServiceAccountId = "FETCH";

            } else {


            }
        }
        else if (this.ServiceAccountId != null && ec.Excludes("serviceAccountId",true))
        {
            this.ServiceAccountId = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
        //      C# -> ErrorInfo? LastFailedErrorInfo
        // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
        if (ec.Includes("lastFailedErrorInfo",false))
        {
            if(this.LastFailedErrorInfo == null) {

                this.LastFailedErrorInfo = new ErrorInfo();
                this.LastFailedErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("lastFailedErrorInfo"));

            } else {

                this.LastFailedErrorInfo.ApplyExploratoryFieldSpec(ec.NewChild("lastFailedErrorInfo"));

            }
        }
        else if (this.LastFailedErrorInfo != null && ec.Excludes("lastFailedErrorInfo",false))
        {
            this.LastFailedErrorInfo = null;
        }
        //      C# -> SubscriptionSeverity? SubscriptionSeverity
        // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
        if (ec.Includes("subscriptionSeverity",false))
        {
            if(this.SubscriptionSeverity == null) {

                this.SubscriptionSeverity = new SubscriptionSeverity();
                this.SubscriptionSeverity.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionSeverity"));

            } else {

                this.SubscriptionSeverity.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionSeverity"));

            }
        }
        else if (this.SubscriptionSeverity != null && ec.Excludes("subscriptionSeverity",false))
        {
            this.SubscriptionSeverity = null;
        }
        //      C# -> SubscriptionType? SubscriptionType
        // GraphQL -> subscriptionType: SubscriptionType! (type)
        if (ec.Includes("subscriptionType",false))
        {
            if(this.SubscriptionType == null) {

                this.SubscriptionType = new SubscriptionType();
                this.SubscriptionType.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionType"));

            } else {

                this.SubscriptionType.ApplyExploratoryFieldSpec(ec.NewChild("subscriptionType"));

            }
        }
        else if (this.SubscriptionType != null && ec.Excludes("subscriptionType",false))
        {
            this.SubscriptionType = null;
        }
    }


    #endregion

    } // class Webhook
    
    #endregion

    public static class ListWebhookExtensions
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
            this List<Webhook> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Webhook> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Webhook> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Webhook());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Webhook> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types