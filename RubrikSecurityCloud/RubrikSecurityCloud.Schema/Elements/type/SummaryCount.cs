// SummaryCount.cs
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
    #region SummaryCount
    public class SummaryCount: BaseType
    {
        #region members

        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }

        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        [JsonProperty("violatedCount")]
        public System.Int64? ViolatedCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SummaryCount";
    }

    public SummaryCount Set(
        System.Int64? TotalCount = null,
        System.Int64? ViolatedCount = null
    ) 
    {
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( ViolatedCount != null ) {
            this.ViolatedCount = ViolatedCount;
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
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        if (this.ViolatedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedCount\n" ;
            } else {
                s += ind + "violatedCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
        //      C# -> System.Int64? ViolatedCount
        // GraphQL -> violatedCount: Long! (scalar)
        if (ec.Includes("violatedCount",true))
        {
            if(this.ViolatedCount == null) {

                this.ViolatedCount = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedCount != null && ec.Excludes("violatedCount",true))
        {
            this.ViolatedCount = null;
        }
    }


    #endregion

    } // class SummaryCount
    
    #endregion

    public static class ListSummaryCountExtensions
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
            this List<SummaryCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SummaryCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SummaryCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SummaryCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types