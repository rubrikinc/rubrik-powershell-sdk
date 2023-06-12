// IndicatorOfCompromise.cs
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
    #region IndicatorOfCompromise
    public class IndicatorOfCompromise: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("iocKind")]
        public IndicatorOfCompromiseKind? IocKind { get; set; }

        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        [JsonProperty("iocValue")]
        public System.String? IocValue { get; set; }


        #endregion

    #region methods

    public IndicatorOfCompromise Set(
        IndicatorOfCompromiseKind? IocKind = null,
        System.String? IocValue = null
    ) 
    {
        if ( IocKind != null ) {
            this.IocKind = IocKind;
        }
        if ( IocValue != null ) {
            this.IocValue = IocValue;
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
        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        if (this.IocKind != null) {
            s += ind + "iocKind\n" ;
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (this.IocValue != null) {
            s += ind + "iocValue\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        if (this.IocKind == null && Exploration.Includes(parent + ".iocKind", true))
        {
            this.IocKind = new IndicatorOfCompromiseKind();
        }
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        if (this.IocValue == null && Exploration.Includes(parent + ".iocValue", true))
        {
            this.IocValue = "FETCH";
        }
    }


    #endregion

    } // class IndicatorOfCompromise
    
    #endregion

    public static class ListIndicatorOfCompromiseExtensions
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
            this List<IndicatorOfCompromise> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<IndicatorOfCompromise> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new IndicatorOfCompromise());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types