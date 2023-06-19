// GetMosaicRecoverableRangeResponse.cs
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
    #region GetMosaicRecoverableRangeResponse
    public class GetMosaicRecoverableRangeResponse: BaseType
    {
        #region members

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        [JsonProperty("returnCode")]
        public System.Int64? ReturnCode { get; set; }

        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        [JsonProperty("status")]
        public System.Boolean? Status { get; set; }

        //      C# -> MosaicRecoverableRangeObject? Data
        // GraphQL -> data: MosaicRecoverableRangeObject (type)
        [JsonProperty("data")]
        public MosaicRecoverableRangeObject? Data { get; set; }


        #endregion

    #region methods

    public GetMosaicRecoverableRangeResponse Set(
        System.String? Message = null,
        System.Int64? ReturnCode = null,
        System.Boolean? Status = null,
        MosaicRecoverableRangeObject? Data = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ReturnCode != null ) {
            this.ReturnCode = ReturnCode;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Data != null ) {
            this.Data = Data;
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
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (this.ReturnCode != null) {
            s += ind + "returnCode\n" ;
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> MosaicRecoverableRangeObject? Data
        // GraphQL -> data: MosaicRecoverableRangeObject (type)
        if (this.Data != null) {
            var fspec = this.Data.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "data {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (this.ReturnCode == null && Exploration.Includes(parent + ".returnCode", true))
        {
            this.ReturnCode = new System.Int64();
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = true;
        }
        //      C# -> MosaicRecoverableRangeObject? Data
        // GraphQL -> data: MosaicRecoverableRangeObject (type)
        if (this.Data == null && Exploration.Includes(parent + ".data"))
        {
            this.Data = new MosaicRecoverableRangeObject();
            this.Data.ApplyExploratoryFieldSpec(parent + ".data");
        }
    }


    #endregion

    } // class GetMosaicRecoverableRangeResponse
    
    #endregion

    public static class ListGetMosaicRecoverableRangeResponseExtensions
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
            this List<GetMosaicRecoverableRangeResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetMosaicRecoverableRangeResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetMosaicRecoverableRangeResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types