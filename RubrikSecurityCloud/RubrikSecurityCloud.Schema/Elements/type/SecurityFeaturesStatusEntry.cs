// SecurityFeaturesStatusEntry.cs
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
    #region SecurityFeaturesStatusEntry
    public class SecurityFeaturesStatusEntry: BaseType
    {
        #region members

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? SupportedForAnomalyDetection
        // GraphQL -> supportedForAnomalyDetection: Boolean! (scalar)
        [JsonProperty("supportedForAnomalyDetection")]
        public System.Boolean? SupportedForAnomalyDetection { get; set; }

        //      C# -> System.Boolean? SupportedForThreatMonitoring
        // GraphQL -> supportedForThreatMonitoring: Boolean! (scalar)
        [JsonProperty("supportedForThreatMonitoring")]
        public System.Boolean? SupportedForThreatMonitoring { get; set; }

        //      C# -> SecurityFeaturesStatus? Status
        // GraphQL -> status: SecurityFeaturesStatus (type)
        [JsonProperty("status")]
        public SecurityFeaturesStatus? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SecurityFeaturesStatusEntry";
    }

    public SecurityFeaturesStatusEntry Set(
        System.String? Fid = null,
        System.Boolean? SupportedForAnomalyDetection = null,
        System.Boolean? SupportedForThreatMonitoring = null,
        SecurityFeaturesStatus? Status = null
    ) 
    {
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( SupportedForAnomalyDetection != null ) {
            this.SupportedForAnomalyDetection = SupportedForAnomalyDetection;
        }
        if ( SupportedForThreatMonitoring != null ) {
            this.SupportedForThreatMonitoring = SupportedForThreatMonitoring;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Boolean? SupportedForAnomalyDetection
        // GraphQL -> supportedForAnomalyDetection: Boolean! (scalar)
        if (this.SupportedForAnomalyDetection != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedForAnomalyDetection\n" ;
            } else {
                s += ind + "supportedForAnomalyDetection\n" ;
            }
        }
        //      C# -> System.Boolean? SupportedForThreatMonitoring
        // GraphQL -> supportedForThreatMonitoring: Boolean! (scalar)
        if (this.SupportedForThreatMonitoring != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedForThreatMonitoring\n" ;
            } else {
                s += ind + "supportedForThreatMonitoring\n" ;
            }
        }
        //      C# -> SecurityFeaturesStatus? Status
        // GraphQL -> status: SecurityFeaturesStatus (type)
        if (this.Status != null) {
            var fspec = this.Status.AsFieldSpec(conf.Child("status"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "status" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Boolean? SupportedForAnomalyDetection
        // GraphQL -> supportedForAnomalyDetection: Boolean! (scalar)
        if (ec.Includes("supportedForAnomalyDetection",true))
        {
            if(this.SupportedForAnomalyDetection == null) {

                this.SupportedForAnomalyDetection = true;

            } else {


            }
        }
        else if (this.SupportedForAnomalyDetection != null && ec.Excludes("supportedForAnomalyDetection",true))
        {
            this.SupportedForAnomalyDetection = null;
        }
        //      C# -> System.Boolean? SupportedForThreatMonitoring
        // GraphQL -> supportedForThreatMonitoring: Boolean! (scalar)
        if (ec.Includes("supportedForThreatMonitoring",true))
        {
            if(this.SupportedForThreatMonitoring == null) {

                this.SupportedForThreatMonitoring = true;

            } else {


            }
        }
        else if (this.SupportedForThreatMonitoring != null && ec.Excludes("supportedForThreatMonitoring",true))
        {
            this.SupportedForThreatMonitoring = null;
        }
        //      C# -> SecurityFeaturesStatus? Status
        // GraphQL -> status: SecurityFeaturesStatus (type)
        if (ec.Includes("status",false))
        {
            if(this.Status == null) {

                this.Status = new SecurityFeaturesStatus();
                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            } else {

                this.Status.ApplyExploratoryFieldSpec(ec.NewChild("status"));

            }
        }
        else if (this.Status != null && ec.Excludes("status",false))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class SecurityFeaturesStatusEntry
    
    #endregion

    public static class ListSecurityFeaturesStatusEntryExtensions
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
            this List<SecurityFeaturesStatusEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SecurityFeaturesStatusEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SecurityFeaturesStatusEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SecurityFeaturesStatusEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SecurityFeaturesStatusEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types