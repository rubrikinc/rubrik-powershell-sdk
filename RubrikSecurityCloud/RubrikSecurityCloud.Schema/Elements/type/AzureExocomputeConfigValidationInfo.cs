// AzureExocomputeConfigValidationInfo.cs
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
    #region AzureExocomputeConfigValidationInfo
    public class AzureExocomputeConfigValidationInfo: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        [JsonProperty("hasBlockedSecurityRules")]
        public System.Boolean? HasBlockedSecurityRules { get; set; }

        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        [JsonProperty("hasRestrictedAddressRangeOverlap")]
        public System.Boolean? HasRestrictedAddressRangeOverlap { get; set; }

        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        [JsonProperty("isClusterSubnetSizeTooSmall")]
        public System.Boolean? IsClusterSubnetSizeTooSmall { get; set; }

        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        [JsonProperty("isPodAndClusterSubnetSame")]
        public System.Boolean? IsPodAndClusterSubnetSame { get; set; }

        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        [JsonProperty("isPodAndClusterVnetDifferent")]
        public System.Boolean? IsPodAndClusterVnetDifferent { get; set; }

        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        [JsonProperty("isPodSubnetSizeTooSmall")]
        public System.Boolean? IsPodSubnetSizeTooSmall { get; set; }

        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        [JsonProperty("isSubnetDelegated")]
        public System.Boolean? IsSubnetDelegated { get; set; }

        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        [JsonProperty("config")]
        public AzureExocomputeRegionConfig? Config { get; set; }


        #endregion

    #region methods

    public AzureExocomputeConfigValidationInfo Set(
        System.String? ErrorMessage = null,
        System.Boolean? HasBlockedSecurityRules = null,
        System.Boolean? HasRestrictedAddressRangeOverlap = null,
        System.Boolean? IsClusterSubnetSizeTooSmall = null,
        System.Boolean? IsPodAndClusterSubnetSame = null,
        System.Boolean? IsPodAndClusterVnetDifferent = null,
        System.Boolean? IsPodSubnetSizeTooSmall = null,
        System.Boolean? IsSubnetDelegated = null,
        AzureExocomputeRegionConfig? Config = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( HasBlockedSecurityRules != null ) {
            this.HasBlockedSecurityRules = HasBlockedSecurityRules;
        }
        if ( HasRestrictedAddressRangeOverlap != null ) {
            this.HasRestrictedAddressRangeOverlap = HasRestrictedAddressRangeOverlap;
        }
        if ( IsClusterSubnetSizeTooSmall != null ) {
            this.IsClusterSubnetSizeTooSmall = IsClusterSubnetSizeTooSmall;
        }
        if ( IsPodAndClusterSubnetSame != null ) {
            this.IsPodAndClusterSubnetSame = IsPodAndClusterSubnetSame;
        }
        if ( IsPodAndClusterVnetDifferent != null ) {
            this.IsPodAndClusterVnetDifferent = IsPodAndClusterVnetDifferent;
        }
        if ( IsPodSubnetSizeTooSmall != null ) {
            this.IsPodSubnetSizeTooSmall = IsPodSubnetSizeTooSmall;
        }
        if ( IsSubnetDelegated != null ) {
            this.IsSubnetDelegated = IsSubnetDelegated;
        }
        if ( Config != null ) {
            this.Config = Config;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        if (this.HasBlockedSecurityRules != null) {
            s += ind + "hasBlockedSecurityRules\n" ;
        }
        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        if (this.HasRestrictedAddressRangeOverlap != null) {
            s += ind + "hasRestrictedAddressRangeOverlap\n" ;
        }
        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsClusterSubnetSizeTooSmall != null) {
            s += ind + "isClusterSubnetSizeTooSmall\n" ;
        }
        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        if (this.IsPodAndClusterSubnetSame != null) {
            s += ind + "isPodAndClusterSubnetSame\n" ;
        }
        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        if (this.IsPodAndClusterVnetDifferent != null) {
            s += ind + "isPodAndClusterVnetDifferent\n" ;
        }
        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsPodSubnetSizeTooSmall != null) {
            s += ind + "isPodSubnetSizeTooSmall\n" ;
        }
        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        if (this.IsSubnetDelegated != null) {
            s += ind + "isSubnetDelegated\n" ;
        }
        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        if (this.Config != null) {
            var fspec = this.Config.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "config {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage", true))
        {
            this.ErrorMessage = "FETCH";
        }
        //      C# -> System.Boolean? HasBlockedSecurityRules
        // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
        if (this.HasBlockedSecurityRules == null && Exploration.Includes(parent + ".hasBlockedSecurityRules", true))
        {
            this.HasBlockedSecurityRules = true;
        }
        //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
        // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
        if (this.HasRestrictedAddressRangeOverlap == null && Exploration.Includes(parent + ".hasRestrictedAddressRangeOverlap", true))
        {
            this.HasRestrictedAddressRangeOverlap = true;
        }
        //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
        // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsClusterSubnetSizeTooSmall == null && Exploration.Includes(parent + ".isClusterSubnetSizeTooSmall", true))
        {
            this.IsClusterSubnetSizeTooSmall = true;
        }
        //      C# -> System.Boolean? IsPodAndClusterSubnetSame
        // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
        if (this.IsPodAndClusterSubnetSame == null && Exploration.Includes(parent + ".isPodAndClusterSubnetSame", true))
        {
            this.IsPodAndClusterSubnetSame = true;
        }
        //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
        // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
        if (this.IsPodAndClusterVnetDifferent == null && Exploration.Includes(parent + ".isPodAndClusterVnetDifferent", true))
        {
            this.IsPodAndClusterVnetDifferent = true;
        }
        //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
        // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
        if (this.IsPodSubnetSizeTooSmall == null && Exploration.Includes(parent + ".isPodSubnetSizeTooSmall", true))
        {
            this.IsPodSubnetSizeTooSmall = true;
        }
        //      C# -> System.Boolean? IsSubnetDelegated
        // GraphQL -> isSubnetDelegated: Boolean! (scalar)
        if (this.IsSubnetDelegated == null && Exploration.Includes(parent + ".isSubnetDelegated", true))
        {
            this.IsSubnetDelegated = true;
        }
        //      C# -> AzureExocomputeRegionConfig? Config
        // GraphQL -> config: AzureExocomputeRegionConfig (type)
        if (this.Config == null && Exploration.Includes(parent + ".config"))
        {
            this.Config = new AzureExocomputeRegionConfig();
            this.Config.ApplyExploratoryFieldSpec(parent + ".config");
        }
    }


    #endregion

    } // class AzureExocomputeConfigValidationInfo
    
    #endregion

    public static class ListAzureExocomputeConfigValidationInfoExtensions
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
            this List<AzureExocomputeConfigValidationInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeConfigValidationInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeConfigValidationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types