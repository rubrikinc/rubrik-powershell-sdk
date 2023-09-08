// O365FullSpObject.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region O365FullSpObject

    public interface O365FullSpObject: IFieldSpec
    {
        #region members

        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        [JsonProperty("sharepointId")]
        System.String? SharepointId { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        System.String? Fid { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        [JsonProperty("parentId")]
        System.String? ParentId { get; set; }

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        [JsonProperty("objectType")]
        SharePointDescendantType? ObjectType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        System.String? Name { get; set; }

        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        [JsonProperty("createTime")]
        DateTime? CreateTime { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        DateTime? ModifiedTime { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        System.String? SnapshotId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        System.Int32? SnapshotNum { get; set; }


        #endregion

    } // interface O365FullSpObject

    #endregion



    public static class ListO365FullSpObjectExtensions
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
            this List<O365FullSpObject> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (O365FullSpObject item in list) 
            {
                var fspec = item.AsFieldSpec(indent+1);
                string typename;
                if (item is BaseType bt) {
                    typename = bt.GetGqlTypeName();
                } else {
                    typename = item.GetType().Name;
                }
                if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                    fieldspecs += ind + " ... on " + typename + " {\n" + fspec + ind + "}\n";
                }
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365FullSpObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<O365FullSpObject>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (O365FullSpObject item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void Fetch(this List<O365FullSpObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types