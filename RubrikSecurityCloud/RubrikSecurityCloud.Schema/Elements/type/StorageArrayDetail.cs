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

namespace Rubrik.SecurityCloud.Types
{
    #region StorageArrayDetail
    public class StorageArrayDetail: IFragment
    {
        #region members
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

        //      C# -> StorageArrayType? ArrayType
        // GraphQL -> arrayType: StorageArrayType! (enum)
        [JsonProperty("arrayType")]
        public StorageArrayType? ArrayType { get; set; }

        #endregion

    #region methods

    public StorageArrayDetail Set(
        System.String? CaCerts = null,
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? Username = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        StorageArrayType? ArrayType = null
    ) 
    {
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
        if ( ArrayType != null ) {
            this.ArrayType = ArrayType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String (scalar)
            if (this.CaCerts != null)
            {
                 s += ind + "caCerts\n";

            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname != null)
            {
                 s += ind + "hostname\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus != null)
            {
                 s += ind + "connectionStatus\n";

                 s += ind + "{\n" + 
                 this.ConnectionStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> StorageArrayType? ArrayType
            // GraphQL -> arrayType: StorageArrayType! (enum)
            if (this.ArrayType != null)
            {
                 s += ind + "arrayType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String (scalar)
            if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts$"))
            {
                this.CaCerts = new System.String("FETCH");
            }
            //      C# -> System.String? Hostname
            // GraphQL -> hostname: String! (scalar)
            if (this.Hostname == null && Exploration.Includes(parent + ".hostname$"))
            {
                this.Hostname = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
            // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
            if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus"))
            {
                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFragment(parent + ".connectionStatus");
            }
            //      C# -> StorageArrayType? ArrayType
            // GraphQL -> arrayType: StorageArrayType! (enum)
            if (this.ArrayType == null && Exploration.Includes(parent + ".arrayType$"))
            {
                this.ArrayType = new StorageArrayType();
            }
        }


    #endregion

    } // class StorageArrayDetail
    #endregion

    public static class ListStorageArrayDetailExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<StorageArrayDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StorageArrayDetail> list, 
            String parent = "")
        {
            var item = new StorageArrayDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types