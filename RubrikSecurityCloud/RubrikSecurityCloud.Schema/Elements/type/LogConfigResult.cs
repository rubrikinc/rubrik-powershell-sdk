// LogConfigResult.cs
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
    #region LogConfigResult
    public class LogConfigResult: BaseType
    {
        #region members

        //      C# -> SlaLogFrequencyConfigResult? SlaLogFrequencyConfig
        // GraphQL -> slaLogFrequencyConfig: SlaLogFrequencyConfigResult (type)
        [JsonProperty("slaLogFrequencyConfig")]
        public SlaLogFrequencyConfigResult? SlaLogFrequencyConfig { get; set; }


        #endregion

    #region methods

    public LogConfigResult Set(
        SlaLogFrequencyConfigResult? SlaLogFrequencyConfig = null
    ) 
    {
        if ( SlaLogFrequencyConfig != null ) {
            this.SlaLogFrequencyConfig = SlaLogFrequencyConfig;
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
        //      C# -> SlaLogFrequencyConfigResult? SlaLogFrequencyConfig
        // GraphQL -> slaLogFrequencyConfig: SlaLogFrequencyConfigResult (type)
        if (this.SlaLogFrequencyConfig != null) {
            var fspec = this.SlaLogFrequencyConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaLogFrequencyConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaLogFrequencyConfigResult? SlaLogFrequencyConfig
        // GraphQL -> slaLogFrequencyConfig: SlaLogFrequencyConfigResult (type)
        if (this.SlaLogFrequencyConfig == null && Exploration.Includes(parent + ".slaLogFrequencyConfig"))
        {
            this.SlaLogFrequencyConfig = new SlaLogFrequencyConfigResult();
            this.SlaLogFrequencyConfig.ApplyExploratoryFieldSpec(parent + ".slaLogFrequencyConfig");
        }
    }


    #endregion

    } // class LogConfigResult
    
    #endregion

    public static class ListLogConfigResultExtensions
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
            this List<LogConfigResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LogConfigResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LogConfigResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types