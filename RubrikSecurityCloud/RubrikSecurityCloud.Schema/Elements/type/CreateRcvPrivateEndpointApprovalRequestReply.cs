// CreateRcvPrivateEndpointApprovalRequestReply.cs
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
    #region CreateRcvPrivateEndpointApprovalRequestReply
    public class CreateRcvPrivateEndpointApprovalRequestReply: BaseType
    {
        #region members

        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        [JsonProperty("requestMessage")]
        public System.String? RequestMessage { get; set; }

        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        [JsonProperty("storageAccountId")]
        public System.String? StorageAccountId { get; set; }


        #endregion

    #region methods

    public CreateRcvPrivateEndpointApprovalRequestReply Set(
        System.String? RequestMessage = null,
        System.String? StorageAccountId = null
    ) 
    {
        if ( RequestMessage != null ) {
            this.RequestMessage = RequestMessage;
        }
        if ( StorageAccountId != null ) {
            this.StorageAccountId = StorageAccountId;
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
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (this.RequestMessage != null) {
            s += ind + "requestMessage\n" ;
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (this.StorageAccountId != null) {
            s += ind + "storageAccountId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (this.RequestMessage == null && Exploration.Includes(parent + ".requestMessage", true))
        {
            this.RequestMessage = "FETCH";
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (this.StorageAccountId == null && Exploration.Includes(parent + ".storageAccountId", true))
        {
            this.StorageAccountId = "FETCH";
        }
    }


    #endregion

    } // class CreateRcvPrivateEndpointApprovalRequestReply
    
    #endregion

    public static class ListCreateRcvPrivateEndpointApprovalRequestReplyExtensions
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
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateRcvPrivateEndpointApprovalRequestReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types