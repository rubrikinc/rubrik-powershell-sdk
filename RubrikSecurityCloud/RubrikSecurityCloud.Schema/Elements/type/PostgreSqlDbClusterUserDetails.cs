// PostgreSqlDbClusterUserDetails.cs
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
    #region PostgreSqlDbClusterUserDetails
    public class PostgreSqlDbClusterUserDetails: BaseType
    {
        #region members

        //      C# -> System.String? PostgreSqlDatabaseUserName
        // GraphQL -> postgreSQLDatabaseUserName: String! (scalar)
        [JsonProperty("postgreSQLDatabaseUserName")]
        public System.String? PostgreSqlDatabaseUserName { get; set; }

        //      C# -> System.String? PostgreSqlSystemUserName
        // GraphQL -> postgreSQLSystemUserName: String! (scalar)
        [JsonProperty("postgreSQLSystemUserName")]
        public System.String? PostgreSqlSystemUserName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PostgreSQLDbClusterUserDetails";
    }

    public PostgreSqlDbClusterUserDetails Set(
        System.String? PostgreSqlDatabaseUserName = null,
        System.String? PostgreSqlSystemUserName = null
    ) 
    {
        if ( PostgreSqlDatabaseUserName != null ) {
            this.PostgreSqlDatabaseUserName = PostgreSqlDatabaseUserName;
        }
        if ( PostgreSqlSystemUserName != null ) {
            this.PostgreSqlSystemUserName = PostgreSqlSystemUserName;
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
        //      C# -> System.String? PostgreSqlDatabaseUserName
        // GraphQL -> postgreSQLDatabaseUserName: String! (scalar)
        if (this.PostgreSqlDatabaseUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postgreSQLDatabaseUserName\n" ;
            } else {
                s += ind + "postgreSQLDatabaseUserName\n" ;
            }
        }
        //      C# -> System.String? PostgreSqlSystemUserName
        // GraphQL -> postgreSQLSystemUserName: String! (scalar)
        if (this.PostgreSqlSystemUserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "postgreSQLSystemUserName\n" ;
            } else {
                s += ind + "postgreSQLSystemUserName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? PostgreSqlDatabaseUserName
        // GraphQL -> postgreSQLDatabaseUserName: String! (scalar)
        if (ec.Includes("postgreSQLDatabaseUserName",true))
        {
            if(this.PostgreSqlDatabaseUserName == null) {

                this.PostgreSqlDatabaseUserName = "FETCH";

            } else {


            }
        }
        else if (this.PostgreSqlDatabaseUserName != null && ec.Excludes("postgreSQLDatabaseUserName",true))
        {
            this.PostgreSqlDatabaseUserName = null;
        }
        //      C# -> System.String? PostgreSqlSystemUserName
        // GraphQL -> postgreSQLSystemUserName: String! (scalar)
        if (ec.Includes("postgreSQLSystemUserName",true))
        {
            if(this.PostgreSqlSystemUserName == null) {

                this.PostgreSqlSystemUserName = "FETCH";

            } else {


            }
        }
        else if (this.PostgreSqlSystemUserName != null && ec.Excludes("postgreSQLSystemUserName",true))
        {
            this.PostgreSqlSystemUserName = null;
        }
    }


    #endregion

    } // class PostgreSqlDbClusterUserDetails
    
    #endregion

    public static class ListPostgreSqlDbClusterUserDetailsExtensions
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
            this List<PostgreSqlDbClusterUserDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PostgreSqlDbClusterUserDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PostgreSqlDbClusterUserDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PostgreSqlDbClusterUserDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PostgreSqlDbClusterUserDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types