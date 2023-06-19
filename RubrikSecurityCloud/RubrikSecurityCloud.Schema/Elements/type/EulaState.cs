// EulaState.cs
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
    #region EulaState
    public class EulaState: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        [JsonProperty("isAccepted")]
        public System.Boolean? IsAccepted { get; set; }

        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        [JsonProperty("isPactsafeEnabled")]
        public System.Boolean? IsPactsafeEnabled { get; set; }

        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        [JsonProperty("isPactsafeV2Enabled")]
        public System.Boolean? IsPactsafeV2Enabled { get; set; }


        #endregion

    #region methods

    public EulaState Set(
        System.Boolean? IsAccepted = null,
        System.Boolean? IsPactsafeEnabled = null,
        System.Boolean? IsPactsafeV2Enabled = null
    ) 
    {
        if ( IsAccepted != null ) {
            this.IsAccepted = IsAccepted;
        }
        if ( IsPactsafeEnabled != null ) {
            this.IsPactsafeEnabled = IsPactsafeEnabled;
        }
        if ( IsPactsafeV2Enabled != null ) {
            this.IsPactsafeV2Enabled = IsPactsafeV2Enabled;
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
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted != null) {
            s += ind + "isAccepted\n" ;
        }
        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        if (this.IsPactsafeEnabled != null) {
            s += ind + "isPactsafeEnabled\n" ;
        }
        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        if (this.IsPactsafeV2Enabled != null) {
            s += ind + "isPactsafeV2Enabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted == null && Exploration.Includes(parent + ".isAccepted", true))
        {
            this.IsAccepted = true;
        }
        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        if (this.IsPactsafeEnabled == null && Exploration.Includes(parent + ".isPactsafeEnabled", true))
        {
            this.IsPactsafeEnabled = true;
        }
        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        if (this.IsPactsafeV2Enabled == null && Exploration.Includes(parent + ".isPactsafeV2Enabled", true))
        {
            this.IsPactsafeV2Enabled = true;
        }
    }


    #endregion

    } // class EulaState
    
    #endregion

    public static class ListEulaStateExtensions
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
            this List<EulaState> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EulaState> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EulaState());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types