// MosaicStoreConnectionParameters.cs
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
    #region MosaicStoreConnectionParameters
    public class MosaicStoreConnectionParameters: BaseType
    {
        #region members

        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        [JsonProperty("nfsServer")]
        public System.String? NfsServer { get; set; }

        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        [JsonProperty("nfsServerMountPath")]
        public System.String? NfsServerMountPath { get; set; }

        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        [JsonProperty("storeUrl")]
        public System.String? StoreUrl { get; set; }


        #endregion

    #region methods

    public MosaicStoreConnectionParameters Set(
        System.String? NfsServer = null,
        System.String? NfsServerMountPath = null,
        System.String? StoreUrl = null
    ) 
    {
        if ( NfsServer != null ) {
            this.NfsServer = NfsServer;
        }
        if ( NfsServerMountPath != null ) {
            this.NfsServerMountPath = NfsServerMountPath;
        }
        if ( StoreUrl != null ) {
            this.StoreUrl = StoreUrl;
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
        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        if (this.NfsServer != null) {
            s += ind + "nfsServer\n" ;
        }
        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        if (this.NfsServerMountPath != null) {
            s += ind + "nfsServerMountPath\n" ;
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl != null) {
            s += ind + "storeUrl\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NfsServer
        // GraphQL -> nfsServer: String! (scalar)
        if (this.NfsServer == null && Exploration.Includes(parent + ".nfsServer", true))
        {
            this.NfsServer = new System.String("FETCH");
        }
        //      C# -> System.String? NfsServerMountPath
        // GraphQL -> nfsServerMountPath: String! (scalar)
        if (this.NfsServerMountPath == null && Exploration.Includes(parent + ".nfsServerMountPath", true))
        {
            this.NfsServerMountPath = new System.String("FETCH");
        }
        //      C# -> System.String? StoreUrl
        // GraphQL -> storeUrl: String! (scalar)
        if (this.StoreUrl == null && Exploration.Includes(parent + ".storeUrl", true))
        {
            this.StoreUrl = new System.String("FETCH");
        }
    }


    #endregion

    } // class MosaicStoreConnectionParameters
    
    #endregion

    public static class ListMosaicStoreConnectionParametersExtensions
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
            this List<MosaicStoreConnectionParameters> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStoreConnectionParameters> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStoreConnectionParameters());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types