// PlatformProtectionCoverage.cs
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
    #region PlatformProtectionCoverage
    public class PlatformProtectionCoverage: BaseType
    {
        #region members

        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        [JsonProperty("platformCategory")]
        public PlatformCategory? PlatformCategory { get; set; }

        //      C# -> System.Int32? NewProtectedObjectsCount
        // GraphQL -> newProtectedObjectsCount: Int! (scalar)
        [JsonProperty("newProtectedObjectsCount")]
        public System.Int32? NewProtectedObjectsCount { get; set; }

        //      C# -> System.Single? NewProtectionPercentCoverage
        // GraphQL -> newProtectionPercentCoverage: Float! (scalar)
        [JsonProperty("newProtectionPercentCoverage")]
        public System.Single? NewProtectionPercentCoverage { get; set; }

        //      C# -> System.Int32? NewViolatedSensitiveObjects
        // GraphQL -> newViolatedSensitiveObjects: Int! (scalar)
        [JsonProperty("newViolatedSensitiveObjects")]
        public System.Int32? NewViolatedSensitiveObjects { get; set; }

        //      C# -> System.Int32? ProtectedObjectsCount
        // GraphQL -> protectedObjectsCount: Int! (scalar)
        [JsonProperty("protectedObjectsCount")]
        public System.Int32? ProtectedObjectsCount { get; set; }

        //      C# -> System.Single? ProtectionPercentCoverage
        // GraphQL -> protectionPercentCoverage: Float! (scalar)
        [JsonProperty("protectionPercentCoverage")]
        public System.Single? ProtectionPercentCoverage { get; set; }

        //      C# -> System.Int32? SupportedObjectsCount
        // GraphQL -> supportedObjectsCount: Int! (scalar)
        [JsonProperty("supportedObjectsCount")]
        public System.Int32? SupportedObjectsCount { get; set; }

        //      C# -> System.Int32? ViolatedSensitiveObjects
        // GraphQL -> violatedSensitiveObjects: Int! (scalar)
        [JsonProperty("violatedSensitiveObjects")]
        public System.Int32? ViolatedSensitiveObjects { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PlatformProtectionCoverage";
    }

    public PlatformProtectionCoverage Set(
        PlatformCategory? PlatformCategory = null,
        System.Int32? NewProtectedObjectsCount = null,
        System.Single? NewProtectionPercentCoverage = null,
        System.Int32? NewViolatedSensitiveObjects = null,
        System.Int32? ProtectedObjectsCount = null,
        System.Single? ProtectionPercentCoverage = null,
        System.Int32? SupportedObjectsCount = null,
        System.Int32? ViolatedSensitiveObjects = null
    ) 
    {
        if ( PlatformCategory != null ) {
            this.PlatformCategory = PlatformCategory;
        }
        if ( NewProtectedObjectsCount != null ) {
            this.NewProtectedObjectsCount = NewProtectedObjectsCount;
        }
        if ( NewProtectionPercentCoverage != null ) {
            this.NewProtectionPercentCoverage = NewProtectionPercentCoverage;
        }
        if ( NewViolatedSensitiveObjects != null ) {
            this.NewViolatedSensitiveObjects = NewViolatedSensitiveObjects;
        }
        if ( ProtectedObjectsCount != null ) {
            this.ProtectedObjectsCount = ProtectedObjectsCount;
        }
        if ( ProtectionPercentCoverage != null ) {
            this.ProtectionPercentCoverage = ProtectionPercentCoverage;
        }
        if ( SupportedObjectsCount != null ) {
            this.SupportedObjectsCount = SupportedObjectsCount;
        }
        if ( ViolatedSensitiveObjects != null ) {
            this.ViolatedSensitiveObjects = ViolatedSensitiveObjects;
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
        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        if (this.PlatformCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformCategory\n" ;
            } else {
                s += ind + "platformCategory\n" ;
            }
        }
        //      C# -> System.Int32? NewProtectedObjectsCount
        // GraphQL -> newProtectedObjectsCount: Int! (scalar)
        if (this.NewProtectedObjectsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newProtectedObjectsCount\n" ;
            } else {
                s += ind + "newProtectedObjectsCount\n" ;
            }
        }
        //      C# -> System.Single? NewProtectionPercentCoverage
        // GraphQL -> newProtectionPercentCoverage: Float! (scalar)
        if (this.NewProtectionPercentCoverage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newProtectionPercentCoverage\n" ;
            } else {
                s += ind + "newProtectionPercentCoverage\n" ;
            }
        }
        //      C# -> System.Int32? NewViolatedSensitiveObjects
        // GraphQL -> newViolatedSensitiveObjects: Int! (scalar)
        if (this.NewViolatedSensitiveObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newViolatedSensitiveObjects\n" ;
            } else {
                s += ind + "newViolatedSensitiveObjects\n" ;
            }
        }
        //      C# -> System.Int32? ProtectedObjectsCount
        // GraphQL -> protectedObjectsCount: Int! (scalar)
        if (this.ProtectedObjectsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedObjectsCount\n" ;
            } else {
                s += ind + "protectedObjectsCount\n" ;
            }
        }
        //      C# -> System.Single? ProtectionPercentCoverage
        // GraphQL -> protectionPercentCoverage: Float! (scalar)
        if (this.ProtectionPercentCoverage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionPercentCoverage\n" ;
            } else {
                s += ind + "protectionPercentCoverage\n" ;
            }
        }
        //      C# -> System.Int32? SupportedObjectsCount
        // GraphQL -> supportedObjectsCount: Int! (scalar)
        if (this.SupportedObjectsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedObjectsCount\n" ;
            } else {
                s += ind + "supportedObjectsCount\n" ;
            }
        }
        //      C# -> System.Int32? ViolatedSensitiveObjects
        // GraphQL -> violatedSensitiveObjects: Int! (scalar)
        if (this.ViolatedSensitiveObjects != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedSensitiveObjects\n" ;
            } else {
                s += ind + "violatedSensitiveObjects\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PlatformCategory? PlatformCategory
        // GraphQL -> platformCategory: PlatformCategory! (enum)
        if (ec.Includes("platformCategory",true))
        {
            if(this.PlatformCategory == null) {

                this.PlatformCategory = new PlatformCategory();

            } else {


            }
        }
        else if (this.PlatformCategory != null && ec.Excludes("platformCategory",true))
        {
            this.PlatformCategory = null;
        }
        //      C# -> System.Int32? NewProtectedObjectsCount
        // GraphQL -> newProtectedObjectsCount: Int! (scalar)
        if (ec.Includes("newProtectedObjectsCount",true))
        {
            if(this.NewProtectedObjectsCount == null) {

                this.NewProtectedObjectsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewProtectedObjectsCount != null && ec.Excludes("newProtectedObjectsCount",true))
        {
            this.NewProtectedObjectsCount = null;
        }
        //      C# -> System.Single? NewProtectionPercentCoverage
        // GraphQL -> newProtectionPercentCoverage: Float! (scalar)
        if (ec.Includes("newProtectionPercentCoverage",true))
        {
            if(this.NewProtectionPercentCoverage == null) {

                this.NewProtectionPercentCoverage = new System.Single();

            } else {


            }
        }
        else if (this.NewProtectionPercentCoverage != null && ec.Excludes("newProtectionPercentCoverage",true))
        {
            this.NewProtectionPercentCoverage = null;
        }
        //      C# -> System.Int32? NewViolatedSensitiveObjects
        // GraphQL -> newViolatedSensitiveObjects: Int! (scalar)
        if (ec.Includes("newViolatedSensitiveObjects",true))
        {
            if(this.NewViolatedSensitiveObjects == null) {

                this.NewViolatedSensitiveObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewViolatedSensitiveObjects != null && ec.Excludes("newViolatedSensitiveObjects",true))
        {
            this.NewViolatedSensitiveObjects = null;
        }
        //      C# -> System.Int32? ProtectedObjectsCount
        // GraphQL -> protectedObjectsCount: Int! (scalar)
        if (ec.Includes("protectedObjectsCount",true))
        {
            if(this.ProtectedObjectsCount == null) {

                this.ProtectedObjectsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ProtectedObjectsCount != null && ec.Excludes("protectedObjectsCount",true))
        {
            this.ProtectedObjectsCount = null;
        }
        //      C# -> System.Single? ProtectionPercentCoverage
        // GraphQL -> protectionPercentCoverage: Float! (scalar)
        if (ec.Includes("protectionPercentCoverage",true))
        {
            if(this.ProtectionPercentCoverage == null) {

                this.ProtectionPercentCoverage = new System.Single();

            } else {


            }
        }
        else if (this.ProtectionPercentCoverage != null && ec.Excludes("protectionPercentCoverage",true))
        {
            this.ProtectionPercentCoverage = null;
        }
        //      C# -> System.Int32? SupportedObjectsCount
        // GraphQL -> supportedObjectsCount: Int! (scalar)
        if (ec.Includes("supportedObjectsCount",true))
        {
            if(this.SupportedObjectsCount == null) {

                this.SupportedObjectsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SupportedObjectsCount != null && ec.Excludes("supportedObjectsCount",true))
        {
            this.SupportedObjectsCount = null;
        }
        //      C# -> System.Int32? ViolatedSensitiveObjects
        // GraphQL -> violatedSensitiveObjects: Int! (scalar)
        if (ec.Includes("violatedSensitiveObjects",true))
        {
            if(this.ViolatedSensitiveObjects == null) {

                this.ViolatedSensitiveObjects = Int32.MinValue;

            } else {


            }
        }
        else if (this.ViolatedSensitiveObjects != null && ec.Excludes("violatedSensitiveObjects",true))
        {
            this.ViolatedSensitiveObjects = null;
        }
    }


    #endregion

    } // class PlatformProtectionCoverage
    
    #endregion

    public static class ListPlatformProtectionCoverageExtensions
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
            this List<PlatformProtectionCoverage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PlatformProtectionCoverage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PlatformProtectionCoverage> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PlatformProtectionCoverage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PlatformProtectionCoverage> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types