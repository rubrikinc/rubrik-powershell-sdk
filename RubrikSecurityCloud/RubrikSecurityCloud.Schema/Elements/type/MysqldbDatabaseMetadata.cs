// MysqldbDatabaseMetadata.cs
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
    #region MysqldbDatabaseMetadata
    public class MysqldbDatabaseMetadata: BaseType
    {
        #region members

        //      C# -> MysqldbDatabaseProtectionStateEnum? ProtectionState
        // GraphQL -> protectionState: MysqldbDatabaseProtectionStateEnum! (enum)
        [JsonProperty("protectionState")]
        public MysqldbDatabaseProtectionStateEnum? ProtectionState { get; set; }

        //      C# -> System.Int64? ApproxDbSizeInBytes
        // GraphQL -> approxDbSizeInBytes: Long! (scalar)
        [JsonProperty("approxDbSizeInBytes")]
        public System.Int64? ApproxDbSizeInBytes { get; set; }

        //      C# -> System.Int64? ProtectableTables
        // GraphQL -> protectableTables: Long! (scalar)
        [JsonProperty("protectableTables")]
        public System.Int64? ProtectableTables { get; set; }

        //      C# -> System.Int64? TotalTables
        // GraphQL -> totalTables: Long! (scalar)
        [JsonProperty("totalTables")]
        public System.Int64? TotalTables { get; set; }

        //      C# -> List<System.String>? UnprotectedStorageEngines
        // GraphQL -> unprotectedStorageEngines: [String!]! (scalar)
        [JsonProperty("unprotectedStorageEngines")]
        public List<System.String>? UnprotectedStorageEngines { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqldbDatabaseMetadata";
    }

    public MysqldbDatabaseMetadata Set(
        MysqldbDatabaseProtectionStateEnum? ProtectionState = null,
        System.Int64? ApproxDbSizeInBytes = null,
        System.Int64? ProtectableTables = null,
        System.Int64? TotalTables = null,
        List<System.String>? UnprotectedStorageEngines = null
    ) 
    {
        if ( ProtectionState != null ) {
            this.ProtectionState = ProtectionState;
        }
        if ( ApproxDbSizeInBytes != null ) {
            this.ApproxDbSizeInBytes = ApproxDbSizeInBytes;
        }
        if ( ProtectableTables != null ) {
            this.ProtectableTables = ProtectableTables;
        }
        if ( TotalTables != null ) {
            this.TotalTables = TotalTables;
        }
        if ( UnprotectedStorageEngines != null ) {
            this.UnprotectedStorageEngines = UnprotectedStorageEngines;
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
        //      C# -> MysqldbDatabaseProtectionStateEnum? ProtectionState
        // GraphQL -> protectionState: MysqldbDatabaseProtectionStateEnum! (enum)
        if (this.ProtectionState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionState\n" ;
            } else {
                s += ind + "protectionState\n" ;
            }
        }
        //      C# -> System.Int64? ApproxDbSizeInBytes
        // GraphQL -> approxDbSizeInBytes: Long! (scalar)
        if (this.ApproxDbSizeInBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "approxDbSizeInBytes\n" ;
            } else {
                s += ind + "approxDbSizeInBytes\n" ;
            }
        }
        //      C# -> System.Int64? ProtectableTables
        // GraphQL -> protectableTables: Long! (scalar)
        if (this.ProtectableTables != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectableTables\n" ;
            } else {
                s += ind + "protectableTables\n" ;
            }
        }
        //      C# -> System.Int64? TotalTables
        // GraphQL -> totalTables: Long! (scalar)
        if (this.TotalTables != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalTables\n" ;
            } else {
                s += ind + "totalTables\n" ;
            }
        }
        //      C# -> List<System.String>? UnprotectedStorageEngines
        // GraphQL -> unprotectedStorageEngines: [String!]! (scalar)
        if (this.UnprotectedStorageEngines != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unprotectedStorageEngines\n" ;
            } else {
                s += ind + "unprotectedStorageEngines\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MysqldbDatabaseProtectionStateEnum? ProtectionState
        // GraphQL -> protectionState: MysqldbDatabaseProtectionStateEnum! (enum)
        if (ec.Includes("protectionState",true))
        {
            if(this.ProtectionState == null) {

                this.ProtectionState = new MysqldbDatabaseProtectionStateEnum();

            } else {


            }
        }
        else if (this.ProtectionState != null && ec.Excludes("protectionState",true))
        {
            this.ProtectionState = null;
        }
        //      C# -> System.Int64? ApproxDbSizeInBytes
        // GraphQL -> approxDbSizeInBytes: Long! (scalar)
        if (ec.Includes("approxDbSizeInBytes",true))
        {
            if(this.ApproxDbSizeInBytes == null) {

                this.ApproxDbSizeInBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ApproxDbSizeInBytes != null && ec.Excludes("approxDbSizeInBytes",true))
        {
            this.ApproxDbSizeInBytes = null;
        }
        //      C# -> System.Int64? ProtectableTables
        // GraphQL -> protectableTables: Long! (scalar)
        if (ec.Includes("protectableTables",true))
        {
            if(this.ProtectableTables == null) {

                this.ProtectableTables = new System.Int64();

            } else {


            }
        }
        else if (this.ProtectableTables != null && ec.Excludes("protectableTables",true))
        {
            this.ProtectableTables = null;
        }
        //      C# -> System.Int64? TotalTables
        // GraphQL -> totalTables: Long! (scalar)
        if (ec.Includes("totalTables",true))
        {
            if(this.TotalTables == null) {

                this.TotalTables = new System.Int64();

            } else {


            }
        }
        else if (this.TotalTables != null && ec.Excludes("totalTables",true))
        {
            this.TotalTables = null;
        }
        //      C# -> List<System.String>? UnprotectedStorageEngines
        // GraphQL -> unprotectedStorageEngines: [String!]! (scalar)
        if (ec.Includes("unprotectedStorageEngines",true))
        {
            if(this.UnprotectedStorageEngines == null) {

                this.UnprotectedStorageEngines = new List<System.String>();

            } else {


            }
        }
        else if (this.UnprotectedStorageEngines != null && ec.Excludes("unprotectedStorageEngines",true))
        {
            this.UnprotectedStorageEngines = null;
        }
    }


    #endregion

    } // class MysqldbDatabaseMetadata
    
    #endregion

    public static class ListMysqldbDatabaseMetadataExtensions
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
            this List<MysqldbDatabaseMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqldbDatabaseMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqldbDatabaseMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqldbDatabaseMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqldbDatabaseMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types