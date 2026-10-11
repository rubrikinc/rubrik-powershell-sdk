// SecurityFeaturesStatus.cs
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
    #region SecurityFeaturesStatus
    public class SecurityFeaturesStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAnomalyDetectionFeatureEnabled
        // GraphQL -> isAnomalyDetectionFeatureEnabled: Boolean! (scalar)
        [JsonProperty("isAnomalyDetectionFeatureEnabled")]
        public System.Boolean? IsAnomalyDetectionFeatureEnabled { get; set; }

        //      C# -> System.Boolean? IsMutedForAnomalyDetection
        // GraphQL -> isMutedForAnomalyDetection: Boolean! (scalar)
        [JsonProperty("isMutedForAnomalyDetection")]
        public System.Boolean? IsMutedForAnomalyDetection { get; set; }

        //      C# -> System.Boolean? IsMutedForThreatMonitoring
        // GraphQL -> isMutedForThreatMonitoring: Boolean! (scalar)
        [JsonProperty("isMutedForThreatMonitoring")]
        public System.Boolean? IsMutedForThreatMonitoring { get; set; }

        //      C# -> System.Boolean? IsThreatMonitoringFeatureEnabled
        // GraphQL -> isThreatMonitoringFeatureEnabled: Boolean! (scalar)
        [JsonProperty("isThreatMonitoringFeatureEnabled")]
        public System.Boolean? IsThreatMonitoringFeatureEnabled { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SecurityFeaturesStatus";
    }

    public SecurityFeaturesStatus Set(
        System.Boolean? IsAnomalyDetectionFeatureEnabled = null,
        System.Boolean? IsMutedForAnomalyDetection = null,
        System.Boolean? IsMutedForThreatMonitoring = null,
        System.Boolean? IsThreatMonitoringFeatureEnabled = null
    ) 
    {
        if ( IsAnomalyDetectionFeatureEnabled != null ) {
            this.IsAnomalyDetectionFeatureEnabled = IsAnomalyDetectionFeatureEnabled;
        }
        if ( IsMutedForAnomalyDetection != null ) {
            this.IsMutedForAnomalyDetection = IsMutedForAnomalyDetection;
        }
        if ( IsMutedForThreatMonitoring != null ) {
            this.IsMutedForThreatMonitoring = IsMutedForThreatMonitoring;
        }
        if ( IsThreatMonitoringFeatureEnabled != null ) {
            this.IsThreatMonitoringFeatureEnabled = IsThreatMonitoringFeatureEnabled;
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
        //      C# -> System.Boolean? IsAnomalyDetectionFeatureEnabled
        // GraphQL -> isAnomalyDetectionFeatureEnabled: Boolean! (scalar)
        if (this.IsAnomalyDetectionFeatureEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomalyDetectionFeatureEnabled\n" ;
            } else {
                s += ind + "isAnomalyDetectionFeatureEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsMutedForAnomalyDetection
        // GraphQL -> isMutedForAnomalyDetection: Boolean! (scalar)
        if (this.IsMutedForAnomalyDetection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMutedForAnomalyDetection\n" ;
            } else {
                s += ind + "isMutedForAnomalyDetection\n" ;
            }
        }
        //      C# -> System.Boolean? IsMutedForThreatMonitoring
        // GraphQL -> isMutedForThreatMonitoring: Boolean! (scalar)
        if (this.IsMutedForThreatMonitoring != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMutedForThreatMonitoring\n" ;
            } else {
                s += ind + "isMutedForThreatMonitoring\n" ;
            }
        }
        //      C# -> System.Boolean? IsThreatMonitoringFeatureEnabled
        // GraphQL -> isThreatMonitoringFeatureEnabled: Boolean! (scalar)
        if (this.IsThreatMonitoringFeatureEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isThreatMonitoringFeatureEnabled\n" ;
            } else {
                s += ind + "isThreatMonitoringFeatureEnabled\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsAnomalyDetectionFeatureEnabled
        // GraphQL -> isAnomalyDetectionFeatureEnabled: Boolean! (scalar)
        if (ec.Includes("isAnomalyDetectionFeatureEnabled",true))
        {
            if(this.IsAnomalyDetectionFeatureEnabled == null) {

                this.IsAnomalyDetectionFeatureEnabled = true;

            } else {


            }
        }
        else if (this.IsAnomalyDetectionFeatureEnabled != null && ec.Excludes("isAnomalyDetectionFeatureEnabled",true))
        {
            this.IsAnomalyDetectionFeatureEnabled = null;
        }
        //      C# -> System.Boolean? IsMutedForAnomalyDetection
        // GraphQL -> isMutedForAnomalyDetection: Boolean! (scalar)
        if (ec.Includes("isMutedForAnomalyDetection",true))
        {
            if(this.IsMutedForAnomalyDetection == null) {

                this.IsMutedForAnomalyDetection = true;

            } else {


            }
        }
        else if (this.IsMutedForAnomalyDetection != null && ec.Excludes("isMutedForAnomalyDetection",true))
        {
            this.IsMutedForAnomalyDetection = null;
        }
        //      C# -> System.Boolean? IsMutedForThreatMonitoring
        // GraphQL -> isMutedForThreatMonitoring: Boolean! (scalar)
        if (ec.Includes("isMutedForThreatMonitoring",true))
        {
            if(this.IsMutedForThreatMonitoring == null) {

                this.IsMutedForThreatMonitoring = true;

            } else {


            }
        }
        else if (this.IsMutedForThreatMonitoring != null && ec.Excludes("isMutedForThreatMonitoring",true))
        {
            this.IsMutedForThreatMonitoring = null;
        }
        //      C# -> System.Boolean? IsThreatMonitoringFeatureEnabled
        // GraphQL -> isThreatMonitoringFeatureEnabled: Boolean! (scalar)
        if (ec.Includes("isThreatMonitoringFeatureEnabled",true))
        {
            if(this.IsThreatMonitoringFeatureEnabled == null) {

                this.IsThreatMonitoringFeatureEnabled = true;

            } else {


            }
        }
        else if (this.IsThreatMonitoringFeatureEnabled != null && ec.Excludes("isThreatMonitoringFeatureEnabled",true))
        {
            this.IsThreatMonitoringFeatureEnabled = null;
        }
    }


    #endregion

    } // class SecurityFeaturesStatus
    
    #endregion

    public static class ListSecurityFeaturesStatusExtensions
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
            this List<SecurityFeaturesStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SecurityFeaturesStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SecurityFeaturesStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SecurityFeaturesStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SecurityFeaturesStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types