// StorageArrayDetail.cs
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
    #region StorageArrayDetail
    public class StorageArrayDetail: BaseType
    {
        #region members

        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        [JsonProperty("arrayType")]
        public StorageArrayType? ArrayType { get; set; }

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }


        #endregion

    #region methods

    public StorageArrayDetail Set(
        StorageArrayType? ArrayType = null,
        System.String? CaCerts = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Username = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null
    ) 
    {
        if ( ArrayType != null ) {
            this.ArrayType = ArrayType;
        }
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
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
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (this.ArrayType != null) {
            s += ind + "arrayType\n" ;
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts != null) {
            s += ind + "caCerts\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            s += ind + "username\n" ;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus {\n" + this.ConnectionStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        if (this.ArrayType == null && Exploration.Includes(parent + ".arrayType", true))
        {
            this.ArrayType = new StorageArrayType();
        }
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts", true))
        {
            this.CaCerts = new System.String("FETCH");
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username == null && Exploration.Includes(parent + ".username", true))
        {
            this.Username = new System.String("FETCH");
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
        {
            this.ConnectionStatus = new RefreshableObjectConnectionStatus();
            this.ConnectionStatus.ApplyExploratoryFieldSpec(parent + ".connectionStatus");
        }
    }


    #endregion

    } // class StorageArrayDetail
    
    #endregion

    public static class ListStorageArrayDetailExtensions
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
            this List<StorageArrayDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<StorageArrayDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new StorageArrayDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types