// RcvAccountEntitlement.cs
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
    #region RcvAccountEntitlement
    public class RcvAccountEntitlement: BaseType
    {
        #region members

        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        [JsonProperty("archiveEntitlement")]
        public RcvEntitlement? ArchiveEntitlement { get; set; }

        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        [JsonProperty("backupEntitlement")]
        public RcvEntitlement? BackupEntitlement { get; set; }

        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        [JsonProperty("entitlements")]
        public List<RcvEntitlementsUsageDetails>? Entitlements { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvAccountEntitlement";
    }

    public RcvAccountEntitlement Set(
        RcvEntitlement? ArchiveEntitlement = null,
        RcvEntitlement? BackupEntitlement = null,
        List<RcvEntitlementsUsageDetails>? Entitlements = null
    ) 
    {
        if ( ArchiveEntitlement != null ) {
            this.ArchiveEntitlement = ArchiveEntitlement;
        }
        if ( BackupEntitlement != null ) {
            this.BackupEntitlement = BackupEntitlement;
        }
        if ( Entitlements != null ) {
            this.Entitlements = Entitlements;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        if (this.ArchiveEntitlement != null) {
            var fspec = this.ArchiveEntitlement.AsFieldSpec(conf.Child("archiveEntitlement"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "archiveEntitlement {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        if (this.BackupEntitlement != null) {
            var fspec = this.BackupEntitlement.AsFieldSpec(conf.Child("backupEntitlement"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupEntitlement {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        if (this.Entitlements != null) {
            var fspec = this.Entitlements.AsFieldSpec(conf.Child("entitlements"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entitlements {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        if (ec.Includes("archiveEntitlement",false))
        {
            if(this.ArchiveEntitlement == null) {

                this.ArchiveEntitlement = new RcvEntitlement();
                this.ArchiveEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("archiveEntitlement"));

            } else {

                this.ArchiveEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("archiveEntitlement"));

            }
        }
        else if (this.ArchiveEntitlement != null && ec.Excludes("archiveEntitlement",false))
        {
            this.ArchiveEntitlement = null;
        }
        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        if (ec.Includes("backupEntitlement",false))
        {
            if(this.BackupEntitlement == null) {

                this.BackupEntitlement = new RcvEntitlement();
                this.BackupEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("backupEntitlement"));

            } else {

                this.BackupEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("backupEntitlement"));

            }
        }
        else if (this.BackupEntitlement != null && ec.Excludes("backupEntitlement",false))
        {
            this.BackupEntitlement = null;
        }
        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        if (ec.Includes("entitlements",false))
        {
            if(this.Entitlements == null) {

                this.Entitlements = new List<RcvEntitlementsUsageDetails>();
                this.Entitlements.ApplyExploratoryFieldSpec(ec.NewChild("entitlements"));

            } else {

                this.Entitlements.ApplyExploratoryFieldSpec(ec.NewChild("entitlements"));

            }
        }
        else if (this.Entitlements != null && ec.Excludes("entitlements",false))
        {
            this.Entitlements = null;
        }
    }


    #endregion

    } // class RcvAccountEntitlement
    
    #endregion

    public static class ListRcvAccountEntitlementExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<RcvAccountEntitlement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RcvAccountEntitlement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvAccountEntitlement> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvAccountEntitlement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvAccountEntitlement> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types