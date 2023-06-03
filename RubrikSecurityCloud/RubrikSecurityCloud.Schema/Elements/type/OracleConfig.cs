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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "frequency {\n" + this.Frequency.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (this.HostLogRetention != null) {
            s += ind + "hostLogRetention {\n" + this.HostLogRetention.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Duration? LogRetention
        // GraphQL -> logRetention: Duration (type)
        if (this.LogRetention != null) {
            s += ind + "logRetention {\n" + this.LogRetention.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Duration? Frequency
        // GraphQL -> frequency: Duration (type)
        if (this.Frequency == null && Exploration.Includes(parent + ".frequency"))
        {
            this.Frequency = new Duration();
            this.Frequency.ApplyExploratoryFieldSpec(parent + ".frequency");
        }
        //      C# -> Duration? HostLogRetention
        // GraphQL -> hostLogRetention: Duration (type)
        if (this.HostLogRetention == null && Exploration.Includes(parent + ".hostLogRetention"))
        {
            this.HostLogRetention = new Duration();
            this.HostLogRetention.ApplyExploratoryFieldSpec(parent + ".hostLogRetention");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types