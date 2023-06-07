// GcpCloudAccountProjectUpgradeStatus.cs
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
    #region GcpCloudAccountProjectUpgradeStatus
    public class GcpCloudAccountProjectUpgradeStatus: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        [JsonProperty("projectUuid")]
        public System.String? ProjectUuid { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }


        #endregion

    #region methods

    public GcpCloudAccountProjectUpgradeStatus Set(
        System.String? Error = null,
        System.String? ProjectUuid = null,
        System.Boolean? Success = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( ProjectUuid != null ) {
            this.ProjectUuid = ProjectUuid;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        if (this.ProjectUuid != null) {
            s += ind + "projectUuid\n" ;
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
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && Exploration.Includes(parent + ".error", true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.String? ProjectUuid
        // GraphQL -> projectUuid: String! (scalar)
        if (this.ProjectUuid == null && Exploration.Includes(parent + ".projectUuid", true))
        {
            this.ProjectUuid = "FETCH";
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success == null && Exploration.Includes(parent + ".success", true))
        {
            this.Success = true;
        }
    }


    #endregion

    } // class GcpCloudAccountProjectUpgradeStatus
    
    #endregion

    public static class ListGcpCloudAccountProjectUpgradeStatusExtensions
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
            this List<GcpCloudAccountProjectUpgradeStatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountProjectUpgradeStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountProjectUpgradeStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types