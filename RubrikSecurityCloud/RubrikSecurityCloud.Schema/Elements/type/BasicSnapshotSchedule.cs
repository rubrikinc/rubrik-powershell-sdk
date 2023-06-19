// BasicSnapshotSchedule.cs
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
    #region BasicSnapshotSchedule
    public class BasicSnapshotSchedule: BaseType
    {
        #region members

        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        [JsonProperty("retentionUnit")]
        public RetentionUnit? RetentionUnit { get; set; }

        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        [JsonProperty("frequency")]
        public System.Int32? Frequency { get; set; }

        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        [JsonProperty("retention")]
        public System.Int32? Retention { get; set; }


        #endregion

    #region methods

    public BasicSnapshotSchedule Set(
        RetentionUnit? RetentionUnit = null,
        System.Int32? Frequency = null,
        System.Int32? Retention = null
    ) 
    {
        if ( RetentionUnit != null ) {
            this.RetentionUnit = RetentionUnit;
        }
        if ( Frequency != null ) {
            this.Frequency = Frequency;
        }
        if ( Retention != null ) {
            this.Retention = Retention;
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
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit != null) {
            s += ind + "retentionUnit\n" ;
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency != null) {
            s += ind + "frequency\n" ;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention != null) {
            s += ind + "retention\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RetentionUnit? RetentionUnit
        // GraphQL -> retentionUnit: RetentionUnit! (enum)
        if (this.RetentionUnit == null && Exploration.Includes(parent + ".retentionUnit", true))
        {
            this.RetentionUnit = new RetentionUnit();
        }
        //      C# -> System.Int32? Frequency
        // GraphQL -> frequency: Int! (scalar)
        if (this.Frequency == null && Exploration.Includes(parent + ".frequency", true))
        {
            this.Frequency = Int32.MinValue;
        }
        //      C# -> System.Int32? Retention
        // GraphQL -> retention: Int! (scalar)
        if (this.Retention == null && Exploration.Includes(parent + ".retention", true))
        {
            this.Retention = Int32.MinValue;
        }
    }


    #endregion

    } // class BasicSnapshotSchedule
    
    #endregion

    public static class ListBasicSnapshotScheduleExtensions
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
            this List<BasicSnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BasicSnapshotSchedule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BasicSnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types