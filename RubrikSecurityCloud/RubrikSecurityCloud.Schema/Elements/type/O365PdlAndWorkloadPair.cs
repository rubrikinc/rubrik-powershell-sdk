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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        if (this.Workload != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workload\n" ;
            } else {
                s += ind + "workload\n" ;
            }
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (this.Pdl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pdl\n" ;
            } else {
                s += ind + "pdl\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? Workload
        // GraphQL -> workload: WorkloadLevelHierarchy! (enum)
        if (ec.Includes("workload",true))
        {
            if(this.Workload == null) {

                this.Workload = new WorkloadLevelHierarchy();

            } else {


            }
        }
        else if (this.Workload != null && ec.Excludes("workload",true))
        {
            this.Workload = null;
        }
        //      C# -> System.String? Pdl
        // GraphQL -> pdl: String! (scalar)
        if (ec.Includes("pdl",true))
        {
            if(this.Pdl == null) {

                this.Pdl = "FETCH";

            } else {


            }
        }
        else if (this.Pdl != null && ec.Excludes("pdl",true))
        {
            this.Pdl = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<O365PdlAndWorkloadPair> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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