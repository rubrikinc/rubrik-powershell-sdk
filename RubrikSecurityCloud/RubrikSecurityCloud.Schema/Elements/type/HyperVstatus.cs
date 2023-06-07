// HyperVstatus.cs
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
    #region HyperVstatus
    public class HyperVstatus: BaseType
    {
        #region members

        //      C# -> System.String? Connectivity
        // GraphQL -> connectivity: String! (scalar)
        [JsonProperty("connectivity")]
        public System.String? Connectivity { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }


        #endregion

    #region methods

    public HyperVstatus Set(
        System.String? Connectivity = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( Connectivity != null ) {
            this.Connectivity = Connectivity;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
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
        //      C# -> System.String? Connectivity
        // GraphQL -> connectivity: String! (scalar)
        if (this.Connectivity != null) {
            s += ind + "connectivity\n" ;
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis != null) {
            s += ind + "timestampMillis\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Connectivity
        // GraphQL -> connectivity: String! (scalar)
        if (this.Connectivity == null && Exploration.Includes(parent + ".connectivity", true))
        {
            this.Connectivity = "FETCH";
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis == null && Exploration.Includes(parent + ".timestampMillis", true))
        {
            this.TimestampMillis = new DateTime();
        }
    }


    #endregion

    } // class HyperVstatus
    
    #endregion

    public static class ListHyperVstatusExtensions
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
            this List<HyperVstatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HyperVstatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HyperVstatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types