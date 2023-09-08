// ConnectionStatus.cs
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
    #region ConnectionStatus
    public class ConnectionStatus: BaseType
    {
        #region members

        //      C# -> SaasConnectionStatus? Status
        // GraphQL -> status: SaasConnectionStatus! (enum)
        [JsonProperty("status")]
        public SaasConnectionStatus? Status { get; set; }

        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        [JsonProperty("expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        [JsonProperty("lastUpdated")]
        public DateTime? LastUpdated { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConnectionStatus";
    }

    public ConnectionStatus Set(
        SaasConnectionStatus? Status = null,
        DateTime? ExpirationTime = null,
        DateTime? LastUpdated = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ExpirationTime != null ) {
            this.ExpirationTime = ExpirationTime;
        }
        if ( LastUpdated != null ) {
            this.LastUpdated = LastUpdated;
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
        //      C# -> SaasConnectionStatus? Status
        // GraphQL -> status: SaasConnectionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime != null) {
            s += ind + "expirationTime\n" ;
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated != null) {
            s += ind + "lastUpdated\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SaasConnectionStatus? Status
        // GraphQL -> status: SaasConnectionStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new SaasConnectionStatus();
        }
        //      C# -> DateTime? ExpirationTime
        // GraphQL -> expirationTime: DateTime (scalar)
        if (this.ExpirationTime == null && ec.Includes("expirationTime",true))
        {
            this.ExpirationTime = new DateTime();
        }
        //      C# -> DateTime? LastUpdated
        // GraphQL -> lastUpdated: DateTime (scalar)
        if (this.LastUpdated == null && ec.Includes("lastUpdated",true))
        {
            this.LastUpdated = new DateTime();
        }
    }


    #endregion

    } // class ConnectionStatus
    
    #endregion

    public static class ListConnectionStatusExtensions
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
            this List<ConnectionStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ConnectionStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConnectionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ConnectionStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types