// CertificateClusterOperationError.cs
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
    #region CertificateClusterOperationError
    public class CertificateClusterOperationError: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? IsTimedOut
        // GraphQL -> isTimedOut: Boolean! (scalar)
        [JsonProperty("isTimedOut")]
        public System.Boolean? IsTimedOut { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CertificateClusterOperationError";
    }

    public CertificateClusterOperationError Set(
        System.String? ClusterUuid = null,
        System.String? Error = null,
        System.Boolean? IsTimedOut = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( IsTimedOut != null ) {
            this.IsTimedOut = IsTimedOut;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> System.Boolean? IsTimedOut
        // GraphQL -> isTimedOut: Boolean! (scalar)
        if (this.IsTimedOut != null) {
            s += ind + "isTimedOut\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && ec.Includes("clusterUuid",true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && ec.Includes("error",true))
        {
            this.Error = "FETCH";
        }
        //      C# -> System.Boolean? IsTimedOut
        // GraphQL -> isTimedOut: Boolean! (scalar)
        if (this.IsTimedOut == null && ec.Includes("isTimedOut",true))
        {
            this.IsTimedOut = true;
        }
    }


    #endregion

    } // class CertificateClusterOperationError
    
    #endregion

    public static class ListCertificateClusterOperationErrorExtensions
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
            this List<CertificateClusterOperationError> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CertificateClusterOperationError> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CertificateClusterOperationError());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CertificateClusterOperationError> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types