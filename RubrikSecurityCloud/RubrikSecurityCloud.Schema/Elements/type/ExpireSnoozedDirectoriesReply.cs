// ExpireSnoozedDirectoriesReply.cs
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
    #region ExpireSnoozedDirectoriesReply
    public class ExpireSnoozedDirectoriesReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? DirectoriesExpired
        // GraphQL -> directoriesExpired: [String!]! (scalar)
        [JsonProperty("directoriesExpired")]
        public List<System.String>? DirectoriesExpired { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExpireSnoozedDirectoriesReply";
    }

    public ExpireSnoozedDirectoriesReply Set(
        List<System.String>? DirectoriesExpired = null,
        System.Int64? Total = null
    ) 
    {
        if ( DirectoriesExpired != null ) {
            this.DirectoriesExpired = DirectoriesExpired;
        }
        if ( Total != null ) {
            this.Total = Total;
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
        //      C# -> List<System.String>? DirectoriesExpired
        // GraphQL -> directoriesExpired: [String!]! (scalar)
        if (this.DirectoriesExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directoriesExpired\n" ;
            } else {
                s += ind + "directoriesExpired\n" ;
            }
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (this.Total != null) {
            if (conf.Flat) {
                s += conf.Prefix + "total\n" ;
            } else {
                s += ind + "total\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? DirectoriesExpired
        // GraphQL -> directoriesExpired: [String!]! (scalar)
        if (ec.Includes("directoriesExpired",true))
        {
            if(this.DirectoriesExpired == null) {

                this.DirectoriesExpired = new List<System.String>();

            } else {


            }
        }
        else if (this.DirectoriesExpired != null && ec.Excludes("directoriesExpired",true))
        {
            this.DirectoriesExpired = null;
        }
        //      C# -> System.Int64? Total
        // GraphQL -> total: Long! (scalar)
        if (ec.Includes("total",true))
        {
            if(this.Total == null) {

                this.Total = new System.Int64();

            } else {


            }
        }
        else if (this.Total != null && ec.Excludes("total",true))
        {
            this.Total = null;
        }
    }


    #endregion

    } // class ExpireSnoozedDirectoriesReply
    
    #endregion

    public static class ListExpireSnoozedDirectoriesReplyExtensions
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
            this List<ExpireSnoozedDirectoriesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ExpireSnoozedDirectoriesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExpireSnoozedDirectoriesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExpireSnoozedDirectoriesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExpireSnoozedDirectoriesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types