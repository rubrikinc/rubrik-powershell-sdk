// SqlServerSetupScriptDetails.cs
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
    #region SqlServerSetupScriptDetails
    public class SqlServerSetupScriptDetails: BaseType
    {
        #region members

        //      C# -> AzureSqlAuthenticationType? AuthType
        // GraphQL -> authType: AzureSqlAuthenticationType! (enum)
        [JsonProperty("authType")]
        public AzureSqlAuthenticationType? AuthType { get; set; }

        //      C# -> System.String? DatabaseId
        // GraphQL -> databaseId: String! (scalar)
        [JsonProperty("databaseId")]
        public System.String? DatabaseId { get; set; }

        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        [JsonProperty("script")]
        public System.String? Script { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SqlServerSetupScriptDetails";
    }

    public SqlServerSetupScriptDetails Set(
        AzureSqlAuthenticationType? AuthType = null,
        System.String? DatabaseId = null,
        System.String? Script = null
    ) 
    {
        if ( AuthType != null ) {
            this.AuthType = AuthType;
        }
        if ( DatabaseId != null ) {
            this.DatabaseId = DatabaseId;
        }
        if ( Script != null ) {
            this.Script = Script;
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
        //      C# -> AzureSqlAuthenticationType? AuthType
        // GraphQL -> authType: AzureSqlAuthenticationType! (enum)
        if (this.AuthType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authType\n" ;
            } else {
                s += ind + "authType\n" ;
            }
        }
        //      C# -> System.String? DatabaseId
        // GraphQL -> databaseId: String! (scalar)
        if (this.DatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseId\n" ;
            } else {
                s += ind + "databaseId\n" ;
            }
        }
        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        if (this.Script != null) {
            if (conf.Flat) {
                s += conf.Prefix + "script\n" ;
            } else {
                s += ind + "script\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureSqlAuthenticationType? AuthType
        // GraphQL -> authType: AzureSqlAuthenticationType! (enum)
        if (ec.Includes("authType",true))
        {
            if(this.AuthType == null) {

                this.AuthType = new AzureSqlAuthenticationType();

            } else {


            }
        }
        else if (this.AuthType != null && ec.Excludes("authType",true))
        {
            this.AuthType = null;
        }
        //      C# -> System.String? DatabaseId
        // GraphQL -> databaseId: String! (scalar)
        if (ec.Includes("databaseId",true))
        {
            if(this.DatabaseId == null) {

                this.DatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.DatabaseId != null && ec.Excludes("databaseId",true))
        {
            this.DatabaseId = null;
        }
        //      C# -> System.String? Script
        // GraphQL -> script: String! (scalar)
        if (ec.Includes("script",true))
        {
            if(this.Script == null) {

                this.Script = "FETCH";

            } else {


            }
        }
        else if (this.Script != null && ec.Excludes("script",true))
        {
            this.Script = null;
        }
    }


    #endregion

    } // class SqlServerSetupScriptDetails
    
    #endregion

    public static class ListSqlServerSetupScriptDetailsExtensions
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
            this List<SqlServerSetupScriptDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SqlServerSetupScriptDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SqlServerSetupScriptDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SqlServerSetupScriptDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SqlServerSetupScriptDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types