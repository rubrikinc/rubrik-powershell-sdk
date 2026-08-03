// AppAccessCounts.cs
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
    #region AppAccessCounts
    public class AppAccessCounts: BaseType
    {
        #region members

        //      C# -> System.Int32? DirectAppCount
        // GraphQL -> directAppCount: Int! (scalar)
        [JsonProperty("directAppCount")]
        public System.Int32? DirectAppCount { get; set; }

        //      C# -> System.Int32? GroupCount
        // GraphQL -> groupCount: Int! (scalar)
        [JsonProperty("groupCount")]
        public System.Int32? GroupCount { get; set; }

        //      C# -> System.Int32? IndirectAppCount
        // GraphQL -> indirectAppCount: Int! (scalar)
        [JsonProperty("indirectAppCount")]
        public System.Int32? IndirectAppCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AppAccessCounts";
    }

    public AppAccessCounts Set(
        System.Int32? DirectAppCount = null,
        System.Int32? GroupCount = null,
        System.Int32? IndirectAppCount = null
    ) 
    {
        if ( DirectAppCount != null ) {
            this.DirectAppCount = DirectAppCount;
        }
        if ( GroupCount != null ) {
            this.GroupCount = GroupCount;
        }
        if ( IndirectAppCount != null ) {
            this.IndirectAppCount = IndirectAppCount;
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
        //      C# -> System.Int32? DirectAppCount
        // GraphQL -> directAppCount: Int! (scalar)
        if (this.DirectAppCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directAppCount\n" ;
            } else {
                s += ind + "directAppCount\n" ;
            }
        }
        //      C# -> System.Int32? GroupCount
        // GraphQL -> groupCount: Int! (scalar)
        if (this.GroupCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupCount\n" ;
            } else {
                s += ind + "groupCount\n" ;
            }
        }
        //      C# -> System.Int32? IndirectAppCount
        // GraphQL -> indirectAppCount: Int! (scalar)
        if (this.IndirectAppCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indirectAppCount\n" ;
            } else {
                s += ind + "indirectAppCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? DirectAppCount
        // GraphQL -> directAppCount: Int! (scalar)
        if (ec.Includes("directAppCount",true))
        {
            if(this.DirectAppCount == null) {

                this.DirectAppCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DirectAppCount != null && ec.Excludes("directAppCount",true))
        {
            this.DirectAppCount = null;
        }
        //      C# -> System.Int32? GroupCount
        // GraphQL -> groupCount: Int! (scalar)
        if (ec.Includes("groupCount",true))
        {
            if(this.GroupCount == null) {

                this.GroupCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.GroupCount != null && ec.Excludes("groupCount",true))
        {
            this.GroupCount = null;
        }
        //      C# -> System.Int32? IndirectAppCount
        // GraphQL -> indirectAppCount: Int! (scalar)
        if (ec.Includes("indirectAppCount",true))
        {
            if(this.IndirectAppCount == null) {

                this.IndirectAppCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.IndirectAppCount != null && ec.Excludes("indirectAppCount",true))
        {
            this.IndirectAppCount = null;
        }
    }


    #endregion

    } // class AppAccessCounts
    
    #endregion

    public static class ListAppAccessCountsExtensions
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
            this List<AppAccessCounts> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AppAccessCounts> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AppAccessCounts> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AppAccessCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AppAccessCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types