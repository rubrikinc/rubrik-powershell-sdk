// ApiTypeUsage.cs
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
    #region ApiTypeUsage
    public class ApiTypeUsage: BaseType
    {
        #region members

        //      C# -> SaasAppApiType? ApiType
        // GraphQL -> apiType: SaasAppApiType! (enum)
        [JsonProperty("apiType")]
        public SaasAppApiType? ApiType { get; set; }

        //      C# -> System.Int32? RubrikUsageLimit
        // GraphQL -> rubrikUsageLimit: Int! (scalar)
        [JsonProperty("rubrikUsageLimit")]
        public System.Int32? RubrikUsageLimit { get; set; }

        //      C# -> System.Int32? SourceUsageLimit
        // GraphQL -> sourceUsageLimit: Int! (scalar)
        [JsonProperty("sourceUsageLimit")]
        public System.Int32? SourceUsageLimit { get; set; }

        //      C# -> System.Int32? UsageCount
        // GraphQL -> usageCount: Int! (scalar)
        [JsonProperty("usageCount")]
        public System.Int32? UsageCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ApiTypeUsage";
    }

    public ApiTypeUsage Set(
        SaasAppApiType? ApiType = null,
        System.Int32? RubrikUsageLimit = null,
        System.Int32? SourceUsageLimit = null,
        System.Int32? UsageCount = null
    ) 
    {
        if ( ApiType != null ) {
            this.ApiType = ApiType;
        }
        if ( RubrikUsageLimit != null ) {
            this.RubrikUsageLimit = RubrikUsageLimit;
        }
        if ( SourceUsageLimit != null ) {
            this.SourceUsageLimit = SourceUsageLimit;
        }
        if ( UsageCount != null ) {
            this.UsageCount = UsageCount;
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
        //      C# -> SaasAppApiType? ApiType
        // GraphQL -> apiType: SaasAppApiType! (enum)
        if (this.ApiType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiType\n" ;
            } else {
                s += ind + "apiType\n" ;
            }
        }
        //      C# -> System.Int32? RubrikUsageLimit
        // GraphQL -> rubrikUsageLimit: Int! (scalar)
        if (this.RubrikUsageLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikUsageLimit\n" ;
            } else {
                s += ind + "rubrikUsageLimit\n" ;
            }
        }
        //      C# -> System.Int32? SourceUsageLimit
        // GraphQL -> sourceUsageLimit: Int! (scalar)
        if (this.SourceUsageLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceUsageLimit\n" ;
            } else {
                s += ind + "sourceUsageLimit\n" ;
            }
        }
        //      C# -> System.Int32? UsageCount
        // GraphQL -> usageCount: Int! (scalar)
        if (this.UsageCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usageCount\n" ;
            } else {
                s += ind + "usageCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SaasAppApiType? ApiType
        // GraphQL -> apiType: SaasAppApiType! (enum)
        if (ec.Includes("apiType",true))
        {
            if(this.ApiType == null) {

                this.ApiType = new SaasAppApiType();

            } else {


            }
        }
        else if (this.ApiType != null && ec.Excludes("apiType",true))
        {
            this.ApiType = null;
        }
        //      C# -> System.Int32? RubrikUsageLimit
        // GraphQL -> rubrikUsageLimit: Int! (scalar)
        if (ec.Includes("rubrikUsageLimit",true))
        {
            if(this.RubrikUsageLimit == null) {

                this.RubrikUsageLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.RubrikUsageLimit != null && ec.Excludes("rubrikUsageLimit",true))
        {
            this.RubrikUsageLimit = null;
        }
        //      C# -> System.Int32? SourceUsageLimit
        // GraphQL -> sourceUsageLimit: Int! (scalar)
        if (ec.Includes("sourceUsageLimit",true))
        {
            if(this.SourceUsageLimit == null) {

                this.SourceUsageLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.SourceUsageLimit != null && ec.Excludes("sourceUsageLimit",true))
        {
            this.SourceUsageLimit = null;
        }
        //      C# -> System.Int32? UsageCount
        // GraphQL -> usageCount: Int! (scalar)
        if (ec.Includes("usageCount",true))
        {
            if(this.UsageCount == null) {

                this.UsageCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.UsageCount != null && ec.Excludes("usageCount",true))
        {
            this.UsageCount = null;
        }
    }


    #endregion

    } // class ApiTypeUsage
    
    #endregion

    public static class ListApiTypeUsageExtensions
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
            this List<ApiTypeUsage> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ApiTypeUsage> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ApiTypeUsage> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ApiTypeUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ApiTypeUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types