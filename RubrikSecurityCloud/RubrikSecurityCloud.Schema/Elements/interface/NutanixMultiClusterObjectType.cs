// NutanixMultiClusterObjectType.cs
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
    #region NutanixMultiClusterObjectType

    public interface NutanixMultiClusterObjectType: IFieldSpec
    {
        #region members

        //      C# -> System.Int32? DuplicateObjectsAbsoluteCount
        // GraphQL -> duplicateObjectsAbsoluteCount: Int! (scalar)
        [JsonProperty("duplicateObjectsAbsoluteCount")]
        System.Int32? DuplicateObjectsAbsoluteCount { get; set; }

        //      C# -> List<CdmHierarchyObject>? DuplicateObjects
        // GraphQL -> duplicateObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("duplicateObjects")]
        List<CdmHierarchyObject>? DuplicateObjects { get; set; }


        #endregion

    } // interface NutanixMultiClusterObjectType

    #endregion



    public static class ListNutanixMultiClusterObjectTypeExtensions
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
            this List<NutanixMultiClusterObjectType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            string ind = conf.IndentStr();
            string fieldspecs = "";
            foreach (NutanixMultiClusterObjectType item in list) 
            {
                var fspec = item.AsFieldSpec(conf.Child());
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
            return fieldspecs;
        }

        public static List<string> SelectedFields(this List<NutanixMultiClusterObjectType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixMultiClusterObjectType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<NutanixMultiClusterObjectType>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(ec));
            } else {
                foreach (NutanixMultiClusterObjectType item in list) {
                    item.ApplyExploratoryFieldSpec(ec);
                }
            }

        }

        public static void SelectForRetrieval(this List<NutanixMultiClusterObjectType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types