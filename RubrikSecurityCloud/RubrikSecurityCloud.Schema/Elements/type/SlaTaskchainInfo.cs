// SlaTaskchainInfo.cs
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
    #region SlaTaskchainInfo
    public class SlaTaskchainInfo: BaseType
    {
        #region members

        //      C# -> System.String? ErrMsg
        // GraphQL -> errMsg: String! (scalar)
        [JsonProperty("errMsg")]
        public System.String? ErrMsg { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaTaskchainInfo";
    }

    public SlaTaskchainInfo Set(
        System.String? ErrMsg = null,
        System.String? SlaId = null,
        System.String? TaskchainId = null
    ) 
    {
        if ( ErrMsg != null ) {
            this.ErrMsg = ErrMsg;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
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
        //      C# -> System.String? ErrMsg
        // GraphQL -> errMsg: String! (scalar)
        if (this.ErrMsg != null) {
            s += ind + "errMsg\n" ;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId != null) {
            s += ind + "slaId\n" ;
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId != null) {
            s += ind + "taskchainId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ErrMsg
        // GraphQL -> errMsg: String! (scalar)
        if (this.ErrMsg == null && Exploration.Includes(parent + ".errMsg", true))
        {
            this.ErrMsg = "FETCH";
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String! (scalar)
        if (this.SlaId == null && Exploration.Includes(parent + ".slaId", true))
        {
            this.SlaId = "FETCH";
        }
        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId", true))
        {
            this.TaskchainId = "FETCH";
        }
    }


    #endregion

    } // class SlaTaskchainInfo
    
    #endregion

    public static class ListSlaTaskchainInfoExtensions
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
            this List<SlaTaskchainInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SlaTaskchainInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaTaskchainInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types