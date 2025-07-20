// NamespaceOverrides.cs
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
    #region NamespaceOverrides
    public class NamespaceOverrides: BaseType
    {
        #region members

        //      C# -> List<DataHosts>? DataHostsMap
        // GraphQL -> dataHostsMap: [DataHosts!] (type)
        [JsonProperty("dataHostsMap")]
        public List<DataHosts>? DataHostsMap { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NamespaceOverrides";
    }

    public NamespaceOverrides Set(
        List<DataHosts>? DataHostsMap = null
    ) 
    {
        if ( DataHostsMap != null ) {
            this.DataHostsMap = DataHostsMap;
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
        //      C# -> List<DataHosts>? DataHostsMap
        // GraphQL -> dataHostsMap: [DataHosts!] (type)
        if (this.DataHostsMap != null) {
            var fspec = this.DataHostsMap.AsFieldSpec(conf.Child("dataHostsMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataHostsMap" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<DataHosts>? DataHostsMap
        // GraphQL -> dataHostsMap: [DataHosts!] (type)
        if (ec.Includes("dataHostsMap",false))
        {
            if(this.DataHostsMap == null) {

                this.DataHostsMap = new List<DataHosts>();
                this.DataHostsMap.ApplyExploratoryFieldSpec(ec.NewChild("dataHostsMap"));

            } else {

                this.DataHostsMap.ApplyExploratoryFieldSpec(ec.NewChild("dataHostsMap"));

            }
        }
        else if (this.DataHostsMap != null && ec.Excludes("dataHostsMap",false))
        {
            this.DataHostsMap = null;
        }
    }


    #endregion

    } // class NamespaceOverrides
    
    #endregion

    public static class ListNamespaceOverridesExtensions
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
            this List<NamespaceOverrides> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NamespaceOverrides> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NamespaceOverrides> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NamespaceOverrides());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NamespaceOverrides> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types