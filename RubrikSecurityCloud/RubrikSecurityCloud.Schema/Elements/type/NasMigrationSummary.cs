// NasMigrationSummary.cs
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
    #region NasMigrationSummary
    public class NasMigrationSummary: BaseType
    {
        #region members

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public NasMigrationSummary Set(
        System.String? FailureReason = null,
        System.String? ManagedId = null,
        System.String? Status = null
    ) 
    {
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            s += ind + "managedId\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason", true))
        {
            this.FailureReason = "FETCH";
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId == null && Exploration.Includes(parent + ".managedId", true))
        {
            this.ManagedId = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class NasMigrationSummary
    
    #endregion

    public static class ListNasMigrationSummaryExtensions
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
            this List<NasMigrationSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasMigrationSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NasMigrationSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types