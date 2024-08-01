// SalesforceOrganizationApiLimits.cs
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
    #region SalesforceOrganizationApiLimits
    public class SalesforceOrganizationApiLimits: BaseType
    {
        #region members

        //      C# -> System.Int32? BulkApiLimit
        // GraphQL -> bulkApiLimit: Int! (scalar)
        [JsonProperty("bulkApiLimit")]
        public System.Int32? BulkApiLimit { get; set; }

        //      C# -> System.Int32? BulkApiV2Limit
        // GraphQL -> bulkApiV2Limit: Int! (scalar)
        [JsonProperty("bulkApiV2Limit")]
        public System.Int32? BulkApiV2Limit { get; set; }

        //      C# -> System.Int32? RestApiLimit
        // GraphQL -> restApiLimit: Int! (scalar)
        [JsonProperty("restApiLimit")]
        public System.Int32? RestApiLimit { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SalesforceOrganizationApiLimits";
    }

    public SalesforceOrganizationApiLimits Set(
        System.Int32? BulkApiLimit = null,
        System.Int32? BulkApiV2Limit = null,
        System.Int32? RestApiLimit = null
    ) 
    {
        if ( BulkApiLimit != null ) {
            this.BulkApiLimit = BulkApiLimit;
        }
        if ( BulkApiV2Limit != null ) {
            this.BulkApiV2Limit = BulkApiV2Limit;
        }
        if ( RestApiLimit != null ) {
            this.RestApiLimit = RestApiLimit;
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
        //      C# -> System.Int32? BulkApiLimit
        // GraphQL -> bulkApiLimit: Int! (scalar)
        if (this.BulkApiLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bulkApiLimit\n" ;
            } else {
                s += ind + "bulkApiLimit\n" ;
            }
        }
        //      C# -> System.Int32? BulkApiV2Limit
        // GraphQL -> bulkApiV2Limit: Int! (scalar)
        if (this.BulkApiV2Limit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bulkApiV2Limit\n" ;
            } else {
                s += ind + "bulkApiV2Limit\n" ;
            }
        }
        //      C# -> System.Int32? RestApiLimit
        // GraphQL -> restApiLimit: Int! (scalar)
        if (this.RestApiLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "restApiLimit\n" ;
            } else {
                s += ind + "restApiLimit\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? BulkApiLimit
        // GraphQL -> bulkApiLimit: Int! (scalar)
        if (ec.Includes("bulkApiLimit",true))
        {
            if(this.BulkApiLimit == null) {

                this.BulkApiLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.BulkApiLimit != null && ec.Excludes("bulkApiLimit",true))
        {
            this.BulkApiLimit = null;
        }
        //      C# -> System.Int32? BulkApiV2Limit
        // GraphQL -> bulkApiV2Limit: Int! (scalar)
        if (ec.Includes("bulkApiV2Limit",true))
        {
            if(this.BulkApiV2Limit == null) {

                this.BulkApiV2Limit = Int32.MinValue;

            } else {


            }
        }
        else if (this.BulkApiV2Limit != null && ec.Excludes("bulkApiV2Limit",true))
        {
            this.BulkApiV2Limit = null;
        }
        //      C# -> System.Int32? RestApiLimit
        // GraphQL -> restApiLimit: Int! (scalar)
        if (ec.Includes("restApiLimit",true))
        {
            if(this.RestApiLimit == null) {

                this.RestApiLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.RestApiLimit != null && ec.Excludes("restApiLimit",true))
        {
            this.RestApiLimit = null;
        }
    }


    #endregion

    } // class SalesforceOrganizationApiLimits
    
    #endregion

    public static class ListSalesforceOrganizationApiLimitsExtensions
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
            this List<SalesforceOrganizationApiLimits> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SalesforceOrganizationApiLimits> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SalesforceOrganizationApiLimits> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SalesforceOrganizationApiLimits());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SalesforceOrganizationApiLimits> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types