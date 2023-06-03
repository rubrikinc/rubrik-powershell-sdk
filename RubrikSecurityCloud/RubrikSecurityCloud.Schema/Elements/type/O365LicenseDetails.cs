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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region O365LicenseDetails
    public class O365LicenseDetails: BaseType
    {
        #region members

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

        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        [JsonProperty("allowedO365UserCount")]
        public System.Int32? AllowedO365UserCount { get; set; }

        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        [JsonProperty("disableLicense")]
        public System.Boolean? DisableLicense { get; set; }


        #endregion

    #region methods

    public O365LicenseDetails Set(
        AzureHostType? AllowedHost = null,
        M365Cloud? M365Cloud = null,
        O365AzureCloudType? RubrikSaasCloud = null,
        System.Int32? AllowedO365UserCount = null,
        System.Boolean? DisableLicense = null
    ) 
    {
        if ( AllowedHost != null ) {
            this.AllowedHost = AllowedHost;
        }
        if ( M365Cloud != null ) {
            this.M365Cloud = M365Cloud;
        }
        if ( RubrikSaasCloud != null ) {
            this.RubrikSaasCloud = RubrikSaasCloud;
        }
        if ( AllowedO365UserCount != null ) {
            this.AllowedO365UserCount = AllowedO365UserCount;
        }
        if ( DisableLicense != null ) {
            this.DisableLicense = DisableLicense;
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
        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        if (this.AllowedHost != null) {
            s += ind + "allowedHost\n" ;
        }
        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        if (this.M365Cloud != null) {
            s += ind + "m365Cloud\n" ;
        }
        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        if (this.RubrikSaasCloud != null) {
            s += ind + "rubrikSaasCloud\n" ;
        }
        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        if (this.AllowedO365UserCount != null) {
            s += ind + "allowedO365UserCount\n" ;
        }
        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        if (this.DisableLicense != null) {
            s += ind + "disableLicense\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        if (this.AllowedHost == null && Exploration.Includes(parent + ".allowedHost", true))
        {
            this.AllowedHost = new AzureHostType();
        }
        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        if (this.M365Cloud == null && Exploration.Includes(parent + ".m365Cloud", true))
        {
            this.M365Cloud = new M365Cloud();
        }
        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        if (this.RubrikSaasCloud == null && Exploration.Includes(parent + ".rubrikSaasCloud", true))
        {
            this.RubrikSaasCloud = new O365AzureCloudType();
        }
        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        if (this.AllowedO365UserCount == null && Exploration.Includes(parent + ".allowedO365UserCount", true))
        {
            this.AllowedO365UserCount = new System.Int32();
        }
        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        if (this.DisableLicense == null && Exploration.Includes(parent + ".disableLicense", true))
        {
            this.DisableLicense = true;
        }
    }


    #endregion

    } // class O365LicenseDetails
    
    #endregion

    public static class ListO365LicenseDetailsExtensions
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
            this List<O365LicenseDetails> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365LicenseDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365LicenseDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types