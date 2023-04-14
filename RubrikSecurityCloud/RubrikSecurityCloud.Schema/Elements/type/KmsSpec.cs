// KmsSpec.cs
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
    #region KmsSpec
    public class KmsSpec: IFragment
    {
        #region members
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? AppSecret
        // GraphQL -> appSecret: String! (scalar)
        [JsonProperty("appSecret")]
        public System.String? AppSecret { get; set; }

        //      C# -> System.String? KekNameColossus
        // GraphQL -> kekNameColossus: String! (scalar)
        [JsonProperty("kekNameColossus")]
        public System.String? KekNameColossus { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KmsId
        // GraphQL -> kmsId: String! (scalar)
        [JsonProperty("kmsId")]
        public System.String? KmsId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> O365AzureCloudType? CloudType
        // GraphQL -> cloudType: O365AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public O365AzureCloudType? CloudType { get; set; }

        #endregion

    #region methods

    public KmsSpec Set(
        System.String? AppId = null,
        System.String? AppSecret = null,
        System.String? KekNameColossus = null,
        System.String? KeyName = null,
        System.String? KmsId = null,
        System.String? TenantId = null,
        O365AzureCloudType? CloudType = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( AppSecret != null ) {
            this.AppSecret = AppSecret;
        }
        if ( KekNameColossus != null ) {
            this.KekNameColossus = KekNameColossus;
        }
        if ( KeyName != null ) {
            this.KeyName = KeyName;
        }
        if ( KmsId != null ) {
            this.KmsId = KmsId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
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
            //      C# -> System.String? AppId
            // GraphQL -> appId: String! (scalar)
            if (this.AppId != null)
            {
                 s += ind + "appId\n";

            }
            //      C# -> System.String? AppSecret
            // GraphQL -> appSecret: String! (scalar)
            if (this.AppSecret != null)
            {
                 s += ind + "appSecret\n";

            }
            //      C# -> System.String? KekNameColossus
            // GraphQL -> kekNameColossus: String! (scalar)
            if (this.KekNameColossus != null)
            {
                 s += ind + "kekNameColossus\n";

            }
            //      C# -> System.String? KeyName
            // GraphQL -> keyName: String! (scalar)
            if (this.KeyName != null)
            {
                 s += ind + "keyName\n";

            }
            //      C# -> System.String? KmsId
            // GraphQL -> kmsId: String! (scalar)
            if (this.KmsId != null)
            {
                 s += ind + "kmsId\n";

            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId != null)
            {
                 s += ind + "tenantId\n";

            }
            //      C# -> O365AzureCloudType? CloudType
            // GraphQL -> cloudType: O365AzureCloudType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AppId
            // GraphQL -> appId: String! (scalar)
            if (this.AppId == null && Exploration.Includes(parent + ".appId$"))
            {
                this.AppId = new System.String("FETCH");
            }
            //      C# -> System.String? AppSecret
            // GraphQL -> appSecret: String! (scalar)
            if (this.AppSecret == null && Exploration.Includes(parent + ".appSecret$"))
            {
                this.AppSecret = new System.String("FETCH");
            }
            //      C# -> System.String? KekNameColossus
            // GraphQL -> kekNameColossus: String! (scalar)
            if (this.KekNameColossus == null && Exploration.Includes(parent + ".kekNameColossus$"))
            {
                this.KekNameColossus = new System.String("FETCH");
            }
            //      C# -> System.String? KeyName
            // GraphQL -> keyName: String! (scalar)
            if (this.KeyName == null && Exploration.Includes(parent + ".keyName$"))
            {
                this.KeyName = new System.String("FETCH");
            }
            //      C# -> System.String? KmsId
            // GraphQL -> kmsId: String! (scalar)
            if (this.KmsId == null && Exploration.Includes(parent + ".kmsId$"))
            {
                this.KmsId = new System.String("FETCH");
            }
            //      C# -> System.String? TenantId
            // GraphQL -> tenantId: String! (scalar)
            if (this.TenantId == null && Exploration.Includes(parent + ".tenantId$"))
            {
                this.TenantId = new System.String("FETCH");
            }
            //      C# -> O365AzureCloudType? CloudType
            // GraphQL -> cloudType: O365AzureCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new O365AzureCloudType();
            }
        }


    #endregion

    } // class KmsSpec
    #endregion

    public static class ListKmsSpecExtensions
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
            this List<KmsSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<KmsSpec> list, 
            String parent = "")
        {
            var item = new KmsSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types