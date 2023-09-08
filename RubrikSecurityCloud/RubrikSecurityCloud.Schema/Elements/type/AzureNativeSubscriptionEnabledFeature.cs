// AzureNativeSubscriptionEnabledFeature.cs
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
    #region AzureNativeSubscriptionEnabledFeature
    public class AzureNativeSubscriptionEnabledFeature: BaseType
    {
        #region members

        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        [JsonProperty("featureName")]
        public AzureNativeProtectionFeature? FeatureName { get; set; }

        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        [JsonProperty("status")]
        public AzureSubscriptionStatus? Status { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeSubscriptionEnabledFeature";
    }

    public AzureNativeSubscriptionEnabledFeature Set(
        AzureNativeProtectionFeature? FeatureName = null,
        AzureSubscriptionStatus? Status = null,
        DateTime? LastRefreshedAt = null
    ) 
    {
        if ( FeatureName != null ) {
            this.FeatureName = FeatureName;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
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
        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        if (this.FeatureName != null) {
            s += ind + "featureName\n" ;
        }
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            s += ind + "lastRefreshedAt\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        if (this.FeatureName == null && ec.Includes("featureName",true))
        {
            this.FeatureName = new AzureNativeProtectionFeature();
        }
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new AzureSubscriptionStatus();
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt == null && ec.Includes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = new DateTime();
        }
    }


    #endregion

    } // class AzureNativeSubscriptionEnabledFeature
    
    #endregion

    public static class ListAzureNativeSubscriptionEnabledFeatureExtensions
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
            this List<AzureNativeSubscriptionEnabledFeature> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeSubscriptionEnabledFeature> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeSubscriptionEnabledFeature());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureNativeSubscriptionEnabledFeature> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types