// CheckAzurePersistentStorageSubscriptionCanUnmapReply.cs
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
    #region CheckAzurePersistentStorageSubscriptionCanUnmapReply
    public class CheckAzurePersistentStorageSubscriptionCanUnmapReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? CanUnmap
        // GraphQL -> canUnmap: Boolean! (scalar)
        [JsonProperty("canUnmap")]
        public System.Boolean? CanUnmap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CheckAzurePersistentStorageSubscriptionCanUnmapReply";
    }

    public CheckAzurePersistentStorageSubscriptionCanUnmapReply Set(
        System.Boolean? CanUnmap = null
    ) 
    {
        if ( CanUnmap != null ) {
            this.CanUnmap = CanUnmap;
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
        //      C# -> System.Boolean? CanUnmap
        // GraphQL -> canUnmap: Boolean! (scalar)
        if (this.CanUnmap != null) {
            s += ind + "canUnmap\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? CanUnmap
        // GraphQL -> canUnmap: Boolean! (scalar)
        if (this.CanUnmap == null && ec.Includes("canUnmap",true))
        {
            this.CanUnmap = true;
        }
    }


    #endregion

    } // class CheckAzurePersistentStorageSubscriptionCanUnmapReply
    
    #endregion

    public static class ListCheckAzurePersistentStorageSubscriptionCanUnmapReplyExtensions
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
            this List<CheckAzurePersistentStorageSubscriptionCanUnmapReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CheckAzurePersistentStorageSubscriptionCanUnmapReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckAzurePersistentStorageSubscriptionCanUnmapReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CheckAzurePersistentStorageSubscriptionCanUnmapReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types