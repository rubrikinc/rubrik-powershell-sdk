// SlaUpgrade.cs
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
    #region SlaUpgrade
    public class SlaUpgrade: BaseType
    {
        #region members

        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        [JsonProperty("status")]
        public SlaMigrationStatus? Status { get; set; }

        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        [JsonProperty("msg")]
        public System.String? Msg { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaUpgrade";
    }

    public SlaUpgrade Set(
        SlaMigrationStatus? Status = null,
        System.String? Msg = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Msg != null ) {
            this.Msg = Msg;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        if (this.Msg != null) {
            s += ind + "msg\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new SlaMigrationStatus();
        }
        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        if (this.Msg == null && ec.Includes("msg",true))
        {
            this.Msg = "FETCH";
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId == null && ec.Includes("taskchainId",true))
        {
            this.TaskchainId = "FETCH";
        }
    }


    #endregion

    } // class SlaUpgrade
    
    #endregion

    public static class ListSlaUpgradeExtensions
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
            this List<SlaUpgrade> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaUpgrade> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaUpgrade());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaUpgrade> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types