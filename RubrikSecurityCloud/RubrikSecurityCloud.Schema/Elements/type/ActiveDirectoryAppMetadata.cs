// ActiveDirectoryAppMetadata.cs
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
    #region ActiveDirectoryAppMetadata
    public class ActiveDirectoryAppMetadata: BaseType
    {
        #region members

        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        [JsonProperty("objectsCount")]
        public ActiveDirectoryObjectsCount? ObjectsCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryAppMetadata";
    }

    public ActiveDirectoryAppMetadata Set(
        ActiveDirectoryObjectsCount? ObjectsCount = null
    ) 
    {
        if ( ObjectsCount != null ) {
            this.ObjectsCount = ObjectsCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (this.ObjectsCount != null) {
            var fspec = this.ObjectsCount.AsFieldSpec(conf.Child("objectsCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectsCount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActiveDirectoryObjectsCount? ObjectsCount
        // GraphQL -> objectsCount: ActiveDirectoryObjectsCount (type)
        if (ec.Includes("objectsCount",false))
        {
            if(this.ObjectsCount == null) {

                this.ObjectsCount = new ActiveDirectoryObjectsCount();
                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            } else {

                this.ObjectsCount.ApplyExploratoryFieldSpec(ec.NewChild("objectsCount"));

            }
        }
        else if (this.ObjectsCount != null && ec.Excludes("objectsCount",false))
        {
            this.ObjectsCount = null;
        }
    }


    #endregion

    } // class ActiveDirectoryAppMetadata
    
    #endregion

    public static class ListActiveDirectoryAppMetadataExtensions
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
            this List<ActiveDirectoryAppMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryAppMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryAppMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryAppMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryAppMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types