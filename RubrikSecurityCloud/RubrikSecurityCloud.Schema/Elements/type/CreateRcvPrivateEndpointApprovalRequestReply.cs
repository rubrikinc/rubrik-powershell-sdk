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

    public override string GetGqlTypeName() {
        return "CreateRcvPrivateEndpointApprovalRequestReply";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (this.RequestMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestMessage\n" ;
            } else {
                s += ind + "requestMessage\n" ;
            }
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (this.StorageAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountId\n" ;
            } else {
                s += ind + "storageAccountId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (ec.Includes("requestMessage",true))
        {
            if(this.RequestMessage == null) {

                this.RequestMessage = "FETCH";

            } else {


            }
        }
        else if (this.RequestMessage != null && ec.Excludes("requestMessage",true))
        {
            this.RequestMessage = null;
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (ec.Includes("storageAccountId",true))
        {
            if(this.StorageAccountId == null) {

                this.StorageAccountId = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountId != null && ec.Excludes("storageAccountId",true))
        {
            this.StorageAccountId = null;
        }
    }


    #endregion

    } // class CreateRcvPrivateEndpointApprovalRequestReply
    
    #endregion

    public static class ListCreateRcvPrivateEndpointApprovalRequestReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CreateRcvPrivateEndpointApprovalRequestReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateRcvPrivateEndpointApprovalRequestReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateRcvPrivateEndpointApprovalRequestReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types