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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        if (this.FastUpgradeDuration != null) {
            s += ind + "fastUpgradeDuration\n" ;
        }
        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        if (this.RollingUpgradeDuration != null) {
            s += ind + "rollingUpgradeDuration\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? FastUpgradeDuration
        // GraphQL -> fastUpgradeDuration: Long! (scalar)
        if (this.FastUpgradeDuration == null && Exploration.Includes(parent + ".fastUpgradeDuration", true))
        {
            this.FastUpgradeDuration = new System.Int64();
        }
        //      C# -> System.Int64? RollingUpgradeDuration
        // GraphQL -> rollingUpgradeDuration: Long! (scalar)
        if (this.RollingUpgradeDuration == null && Exploration.Includes(parent + ".rollingUpgradeDuration", true))
        {
            this.RollingUpgradeDuration = new System.Int64();
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeDurationReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeDurationReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types