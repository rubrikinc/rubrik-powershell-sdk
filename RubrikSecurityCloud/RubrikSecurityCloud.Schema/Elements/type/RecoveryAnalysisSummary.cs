// RecoveryAnalysisSummary.cs
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
    #region RecoveryAnalysisSummary
    public class RecoveryAnalysisSummary: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalCalendarEvents
        // GraphQL -> totalCalendarEvents: Long! (scalar)
        [JsonProperty("totalCalendarEvents")]
        public System.Int64? TotalCalendarEvents { get; set; }

        //      C# -> System.Int64? TotalContacts
        // GraphQL -> totalContacts: Long! (scalar)
        [JsonProperty("totalContacts")]
        public System.Int64? TotalContacts { get; set; }

        //      C# -> System.Int64? TotalEmails
        // GraphQL -> totalEmails: Long! (scalar)
        [JsonProperty("totalEmails")]
        public System.Int64? TotalEmails { get; set; }

        //      C# -> System.Int64? TotalOnedriveFiles
        // GraphQL -> totalOnedriveFiles: Long! (scalar)
        [JsonProperty("totalOnedriveFiles")]
        public System.Int64? TotalOnedriveFiles { get; set; }

        //      C# -> System.Int64? TotalSharepointFiles
        // GraphQL -> totalSharepointFiles: Long! (scalar)
        [JsonProperty("totalSharepointFiles")]
        public System.Int64? TotalSharepointFiles { get; set; }

        //      C# -> System.Int64? TotalSharepointSites
        // GraphQL -> totalSharepointSites: Long! (scalar)
        [JsonProperty("totalSharepointSites")]
        public System.Int64? TotalSharepointSites { get; set; }

        //      C# -> System.Int64? TotalUserCount
        // GraphQL -> totalUserCount: Long! (scalar)
        [JsonProperty("totalUserCount")]
        public System.Int64? TotalUserCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryAnalysisSummary";
    }

    public RecoveryAnalysisSummary Set(
        System.Int64? TotalCalendarEvents = null,
        System.Int64? TotalContacts = null,
        System.Int64? TotalEmails = null,
        System.Int64? TotalOnedriveFiles = null,
        System.Int64? TotalSharepointFiles = null,
        System.Int64? TotalSharepointSites = null,
        System.Int64? TotalUserCount = null
    ) 
    {
        if ( TotalCalendarEvents != null ) {
            this.TotalCalendarEvents = TotalCalendarEvents;
        }
        if ( TotalContacts != null ) {
            this.TotalContacts = TotalContacts;
        }
        if ( TotalEmails != null ) {
            this.TotalEmails = TotalEmails;
        }
        if ( TotalOnedriveFiles != null ) {
            this.TotalOnedriveFiles = TotalOnedriveFiles;
        }
        if ( TotalSharepointFiles != null ) {
            this.TotalSharepointFiles = TotalSharepointFiles;
        }
        if ( TotalSharepointSites != null ) {
            this.TotalSharepointSites = TotalSharepointSites;
        }
        if ( TotalUserCount != null ) {
            this.TotalUserCount = TotalUserCount;
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
        //      C# -> System.Int64? TotalCalendarEvents
        // GraphQL -> totalCalendarEvents: Long! (scalar)
        if (this.TotalCalendarEvents != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCalendarEvents\n" ;
            } else {
                s += ind + "totalCalendarEvents\n" ;
            }
        }
        //      C# -> System.Int64? TotalContacts
        // GraphQL -> totalContacts: Long! (scalar)
        if (this.TotalContacts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalContacts\n" ;
            } else {
                s += ind + "totalContacts\n" ;
            }
        }
        //      C# -> System.Int64? TotalEmails
        // GraphQL -> totalEmails: Long! (scalar)
        if (this.TotalEmails != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalEmails\n" ;
            } else {
                s += ind + "totalEmails\n" ;
            }
        }
        //      C# -> System.Int64? TotalOnedriveFiles
        // GraphQL -> totalOnedriveFiles: Long! (scalar)
        if (this.TotalOnedriveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalOnedriveFiles\n" ;
            } else {
                s += ind + "totalOnedriveFiles\n" ;
            }
        }
        //      C# -> System.Int64? TotalSharepointFiles
        // GraphQL -> totalSharepointFiles: Long! (scalar)
        if (this.TotalSharepointFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSharepointFiles\n" ;
            } else {
                s += ind + "totalSharepointFiles\n" ;
            }
        }
        //      C# -> System.Int64? TotalSharepointSites
        // GraphQL -> totalSharepointSites: Long! (scalar)
        if (this.TotalSharepointSites != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSharepointSites\n" ;
            } else {
                s += ind + "totalSharepointSites\n" ;
            }
        }
        //      C# -> System.Int64? TotalUserCount
        // GraphQL -> totalUserCount: Long! (scalar)
        if (this.TotalUserCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUserCount\n" ;
            } else {
                s += ind + "totalUserCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? TotalCalendarEvents
        // GraphQL -> totalCalendarEvents: Long! (scalar)
        if (ec.Includes("totalCalendarEvents",true))
        {
            if(this.TotalCalendarEvents == null) {

                this.TotalCalendarEvents = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCalendarEvents != null && ec.Excludes("totalCalendarEvents",true))
        {
            this.TotalCalendarEvents = null;
        }
        //      C# -> System.Int64? TotalContacts
        // GraphQL -> totalContacts: Long! (scalar)
        if (ec.Includes("totalContacts",true))
        {
            if(this.TotalContacts == null) {

                this.TotalContacts = new System.Int64();

            } else {


            }
        }
        else if (this.TotalContacts != null && ec.Excludes("totalContacts",true))
        {
            this.TotalContacts = null;
        }
        //      C# -> System.Int64? TotalEmails
        // GraphQL -> totalEmails: Long! (scalar)
        if (ec.Includes("totalEmails",true))
        {
            if(this.TotalEmails == null) {

                this.TotalEmails = new System.Int64();

            } else {


            }
        }
        else if (this.TotalEmails != null && ec.Excludes("totalEmails",true))
        {
            this.TotalEmails = null;
        }
        //      C# -> System.Int64? TotalOnedriveFiles
        // GraphQL -> totalOnedriveFiles: Long! (scalar)
        if (ec.Includes("totalOnedriveFiles",true))
        {
            if(this.TotalOnedriveFiles == null) {

                this.TotalOnedriveFiles = new System.Int64();

            } else {


            }
        }
        else if (this.TotalOnedriveFiles != null && ec.Excludes("totalOnedriveFiles",true))
        {
            this.TotalOnedriveFiles = null;
        }
        //      C# -> System.Int64? TotalSharepointFiles
        // GraphQL -> totalSharepointFiles: Long! (scalar)
        if (ec.Includes("totalSharepointFiles",true))
        {
            if(this.TotalSharepointFiles == null) {

                this.TotalSharepointFiles = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSharepointFiles != null && ec.Excludes("totalSharepointFiles",true))
        {
            this.TotalSharepointFiles = null;
        }
        //      C# -> System.Int64? TotalSharepointSites
        // GraphQL -> totalSharepointSites: Long! (scalar)
        if (ec.Includes("totalSharepointSites",true))
        {
            if(this.TotalSharepointSites == null) {

                this.TotalSharepointSites = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSharepointSites != null && ec.Excludes("totalSharepointSites",true))
        {
            this.TotalSharepointSites = null;
        }
        //      C# -> System.Int64? TotalUserCount
        // GraphQL -> totalUserCount: Long! (scalar)
        if (ec.Includes("totalUserCount",true))
        {
            if(this.TotalUserCount == null) {

                this.TotalUserCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUserCount != null && ec.Excludes("totalUserCount",true))
        {
            this.TotalUserCount = null;
        }
    }


    #endregion

    } // class RecoveryAnalysisSummary
    
    #endregion

    public static class ListRecoveryAnalysisSummaryExtensions
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
            this List<RecoveryAnalysisSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryAnalysisSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryAnalysisSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryAnalysisSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryAnalysisSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types