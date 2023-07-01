// SapHanaConfig.cs
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
    #region SapHanaConfig
    public class SapHanaConfig: BaseType
    {
        #region members

        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        [JsonProperty("differentialFrequency")]
        public Duration? DifferentialFrequency { get; set; }

        //      C# -> Duration? IncrementalFrequency
        // GraphQL -> incrementalFrequency: Duration (type)
        [JsonProperty("incrementalFrequency")]
        public Duration? IncrementalFrequency { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaConfig";
    }

    public SapHanaConfig Set(
        Duration? DifferentialFrequency = null,
        Duration? IncrementalFrequency = null,
        Duration? LogRetention = null
    ) 
    {
        if ( DifferentialFrequency != null ) {
            this.DifferentialFrequency = DifferentialFrequency;
        }
        if ( IncrementalFrequency != null ) {
            this.IncrementalFrequency = IncrementalFrequency;
        }
        if ( LogRetention != null ) {
            this.LogRetention = LogRetention;
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
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        if (this.DifferentialFrequency != null) {
            var fspec = this.DifferentialFrequency.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "differentialFrequency {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? IncrementalFrequency
        // GraphQL -> incrementalFrequency: Duration (type)
        if (this.IncrementalFrequency != null) {
            var fspec = this.IncrementalFrequency.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "incrementalFrequency {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            var fspec = this.LogRetention.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logRetention {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        if (this.DifferentialFrequency == null && Exploration.Includes(parent + ".differentialFrequency"))
        {
            this.DifferentialFrequency = new Duration();
            this.DifferentialFrequency.ApplyExploratoryFieldSpec(parent + ".differentialFrequency");
        }
        //      C# -> Duration? IncrementalFrequency
        // GraphQL -> incrementalFrequency: Duration (type)
        if (this.IncrementalFrequency == null && Exploration.Includes(parent + ".incrementalFrequency"))
        {
            this.IncrementalFrequency = new Duration();
            this.IncrementalFrequency.ApplyExploratoryFieldSpec(parent + ".incrementalFrequency");
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention == null && Exploration.Includes(parent + ".logRetention"))
        {
            this.LogRetention = new Duration();
            this.LogRetention.ApplyExploratoryFieldSpec(parent + ".logRetention");
        }
    }


    #endregion

    } // class SapHanaConfig
    
    #endregion

    public static class ListSapHanaConfigExtensions
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
            this List<SapHanaConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types