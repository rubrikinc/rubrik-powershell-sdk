// PendingActionType.cs
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
    #region PendingActionType
    public class PendingActionType: BaseType
    {
        #region members

        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        [JsonProperty("pendingActionGroupType")]
        public PendingActionGroupTypeEnum? PendingActionGroupType { get; set; }

        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        [JsonProperty("pendingActionSubGroupType")]
        public PendingActionSubGroupTypeEnum? PendingActionSubGroupType { get; set; }

        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        [JsonProperty("pendingActionSyncType")]
        public PendingActionSyncType? PendingActionSyncType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PendingActionType";
    }

    public PendingActionType Set(
        PendingActionGroupTypeEnum? PendingActionGroupType = null,
        PendingActionSubGroupTypeEnum? PendingActionSubGroupType = null,
        PendingActionSyncType? PendingActionSyncType = null
    ) 
    {
        if ( PendingActionGroupType != null ) {
            this.PendingActionGroupType = PendingActionGroupType;
        }
        if ( PendingActionSubGroupType != null ) {
            this.PendingActionSubGroupType = PendingActionSubGroupType;
        }
        if ( PendingActionSyncType != null ) {
            this.PendingActionSyncType = PendingActionSyncType;
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
        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        if (this.PendingActionGroupType != null) {
            s += ind + "pendingActionGroupType\n" ;
        }
        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        if (this.PendingActionSubGroupType != null) {
            s += ind + "pendingActionSubGroupType\n" ;
        }
        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        if (this.PendingActionSyncType != null) {
            s += ind + "pendingActionSyncType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        if (this.PendingActionGroupType == null && Exploration.Includes(parent + ".pendingActionGroupType", true))
        {
            this.PendingActionGroupType = new PendingActionGroupTypeEnum();
        }
        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        if (this.PendingActionSubGroupType == null && Exploration.Includes(parent + ".pendingActionSubGroupType", true))
        {
            this.PendingActionSubGroupType = new PendingActionSubGroupTypeEnum();
        }
        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        if (this.PendingActionSyncType == null && Exploration.Includes(parent + ".pendingActionSyncType", true))
        {
            this.PendingActionSyncType = new PendingActionSyncType();
        }
    }


    #endregion

    } // class PendingActionType
    
    #endregion

    public static class ListPendingActionTypeExtensions
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
            this List<PendingActionType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PendingActionType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingActionType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types