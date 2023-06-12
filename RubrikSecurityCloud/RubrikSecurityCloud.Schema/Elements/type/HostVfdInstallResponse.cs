// HostVfdInstallResponse.cs
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
    #region HostVfdInstallResponse
    public class HostVfdInstallResponse: BaseType
    {
        #region members

        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        [JsonProperty("hostVfdDriverState")]
        public HostVfdState? HostVfdDriverState { get; set; }

        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        [JsonProperty("errorInfo")]
        public System.String? ErrorInfo { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }


        #endregion

    #region methods

    public HostVfdInstallResponse Set(
        HostVfdState? HostVfdDriverState = null,
        System.String? ErrorInfo = null,
        System.String? HostId = null
    ) 
    {
        if ( HostVfdDriverState != null ) {
            this.HostVfdDriverState = HostVfdDriverState;
        }
        if ( ErrorInfo != null ) {
            this.ErrorInfo = ErrorInfo;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
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
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState != null) {
            s += ind + "hostVfdDriverState\n" ;
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo != null) {
            s += ind + "errorInfo\n" ;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            s += ind + "hostId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> HostVfdState? HostVfdDriverState
        // GraphQL -> hostVfdDriverState: HostVfdState! (enum)
        if (this.HostVfdDriverState == null && Exploration.Includes(parent + ".hostVfdDriverState", true))
        {
            this.HostVfdDriverState = new HostVfdState();
        }
        //      C# -> System.String? ErrorInfo
        // GraphQL -> errorInfo: String (scalar)
        if (this.ErrorInfo == null && Exploration.Includes(parent + ".errorInfo", true))
        {
            this.ErrorInfo = "FETCH";
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId == null && Exploration.Includes(parent + ".hostId", true))
        {
            this.HostId = "FETCH";
        }
    }


    #endregion

    } // class HostVfdInstallResponse
    
    #endregion

    public static class ListHostVfdInstallResponseExtensions
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
            this List<HostVfdInstallResponse> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostVfdInstallResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HostVfdInstallResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types