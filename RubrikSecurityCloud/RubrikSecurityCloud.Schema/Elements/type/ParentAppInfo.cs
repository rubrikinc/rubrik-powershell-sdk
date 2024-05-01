// ParentAppInfo.cs
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
    #region ParentAppInfo
    public class ParentAppInfo: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        [JsonProperty("isProtectedThruHierarchy")]
        public System.Boolean? IsProtectedThruHierarchy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ParentAppInfo";
    }

    public ParentAppInfo Set(
        System.String? Id = null,
        System.Boolean? IsProtectedThruHierarchy = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsProtectedThruHierarchy != null ) {
            this.IsProtectedThruHierarchy = IsProtectedThruHierarchy;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        if (this.IsProtectedThruHierarchy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isProtectedThruHierarchy\n" ;
            } else {
                s += ind + "isProtectedThruHierarchy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        if (ec.Includes("isProtectedThruHierarchy",true))
        {
            if(this.IsProtectedThruHierarchy == null) {

                this.IsProtectedThruHierarchy = true;

            } else {


            }
        }
        else if (this.IsProtectedThruHierarchy != null && ec.Excludes("isProtectedThruHierarchy",true))
        {
            this.IsProtectedThruHierarchy = null;
        }
    }


    #endregion

    } // class ParentAppInfo
    
    #endregion

    public static class ListParentAppInfoExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ParentAppInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ParentAppInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ParentAppInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ParentAppInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ParentAppInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types