// ClusterLicenseCapacityValidations.cs
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
    #region ClusterLicenseCapacityValidations
    public class ClusterLicenseCapacityValidations: BaseType
    {
        #region members

        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        [JsonProperty("errors")]
        public List<ClusterLicenseInfo>? Errors { get; set; }

        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        [JsonProperty("warnings")]
        public List<ClusterLicenseInfo>? Warnings { get; set; }


        #endregion

    #region methods

    public ClusterLicenseCapacityValidations Set(
        List<ClusterLicenseInfo>? Errors = null,
        List<ClusterLicenseInfo>? Warnings = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( Warnings != null ) {
            this.Warnings = Warnings;
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
        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        if (this.Errors != null) {
            var fspec = this.Errors.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "errors {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        if (this.Warnings != null) {
            var fspec = this.Warnings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "warnings {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        if (this.Errors == null && Exploration.Includes(parent + ".errors"))
        {
            this.Errors = new List<ClusterLicenseInfo>();
            this.Errors.ApplyExploratoryFieldSpec(parent + ".errors");
        }
        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        if (this.Warnings == null && Exploration.Includes(parent + ".warnings"))
        {
            this.Warnings = new List<ClusterLicenseInfo>();
            this.Warnings.ApplyExploratoryFieldSpec(parent + ".warnings");
        }
    }


    #endregion

    } // class ClusterLicenseCapacityValidations
    
    #endregion

    public static class ListClusterLicenseCapacityValidationsExtensions
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
            this List<ClusterLicenseCapacityValidations> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterLicenseCapacityValidations> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterLicenseCapacityValidations());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types