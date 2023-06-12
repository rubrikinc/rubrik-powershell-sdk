// BlueprintFailover.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region BlueprintFailover
    public class BlueprintFailover: BaseType
    {
        #region members

        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        [JsonProperty("failoverType")]
        public FailoverTypeEnum? FailoverType { get; set; }

        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        [JsonProperty("status")]
        public FailoverStatusEnum? Status { get; set; }

        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        [JsonProperty("failoverId")]
        public System.String? FailoverId { get; set; }


        #endregion

    #region methods

    public BlueprintFailover Set(
        FailoverTypeEnum? FailoverType = null,
        FailoverStatusEnum? Status = null,
        System.String? FailoverId = null
    ) 
    {
        if ( FailoverType != null ) {
            this.FailoverType = FailoverType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( FailoverId != null ) {
            this.FailoverId = FailoverId;
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
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType != null) {
            s += ind + "failoverType\n" ;
        }
        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        if (this.FailoverId != null) {
            s += ind + "failoverId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> FailoverTypeEnum? FailoverType
        // GraphQL -> failoverType: FailoverTypeEnum! (enum)
        if (this.FailoverType == null && Exploration.Includes(parent + ".failoverType", true))
        {
            this.FailoverType = new FailoverTypeEnum();
        }
        //      C# -> FailoverStatusEnum? Status
        // GraphQL -> status: FailoverStatusEnum! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new FailoverStatusEnum();
        }
        //      C# -> System.String? FailoverId
        // GraphQL -> failoverId: String! (scalar)
        if (this.FailoverId == null && Exploration.Includes(parent + ".failoverId", true))
        {
            this.FailoverId = "FETCH";
        }
    }


    #endregion

    } // class BlueprintFailover
    
    #endregion

    public static class ListBlueprintFailoverExtensions
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
            this List<BlueprintFailover> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintFailover> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintFailover());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types