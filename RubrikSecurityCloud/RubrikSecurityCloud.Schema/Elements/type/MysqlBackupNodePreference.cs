// MysqlBackupNodePreference.cs
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
    #region MysqlBackupNodePreference
    public class MysqlBackupNodePreference: BaseType
    {
        #region members

        //      C# -> BackupNodePreferenceStrategy? Strategy
        // GraphQL -> strategy: BackupNodePreferenceStrategy! (enum)
        [JsonProperty("strategy")]
        public BackupNodePreferenceStrategy? Strategy { get; set; }

        //      C# -> List<System.String>? ExcludedReplicaIds
        // GraphQL -> excludedReplicaIds: [String!]! (scalar)
        [JsonProperty("excludedReplicaIds")]
        public List<System.String>? ExcludedReplicaIds { get; set; }

        //      C# -> List<System.String>? OrderedReplicaPreferences
        // GraphQL -> orderedReplicaPreferences: [String!]! (scalar)
        [JsonProperty("orderedReplicaPreferences")]
        public List<System.String>? OrderedReplicaPreferences { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqlBackupNodePreference";
    }

    public MysqlBackupNodePreference Set(
        BackupNodePreferenceStrategy? Strategy = null,
        List<System.String>? ExcludedReplicaIds = null,
        List<System.String>? OrderedReplicaPreferences = null
    ) 
    {
        if ( Strategy != null ) {
            this.Strategy = Strategy;
        }
        if ( ExcludedReplicaIds != null ) {
            this.ExcludedReplicaIds = ExcludedReplicaIds;
        }
        if ( OrderedReplicaPreferences != null ) {
            this.OrderedReplicaPreferences = OrderedReplicaPreferences;
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
        //      C# -> BackupNodePreferenceStrategy? Strategy
        // GraphQL -> strategy: BackupNodePreferenceStrategy! (enum)
        if (this.Strategy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "strategy\n" ;
            } else {
                s += ind + "strategy\n" ;
            }
        }
        //      C# -> List<System.String>? ExcludedReplicaIds
        // GraphQL -> excludedReplicaIds: [String!]! (scalar)
        if (this.ExcludedReplicaIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedReplicaIds\n" ;
            } else {
                s += ind + "excludedReplicaIds\n" ;
            }
        }
        //      C# -> List<System.String>? OrderedReplicaPreferences
        // GraphQL -> orderedReplicaPreferences: [String!]! (scalar)
        if (this.OrderedReplicaPreferences != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orderedReplicaPreferences\n" ;
            } else {
                s += ind + "orderedReplicaPreferences\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> BackupNodePreferenceStrategy? Strategy
        // GraphQL -> strategy: BackupNodePreferenceStrategy! (enum)
        if (ec.Includes("strategy",true))
        {
            if(this.Strategy == null) {

                this.Strategy = new BackupNodePreferenceStrategy();

            } else {


            }
        }
        else if (this.Strategy != null && ec.Excludes("strategy",true))
        {
            this.Strategy = null;
        }
        //      C# -> List<System.String>? ExcludedReplicaIds
        // GraphQL -> excludedReplicaIds: [String!]! (scalar)
        if (ec.Includes("excludedReplicaIds",true))
        {
            if(this.ExcludedReplicaIds == null) {

                this.ExcludedReplicaIds = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedReplicaIds != null && ec.Excludes("excludedReplicaIds",true))
        {
            this.ExcludedReplicaIds = null;
        }
        //      C# -> List<System.String>? OrderedReplicaPreferences
        // GraphQL -> orderedReplicaPreferences: [String!]! (scalar)
        if (ec.Includes("orderedReplicaPreferences",true))
        {
            if(this.OrderedReplicaPreferences == null) {

                this.OrderedReplicaPreferences = new List<System.String>();

            } else {


            }
        }
        else if (this.OrderedReplicaPreferences != null && ec.Excludes("orderedReplicaPreferences",true))
        {
            this.OrderedReplicaPreferences = null;
        }
    }


    #endregion

    } // class MysqlBackupNodePreference
    
    #endregion

    public static class ListMysqlBackupNodePreferenceExtensions
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
            this List<MysqlBackupNodePreference> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqlBackupNodePreference> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqlBackupNodePreference> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqlBackupNodePreference());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqlBackupNodePreference> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types