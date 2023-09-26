// UpgradeDurationReply.cs
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
    #region UpgradeDurationReply
    public class UpgradeDurationReply: BaseType
    {
        #region members

        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        [JsonProperty("fastUpgradeDuration")]
        public System.Int64? FastUpgradeDuration { get; set; }

        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        [JsonProperty("rollingUpgradeDuration")]
        public System.Int64? RollingUpgradeDuration { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpgradeDurationReply";
    }

    public UpgradeDurationReply Set(
        System.Int64? FastUpgradeDuration = null,
        System.Int64? RollingUpgradeDuration = null
    ) 
    {
        if ( FastUpgradeDuration != null ) {
            this.FastUpgradeDuration = FastUpgradeDuration;
        }
        if ( RollingUpgradeDuration != null ) {
            this.RollingUpgradeDuration = RollingUpgradeDuration;
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
        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        if (this.FastUpgradeDuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fastUpgradeDuration\n" ;
            } else {
                s += ind + "fastUpgradeDuration\n" ;
            }
        }
        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        if (this.RollingUpgradeDuration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rollingUpgradeDuration\n" ;
            } else {
                s += ind + "rollingUpgradeDuration\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        if (ec.Includes("fastUpgradeDuration",true))
        {
            if(this.FastUpgradeDuration == null) {

                this.FastUpgradeDuration = new System.Int64();

            } else {


            }
        }
        else if (this.FastUpgradeDuration != null && ec.Excludes("fastUpgradeDuration",true))
        {
            this.FastUpgradeDuration = null;
        }
        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        if (ec.Includes("rollingUpgradeDuration",true))
        {
            if(this.RollingUpgradeDuration == null) {

                this.RollingUpgradeDuration = new System.Int64();

            } else {


            }
        }
        else if (this.RollingUpgradeDuration != null && ec.Excludes("rollingUpgradeDuration",true))
        {
            this.RollingUpgradeDuration = null;
        }
    }


    #endregion

    } // class UpgradeDurationReply
    
    #endregion

    public static class ListUpgradeDurationReplyExtensions
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
            this List<UpgradeDurationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeDurationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeDurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpgradeDurationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types