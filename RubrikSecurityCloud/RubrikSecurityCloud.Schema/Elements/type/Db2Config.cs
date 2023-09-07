// Db2Config.cs
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
    #region Db2Config
    public class Db2Config: BaseType
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
        return "Db2Config";
    }

    public Db2Config Set(
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? DifferentialFrequency
        // GraphQL -> differentialFrequency: Duration (type)
        if (this.DifferentialFrequency == null && ec.Includes("differentialFrequency",false))
        {
            this.DifferentialFrequency = new Duration();
            this.DifferentialFrequency.ApplyExploratoryFieldSpec(ec.NewChild("differentialFrequency"));
        }
        //      C# -> Duration? IncrementalFrequency
        // GraphQL -> incrementalFrequency: Duration (type)
        if (this.IncrementalFrequency == null && ec.Includes("incrementalFrequency",false))
        {
            this.IncrementalFrequency = new Duration();
            this.IncrementalFrequency.ApplyExploratoryFieldSpec(ec.NewChild("incrementalFrequency"));
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention == null && ec.Includes("logRetention",false))
        {
            this.LogRetention = new Duration();
            this.LogRetention.ApplyExploratoryFieldSpec(ec.NewChild("logRetention"));
        }
    }


    #endregion

    } // class Db2Config
    
    #endregion

    public static class ListDb2ConfigExtensions
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
            this List<Db2Config> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Db2Config> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Db2Config());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Db2Config> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types