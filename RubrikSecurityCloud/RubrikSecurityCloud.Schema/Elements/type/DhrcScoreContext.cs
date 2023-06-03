// DhrcScoreContext.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region DhrcScoreContext
    public class DhrcScoreContext: BaseType
    {
        #region members

        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        [JsonProperty("metrics")]
        public List<DhrcScoreMetric>? Metrics { get; set; }


        #endregion

    #region methods

    public DhrcScoreContext Set(
        List<DhrcScoreMetric>? Metrics = null
    ) 
    {
        if ( Metrics != null ) {
            this.Metrics = Metrics;
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
        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        if (this.Metrics != null) {
            s += ind + "metrics {\n" + this.Metrics.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DhrcScoreMetric>? Metrics
        // GraphQL -> metrics: [DhrcScoreMetric!]! (type)
        if (this.Metrics == null && Exploration.Includes(parent + ".metrics"))
        {
            this.Metrics = new List<DhrcScoreMetric>();
            this.Metrics.ApplyExploratoryFieldSpec(parent + ".metrics");
        }
    }


    #endregion

    } // class DhrcScoreContext
    
    #endregion

    public static class ListDhrcScoreContextExtensions
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
            this List<DhrcScoreContext> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScoreContext> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScoreContext());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types