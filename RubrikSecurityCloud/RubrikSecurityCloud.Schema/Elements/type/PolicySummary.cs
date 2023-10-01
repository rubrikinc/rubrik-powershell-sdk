// PolicySummary.cs
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
    #region PolicySummary
    public class PolicySummary: BaseType
    {
        #region members

        //      C# -> TimelineEntry? HighRiskFiles
        // GraphQL -> highRiskFiles: TimelineEntry (type)
        [JsonProperty("highRiskFiles")]
        public TimelineEntry? HighRiskFiles { get; set; }

        //      C# -> TimelineEntry? LowRiskFiles
        // GraphQL -> lowRiskFiles: TimelineEntry (type)
        [JsonProperty("lowRiskFiles")]
        public TimelineEntry? LowRiskFiles { get; set; }

        //      C# -> ClassificationPolicySummary? Summary
        // GraphQL -> summary: ClassificationPolicySummary (type)
        [JsonProperty("summary")]
        public ClassificationPolicySummary? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolicySummary";
    }

    public PolicySummary Set(
        TimelineEntry? HighRiskFiles = null,
        TimelineEntry? LowRiskFiles = null,
        ClassificationPolicySummary? Summary = null
    ) 
    {
        if ( HighRiskFiles != null ) {
            this.HighRiskFiles = HighRiskFiles;
        }
        if ( LowRiskFiles != null ) {
            this.LowRiskFiles = LowRiskFiles;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> TimelineEntry? HighRiskFiles
        // GraphQL -> highRiskFiles: TimelineEntry (type)
        if (this.HighRiskFiles != null) {
            var fspec = this.HighRiskFiles.AsFieldSpec(conf.Child("highRiskFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "highRiskFiles {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TimelineEntry? LowRiskFiles
        // GraphQL -> lowRiskFiles: TimelineEntry (type)
        if (this.LowRiskFiles != null) {
            var fspec = this.LowRiskFiles.AsFieldSpec(conf.Child("lowRiskFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lowRiskFiles {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ClassificationPolicySummary? Summary
        // GraphQL -> summary: ClassificationPolicySummary (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(conf.Child("summary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "summary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TimelineEntry? HighRiskFiles
        // GraphQL -> highRiskFiles: TimelineEntry (type)
        if (ec.Includes("highRiskFiles",false))
        {
            if(this.HighRiskFiles == null) {

                this.HighRiskFiles = new TimelineEntry();
                this.HighRiskFiles.ApplyExploratoryFieldSpec(ec.NewChild("highRiskFiles"));

            } else {

                this.HighRiskFiles.ApplyExploratoryFieldSpec(ec.NewChild("highRiskFiles"));

            }
        }
        else if (this.HighRiskFiles != null && ec.Excludes("highRiskFiles",false))
        {
            this.HighRiskFiles = null;
        }
        //      C# -> TimelineEntry? LowRiskFiles
        // GraphQL -> lowRiskFiles: TimelineEntry (type)
        if (ec.Includes("lowRiskFiles",false))
        {
            if(this.LowRiskFiles == null) {

                this.LowRiskFiles = new TimelineEntry();
                this.LowRiskFiles.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskFiles"));

            } else {

                this.LowRiskFiles.ApplyExploratoryFieldSpec(ec.NewChild("lowRiskFiles"));

            }
        }
        else if (this.LowRiskFiles != null && ec.Excludes("lowRiskFiles",false))
        {
            this.LowRiskFiles = null;
        }
        //      C# -> ClassificationPolicySummary? Summary
        // GraphQL -> summary: ClassificationPolicySummary (type)
        if (ec.Includes("summary",false))
        {
            if(this.Summary == null) {

                this.Summary = new ClassificationPolicySummary();
                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            } else {

                this.Summary.ApplyExploratoryFieldSpec(ec.NewChild("summary"));

            }
        }
        else if (this.Summary != null && ec.Excludes("summary",false))
        {
            this.Summary = null;
        }
    }


    #endregion

    } // class PolicySummary
    
    #endregion

    public static class ListPolicySummaryExtensions
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
            this List<PolicySummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PolicySummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicySummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicySummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicySummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types