// MssqlDatabaseRestoreRecoverySpec.cs
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
    #region MssqlDatabaseRestoreRecoverySpec
    public class MssqlDatabaseRestoreRecoverySpec: BaseType
    {
        #region members

        //      C# -> System.String? TargetDataFilePath
        // GraphQL -> targetDataFilePath: String! (scalar)
        [JsonProperty("targetDataFilePath")]
        public System.String? TargetDataFilePath { get; set; }

        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: UUID (scalar)
        [JsonProperty("targetInstanceId")]
        public System.String? TargetInstanceId { get; set; }

        //      C# -> System.String? TargetLogFilePath
        // GraphQL -> targetLogFilePath: String! (scalar)
        [JsonProperty("targetLogFilePath")]
        public System.String? TargetLogFilePath { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDatabaseRestoreRecoverySpec";
    }

    public MssqlDatabaseRestoreRecoverySpec Set(
        System.String? TargetDataFilePath = null,
        System.String? TargetInstanceId = null,
        System.String? TargetLogFilePath = null,
        System.Int64? Version = null
    ) 
    {
        if ( TargetDataFilePath != null ) {
            this.TargetDataFilePath = TargetDataFilePath;
        }
        if ( TargetInstanceId != null ) {
            this.TargetInstanceId = TargetInstanceId;
        }
        if ( TargetLogFilePath != null ) {
            this.TargetLogFilePath = TargetLogFilePath;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> System.String? TargetDataFilePath
        // GraphQL -> targetDataFilePath: String! (scalar)
        if (this.TargetDataFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetDataFilePath\n" ;
            } else {
                s += ind + "targetDataFilePath\n" ;
            }
        }
        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: UUID (scalar)
        if (this.TargetInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetInstanceId\n" ;
            } else {
                s += ind + "targetInstanceId\n" ;
            }
        }
        //      C# -> System.String? TargetLogFilePath
        // GraphQL -> targetLogFilePath: String! (scalar)
        if (this.TargetLogFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLogFilePath\n" ;
            } else {
                s += ind + "targetLogFilePath\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? TargetDataFilePath
        // GraphQL -> targetDataFilePath: String! (scalar)
        if (ec.Includes("targetDataFilePath",true))
        {
            if(this.TargetDataFilePath == null) {

                this.TargetDataFilePath = "FETCH";

            } else {


            }
        }
        else if (this.TargetDataFilePath != null && ec.Excludes("targetDataFilePath",true))
        {
            this.TargetDataFilePath = null;
        }
        //      C# -> System.String? TargetInstanceId
        // GraphQL -> targetInstanceId: UUID (scalar)
        if (ec.Includes("targetInstanceId",true))
        {
            if(this.TargetInstanceId == null) {

                this.TargetInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.TargetInstanceId != null && ec.Excludes("targetInstanceId",true))
        {
            this.TargetInstanceId = null;
        }
        //      C# -> System.String? TargetLogFilePath
        // GraphQL -> targetLogFilePath: String! (scalar)
        if (ec.Includes("targetLogFilePath",true))
        {
            if(this.TargetLogFilePath == null) {

                this.TargetLogFilePath = "FETCH";

            } else {


            }
        }
        else if (this.TargetLogFilePath != null && ec.Excludes("targetLogFilePath",true))
        {
            this.TargetLogFilePath = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class MssqlDatabaseRestoreRecoverySpec
    
    #endregion

    public static class ListMssqlDatabaseRestoreRecoverySpecExtensions
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
            this List<MssqlDatabaseRestoreRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlDatabaseRestoreRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDatabaseRestoreRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDatabaseRestoreRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDatabaseRestoreRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types