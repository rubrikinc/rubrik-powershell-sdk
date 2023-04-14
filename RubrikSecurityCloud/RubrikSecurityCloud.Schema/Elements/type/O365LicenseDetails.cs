// O365LicenseDetails.cs
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
    #region O365LicenseDetails
    public class O365LicenseDetails: IFragment
    {
        #region members
        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        [JsonProperty("allowedO365UserCount")]
        public System.Int32? AllowedO365UserCount { get; set; }

        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        [JsonProperty("disableLicense")]
        public System.Boolean? DisableLicense { get; set; }

        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        [JsonProperty("allowedHost")]
        public AzureHostType? AllowedHost { get; set; }

        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        [JsonProperty("m365Cloud")]
        public M365Cloud? M365Cloud { get; set; }

        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        [JsonProperty("rubrikSaasCloud")]
        public O365AzureCloudType? RubrikSaasCloud { get; set; }

        #endregion

    #region methods

    public O365LicenseDetails Set(
        System.Int32? AllowedO365UserCount = null,
        System.Boolean? DisableLicense = null,
        AzureHostType? AllowedHost = null,
        M365Cloud? M365Cloud = null,
        O365AzureCloudType? RubrikSaasCloud = null
    ) 
    {
        if ( AllowedO365UserCount != null ) {
            this.AllowedO365UserCount = AllowedO365UserCount;
        }
        if ( DisableLicense != null ) {
            this.DisableLicense = DisableLicense;
        }
        if ( AllowedHost != null ) {
            this.AllowedHost = AllowedHost;
        }
        if ( M365Cloud != null ) {
            this.M365Cloud = M365Cloud;
        }
        if ( RubrikSaasCloud != null ) {
            this.RubrikSaasCloud = RubrikSaasCloud;
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
            //      C# -> System.Int32? AllowedO365UserCount
            // GraphQL -> allowedO365UserCount: Int! (scalar)
            if (this.AllowedO365UserCount != null)
            {
                 s += ind + "allowedO365UserCount\n";

            }
            //      C# -> System.Boolean? DisableLicense
            // GraphQL -> disableLicense: Boolean! (scalar)
            if (this.DisableLicense != null)
            {
                 s += ind + "disableLicense\n";

            }
            //      C# -> AzureHostType? AllowedHost
            // GraphQL -> allowedHost: AzureHostType! (enum)
            if (this.AllowedHost != null)
            {
                 s += ind + "allowedHost\n";

            }
            //      C# -> M365Cloud? M365Cloud
            // GraphQL -> m365Cloud: M365Cloud! (enum)
            if (this.M365Cloud != null)
            {
                 s += ind + "m365Cloud\n";

            }
            //      C# -> O365AzureCloudType? RubrikSaasCloud
            // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
            if (this.RubrikSaasCloud != null)
            {
                 s += ind + "rubrikSaasCloud\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? AllowedO365UserCount
            // GraphQL -> allowedO365UserCount: Int! (scalar)
            if (this.AllowedO365UserCount == null && Exploration.Includes(parent + ".allowedO365UserCount$"))
            {
                this.AllowedO365UserCount = new System.Int32();
            }
            //      C# -> System.Boolean? DisableLicense
            // GraphQL -> disableLicense: Boolean! (scalar)
            if (this.DisableLicense == null && Exploration.Includes(parent + ".disableLicense$"))
            {
                this.DisableLicense = new System.Boolean();
            }
            //      C# -> AzureHostType? AllowedHost
            // GraphQL -> allowedHost: AzureHostType! (enum)
            if (this.AllowedHost == null && Exploration.Includes(parent + ".allowedHost$"))
            {
                this.AllowedHost = new AzureHostType();
            }
            //      C# -> M365Cloud? M365Cloud
            // GraphQL -> m365Cloud: M365Cloud! (enum)
            if (this.M365Cloud == null && Exploration.Includes(parent + ".m365Cloud$"))
            {
                this.M365Cloud = new M365Cloud();
            }
            //      C# -> O365AzureCloudType? RubrikSaasCloud
            // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
            if (this.RubrikSaasCloud == null && Exploration.Includes(parent + ".rubrikSaasCloud$"))
            {
                this.RubrikSaasCloud = new O365AzureCloudType();
            }
        }


    #endregion

    } // class O365LicenseDetails
    #endregion

    public static class ListO365LicenseDetailsExtensions
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
            this List<O365LicenseDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365LicenseDetails> list, 
            String parent = "")
        {
            var item = new O365LicenseDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types