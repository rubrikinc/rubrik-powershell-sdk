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

namespace Rubrik.SecurityCloud.Types
{
    #region Webhook
    public class Webhook: IFragment
    {
        #region members
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

        #endregion

    #region methods

    public Webhook Set(
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
        SubscriptionType? SubscriptionType = null,
        AuthenticationType? AuthType = null,
        ProviderType? ProviderType = null,
        WebhookStatus? Status = null
    ) 
    {
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
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( ProviderType != null ) {
            this.ProviderType = ProviderType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> System.String? CreatedBy
            // GraphQL -> createdBy: String! (scalar)
            if (this.CreatedBy != null)
            {
                 s += ind + "createdBy\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ServerCertificate
            // GraphQL -> serverCertificate: String (scalar)
            if (this.ServerCertificate != null)
            {
                 s += ind + "serverCertificate\n";

            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt != null)
            {
                 s += ind + "updatedAt\n";

            }
            //      C# -> System.String? Url
            // GraphQL -> url: URL! (scalar)
            if (this.Url != null)
            {
                 s += ind + "url\n";

            }
            //      C# -> ErrorInfo? LastFailedErrorInfo
            // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
            if (this.LastFailedErrorInfo != null)
            {
                 s += ind + "lastFailedErrorInfo\n";

                 s += ind + "{\n" + 
                 this.LastFailedErrorInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SubscriptionSeverity? SubscriptionSeverity
            // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
            if (this.SubscriptionSeverity != null)
            {
                 s += ind + "subscriptionSeverity\n";

                 s += ind + "{\n" + 
                 this.SubscriptionSeverity.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SubscriptionType? SubscriptionType
            // GraphQL -> subscriptionType: SubscriptionType! (type)
            if (this.SubscriptionType != null)
            {
                 s += ind + "subscriptionType\n";

                 s += ind + "{\n" + 
                 this.SubscriptionType.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AuthenticationType? AuthType
            // GraphQL -> authType: AuthenticationType! (enum)
            if (this.AuthType != null)
            {
                 s += ind + "authType\n";

            }
            //      C# -> ProviderType? ProviderType
            // GraphQL -> providerType: ProviderType! (enum)
            if (this.ProviderType != null)
            {
                 s += ind + "providerType\n";

            }
            //      C# -> WebhookStatus? Status
            // GraphQL -> status: WebhookStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> System.String? CreatedBy
            // GraphQL -> createdBy: String! (scalar)
            if (this.CreatedBy == null && Exploration.Includes(parent + ".createdBy$"))
            {
                this.CreatedBy = new System.String("FETCH");
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ServerCertificate
            // GraphQL -> serverCertificate: String (scalar)
            if (this.ServerCertificate == null && Exploration.Includes(parent + ".serverCertificate$"))
            {
                this.ServerCertificate = new System.String("FETCH");
            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime (scalar)
            if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt$"))
            {
                this.UpdatedAt = new DateTime();
            }
            //      C# -> System.String? Url
            // GraphQL -> url: URL! (scalar)
            if (this.Url == null && Exploration.Includes(parent + ".url$"))
            {
                this.Url = new System.String("FETCH");
            }
            //      C# -> ErrorInfo? LastFailedErrorInfo
            // GraphQL -> lastFailedErrorInfo: ErrorInfo (type)
            if (this.LastFailedErrorInfo == null && Exploration.Includes(parent + ".lastFailedErrorInfo"))
            {
                this.LastFailedErrorInfo = new ErrorInfo();
                this.LastFailedErrorInfo.ApplyExploratoryFragment(parent + ".lastFailedErrorInfo");
            }
            //      C# -> SubscriptionSeverity? SubscriptionSeverity
            // GraphQL -> subscriptionSeverity: SubscriptionSeverity! (type)
            if (this.SubscriptionSeverity == null && Exploration.Includes(parent + ".subscriptionSeverity"))
            {
                this.SubscriptionSeverity = new SubscriptionSeverity();
                this.SubscriptionSeverity.ApplyExploratoryFragment(parent + ".subscriptionSeverity");
            }
            //      C# -> SubscriptionType? SubscriptionType
            // GraphQL -> subscriptionType: SubscriptionType! (type)
            if (this.SubscriptionType == null && Exploration.Includes(parent + ".subscriptionType"))
            {
                this.SubscriptionType = new SubscriptionType();
                this.SubscriptionType.ApplyExploratoryFragment(parent + ".subscriptionType");
            }
            //      C# -> AuthenticationType? AuthType
            // GraphQL -> authType: AuthenticationType! (enum)
            if (this.AuthType == null && Exploration.Includes(parent + ".authType$"))
            {
                this.AuthType = new AuthenticationType();
            }
            //      C# -> ProviderType? ProviderType
            // GraphQL -> providerType: ProviderType! (enum)
            if (this.ProviderType == null && Exploration.Includes(parent + ".providerType$"))
            {
                this.ProviderType = new ProviderType();
            }
            //      C# -> WebhookStatus? Status
            // GraphQL -> status: WebhookStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new WebhookStatus();
            }
        }


    #endregion

    } // class Webhook
    #endregion

    public static class ListWebhookExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<Webhook> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Webhook> list, 
            String parent = "")
        {
            var item = new Webhook();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types