// FailuresAndWarningsStatsReply.cs
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
    #region FailuresAndWarningsStatsReply
    public class FailuresAndWarningsStatsReply: BaseType
    {
        #region members

        //      C# -> List<FailuresAndWarningsStats>? FailuresAndWarningsStats
        // GraphQL -> failuresAndWarningsStats: [FailuresAndWarningsStats!]! (type)
        [JsonProperty("failuresAndWarningsStats")]
        public List<FailuresAndWarningsStats>? FailuresAndWarningsStats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FailuresAndWarningsStatsReply";
    }

    public FailuresAndWarningsStatsReply Set(
        List<FailuresAndWarningsStats>? FailuresAndWarningsStats = null
    ) 
    {
        if ( FailuresAndWarningsStats != null ) {
            this.FailuresAndWarningsStats = FailuresAndWarningsStats;
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
        //      C# -> List<FailuresAndWarningsStats>? FailuresAndWarningsStats
        // GraphQL -> failuresAndWarningsStats: [FailuresAndWarningsStats!]! (type)
        if (this.FailuresAndWarningsStats != null) {
            var fspec = this.FailuresAndWarningsStats.AsFieldSpec(conf.Child("failuresAndWarningsStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failuresAndWarningsStats {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<FailuresAndWarningsStats>? FailuresAndWarningsStats
        // GraphQL -> failuresAndWarningsStats: [FailuresAndWarningsStats!]! (type)
        if (ec.Includes("failuresAndWarningsStats",false))
        {
            if(this.FailuresAndWarningsStats == null) {

                this.FailuresAndWarningsStats = new List<FailuresAndWarningsStats>();
                this.FailuresAndWarningsStats.ApplyExploratoryFieldSpec(ec.NewChild("failuresAndWarningsStats"));

            } else {

                this.FailuresAndWarningsStats.ApplyExploratoryFieldSpec(ec.NewChild("failuresAndWarningsStats"));

            }
        }
        else if (this.FailuresAndWarningsStats != null && ec.Excludes("failuresAndWarningsStats",false))
        {
            this.FailuresAndWarningsStats = null;
        }
    }


    #endregion

    } // class FailuresAndWarningsStatsReply
    
    #endregion

    public static class ListFailuresAndWarningsStatsReplyExtensions
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
            this List<FailuresAndWarningsStatsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FailuresAndWarningsStatsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FailuresAndWarningsStatsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FailuresAndWarningsStatsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FailuresAndWarningsStatsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types