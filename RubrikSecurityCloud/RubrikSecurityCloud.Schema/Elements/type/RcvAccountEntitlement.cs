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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        if (this.ArchiveEntitlement != null) {
            var fspec = this.ArchiveEntitlement.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "archiveEntitlement {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        if (this.BackupEntitlement != null) {
            var fspec = this.BackupEntitlement.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "backupEntitlement {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        if (this.Entitlements != null) {
            var fspec = this.Entitlements.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "entitlements {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> RcvEntitlement? ArchiveEntitlement
        // GraphQL -> archiveEntitlement: RcvEntitlement (type)
        if (this.ArchiveEntitlement == null && ec.Includes("archiveEntitlement",false))
        {
            this.ArchiveEntitlement = new RcvEntitlement();
            this.ArchiveEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("archiveEntitlement"));
        }
        //      C# -> RcvEntitlement? BackupEntitlement
        // GraphQL -> backupEntitlement: RcvEntitlement (type)
        if (this.BackupEntitlement == null && ec.Includes("backupEntitlement",false))
        {
            this.BackupEntitlement = new RcvEntitlement();
            this.BackupEntitlement.ApplyExploratoryFieldSpec(ec.NewChild("backupEntitlement"));
        }
        //      C# -> List<RcvEntitlementsUsageDetails>? Entitlements
        // GraphQL -> entitlements: [RcvEntitlementsUsageDetails!]! (type)
        if (this.Entitlements == null && ec.Includes("entitlements",false))
        {
            this.Entitlements = new List<RcvEntitlementsUsageDetails>();
            this.Entitlements.ApplyExploratoryFieldSpec(ec.NewChild("entitlements"));
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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