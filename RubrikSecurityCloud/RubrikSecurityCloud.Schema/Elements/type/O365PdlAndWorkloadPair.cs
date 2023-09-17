// O365PdlAndWorkloadPair.cs
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
    #region O365PdlAndWorkloadPair
    public class O365PdlAndWorkloadPair: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        [JsonProperty("workload")]
        public WorkloadLevelHierarchy? Workload { get; set; }

        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        [JsonProperty("pdl")]
        public System.String? Pdl { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365PdlAndWorkloadPair";
    }

    public O365PdlAndWorkloadPair Set(
        WorkloadLevelHierarchy? Workload = null,
        System.String? Pdl = null
    ) 
    {
        if ( Workload != null ) {
            this.Workload = Workload;
        }
        if ( Pdl != null ) {
            this.Pdl = Pdl;
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
        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        if (this.Workload != null) {
            s += ind + "workload\n" ;
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl != null) {
            s += ind + "pdl\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        if (this.Workload == null && ec.Includes("workload",true))
        {
            this.Workload = new WorkloadLevelHierarchy();
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl == null && ec.Includes("pdl",true))
        {
            this.Pdl = "FETCH";
        }
    }


    #endregion

    } // class O365PdlAndWorkloadPair
    
    #endregion

    public static class ListO365PdlAndWorkloadPairExtensions
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
            this List<O365PdlAndWorkloadPair> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365PdlAndWorkloadPair> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365PdlAndWorkloadPair());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365PdlAndWorkloadPair> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types