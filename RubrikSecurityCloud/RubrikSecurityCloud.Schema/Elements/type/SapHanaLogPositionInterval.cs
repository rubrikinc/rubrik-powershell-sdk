// SapHanaLogPositionInterval.cs
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
    #region SapHanaLogPositionInterval
    public class SapHanaLogPositionInterval: BaseType
    {
        #region members

        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        [JsonProperty("newestLogPosition")]
        public System.Int64? NewestLogPosition { get; set; }

        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        [JsonProperty("oldestLogPosition")]
        public System.Int64? OldestLogPosition { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SapHanaLogPositionInterval";
    }

    public SapHanaLogPositionInterval Set(
        System.Int64? NewestLogPosition = null,
        System.Int64? OldestLogPosition = null
    ) 
    {
        if ( NewestLogPosition != null ) {
            this.NewestLogPosition = NewestLogPosition;
        }
        if ( OldestLogPosition != null ) {
            this.OldestLogPosition = OldestLogPosition;
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
        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        if (this.NewestLogPosition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newestLogPosition\n" ;
            } else {
                s += ind + "newestLogPosition\n" ;
            }
        }
        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        if (this.OldestLogPosition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "oldestLogPosition\n" ;
            } else {
                s += ind + "oldestLogPosition\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? NewestLogPosition
        // GraphQL -> newestLogPosition: Long (scalar)
        if (ec.Includes("newestLogPosition",true))
        {
            if(this.NewestLogPosition == null) {

                this.NewestLogPosition = new System.Int64();

            } else {


            }
        }
        else if (this.NewestLogPosition != null && ec.Excludes("newestLogPosition",true))
        {
            this.NewestLogPosition = null;
        }
        //      C# -> System.Int64? OldestLogPosition
        // GraphQL -> oldestLogPosition: Long (scalar)
        if (ec.Includes("oldestLogPosition",true))
        {
            if(this.OldestLogPosition == null) {

                this.OldestLogPosition = new System.Int64();

            } else {


            }
        }
        else if (this.OldestLogPosition != null && ec.Excludes("oldestLogPosition",true))
        {
            this.OldestLogPosition = null;
        }
    }


    #endregion

    } // class SapHanaLogPositionInterval
    
    #endregion

    public static class ListSapHanaLogPositionIntervalExtensions
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
            this List<SapHanaLogPositionInterval> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SapHanaLogPositionInterval> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SapHanaLogPositionInterval());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SapHanaLogPositionInterval> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types