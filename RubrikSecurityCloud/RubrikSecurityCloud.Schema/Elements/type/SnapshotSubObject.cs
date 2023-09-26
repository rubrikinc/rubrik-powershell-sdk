// SnapshotSubObject.cs
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
    #region SnapshotSubObject
    public class SnapshotSubObject: BaseType
    {
        #region members

        //      C# -> SnapshotSubObj? SubObj
        // GraphQL -> subObj: SnapshotSubObj! (type)
        [JsonProperty("subObj")]
        public SnapshotSubObj? SubObj { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotSubObject";
    }

    public SnapshotSubObject Set(
        SnapshotSubObj? SubObj = null
    ) 
    {
        if ( SubObj != null ) {
            this.SubObj = SubObj;
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
        //      C# -> SnapshotSubObj? SubObj
        // GraphQL -> subObj: SnapshotSubObj! (type)
        if (this.SubObj != null) {
            var fspec = this.SubObj.AsFieldSpec(conf.Child("subObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subObj {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SnapshotSubObj? SubObj
        // GraphQL -> subObj: SnapshotSubObj! (type)
        if (ec.Includes("subObj",false))
        {
            if(this.SubObj == null) {

                this.SubObj = new SnapshotSubObj();
                this.SubObj.ApplyExploratoryFieldSpec(ec.NewChild("subObj"));

            } else {

                this.SubObj.ApplyExploratoryFieldSpec(ec.NewChild("subObj"));

            }
        }
        else if (this.SubObj != null && ec.Excludes("subObj",false))
        {
            this.SubObj = null;
        }
    }


    #endregion

    } // class SnapshotSubObject
    
    #endregion

    public static class ListSnapshotSubObjectExtensions
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
            this List<SnapshotSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSubObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSubObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSubObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types