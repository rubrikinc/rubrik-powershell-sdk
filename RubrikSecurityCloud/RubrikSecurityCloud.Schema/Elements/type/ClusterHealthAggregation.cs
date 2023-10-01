// ClusterHealthAggregation.cs
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
    #region ClusterHealthAggregation
    public class ClusterHealthAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        [JsonProperty("fatal")]
        public System.Int64? Fatal { get; set; }

        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        [JsonProperty("ok")]
        public System.Int64? Ok { get; set; }

        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        [JsonProperty("warning")]
        public System.Int64? Warning { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterHealthAggregation";
    }

    public ClusterHealthAggregation Set(
        System.Int64? Fatal = null,
        System.Int64? Ok = null,
        System.Int64? Warning = null
    ) 
    {
        if ( Fatal != null ) {
            this.Fatal = Fatal;
        }
        if ( Ok != null ) {
            this.Ok = Ok;
        }
        if ( Warning != null ) {
            this.Warning = Warning;
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
        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        if (this.Fatal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fatal\n" ;
            } else {
                s += ind + "fatal\n" ;
            }
        }
        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        if (this.Ok != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ok\n" ;
            } else {
                s += ind + "ok\n" ;
            }
        }
        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        if (this.Warning != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warning\n" ;
            } else {
                s += ind + "warning\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        if (ec.Includes("fatal",true))
        {
            if(this.Fatal == null) {

                this.Fatal = new System.Int64();

            } else {


            }
        }
        else if (this.Fatal != null && ec.Excludes("fatal",true))
        {
            this.Fatal = null;
        }
        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        if (ec.Includes("ok",true))
        {
            if(this.Ok == null) {

                this.Ok = new System.Int64();

            } else {


            }
        }
        else if (this.Ok != null && ec.Excludes("ok",true))
        {
            this.Ok = null;
        }
        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        if (ec.Includes("warning",true))
        {
            if(this.Warning == null) {

                this.Warning = new System.Int64();

            } else {


            }
        }
        else if (this.Warning != null && ec.Excludes("warning",true))
        {
            this.Warning = null;
        }
    }


    #endregion

    } // class ClusterHealthAggregation
    
    #endregion

    public static class ListClusterHealthAggregationExtensions
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
            this List<ClusterHealthAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterHealthAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterHealthAggregation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterHealthAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterHealthAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types