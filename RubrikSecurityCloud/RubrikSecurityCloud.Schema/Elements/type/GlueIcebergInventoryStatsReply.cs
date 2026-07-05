// GlueIcebergInventoryStatsReply.cs
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
    #region GlueIcebergInventoryStatsReply
    public class GlueIcebergInventoryStatsReply: BaseType
    {
        #region members

        //      C# -> System.Int32? AwsAccountsCount
        // GraphQL -> awsAccountsCount: Int! (scalar)
        [JsonProperty("awsAccountsCount")]
        public System.Int32? AwsAccountsCount { get; set; }

        //      C# -> System.Int32? CatalogsCount
        // GraphQL -> catalogsCount: Int! (scalar)
        [JsonProperty("catalogsCount")]
        public System.Int32? CatalogsCount { get; set; }

        //      C# -> System.Int32? DatabasesCount
        // GraphQL -> databasesCount: Int! (scalar)
        [JsonProperty("databasesCount")]
        public System.Int32? DatabasesCount { get; set; }

        //      C# -> System.Int32? TablesProtectedCount
        // GraphQL -> tablesProtectedCount: Int! (scalar)
        [JsonProperty("tablesProtectedCount")]
        public System.Int32? TablesProtectedCount { get; set; }

        //      C# -> System.Int32? TablesTotalCount
        // GraphQL -> tablesTotalCount: Int! (scalar)
        [JsonProperty("tablesTotalCount")]
        public System.Int32? TablesTotalCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlueIcebergInventoryStatsReply";
    }

    public GlueIcebergInventoryStatsReply Set(
        System.Int32? AwsAccountsCount = null,
        System.Int32? CatalogsCount = null,
        System.Int32? DatabasesCount = null,
        System.Int32? TablesProtectedCount = null,
        System.Int32? TablesTotalCount = null
    ) 
    {
        if ( AwsAccountsCount != null ) {
            this.AwsAccountsCount = AwsAccountsCount;
        }
        if ( CatalogsCount != null ) {
            this.CatalogsCount = CatalogsCount;
        }
        if ( DatabasesCount != null ) {
            this.DatabasesCount = DatabasesCount;
        }
        if ( TablesProtectedCount != null ) {
            this.TablesProtectedCount = TablesProtectedCount;
        }
        if ( TablesTotalCount != null ) {
            this.TablesTotalCount = TablesTotalCount;
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
        //      C# -> System.Int32? AwsAccountsCount
        // GraphQL -> awsAccountsCount: Int! (scalar)
        if (this.AwsAccountsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsAccountsCount\n" ;
            } else {
                s += ind + "awsAccountsCount\n" ;
            }
        }
        //      C# -> System.Int32? CatalogsCount
        // GraphQL -> catalogsCount: Int! (scalar)
        if (this.CatalogsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "catalogsCount\n" ;
            } else {
                s += ind + "catalogsCount\n" ;
            }
        }
        //      C# -> System.Int32? DatabasesCount
        // GraphQL -> databasesCount: Int! (scalar)
        if (this.DatabasesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databasesCount\n" ;
            } else {
                s += ind + "databasesCount\n" ;
            }
        }
        //      C# -> System.Int32? TablesProtectedCount
        // GraphQL -> tablesProtectedCount: Int! (scalar)
        if (this.TablesProtectedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tablesProtectedCount\n" ;
            } else {
                s += ind + "tablesProtectedCount\n" ;
            }
        }
        //      C# -> System.Int32? TablesTotalCount
        // GraphQL -> tablesTotalCount: Int! (scalar)
        if (this.TablesTotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tablesTotalCount\n" ;
            } else {
                s += ind + "tablesTotalCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? AwsAccountsCount
        // GraphQL -> awsAccountsCount: Int! (scalar)
        if (ec.Includes("awsAccountsCount",true))
        {
            if(this.AwsAccountsCount == null) {

                this.AwsAccountsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AwsAccountsCount != null && ec.Excludes("awsAccountsCount",true))
        {
            this.AwsAccountsCount = null;
        }
        //      C# -> System.Int32? CatalogsCount
        // GraphQL -> catalogsCount: Int! (scalar)
        if (ec.Includes("catalogsCount",true))
        {
            if(this.CatalogsCount == null) {

                this.CatalogsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.CatalogsCount != null && ec.Excludes("catalogsCount",true))
        {
            this.CatalogsCount = null;
        }
        //      C# -> System.Int32? DatabasesCount
        // GraphQL -> databasesCount: Int! (scalar)
        if (ec.Includes("databasesCount",true))
        {
            if(this.DatabasesCount == null) {

                this.DatabasesCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DatabasesCount != null && ec.Excludes("databasesCount",true))
        {
            this.DatabasesCount = null;
        }
        //      C# -> System.Int32? TablesProtectedCount
        // GraphQL -> tablesProtectedCount: Int! (scalar)
        if (ec.Includes("tablesProtectedCount",true))
        {
            if(this.TablesProtectedCount == null) {

                this.TablesProtectedCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TablesProtectedCount != null && ec.Excludes("tablesProtectedCount",true))
        {
            this.TablesProtectedCount = null;
        }
        //      C# -> System.Int32? TablesTotalCount
        // GraphQL -> tablesTotalCount: Int! (scalar)
        if (ec.Includes("tablesTotalCount",true))
        {
            if(this.TablesTotalCount == null) {

                this.TablesTotalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TablesTotalCount != null && ec.Excludes("tablesTotalCount",true))
        {
            this.TablesTotalCount = null;
        }
    }


    #endregion

    } // class GlueIcebergInventoryStatsReply
    
    #endregion

    public static class ListGlueIcebergInventoryStatsReplyExtensions
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
            this List<GlueIcebergInventoryStatsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GlueIcebergInventoryStatsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlueIcebergInventoryStatsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlueIcebergInventoryStatsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlueIcebergInventoryStatsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types