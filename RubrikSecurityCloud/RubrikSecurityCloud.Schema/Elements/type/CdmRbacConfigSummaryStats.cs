// CdmRbacConfigSummaryStats.cs
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
    #region CdmRbacConfigSummaryStats
    public class CdmRbacConfigSummaryStats: BaseType
    {
        #region members

        //      C# -> System.Int32? NumCannotMigrateRoles
        // GraphQL -> numCannotMigrateRoles: Int! (scalar)
        [JsonProperty("numCannotMigrateRoles")]
        public System.Int32? NumCannotMigrateRoles { get; set; }

        //      C# -> System.Int32? NumCannotMigrateSsoGroups
        // GraphQL -> numCannotMigrateSsoGroups: Int! (scalar)
        [JsonProperty("numCannotMigrateSsoGroups")]
        public System.Int32? NumCannotMigrateSsoGroups { get; set; }

        //      C# -> System.Int32? NumCannotMigrateUsers
        // GraphQL -> numCannotMigrateUsers: Int! (scalar)
        [JsonProperty("numCannotMigrateUsers")]
        public System.Int32? NumCannotMigrateUsers { get; set; }

        //      C# -> System.Int32? NumPartiallyUnavailableRoles
        // GraphQL -> numPartiallyUnavailableRoles: Int! (scalar)
        [JsonProperty("numPartiallyUnavailableRoles")]
        public System.Int32? NumPartiallyUnavailableRoles { get; set; }

        //      C# -> System.Int32? NumRoles
        // GraphQL -> numRoles: Int! (scalar)
        [JsonProperty("numRoles")]
        public System.Int32? NumRoles { get; set; }

        //      C# -> System.Int32? NumSsoGroups
        // GraphQL -> numSsoGroups: Int! (scalar)
        [JsonProperty("numSsoGroups")]
        public System.Int32? NumSsoGroups { get; set; }

        //      C# -> System.Int32? NumUsers
        // GraphQL -> numUsers: Int! (scalar)
        [JsonProperty("numUsers")]
        public System.Int32? NumUsers { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmRbacConfigSummaryStats";
    }

    public CdmRbacConfigSummaryStats Set(
        System.Int32? NumCannotMigrateRoles = null,
        System.Int32? NumCannotMigrateSsoGroups = null,
        System.Int32? NumCannotMigrateUsers = null,
        System.Int32? NumPartiallyUnavailableRoles = null,
        System.Int32? NumRoles = null,
        System.Int32? NumSsoGroups = null,
        System.Int32? NumUsers = null
    ) 
    {
        if ( NumCannotMigrateRoles != null ) {
            this.NumCannotMigrateRoles = NumCannotMigrateRoles;
        }
        if ( NumCannotMigrateSsoGroups != null ) {
            this.NumCannotMigrateSsoGroups = NumCannotMigrateSsoGroups;
        }
        if ( NumCannotMigrateUsers != null ) {
            this.NumCannotMigrateUsers = NumCannotMigrateUsers;
        }
        if ( NumPartiallyUnavailableRoles != null ) {
            this.NumPartiallyUnavailableRoles = NumPartiallyUnavailableRoles;
        }
        if ( NumRoles != null ) {
            this.NumRoles = NumRoles;
        }
        if ( NumSsoGroups != null ) {
            this.NumSsoGroups = NumSsoGroups;
        }
        if ( NumUsers != null ) {
            this.NumUsers = NumUsers;
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
        //      C# -> System.Int32? NumCannotMigrateRoles
        // GraphQL -> numCannotMigrateRoles: Int! (scalar)
        if (this.NumCannotMigrateRoles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCannotMigrateRoles\n" ;
            } else {
                s += ind + "numCannotMigrateRoles\n" ;
            }
        }
        //      C# -> System.Int32? NumCannotMigrateSsoGroups
        // GraphQL -> numCannotMigrateSsoGroups: Int! (scalar)
        if (this.NumCannotMigrateSsoGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCannotMigrateSsoGroups\n" ;
            } else {
                s += ind + "numCannotMigrateSsoGroups\n" ;
            }
        }
        //      C# -> System.Int32? NumCannotMigrateUsers
        // GraphQL -> numCannotMigrateUsers: Int! (scalar)
        if (this.NumCannotMigrateUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCannotMigrateUsers\n" ;
            } else {
                s += ind + "numCannotMigrateUsers\n" ;
            }
        }
        //      C# -> System.Int32? NumPartiallyUnavailableRoles
        // GraphQL -> numPartiallyUnavailableRoles: Int! (scalar)
        if (this.NumPartiallyUnavailableRoles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numPartiallyUnavailableRoles\n" ;
            } else {
                s += ind + "numPartiallyUnavailableRoles\n" ;
            }
        }
        //      C# -> System.Int32? NumRoles
        // GraphQL -> numRoles: Int! (scalar)
        if (this.NumRoles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numRoles\n" ;
            } else {
                s += ind + "numRoles\n" ;
            }
        }
        //      C# -> System.Int32? NumSsoGroups
        // GraphQL -> numSsoGroups: Int! (scalar)
        if (this.NumSsoGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numSsoGroups\n" ;
            } else {
                s += ind + "numSsoGroups\n" ;
            }
        }
        //      C# -> System.Int32? NumUsers
        // GraphQL -> numUsers: Int! (scalar)
        if (this.NumUsers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numUsers\n" ;
            } else {
                s += ind + "numUsers\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumCannotMigrateRoles
        // GraphQL -> numCannotMigrateRoles: Int! (scalar)
        if (ec.Includes("numCannotMigrateRoles",true))
        {
            if(this.NumCannotMigrateRoles == null) {

                this.NumCannotMigrateRoles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCannotMigrateRoles != null && ec.Excludes("numCannotMigrateRoles",true))
        {
            this.NumCannotMigrateRoles = null;
        }
        //      C# -> System.Int32? NumCannotMigrateSsoGroups
        // GraphQL -> numCannotMigrateSsoGroups: Int! (scalar)
        if (ec.Includes("numCannotMigrateSsoGroups",true))
        {
            if(this.NumCannotMigrateSsoGroups == null) {

                this.NumCannotMigrateSsoGroups = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCannotMigrateSsoGroups != null && ec.Excludes("numCannotMigrateSsoGroups",true))
        {
            this.NumCannotMigrateSsoGroups = null;
        }
        //      C# -> System.Int32? NumCannotMigrateUsers
        // GraphQL -> numCannotMigrateUsers: Int! (scalar)
        if (ec.Includes("numCannotMigrateUsers",true))
        {
            if(this.NumCannotMigrateUsers == null) {

                this.NumCannotMigrateUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCannotMigrateUsers != null && ec.Excludes("numCannotMigrateUsers",true))
        {
            this.NumCannotMigrateUsers = null;
        }
        //      C# -> System.Int32? NumPartiallyUnavailableRoles
        // GraphQL -> numPartiallyUnavailableRoles: Int! (scalar)
        if (ec.Includes("numPartiallyUnavailableRoles",true))
        {
            if(this.NumPartiallyUnavailableRoles == null) {

                this.NumPartiallyUnavailableRoles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumPartiallyUnavailableRoles != null && ec.Excludes("numPartiallyUnavailableRoles",true))
        {
            this.NumPartiallyUnavailableRoles = null;
        }
        //      C# -> System.Int32? NumRoles
        // GraphQL -> numRoles: Int! (scalar)
        if (ec.Includes("numRoles",true))
        {
            if(this.NumRoles == null) {

                this.NumRoles = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumRoles != null && ec.Excludes("numRoles",true))
        {
            this.NumRoles = null;
        }
        //      C# -> System.Int32? NumSsoGroups
        // GraphQL -> numSsoGroups: Int! (scalar)
        if (ec.Includes("numSsoGroups",true))
        {
            if(this.NumSsoGroups == null) {

                this.NumSsoGroups = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumSsoGroups != null && ec.Excludes("numSsoGroups",true))
        {
            this.NumSsoGroups = null;
        }
        //      C# -> System.Int32? NumUsers
        // GraphQL -> numUsers: Int! (scalar)
        if (ec.Includes("numUsers",true))
        {
            if(this.NumUsers == null) {

                this.NumUsers = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumUsers != null && ec.Excludes("numUsers",true))
        {
            this.NumUsers = null;
        }
    }


    #endregion

    } // class CdmRbacConfigSummaryStats
    
    #endregion

    public static class ListCdmRbacConfigSummaryStatsExtensions
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
            this List<CdmRbacConfigSummaryStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmRbacConfigSummaryStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmRbacConfigSummaryStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmRbacConfigSummaryStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmRbacConfigSummaryStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types