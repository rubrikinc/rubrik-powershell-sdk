// PrechecksStatusReply.cs
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
    #region PrechecksStatusReply
    public class PrechecksStatusReply: BaseType
    {
        #region members

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        [JsonProperty("numPrechecks")]
        public System.Int32? NumPrechecks { get; set; }

        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        [JsonProperty("runPeriodInMinutes")]
        public System.Int32? RunPeriodInMinutes { get; set; }

        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        [JsonProperty("failureResults")]
        public List<PrecheckFailure>? FailureResults { get; set; }

        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        [JsonProperty("nextRunInfo")]
        public PrecheckStatusNextRunInfo? NextRunInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrechecksStatusReply";
    }

    public PrechecksStatusReply Set(
        System.Int64? EndTime = null,
        System.Int32? NumPrechecks = null,
        System.Int32? RunPeriodInMinutes = null,
        List<PrecheckFailure>? FailureResults = null,
        PrecheckStatusNextRunInfo? NextRunInfo = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( NumPrechecks != null ) {
            this.NumPrechecks = NumPrechecks;
        }
        if ( RunPeriodInMinutes != null ) {
            this.RunPeriodInMinutes = RunPeriodInMinutes;
        }
        if ( FailureResults != null ) {
            this.FailureResults = FailureResults;
        }
        if ( NextRunInfo != null ) {
            this.NextRunInfo = NextRunInfo;
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
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        if (this.NumPrechecks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numPrechecks\n" ;
            } else {
                s += ind + "numPrechecks\n" ;
            }
        }
        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        if (this.RunPeriodInMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runPeriodInMinutes\n" ;
            } else {
                s += ind + "runPeriodInMinutes\n" ;
            }
        }
        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        if (this.FailureResults != null) {
            var fspec = this.FailureResults.AsFieldSpec(conf.Child("failureResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failureResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        if (this.NextRunInfo != null) {
            var fspec = this.NextRunInfo.AsFieldSpec(conf.Child("nextRunInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nextRunInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new System.Int64();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Int32? NumPrechecks
        // GraphQL -> numPrechecks: Int! (scalar)
        if (ec.Includes("numPrechecks",true))
        {
            if(this.NumPrechecks == null) {

                this.NumPrechecks = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumPrechecks != null && ec.Excludes("numPrechecks",true))
        {
            this.NumPrechecks = null;
        }
        //      C# -> System.Int32? RunPeriodInMinutes
        // GraphQL -> runPeriodInMinutes: Int! (scalar)
        if (ec.Includes("runPeriodInMinutes",true))
        {
            if(this.RunPeriodInMinutes == null) {

                this.RunPeriodInMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.RunPeriodInMinutes != null && ec.Excludes("runPeriodInMinutes",true))
        {
            this.RunPeriodInMinutes = null;
        }
        //      C# -> List<PrecheckFailure>? FailureResults
        // GraphQL -> failureResults: [PrecheckFailure!]! (type)
        if (ec.Includes("failureResults",false))
        {
            if(this.FailureResults == null) {

                this.FailureResults = new List<PrecheckFailure>();
                this.FailureResults.ApplyExploratoryFieldSpec(ec.NewChild("failureResults"));

            } else {

                this.FailureResults.ApplyExploratoryFieldSpec(ec.NewChild("failureResults"));

            }
        }
        else if (this.FailureResults != null && ec.Excludes("failureResults",false))
        {
            this.FailureResults = null;
        }
        //      C# -> PrecheckStatusNextRunInfo? NextRunInfo
        // GraphQL -> nextRunInfo: PrecheckStatusNextRunInfo (type)
        if (ec.Includes("nextRunInfo",false))
        {
            if(this.NextRunInfo == null) {

                this.NextRunInfo = new PrecheckStatusNextRunInfo();
                this.NextRunInfo.ApplyExploratoryFieldSpec(ec.NewChild("nextRunInfo"));

            } else {

                this.NextRunInfo.ApplyExploratoryFieldSpec(ec.NewChild("nextRunInfo"));

            }
        }
        else if (this.NextRunInfo != null && ec.Excludes("nextRunInfo",false))
        {
            this.NextRunInfo = null;
        }
    }


    #endregion

    } // class PrechecksStatusReply
    
    #endregion

    public static class ListPrechecksStatusReplyExtensions
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
            this List<PrechecksStatusReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrechecksStatusReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrechecksStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrechecksStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrechecksStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types