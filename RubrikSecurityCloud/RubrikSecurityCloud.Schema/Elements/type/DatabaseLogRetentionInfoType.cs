// DatabaseLogRetentionInfoType.cs
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
    #region DatabaseLogRetentionInfoType
    public class DatabaseLogRetentionInfoType: BaseType
    {
        #region members

        //      C# -> List<DatabaseLogRetentionConfigEntryType>? DatabaseLogRetentionConfigs
        // GraphQL -> databaseLogRetentionConfigs: [DatabaseLogRetentionConfigEntryType!]! (type)
        [JsonProperty("databaseLogRetentionConfigs")]
        public List<DatabaseLogRetentionConfigEntryType>? DatabaseLogRetentionConfigs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DatabaseLogRetentionInfoType";
    }

    public DatabaseLogRetentionInfoType Set(
        List<DatabaseLogRetentionConfigEntryType>? DatabaseLogRetentionConfigs = null
    ) 
    {
        if ( DatabaseLogRetentionConfigs != null ) {
            this.DatabaseLogRetentionConfigs = DatabaseLogRetentionConfigs;
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
        //      C# -> List<DatabaseLogRetentionConfigEntryType>? DatabaseLogRetentionConfigs
        // GraphQL -> databaseLogRetentionConfigs: [DatabaseLogRetentionConfigEntryType!]! (type)
        if (this.DatabaseLogRetentionConfigs != null) {
            var fspec = this.DatabaseLogRetentionConfigs.AsFieldSpec(conf.Child("databaseLogRetentionConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "databaseLogRetentionConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<DatabaseLogRetentionConfigEntryType>? DatabaseLogRetentionConfigs
        // GraphQL -> databaseLogRetentionConfigs: [DatabaseLogRetentionConfigEntryType!]! (type)
        if (ec.Includes("databaseLogRetentionConfigs",false))
        {
            if(this.DatabaseLogRetentionConfigs == null) {

                this.DatabaseLogRetentionConfigs = new List<DatabaseLogRetentionConfigEntryType>();
                this.DatabaseLogRetentionConfigs.ApplyExploratoryFieldSpec(ec.NewChild("databaseLogRetentionConfigs"));

            } else {

                this.DatabaseLogRetentionConfigs.ApplyExploratoryFieldSpec(ec.NewChild("databaseLogRetentionConfigs"));

            }
        }
        else if (this.DatabaseLogRetentionConfigs != null && ec.Excludes("databaseLogRetentionConfigs",false))
        {
            this.DatabaseLogRetentionConfigs = null;
        }
    }


    #endregion

    } // class DatabaseLogRetentionInfoType
    
    #endregion

    public static class ListDatabaseLogRetentionInfoTypeExtensions
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
            this List<DatabaseLogRetentionInfoType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DatabaseLogRetentionInfoType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DatabaseLogRetentionInfoType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DatabaseLogRetentionInfoType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DatabaseLogRetentionInfoType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types