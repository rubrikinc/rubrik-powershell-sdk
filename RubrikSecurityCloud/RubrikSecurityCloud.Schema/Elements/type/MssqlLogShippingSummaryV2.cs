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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (this.MakeupReseedLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "makeupReseedLimit\n" ;
            } else {
                s += ind + "makeupReseedLimit\n" ;
            }
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (this.MssqlLogShippingSummary != null) {
            var fspec = this.MssqlLogShippingSummary.AsFieldSpec(conf.Child("mssqlLogShippingSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlLogShippingSummary {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? MakeupReseedLimit
        // GraphQL -> makeupReseedLimit: Int (scalar)
        if (ec.Includes("makeupReseedLimit",true))
        {
            if(this.MakeupReseedLimit == null) {

                this.MakeupReseedLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.MakeupReseedLimit != null && ec.Excludes("makeupReseedLimit",true))
        {
            this.MakeupReseedLimit = null;
        }
        //      C# -> MssqlLogShippingSummary? MssqlLogShippingSummary
        // GraphQL -> mssqlLogShippingSummary: MssqlLogShippingSummary (type)
        if (ec.Includes("mssqlLogShippingSummary",false))
        {
            if(this.MssqlLogShippingSummary == null) {

                this.MssqlLogShippingSummary = new MssqlLogShippingSummary();
                this.MssqlLogShippingSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummary"));

            } else {

                this.MssqlLogShippingSummary.ApplyExploratoryFieldSpec(ec.NewChild("mssqlLogShippingSummary"));

            }
        }
        else if (this.MssqlLogShippingSummary != null && ec.Excludes("mssqlLogShippingSummary",false))
        {
            this.MssqlLogShippingSummary = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<MssqlLogShippingSummaryV2> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types