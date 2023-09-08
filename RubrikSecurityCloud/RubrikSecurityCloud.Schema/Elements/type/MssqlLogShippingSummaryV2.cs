// MssqlLogShippingSummaryV2.cs
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
    #region MssqlLogShippingSummaryV2
    public class MssqlLogShippingSummaryV2: BaseType
    {
        #region members

        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        [JsonProperty("makeupReseedLimit")]
        public System.Int32? MakeupReseedLimit { get; set; }

        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        [JsonProperty("mssqlLogShippingSummary")]
        public MssqlLogShippingSummary? MssqlLogShippingSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlLogShippingSummaryV2";
    }

    public MssqlLogShippingSummaryV2 Set(
        System.Int32? MakeupReseedLimit = null,
        MssqlLogShippingSummary? MssqlLogShippingSummary = null
    ) 
    {
        if ( MakeupReseedLimit != null ) {
            this.MakeupReseedLimit = MakeupReseedLimit;
        }
        if ( MssqlLogShippingSummary != null ) {
            this.MssqlLogShippingSummary = MssqlLogShippingSummary;
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
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (this.MakeupReseedLimit != null) {
            s += ind + "makeupReseedLimit\n" ;
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (this.MssqlLogShippingSummary != null) {
            var fspec = this.MssqlLogShippingSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mssqlLogShippingSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (this.MakeupReseedLimit == null && ec.Includes("makeupReseedLimit",true))
        {
            this.MakeupReseedLimit = Int32.MinValue;
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (this.MssqlLogShippingSummary == null && ec.Includes("mssqlLogShippingSummary",false))
        {
            this.MssqlLogShippingSummary = new MssqlLogShippingSummary();
            this.MssqlLogShippingSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummary"));
        }
    }


    #endregion

    } // class MssqlLogShippingSummaryV2
    
    #endregion

    public static class ListMssqlLogShippingSummaryV2Extensions
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
            this List<MssqlLogShippingSummaryV2> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlLogShippingSummaryV2> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlLogShippingSummaryV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MssqlLogShippingSummaryV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types