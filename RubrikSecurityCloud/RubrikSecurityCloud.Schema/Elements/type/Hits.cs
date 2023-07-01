// Hits.cs
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
    #region Hits
    public class Hits: BaseType
    {
        #region members

        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        [JsonProperty("permittedHits")]
        public System.Int32? PermittedHits { get; set; }

        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        [JsonProperty("permittedHitsDelta")]
        public System.Int32? PermittedHitsDelta { get; set; }

        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        [JsonProperty("totalHits")]
        public System.Int32? TotalHits { get; set; }

        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        [JsonProperty("totalHitsDelta")]
        public System.Int32? TotalHitsDelta { get; set; }

        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        [JsonProperty("violations")]
        public System.Int32? Violations { get; set; }

        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        [JsonProperty("violationsDelta")]
        public System.Int32? ViolationsDelta { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Hits";
    }

    public Hits Set(
        System.Int32? PermittedHits = null,
        System.Int32? PermittedHitsDelta = null,
        System.Int32? TotalHits = null,
        System.Int32? TotalHitsDelta = null,
        System.Int32? Violations = null,
        System.Int32? ViolationsDelta = null
    ) 
    {
        if ( PermittedHits != null ) {
            this.PermittedHits = PermittedHits;
        }
        if ( PermittedHitsDelta != null ) {
            this.PermittedHitsDelta = PermittedHitsDelta;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( TotalHitsDelta != null ) {
            this.TotalHitsDelta = TotalHitsDelta;
        }
        if ( Violations != null ) {
            this.Violations = Violations;
        }
        if ( ViolationsDelta != null ) {
            this.ViolationsDelta = ViolationsDelta;
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
        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        if (this.PermittedHits != null) {
            s += ind + "permittedHits\n" ;
        }
        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        if (this.PermittedHitsDelta != null) {
            s += ind + "permittedHitsDelta\n" ;
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (this.TotalHits != null) {
            s += ind + "totalHits\n" ;
        }
        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        if (this.TotalHitsDelta != null) {
            s += ind + "totalHitsDelta\n" ;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            s += ind + "violations\n" ;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta != null) {
            s += ind + "violationsDelta\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        if (this.PermittedHits == null && Exploration.Includes(parent + ".permittedHits", true))
        {
            this.PermittedHits = Int32.MinValue;
        }
        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        if (this.PermittedHitsDelta == null && Exploration.Includes(parent + ".permittedHitsDelta", true))
        {
            this.PermittedHitsDelta = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (this.TotalHits == null && Exploration.Includes(parent + ".totalHits", true))
        {
            this.TotalHits = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        if (this.TotalHitsDelta == null && Exploration.Includes(parent + ".totalHitsDelta", true))
        {
            this.TotalHitsDelta = Int32.MinValue;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations == null && Exploration.Includes(parent + ".violations", true))
        {
            this.Violations = Int32.MinValue;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta == null && Exploration.Includes(parent + ".violationsDelta", true))
        {
            this.ViolationsDelta = Int32.MinValue;
        }
    }


    #endregion

    } // class Hits
    
    #endregion

    public static class ListHitsExtensions
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
            this List<Hits> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Hits> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Hits());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types