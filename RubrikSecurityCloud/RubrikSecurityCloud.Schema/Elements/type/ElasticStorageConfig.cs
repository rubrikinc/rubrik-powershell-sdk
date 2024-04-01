// ElasticStorageConfig.cs
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
    #region ElasticStorageConfig
    public class ElasticStorageConfig: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        [JsonProperty("isImmutable")]
        public System.Boolean? IsImmutable { get; set; }

        //      C# -> System.Boolean? IsUsingManagedIdentity
        // GraphQL -> isUsingManagedIdentity: Boolean! (scalar)
        [JsonProperty("isUsingManagedIdentity")]
        public System.Boolean? IsUsingManagedIdentity { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ElasticStorageConfig";
    }

    public ElasticStorageConfig Set(
        System.Boolean? IsImmutable = null,
        System.Boolean? IsUsingManagedIdentity = null,
        System.String? LocationId = null,
        System.String? LocationName = null
    ) 
    {
        if ( IsImmutable != null ) {
            this.IsImmutable = IsImmutable;
        }
        if ( IsUsingManagedIdentity != null ) {
            this.IsUsingManagedIdentity = IsUsingManagedIdentity;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
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
        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        if (this.IsImmutable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isImmutable\n" ;
            } else {
                s += ind + "isImmutable\n" ;
            }
        }
        //      C# -> System.Boolean? IsUsingManagedIdentity
        // GraphQL -> isUsingManagedIdentity: Boolean! (scalar)
        if (this.IsUsingManagedIdentity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUsingManagedIdentity\n" ;
            } else {
                s += ind + "isUsingManagedIdentity\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsImmutable
        // GraphQL -> isImmutable: Boolean! (scalar)
        if (ec.Includes("isImmutable",true))
        {
            if(this.IsImmutable == null) {

                this.IsImmutable = true;

            } else {


            }
        }
        else if (this.IsImmutable != null && ec.Excludes("isImmutable",true))
        {
            this.IsImmutable = null;
        }
        //      C# -> System.Boolean? IsUsingManagedIdentity
        // GraphQL -> isUsingManagedIdentity: Boolean! (scalar)
        if (ec.Includes("isUsingManagedIdentity",true))
        {
            if(this.IsUsingManagedIdentity == null) {

                this.IsUsingManagedIdentity = true;

            } else {


            }
        }
        else if (this.IsUsingManagedIdentity != null && ec.Excludes("isUsingManagedIdentity",true))
        {
            this.IsUsingManagedIdentity = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
    }


    #endregion

    } // class ElasticStorageConfig
    
    #endregion

    public static class ListElasticStorageConfigExtensions
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
            this List<ElasticStorageConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ElasticStorageConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ElasticStorageConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ElasticStorageConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ElasticStorageConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types