// AwsExocomputeConfigsDeletionStatusType.cs
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
    #region AwsExocomputeConfigsDeletionStatusType
    public class AwsExocomputeConfigsDeletionStatusType: BaseType
    {
        #region members

        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: String! (scalar)
        [JsonProperty("exocomputeConfigId")]
        public System.String? ExocomputeConfigId { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsExocomputeConfigsDeletionStatusType";
    }

    public AwsExocomputeConfigsDeletionStatusType Set(
        System.String? ExocomputeConfigId = null,
        System.Boolean? Success = null
    ) 
    {
        if ( ExocomputeConfigId != null ) {
            this.ExocomputeConfigId = ExocomputeConfigId;
        }
        if ( Success != null ) {
            this.Success = Success;
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
        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: String! (scalar)
        if (this.ExocomputeConfigId != null) {
            s += ind + "exocomputeConfigId\n" ;
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success != null) {
            s += ind + "success\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ExocomputeConfigId
        // GraphQL -> exocomputeConfigId: String! (scalar)
        if (this.ExocomputeConfigId == null && Exploration.Includes(parent + ".exocomputeConfigId", true))
        {
            this.ExocomputeConfigId = "FETCH";
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success == null && Exploration.Includes(parent + ".success", true))
        {
            this.Success = true;
        }
    }


    #endregion

    } // class AwsExocomputeConfigsDeletionStatusType
    
    #endregion

    public static class ListAwsExocomputeConfigsDeletionStatusTypeExtensions
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
            this List<AwsExocomputeConfigsDeletionStatusType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsExocomputeConfigsDeletionStatusType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsExocomputeConfigsDeletionStatusType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types