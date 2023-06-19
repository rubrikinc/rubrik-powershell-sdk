// UpdateSupportCaseReply.cs
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
    #region UpdateSupportCaseReply
    public class UpdateSupportCaseReply: BaseType
    {
        #region members

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> List<SupportCaseAttachmentResponse>? Attachments
        // GraphQL -> attachments: [SupportCaseAttachmentResponse!]! (type)
        [JsonProperty("attachments")]
        public List<SupportCaseAttachmentResponse>? Attachments { get; set; }


        #endregion

    #region methods

    public UpdateSupportCaseReply Set(
        System.String? CaseId = null,
        System.String? ClusterUuid = null,
        List<SupportCaseAttachmentResponse>? Attachments = null
    ) 
    {
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Attachments != null ) {
            this.Attachments = Attachments;
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
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (this.CaseId != null) {
            s += ind + "caseId\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> List<SupportCaseAttachmentResponse>? Attachments
        // GraphQL -> attachments: [SupportCaseAttachmentResponse!]! (type)
        if (this.Attachments != null) {
            var fspec = this.Attachments.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "attachments {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (this.CaseId == null && Exploration.Includes(parent + ".caseId", true))
        {
            this.CaseId = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> List<SupportCaseAttachmentResponse>? Attachments
        // GraphQL -> attachments: [SupportCaseAttachmentResponse!]! (type)
        if (this.Attachments == null && Exploration.Includes(parent + ".attachments"))
        {
            this.Attachments = new List<SupportCaseAttachmentResponse>();
            this.Attachments.ApplyExploratoryFieldSpec(parent + ".attachments");
        }
    }


    #endregion

    } // class UpdateSupportCaseReply
    
    #endregion

    public static class ListUpdateSupportCaseReplyExtensions
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
            this List<UpdateSupportCaseReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateSupportCaseReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateSupportCaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types