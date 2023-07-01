// VcenterPatch.cs
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
    #region VcenterPatch
    public class VcenterPatch: BaseType
    {
        #region members

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VcenterPatch";
    }

    public VcenterPatch Set(
        System.String? CaCerts = null,
        System.String? ConfiguredSlaDomainId = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
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
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts != null) {
            s += ind + "caCerts\n" ;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            s += ind + "configuredSlaDomainId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts", true))
        {
            this.CaCerts = "FETCH";
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId", true))
        {
            this.ConfiguredSlaDomainId = "FETCH";
        }
    }


    #endregion

    } // class VcenterPatch
    
    #endregion

    public static class ListVcenterPatchExtensions
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
            this List<VcenterPatch> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcenterPatch> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcenterPatch());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types