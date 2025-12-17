// SegregatedFetbConsumption.cs
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
    #region SegregatedFetbConsumption
    public class SegregatedFetbConsumption: BaseType
    {
        #region members

        //      C# -> System.Int64? NoSlaActive
        // GraphQL -> noSlaActive: Long (scalar)
        [JsonProperty("noSlaActive")]
        public System.Int64? NoSlaActive { get; set; }

        //      C# -> System.Int64? NoSlaRelic
        // GraphQL -> noSlaRelic: Long (scalar)
        [JsonProperty("noSlaRelic")]
        public System.Int64? NoSlaRelic { get; set; }

        //      C# -> System.Int64? NotProtectedActive
        // GraphQL -> notProtectedActive: Long (scalar)
        [JsonProperty("notProtectedActive")]
        public System.Int64? NotProtectedActive { get; set; }

        //      C# -> System.Int64? NotProtectedRelic
        // GraphQL -> notProtectedRelic: Long (scalar)
        [JsonProperty("notProtectedRelic")]
        public System.Int64? NotProtectedRelic { get; set; }

        //      C# -> System.Int64? ProtectedActive
        // GraphQL -> protectedActive: Long (scalar)
        [JsonProperty("protectedActive")]
        public System.Int64? ProtectedActive { get; set; }

        //      C# -> System.Int64? ProtectedRelic
        // GraphQL -> protectedRelic: Long (scalar)
        [JsonProperty("protectedRelic")]
        public System.Int64? ProtectedRelic { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SegregatedFETBConsumption";
    }

    public SegregatedFetbConsumption Set(
        System.Int64? NoSlaActive = null,
        System.Int64? NoSlaRelic = null,
        System.Int64? NotProtectedActive = null,
        System.Int64? NotProtectedRelic = null,
        System.Int64? ProtectedActive = null,
        System.Int64? ProtectedRelic = null
    ) 
    {
        if ( NoSlaActive != null ) {
            this.NoSlaActive = NoSlaActive;
        }
        if ( NoSlaRelic != null ) {
            this.NoSlaRelic = NoSlaRelic;
        }
        if ( NotProtectedActive != null ) {
            this.NotProtectedActive = NotProtectedActive;
        }
        if ( NotProtectedRelic != null ) {
            this.NotProtectedRelic = NotProtectedRelic;
        }
        if ( ProtectedActive != null ) {
            this.ProtectedActive = ProtectedActive;
        }
        if ( ProtectedRelic != null ) {
            this.ProtectedRelic = ProtectedRelic;
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
        //      C# -> System.Int64? NoSlaActive
        // GraphQL -> noSlaActive: Long (scalar)
        if (this.NoSlaActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "noSlaActive\n" ;
            } else {
                s += ind + "noSlaActive\n" ;
            }
        }
        //      C# -> System.Int64? NoSlaRelic
        // GraphQL -> noSlaRelic: Long (scalar)
        if (this.NoSlaRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "noSlaRelic\n" ;
            } else {
                s += ind + "noSlaRelic\n" ;
            }
        }
        //      C# -> System.Int64? NotProtectedActive
        // GraphQL -> notProtectedActive: Long (scalar)
        if (this.NotProtectedActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notProtectedActive\n" ;
            } else {
                s += ind + "notProtectedActive\n" ;
            }
        }
        //      C# -> System.Int64? NotProtectedRelic
        // GraphQL -> notProtectedRelic: Long (scalar)
        if (this.NotProtectedRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "notProtectedRelic\n" ;
            } else {
                s += ind + "notProtectedRelic\n" ;
            }
        }
        //      C# -> System.Int64? ProtectedActive
        // GraphQL -> protectedActive: Long (scalar)
        if (this.ProtectedActive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedActive\n" ;
            } else {
                s += ind + "protectedActive\n" ;
            }
        }
        //      C# -> System.Int64? ProtectedRelic
        // GraphQL -> protectedRelic: Long (scalar)
        if (this.ProtectedRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedRelic\n" ;
            } else {
                s += ind + "protectedRelic\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? NoSlaActive
        // GraphQL -> noSlaActive: Long (scalar)
        if (ec.Includes("noSlaActive",true))
        {
            if(this.NoSlaActive == null) {

                this.NoSlaActive = new System.Int64();

            } else {


            }
        }
        else if (this.NoSlaActive != null && ec.Excludes("noSlaActive",true))
        {
            this.NoSlaActive = null;
        }
        //      C# -> System.Int64? NoSlaRelic
        // GraphQL -> noSlaRelic: Long (scalar)
        if (ec.Includes("noSlaRelic",true))
        {
            if(this.NoSlaRelic == null) {

                this.NoSlaRelic = new System.Int64();

            } else {


            }
        }
        else if (this.NoSlaRelic != null && ec.Excludes("noSlaRelic",true))
        {
            this.NoSlaRelic = null;
        }
        //      C# -> System.Int64? NotProtectedActive
        // GraphQL -> notProtectedActive: Long (scalar)
        if (ec.Includes("notProtectedActive",true))
        {
            if(this.NotProtectedActive == null) {

                this.NotProtectedActive = new System.Int64();

            } else {


            }
        }
        else if (this.NotProtectedActive != null && ec.Excludes("notProtectedActive",true))
        {
            this.NotProtectedActive = null;
        }
        //      C# -> System.Int64? NotProtectedRelic
        // GraphQL -> notProtectedRelic: Long (scalar)
        if (ec.Includes("notProtectedRelic",true))
        {
            if(this.NotProtectedRelic == null) {

                this.NotProtectedRelic = new System.Int64();

            } else {


            }
        }
        else if (this.NotProtectedRelic != null && ec.Excludes("notProtectedRelic",true))
        {
            this.NotProtectedRelic = null;
        }
        //      C# -> System.Int64? ProtectedActive
        // GraphQL -> protectedActive: Long (scalar)
        if (ec.Includes("protectedActive",true))
        {
            if(this.ProtectedActive == null) {

                this.ProtectedActive = new System.Int64();

            } else {


            }
        }
        else if (this.ProtectedActive != null && ec.Excludes("protectedActive",true))
        {
            this.ProtectedActive = null;
        }
        //      C# -> System.Int64? ProtectedRelic
        // GraphQL -> protectedRelic: Long (scalar)
        if (ec.Includes("protectedRelic",true))
        {
            if(this.ProtectedRelic == null) {

                this.ProtectedRelic = new System.Int64();

            } else {


            }
        }
        else if (this.ProtectedRelic != null && ec.Excludes("protectedRelic",true))
        {
            this.ProtectedRelic = null;
        }
    }


    #endregion

    } // class SegregatedFetbConsumption
    
    #endregion

    public static class ListSegregatedFetbConsumptionExtensions
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
            this List<SegregatedFetbConsumption> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SegregatedFetbConsumption> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SegregatedFetbConsumption> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SegregatedFetbConsumption());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SegregatedFetbConsumption> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types