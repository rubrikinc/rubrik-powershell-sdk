// PolarisReportFilterConfigs.cs
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
    #region PolarisReportFilterConfigs
    public class PolarisReportFilterConfigs: BaseType
    {
        #region members

        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        [JsonProperty("values")]
        public List<Value>? Values { get; set; }

        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PolarisReportFilterConfigs";
    }

    public PolarisReportFilterConfigs Set(
        List<Value>? Values = null,
        System.String? Key = null
    ) 
    {
        if ( Values != null ) {
            this.Values = Values;
        }
        if ( Key != null ) {
            this.Key = Key;
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
        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        if (this.Values != null) {
                var fspec = this.Values.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "values {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Value>? Values
        // GraphQL -> values: [Value!]! (interface)
        if (this.Values == null && ec.Includes("values",false))
        {
            this.Values = new List<Value>();
            this.Values.ApplyExploratoryFieldSpec(ec.NewChild("values"));
        }
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        if (this.Key == null && ec.Includes("key",true))
        {
            this.Key = "FETCH";
        }
    }


    #endregion

    } // class PolarisReportFilterConfigs
    
    #endregion

    public static class ListPolarisReportFilterConfigsExtensions
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
            this List<PolarisReportFilterConfigs> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PolarisReportFilterConfigs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolarisReportFilterConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<PolarisReportFilterConfigs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types