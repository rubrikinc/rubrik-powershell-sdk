// IndicatorOfCompromise.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region IndicatorOfCompromise
    public class IndicatorOfCompromise: IFragment
    {
        #region members
        //      C# -> System.String? IocValue
        // GraphQL -> iocValue: String! (scalar)
        [JsonProperty("iocValue")]
        public System.String? IocValue { get; set; }

        //      C# -> IndicatorOfCompromiseKind? IocKind
        // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("iocKind")]
        public IndicatorOfCompromiseKind? IocKind { get; set; }

        #endregion

    #region methods

    public IndicatorOfCompromise Set(
        System.String? IocValue = null,
        IndicatorOfCompromiseKind? IocKind = null
    ) 
    {
        if ( IocValue != null ) {
            this.IocValue = IocValue;
        }
        if ( IocKind != null ) {
            this.IocKind = IocKind;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? IocValue
            // GraphQL -> iocValue: String! (scalar)
            if (this.IocValue != null)
            {
                 s += ind + "iocValue\n";

            }
            //      C# -> IndicatorOfCompromiseKind? IocKind
            // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
            if (this.IocKind != null)
            {
                 s += ind + "iocKind\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? IocValue
            // GraphQL -> iocValue: String! (scalar)
            if (this.IocValue == null && Exploration.Includes(parent + ".iocValue$"))
            {
                this.IocValue = new System.String("FETCH");
            }
            //      C# -> IndicatorOfCompromiseKind? IocKind
            // GraphQL -> iocKind: IndicatorOfCompromiseKind! (enum)
            if (this.IocKind == null && Exploration.Includes(parent + ".iocKind$"))
            {
                this.IocKind = new IndicatorOfCompromiseKind();
            }
        }


    #endregion

    } // class IndicatorOfCompromise
    #endregion

    public static class ListIndicatorOfCompromiseExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<IndicatorOfCompromise> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<IndicatorOfCompromise> list, 
            String parent = "")
        {
            var item = new IndicatorOfCompromise();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types