// OracleConfig.cs
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
    #region OracleConfig
    public class OracleConfig: BaseType
    {
        #region members

        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        [JsonProperty("frequency")]
        public Duration? Frequency { get; set; }

        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        [JsonProperty("hostLogRetention")]
        public Duration? HostLogRetention { get; set; }

        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        [JsonProperty("logRetention")]
        public Duration? LogRetention { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OracleConfig";
    }

    public OracleConfig Set(
        Duration? Frequency = null,
        Duration? HostLogRetention = null,
        Duration? LogRetention = null
    ) 
    {
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( HostLogRetention != null ) {
            this.HostLogRetention = HostLogRetention;
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
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (this.Frequency != null) {
            var fspec = this.Frequency.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "frequency {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (this.HostLogRetention != null) {
            var fspec = this.HostLogRetention.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hostLogRetention {\n" + fspec + ind + "}\n" ;
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
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (this.Frequency == null && ec.Includes("frequency",false))
        {
            this.Frequency = new Duration();
            this.Frequency.ApplyExploratoryFieldSpec(ec.NewChild("frequency"));
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (this.HostLogRetention == null && ec.Includes("hostLogRetention",false))
        {
            this.HostLogRetention = new Duration();
            this.HostLogRetention.ApplyExploratoryFieldSpec(ec.NewChild("hostLogRetention"));
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

    } // class OracleConfig
    
    #endregion

    public static class ListOracleConfigExtensions
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
            this List<OracleConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<OracleConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types