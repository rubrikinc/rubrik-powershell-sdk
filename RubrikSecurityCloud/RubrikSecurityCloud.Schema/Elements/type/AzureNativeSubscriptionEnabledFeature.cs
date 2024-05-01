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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        if (this.FeatureName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "featureName\n" ;
            } else {
                s += ind + "featureName\n" ;
            }
        }
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshedAt\n" ;
            } else {
                s += ind + "lastRefreshedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        if (ec.Includes("featureName",true))
        {
            if(this.FeatureName == null) {

                this.FeatureName = new AzureNativeProtectionFeature();

            } else {


            }
        }
        else if (this.FeatureName != null && ec.Excludes("featureName",true))
        {
            this.FeatureName = null;
        }
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AzureSubscriptionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (ec.Includes("lastRefreshedAt",true))
        {
            if(this.LastRefreshedAt == null) {

                this.LastRefreshedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshedAt != null && ec.Excludes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = null;
        }
    }


    #endregion

    } // class AzureNativeSubscriptionEnabledFeature
    
    #endregion

    public static class ListAzureNativeSubscriptionEnabledFeatureExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureNativeSubscriptionEnabledFeature> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeSubscriptionEnabledFeature> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<AzureNativeSubscriptionEnabledFeature> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types