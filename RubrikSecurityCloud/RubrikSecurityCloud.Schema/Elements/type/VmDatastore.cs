// VmDatastore.cs
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
    #region VmDatastore
    public class VmDatastore: BaseType
    {
        #region members

        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        [JsonProperty("datastoreId")]
        public System.String? DatastoreId { get; set; }

        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        [JsonProperty("datastoreName")]
        public System.String? DatastoreName { get; set; }


        #endregion

    #region methods

    public VmDatastore Set(
        System.String? DatastoreId = null,
        System.String? DatastoreName = null
    ) 
    {
        if ( DatastoreId != null ) {
            this.DatastoreId = DatastoreId;
        }
        if ( DatastoreName != null ) {
            this.DatastoreName = DatastoreName;
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
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (this.DatastoreId != null) {
            s += ind + "datastoreId\n" ;
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName != null) {
            s += ind + "datastoreName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DatastoreId
        // GraphQL -> datastoreId: String! (scalar)
        if (this.DatastoreId == null && Exploration.Includes(parent + ".datastoreId", true))
        {
            this.DatastoreId = new System.String("FETCH");
        }
        //      C# -> System.String? DatastoreName
        // GraphQL -> datastoreName: String! (scalar)
        if (this.DatastoreName == null && Exploration.Includes(parent + ".datastoreName", true))
        {
            this.DatastoreName = new System.String("FETCH");
        }
    }


    #endregion

    } // class VmDatastore
    
    #endregion

    public static class ListVmDatastoreExtensions
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
            this List<VmDatastore> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VmDatastore> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VmDatastore());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types