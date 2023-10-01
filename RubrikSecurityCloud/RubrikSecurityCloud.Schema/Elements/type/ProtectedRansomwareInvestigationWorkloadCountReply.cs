// ProtectedRansomwareInvestigationWorkloadCountReply.cs
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
    #region ProtectedRansomwareInvestigationWorkloadCountReply
    public class ProtectedRansomwareInvestigationWorkloadCountReply: BaseType
    {
        #region members

        //      C# -> List<ProtectedRansomwareInvestigationWorkload>? WorkloadCounts
        // GraphQL -> workloadCounts: [ProtectedRansomwareInvestigationWorkload!]! (type)
        [JsonProperty("workloadCounts")]
        public List<ProtectedRansomwareInvestigationWorkload>? WorkloadCounts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectedRansomwareInvestigationWorkloadCountReply";
    }

    public ProtectedRansomwareInvestigationWorkloadCountReply Set(
        List<ProtectedRansomwareInvestigationWorkload>? WorkloadCounts = null
    ) 
    {
        if ( WorkloadCounts != null ) {
            this.WorkloadCounts = WorkloadCounts;
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
        //      C# -> List<ProtectedRansomwareInvestigationWorkload>? WorkloadCounts
        // GraphQL -> workloadCounts: [ProtectedRansomwareInvestigationWorkload!]! (type)
        if (this.WorkloadCounts != null) {
            var fspec = this.WorkloadCounts.AsFieldSpec(conf.Child("workloadCounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadCounts {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ProtectedRansomwareInvestigationWorkload>? WorkloadCounts
        // GraphQL -> workloadCounts: [ProtectedRansomwareInvestigationWorkload!]! (type)
        if (ec.Includes("workloadCounts",false))
        {
            if(this.WorkloadCounts == null) {

                this.WorkloadCounts = new List<ProtectedRansomwareInvestigationWorkload>();
                this.WorkloadCounts.ApplyExploratoryFieldSpec(ec.NewChild("workloadCounts"));

            } else {

                this.WorkloadCounts.ApplyExploratoryFieldSpec(ec.NewChild("workloadCounts"));

            }
        }
        else if (this.WorkloadCounts != null && ec.Excludes("workloadCounts",false))
        {
            this.WorkloadCounts = null;
        }
    }


    #endregion

    } // class ProtectedRansomwareInvestigationWorkloadCountReply
    
    #endregion

    public static class ListProtectedRansomwareInvestigationWorkloadCountReplyExtensions
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
            this List<ProtectedRansomwareInvestigationWorkloadCountReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ProtectedRansomwareInvestigationWorkloadCountReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectedRansomwareInvestigationWorkloadCountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectedRansomwareInvestigationWorkloadCountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectedRansomwareInvestigationWorkloadCountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types