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

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        [JsonProperty("objectType")]
        SharePointDescendantType? ObjectType { get; set; }

        //      C# -> DateTime? CreateTime
        // GraphQL -> createTime: DateTime (scalar)
        [JsonProperty("createTime")]
        DateTime? CreateTime { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        System.String? Fid { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        DateTime? ModifiedTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        System.String? Name { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        [JsonProperty("parentId")]
        System.String? ParentId { get; set; }

        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        [JsonProperty("sharepointId")]
        System.String? SharepointId { get; set; }

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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<O365FullSpObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            string ind = conf.IndentStr();
            string fieldspecs = "";
            foreach (O365FullSpObject item in list) 
            {
                var fspec = item.AsFieldSpec(conf.Child(ignoreComposition: true));
                string typename;
                if (item is BaseType bt) {
                    typename = bt.GetGqlTypeName();
                } else {
                    typename = item.GetType().Name;
                }
                string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
                if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                    if ( conf.Flat ) {
                        fieldspecs += conf.Prefix + fspec;
                    } else {
                        fieldspecs += ind + " ... on " + typename + " {\n" + fspec + ind + "}\n";
                    }
                }
            }
            return fieldspecs; // L-II
        }

        public static List<string> SelectedFields(this List<O365FullSpObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365FullSpObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<O365FullSpObject>(
                        list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (O365FullSpObject item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void SelectForRetrieval(this List<O365FullSpObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types