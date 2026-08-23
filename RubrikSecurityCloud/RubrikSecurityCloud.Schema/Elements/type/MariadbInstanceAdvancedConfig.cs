// MariadbInstanceAdvancedConfig.cs
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
    #region MariadbInstanceAdvancedConfig
    public class MariadbInstanceAdvancedConfig: BaseType
    {
        #region members

        //      C# -> System.String? MariadbBackupBinaryPath
        // GraphQL -> mariadbBackupBinaryPath: String! (scalar)
        [JsonProperty("mariadbBackupBinaryPath")]
        public System.String? MariadbBackupBinaryPath { get; set; }

        //      C# -> System.String? MariadbBinlogBinaryPath
        // GraphQL -> mariadbBinlogBinaryPath: String! (scalar)
        [JsonProperty("mariadbBinlogBinaryPath")]
        public System.String? MariadbBinlogBinaryPath { get; set; }

        //      C# -> System.String? MariadbClientBinaryPath
        // GraphQL -> mariadbClientBinaryPath: String! (scalar)
        [JsonProperty("mariadbClientBinaryPath")]
        public System.String? MariadbClientBinaryPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MariadbInstanceAdvancedConfig";
    }

    public MariadbInstanceAdvancedConfig Set(
        System.String? MariadbBackupBinaryPath = null,
        System.String? MariadbBinlogBinaryPath = null,
        System.String? MariadbClientBinaryPath = null
    ) 
    {
        if ( MariadbBackupBinaryPath != null ) {
            this.MariadbBackupBinaryPath = MariadbBackupBinaryPath;
        }
        if ( MariadbBinlogBinaryPath != null ) {
            this.MariadbBinlogBinaryPath = MariadbBinlogBinaryPath;
        }
        if ( MariadbClientBinaryPath != null ) {
            this.MariadbClientBinaryPath = MariadbClientBinaryPath;
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
        //      C# -> System.String? MariadbBackupBinaryPath
        // GraphQL -> mariadbBackupBinaryPath: String! (scalar)
        if (this.MariadbBackupBinaryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mariadbBackupBinaryPath\n" ;
            } else {
                s += ind + "mariadbBackupBinaryPath\n" ;
            }
        }
        //      C# -> System.String? MariadbBinlogBinaryPath
        // GraphQL -> mariadbBinlogBinaryPath: String! (scalar)
        if (this.MariadbBinlogBinaryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mariadbBinlogBinaryPath\n" ;
            } else {
                s += ind + "mariadbBinlogBinaryPath\n" ;
            }
        }
        //      C# -> System.String? MariadbClientBinaryPath
        // GraphQL -> mariadbClientBinaryPath: String! (scalar)
        if (this.MariadbClientBinaryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mariadbClientBinaryPath\n" ;
            } else {
                s += ind + "mariadbClientBinaryPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? MariadbBackupBinaryPath
        // GraphQL -> mariadbBackupBinaryPath: String! (scalar)
        if (ec.Includes("mariadbBackupBinaryPath",true))
        {
            if(this.MariadbBackupBinaryPath == null) {

                this.MariadbBackupBinaryPath = "FETCH";

            } else {


            }
        }
        else if (this.MariadbBackupBinaryPath != null && ec.Excludes("mariadbBackupBinaryPath",true))
        {
            this.MariadbBackupBinaryPath = null;
        }
        //      C# -> System.String? MariadbBinlogBinaryPath
        // GraphQL -> mariadbBinlogBinaryPath: String! (scalar)
        if (ec.Includes("mariadbBinlogBinaryPath",true))
        {
            if(this.MariadbBinlogBinaryPath == null) {

                this.MariadbBinlogBinaryPath = "FETCH";

            } else {


            }
        }
        else if (this.MariadbBinlogBinaryPath != null && ec.Excludes("mariadbBinlogBinaryPath",true))
        {
            this.MariadbBinlogBinaryPath = null;
        }
        //      C# -> System.String? MariadbClientBinaryPath
        // GraphQL -> mariadbClientBinaryPath: String! (scalar)
        if (ec.Includes("mariadbClientBinaryPath",true))
        {
            if(this.MariadbClientBinaryPath == null) {

                this.MariadbClientBinaryPath = "FETCH";

            } else {


            }
        }
        else if (this.MariadbClientBinaryPath != null && ec.Excludes("mariadbClientBinaryPath",true))
        {
            this.MariadbClientBinaryPath = null;
        }
    }


    #endregion

    } // class MariadbInstanceAdvancedConfig
    
    #endregion

    public static class ListMariadbInstanceAdvancedConfigExtensions
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
            this List<MariadbInstanceAdvancedConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MariadbInstanceAdvancedConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MariadbInstanceAdvancedConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MariadbInstanceAdvancedConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MariadbInstanceAdvancedConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types