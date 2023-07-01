// RscKeyRotationRequest.cs
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
    #region RscKeyRotationRequest
    public class RscKeyRotationRequest: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        [JsonProperty("didKeyRotationJobFail")]
        public System.Boolean? DidKeyRotationJobFail { get; set; }

        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        [JsonProperty("requestedAt")]
        public DateTime? RequestedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscKeyRotationRequest";
    }

    public RscKeyRotationRequest Set(
        System.String? ClusterUuid = null,
        System.Boolean? DidKeyRotationJobFail = null,
        DateTime? RequestedAt = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DidKeyRotationJobFail != null ) {
            this.DidKeyRotationJobFail = DidKeyRotationJobFail;
        }
        if ( RequestedAt != null ) {
            this.RequestedAt = RequestedAt;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        if (this.DidKeyRotationJobFail != null) {
            s += ind + "didKeyRotationJobFail\n" ;
        }
        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        if (this.RequestedAt != null) {
            s += ind + "requestedAt\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Boolean? DidKeyRotationJobFail
        // GraphQL -> didKeyRotationJobFail: Boolean! (scalar)
        if (this.DidKeyRotationJobFail == null && Exploration.Includes(parent + ".didKeyRotationJobFail", true))
        {
            this.DidKeyRotationJobFail = true;
        }
        //      C# -> DateTime? RequestedAt
        // GraphQL -> requestedAt: DateTime (scalar)
        if (this.RequestedAt == null && Exploration.Includes(parent + ".requestedAt", true))
        {
            this.RequestedAt = new DateTime();
        }
    }


    #endregion

    } // class RscKeyRotationRequest
    
    #endregion

    public static class ListRscKeyRotationRequestExtensions
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
            this List<RscKeyRotationRequest> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RscKeyRotationRequest> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RscKeyRotationRequest());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types