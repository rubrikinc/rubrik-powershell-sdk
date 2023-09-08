// CreateSupportCaseReply.cs
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
    #region CreateSupportCaseReply
    public class CreateSupportCaseReply: BaseType
    {
        #region members

        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        [JsonProperty("caseId")]
        public System.String? CaseId { get; set; }

        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: URL! (scalar)
        [JsonProperty("caseLink")]
        public System.String? CaseLink { get; set; }

        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        [JsonProperty("caseNumber")]
        public System.String? CaseNumber { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateSupportCaseReply";
    }

    public CreateSupportCaseReply Set(
        System.String? CaseId = null,
        System.String? CaseLink = null,
        System.String? CaseNumber = null
    ) 
    {
        if ( CaseId != null ) {
            this.CaseId = CaseId;
        }
        if ( CaseLink != null ) {
            this.CaseLink = CaseLink;
        }
        if ( CaseNumber != null ) {
            this.CaseNumber = CaseNumber;
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
        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: URL! (scalar)
        if (this.CaseLink != null) {
            s += ind + "caseLink\n" ;
        }
        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        if (this.CaseNumber != null) {
            s += ind + "caseNumber\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CaseId
        // GraphQL -> caseId: String! (scalar)
        if (this.CaseId == null && ec.Includes("caseId",true))
        {
            this.CaseId = "FETCH";
        }
        //      C# -> System.String? CaseLink
        // GraphQL -> caseLink: URL! (scalar)
        if (this.CaseLink == null && ec.Includes("caseLink",true))
        {
            this.CaseLink = "FETCH";
        }
        //      C# -> System.String? CaseNumber
        // GraphQL -> caseNumber: String! (scalar)
        if (this.CaseNumber == null && ec.Includes("caseNumber",true))
        {
            this.CaseNumber = "FETCH";
        }
    }


    #endregion

    } // class CreateSupportCaseReply
    
    #endregion

    public static class ListCreateSupportCaseReplyExtensions
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
            this List<CreateSupportCaseReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateSupportCaseReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateSupportCaseReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CreateSupportCaseReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types