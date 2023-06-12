// CountChange.cs
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
    #region CountChange
    public class CountChange: BaseType
    {
        #region members

        //      C# -> SummaryCount? From
        // GraphQL -> from: SummaryCount! (type)
        [JsonProperty("from")]
        public SummaryCount? From { get; set; }

        //      C# -> SummaryCount? To
        // GraphQL -> to: SummaryCount! (type)
        [JsonProperty("to")]
        public SummaryCount? To { get; set; }


        #endregion

    #region methods

    public CountChange Set(
        SummaryCount? From = null,
        SummaryCount? To = null
    ) 
    {
        if ( From != null ) {
            this.From = From;
        }
        if ( To != null ) {
            this.To = To;
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
        //      C# -> SummaryCount? From
        // GraphQL -> from: SummaryCount! (type)
        if (this.From != null) {
            var fspec = this.From.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "from {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? To
        // GraphQL -> to: SummaryCount! (type)
        if (this.To != null) {
            var fspec = this.To.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "to {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SummaryCount? From
        // GraphQL -> from: SummaryCount! (type)
        if (this.From == null && Exploration.Includes(parent + ".from"))
        {
            this.From = new SummaryCount();
            this.From.ApplyExploratoryFieldSpec(parent + ".from");
        }
        //      C# -> SummaryCount? To
        // GraphQL -> to: SummaryCount! (type)
        if (this.To == null && Exploration.Includes(parent + ".to"))
        {
            this.To = new SummaryCount();
            this.To.ApplyExploratoryFieldSpec(parent + ".to");
        }
    }


    #endregion

    } // class CountChange
    
    #endregion

    public static class ListCountChangeExtensions
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
            this List<CountChange> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CountChange> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CountChange());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types