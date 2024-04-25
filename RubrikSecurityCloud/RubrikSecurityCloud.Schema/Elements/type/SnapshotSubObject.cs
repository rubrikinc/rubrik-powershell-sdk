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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotSubObj? SubObj
        // GraphQL -> subObj: SnapshotSubObj! (type)
        if (this.SubObj != null) {
            var fspec = this.SubObj.AsFieldSpec(conf.Child("subObj"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subObj" + " " + "{\n" + fspec + ind + "}\n" ;
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
            this List<SnapshotSubObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotSubObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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