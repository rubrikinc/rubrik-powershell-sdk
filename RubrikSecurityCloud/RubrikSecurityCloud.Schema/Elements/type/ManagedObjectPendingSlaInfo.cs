// ManagedObjectPendingSlaInfo.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedObjectPendingSlaInfo
    public class ManagedObjectPendingSlaInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isPendingSlaDomainRetentionLocked")]
        public System.Boolean? IsPendingSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        [JsonProperty("pendingSlaDomainId")]
        public System.String? PendingSlaDomainId { get; set; }

        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        [JsonProperty("pendingSlaDomainName")]
        public System.String? PendingSlaDomainName { get; set; }


        #endregion

    #region methods

    public ManagedObjectPendingSlaInfo Set(
        System.Boolean? IsPendingSlaDomainRetentionLocked = null,
        System.String? ObjectId = null,
        System.String? PendingSlaDomainId = null,
        System.String? PendingSlaDomainName = null
    ) 
    {
        if ( IsPendingSlaDomainRetentionLocked != null ) {
            this.IsPendingSlaDomainRetentionLocked = IsPendingSlaDomainRetentionLocked;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( PendingSlaDomainId != null ) {
            this.PendingSlaDomainId = PendingSlaDomainId;
        }
        if ( PendingSlaDomainName != null ) {
            this.PendingSlaDomainName = PendingSlaDomainName;
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
        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsPendingSlaDomainRetentionLocked != null) {
            s += ind + "isPendingSlaDomainRetentionLocked\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        if (this.PendingSlaDomainId != null) {
            s += ind + "pendingSlaDomainId\n" ;
        }
        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        if (this.PendingSlaDomainName != null) {
            s += ind + "pendingSlaDomainName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsPendingSlaDomainRetentionLocked == null && Exploration.Includes(parent + ".isPendingSlaDomainRetentionLocked", true))
        {
            this.IsPendingSlaDomainRetentionLocked = true;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = new System.String("FETCH");
        }
        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        if (this.PendingSlaDomainId == null && Exploration.Includes(parent + ".pendingSlaDomainId", true))
        {
            this.PendingSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        if (this.PendingSlaDomainName == null && Exploration.Includes(parent + ".pendingSlaDomainName", true))
        {
            this.PendingSlaDomainName = new System.String("FETCH");
        }
    }


    #endregion

    } // class ManagedObjectPendingSlaInfo
    
    #endregion

    public static class ListManagedObjectPendingSlaInfoExtensions
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
            this List<ManagedObjectPendingSlaInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedObjectPendingSlaInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedObjectPendingSlaInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types