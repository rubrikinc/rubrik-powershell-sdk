// TprRequestSummary.cs
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
    #region TprRequestSummary
    public class TprRequestSummary: BaseType
    {
        #region members

        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        [JsonProperty("status")]
        public TprReqStatus? Status { get; set; }

        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        [JsonProperty("triggeredTprRule")]
        public TprRule? TriggeredTprRule { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        [JsonProperty("requestId")]
        public System.String? RequestId { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        [JsonProperty("requester")]
        public UserSummary? Requester { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestSummary";
    }

    public TprRequestSummary Set(
        TprReqStatus? Status = null,
        TprRule? TriggeredTprRule = null,
        System.String? OrgId = null,
        System.String? RequestId = null,
        DateTime? UpdatedAt = null,
        UserSummary? Requester = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TriggeredTprRule != null ) {
            this.TriggeredTprRule = TriggeredTprRule;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( RequestId != null ) {
            this.RequestId = RequestId;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( Requester != null ) {
            this.Requester = Requester;
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
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (this.TriggeredTprRule != null) {
            s += ind + "triggeredTprRule\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        if (this.RequestId != null) {
            s += ind + "requestId\n" ;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            s += ind + "updatedAt\n" ;
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        if (this.Requester != null) {
            var fspec = this.Requester.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "requester {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TprReqStatus? Status
        // GraphQL -> status: TprReqStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new TprReqStatus();
        }
        //      C# -> TprRule? TriggeredTprRule
        // GraphQL -> triggeredTprRule: TprRule! (enum)
        if (this.TriggeredTprRule == null && Exploration.Includes(parent + ".triggeredTprRule", true))
        {
            this.TriggeredTprRule = new TprRule();
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? RequestId
        // GraphQL -> requestId: UUID! (scalar)
        if (this.RequestId == null && Exploration.Includes(parent + ".requestId", true))
        {
            this.RequestId = "FETCH";
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt", true))
        {
            this.UpdatedAt = new DateTime();
        }
        //      C# -> UserSummary? Requester
        // GraphQL -> requester: UserSummary! (type)
        if (this.Requester == null && Exploration.Includes(parent + ".requester"))
        {
            this.Requester = new UserSummary();
            this.Requester.ApplyExploratoryFieldSpec(parent + ".requester");
        }
    }


    #endregion

    } // class TprRequestSummary
    
    #endregion

    public static class ListTprRequestSummaryExtensions
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
            this List<TprRequestSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types