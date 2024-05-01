// MssqlRootProperties.cs
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
    #region MssqlRootProperties
    public class MssqlRootProperties: BaseType
    {
        #region members

        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        [JsonProperty("rootType")]
        public MssqlRootPropertiesRootType? RootType { get; set; }

        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        [JsonProperty("rootId")]
        public System.String? RootId { get; set; }

        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        [JsonProperty("rootName")]
        public System.String? RootName { get; set; }

        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        [JsonProperty("rootRole")]
        public System.String? RootRole { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlRootProperties";
    }

    public MssqlRootProperties Set(
        MssqlRootPropertiesRootType? RootType = null,
        System.String? RootId = null,
        System.String? RootName = null,
        System.String? RootRole = null
    ) 
    {
        if ( RootType != null ) {
            this.RootType = RootType;
        }
        if ( RootId != null ) {
            this.RootId = RootId;
        }
        if ( RootName != null ) {
            this.RootName = RootName;
        }
        if ( RootRole != null ) {
            this.RootRole = RootRole;
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
        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        if (this.RootType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootType\n" ;
            } else {
                s += ind + "rootType\n" ;
            }
        }
        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        if (this.RootId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootId\n" ;
            } else {
                s += ind + "rootId\n" ;
            }
        }
        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        if (this.RootName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootName\n" ;
            } else {
                s += ind + "rootName\n" ;
            }
        }
        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        if (this.RootRole != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootRole\n" ;
            } else {
                s += ind + "rootRole\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        if (ec.Includes("rootType",true))
        {
            if(this.RootType == null) {

                this.RootType = new MssqlRootPropertiesRootType();

            } else {


            }
        }
        else if (this.RootType != null && ec.Excludes("rootType",true))
        {
            this.RootType = null;
        }
        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        if (ec.Includes("rootId",true))
        {
            if(this.RootId == null) {

                this.RootId = "FETCH";

            } else {


            }
        }
        else if (this.RootId != null && ec.Excludes("rootId",true))
        {
            this.RootId = null;
        }
        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        if (ec.Includes("rootName",true))
        {
            if(this.RootName == null) {

                this.RootName = "FETCH";

            } else {


            }
        }
        else if (this.RootName != null && ec.Excludes("rootName",true))
        {
            this.RootName = null;
        }
        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        if (ec.Includes("rootRole",true))
        {
            if(this.RootRole == null) {

                this.RootRole = "FETCH";

            } else {


            }
        }
        else if (this.RootRole != null && ec.Excludes("rootRole",true))
        {
            this.RootRole = null;
        }
    }


    #endregion

    } // class MssqlRootProperties
    
    #endregion

    public static class ListMssqlRootPropertiesExtensions
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
            this List<MssqlRootProperties> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MssqlRootProperties> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlRootProperties> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlRootProperties());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlRootProperties> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types