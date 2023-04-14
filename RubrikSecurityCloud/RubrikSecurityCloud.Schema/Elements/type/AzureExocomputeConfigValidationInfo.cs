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

namespace Rubrik.SecurityCloud.Types
{
    #region AzureExocomputeConfigValidationInfo
    public class AzureExocomputeConfigValidationInfo: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String! (scalar)
            if (this.ErrorMessage != null)
            {
                 s += ind + "errorMessage\n";

            }
            //      C# -> System.Boolean? HasBlockedSecurityRules
            // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
            if (this.HasBlockedSecurityRules != null)
            {
                 s += ind + "hasBlockedSecurityRules\n";

            }
            //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
            // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
            if (this.HasRestrictedAddressRangeOverlap != null)
            {
                 s += ind + "hasRestrictedAddressRangeOverlap\n";

            }
            //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
            // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
            if (this.IsClusterSubnetSizeTooSmall != null)
            {
                 s += ind + "isClusterSubnetSizeTooSmall\n";

            }
            //      C# -> System.Boolean? IsPodAndClusterSubnetSame
            // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
            if (this.IsPodAndClusterSubnetSame != null)
            {
                 s += ind + "isPodAndClusterSubnetSame\n";

            }
            //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
            // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
            if (this.IsPodAndClusterVnetDifferent != null)
            {
                 s += ind + "isPodAndClusterVnetDifferent\n";

            }
            //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
            // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
            if (this.IsPodSubnetSizeTooSmall != null)
            {
                 s += ind + "isPodSubnetSizeTooSmall\n";

            }
            //      C# -> System.Boolean? IsSubnetDelegated
            // GraphQL -> isSubnetDelegated: Boolean! (scalar)
            if (this.IsSubnetDelegated != null)
            {
                 s += ind + "isSubnetDelegated\n";

            }
            //      C# -> AzureExocomputeRegionConfig? Config
            // GraphQL -> config: AzureExocomputeRegionConfig (type)
            if (this.Config != null)
            {
                 s += ind + "config\n";

                 s += ind + "{\n" + 
                 this.Config.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String! (scalar)
            if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage$"))
            {
                this.ErrorMessage = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasBlockedSecurityRules
            // GraphQL -> hasBlockedSecurityRules: Boolean! (scalar)
            if (this.HasBlockedSecurityRules == null && Exploration.Includes(parent + ".hasBlockedSecurityRules$"))
            {
                this.HasBlockedSecurityRules = new System.Boolean();
            }
            //      C# -> System.Boolean? HasRestrictedAddressRangeOverlap
            // GraphQL -> hasRestrictedAddressRangeOverlap: Boolean! (scalar)
            if (this.HasRestrictedAddressRangeOverlap == null && Exploration.Includes(parent + ".hasRestrictedAddressRangeOverlap$"))
            {
                this.HasRestrictedAddressRangeOverlap = new System.Boolean();
            }
            //      C# -> System.Boolean? IsClusterSubnetSizeTooSmall
            // GraphQL -> isClusterSubnetSizeTooSmall: Boolean! (scalar)
            if (this.IsClusterSubnetSizeTooSmall == null && Exploration.Includes(parent + ".isClusterSubnetSizeTooSmall$"))
            {
                this.IsClusterSubnetSizeTooSmall = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPodAndClusterSubnetSame
            // GraphQL -> isPodAndClusterSubnetSame: Boolean! (scalar)
            if (this.IsPodAndClusterSubnetSame == null && Exploration.Includes(parent + ".isPodAndClusterSubnetSame$"))
            {
                this.IsPodAndClusterSubnetSame = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPodAndClusterVnetDifferent
            // GraphQL -> isPodAndClusterVnetDifferent: Boolean! (scalar)
            if (this.IsPodAndClusterVnetDifferent == null && Exploration.Includes(parent + ".isPodAndClusterVnetDifferent$"))
            {
                this.IsPodAndClusterVnetDifferent = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPodSubnetSizeTooSmall
            // GraphQL -> isPodSubnetSizeTooSmall: Boolean! (scalar)
            if (this.IsPodSubnetSizeTooSmall == null && Exploration.Includes(parent + ".isPodSubnetSizeTooSmall$"))
            {
                this.IsPodSubnetSizeTooSmall = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSubnetDelegated
            // GraphQL -> isSubnetDelegated: Boolean! (scalar)
            if (this.IsSubnetDelegated == null && Exploration.Includes(parent + ".isSubnetDelegated$"))
            {
                this.IsSubnetDelegated = new System.Boolean();
            }
            //      C# -> AzureExocomputeRegionConfig? Config
            // GraphQL -> config: AzureExocomputeRegionConfig (type)
            if (this.Config == null && Exploration.Includes(parent + ".config"))
            {
                this.Config = new AzureExocomputeRegionConfig();
                this.Config.ApplyExploratoryFragment(parent + ".config");
            }
        }


    #endregion

    } // class AzureExocomputeConfigValidationInfo
    #endregion

    public static class ListAzureExocomputeConfigValidationInfoExtensions
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
            this List<AzureExocomputeConfigValidationInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureExocomputeConfigValidationInfo> list, 
            String parent = "")
        {
            var item = new AzureExocomputeConfigValidationInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types