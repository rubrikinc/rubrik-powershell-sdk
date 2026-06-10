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

        //      C# -> System.Int64? PermittedHits
        // GraphQL -> permittedHits: Long! (scalar)
        [JsonProperty("permittedHits")]
        public System.Int64? PermittedHits { get; set; }

        //      C# -> System.Int64? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Long! (scalar)
        [JsonProperty("permittedHitsDelta")]
        public System.Int64? PermittedHitsDelta { get; set; }

        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        [JsonProperty("totalHits")]
        public System.Int64? TotalHits { get; set; }

        //      C# -> System.Int64? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Long! (scalar)
        [JsonProperty("totalHitsDelta")]
        public System.Int64? TotalHitsDelta { get; set; }

        //      C# -> System.Int64? Violations
        // GraphQL -> violations: Long! (scalar)
        [JsonProperty("violations")]
        public System.Int64? Violations { get; set; }

        //      C# -> System.Int64? ViolationsDelta
        // GraphQL -> violationsDelta: Long! (scalar)
        [JsonProperty("violationsDelta")]
        public System.Int64? ViolationsDelta { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Hits";
    }

    public Hits Set(
        System.Int64? PermittedHits = null,
        System.Int64? PermittedHitsDelta = null,
        System.Int64? TotalHits = null,
        System.Int64? TotalHitsDelta = null,
        System.Int64? Violations = null,
        System.Int64? ViolationsDelta = null
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? PermittedHits
        // GraphQL -> permittedHits: Long! (scalar)
        if (this.PermittedHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permittedHits\n" ;
            } else {
                s += ind + "permittedHits\n" ;
            }
        }
        //      C# -> System.Int64? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Long! (scalar)
        if (this.PermittedHitsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permittedHitsDelta\n" ;
            } else {
                s += ind + "permittedHitsDelta\n" ;
            }
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Long! (scalar)
        if (this.TotalHitsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHitsDelta\n" ;
            } else {
                s += ind + "totalHitsDelta\n" ;
            }
        }
        //      C# -> System.Int64? Violations
        // GraphQL -> violations: Long! (scalar)
        if (this.Violations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violations\n" ;
            } else {
                s += ind + "violations\n" ;
            }
        }
        //      C# -> System.Int64? ViolationsDelta
        // GraphQL -> violationsDelta: Long! (scalar)
        if (this.ViolationsDelta != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationsDelta\n" ;
            } else {
                s += ind + "violationsDelta\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? PermittedHits
        // GraphQL -> permittedHits: Long! (scalar)
        if (ec.Includes("permittedHits",true))
        {
            if(this.PermittedHits == null) {

                this.PermittedHits = new System.Int64();

            } else {


            }
        }
        else if (this.PermittedHits != null && ec.Excludes("permittedHits",true))
        {
            this.PermittedHits = null;
        }
        //      C# -> System.Int64? PermittedHitsDelta
        // GraphQL -> permittedHitsDelta: Long! (scalar)
        if (ec.Includes("permittedHitsDelta",true))
        {
            if(this.PermittedHitsDelta == null) {

                this.PermittedHitsDelta = new System.Int64();

            } else {


            }
        }
        else if (this.PermittedHitsDelta != null && ec.Excludes("permittedHitsDelta",true))
        {
            this.PermittedHitsDelta = null;
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
        }
        //      C# -> System.Int64? TotalHitsDelta
        // GraphQL -> totalHitsDelta: Long! (scalar)
        if (ec.Includes("totalHitsDelta",true))
        {
            if(this.TotalHitsDelta == null) {

                this.TotalHitsDelta = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHitsDelta != null && ec.Excludes("totalHitsDelta",true))
        {
            this.TotalHitsDelta = null;
        }
        //      C# -> System.Int64? Violations
        // GraphQL -> violations: Long! (scalar)
        if (ec.Includes("violations",true))
        {
            if(this.Violations == null) {

                this.Violations = new System.Int64();

            } else {


            }
        }
        else if (this.Violations != null && ec.Excludes("violations",true))
        {
            this.Violations = null;
        }
        //      C# -> System.Int64? ViolationsDelta
        // GraphQL -> violationsDelta: Long! (scalar)
        if (ec.Includes("violationsDelta",true))
        {
            if(this.ViolationsDelta == null) {

                this.ViolationsDelta = new System.Int64();

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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<Hits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Hits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Hits> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Hits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Hits> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types