// MountDiskReply.cs
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
    #region MountDiskReply
    public class MountDiskReply: BaseType
    {
        #region members

        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: UUID! (scalar)
        [JsonProperty("taskchainUuid")]
        public System.String? TaskchainUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MountDiskReply";
    }

    public MountDiskReply Set(
        System.String? TaskchainUuid = null
    ) 
    {
        if ( TaskchainUuid != null ) {
            this.TaskchainUuid = TaskchainUuid;
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
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: UUID! (scalar)
        if (this.TaskchainUuid != null) {
            s += ind + "taskchainUuid\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? TaskchainUuid
        // GraphQL -> taskchainUuid: UUID! (scalar)
        if (this.TaskchainUuid == null && ec.Includes("taskchainUuid",true))
        {
            this.TaskchainUuid = "FETCH";
        }
    }


    #endregion

    } // class MountDiskReply
    
    #endregion

    public static class ListMountDiskReplyExtensions
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
            this List<MountDiskReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MountDiskReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MountDiskReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MountDiskReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types