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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        if (this.PermittedHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permittedHits\n" ;
            } else {
                s += ind + "permittedHits\n" ;
            }
        }
        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        if (this.PermittedHitsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permittedHitsDelta\n" ;
            } else {
                s += ind + "permittedHitsDelta\n" ;
            }
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        if (this.TotalHitsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHitsDelta\n" ;
            } else {
                s += ind + "totalHitsDelta\n" ;
            }
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (this.Violations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violations\n" ;
            } else {
                s += ind + "violations\n" ;
            }
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (this.ViolationsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationsDelta\n" ;
            } else {
                s += ind + "violationsDelta\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? PermittedHits
        // GraphQL -> permittedHits: Int! (scalar)
        if (ec.Includes("permittedHits",true))
        {
            if(this.PermittedHits == null) {

                this.PermittedHits = Int32.MinValue;

            } else {


            }
        }
        else if (this.PermittedHits != null && ec.Excludes("permittedHits",true))
        {
            this.PermittedHits = null;
        }
        //      C# -> System.Int32? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Int! (scalar)
        if (ec.Includes("permittedHitsDelta",true))
        {
            if(this.PermittedHitsDelta == null) {

                this.PermittedHitsDelta = Int32.MinValue;

            } else {


            }
        }
        else if (this.PermittedHitsDelta != null && ec.Excludes("permittedHitsDelta",true))
        {
            this.PermittedHitsDelta = null;
        }
        //      C# -> System.Int32? TotalHits
        // GraphQL -> totalHits: Int! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
        }
        //      C# -> System.Int32? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Int! (scalar)
        if (ec.Includes("totalHitsDelta",true))
        {
            if(this.TotalHitsDelta == null) {

                this.TotalHitsDelta = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalHitsDelta != null && ec.Excludes("totalHitsDelta",true))
        {
            this.TotalHitsDelta = null;
        }
        //      C# -> System.Int32? Violations
        // GraphQL -> violations: Int! (scalar)
        if (ec.Includes("violations",true))
        {
            if(this.Violations == null) {

                this.Violations = Int32.MinValue;

            } else {


            }
        }
        else if (this.Violations != null && ec.Excludes("violations",true))
        {
            this.Violations = null;
        }
        //      C# -> System.Int32? ViolationsDelta
        // GraphQL -> violationsDelta: Int! (scalar)
        if (ec.Includes("violationsDelta",true))
        {
            if(this.ViolationsDelta == null) {

                this.ViolationsDelta = Int32.MinValue;

            } else {


            }
        }
        else if (this.ViolationsDelta != null && ec.Excludes("violationsDelta",true))
        {
            this.ViolationsDelta = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<Hits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Hits> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Hits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Hits> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types