// ExocomputeStorageAccountIds.cs
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
    #region ExocomputeStorageAccountIds
    public class ExocomputeStorageAccountIds: BaseType
    {
        #region members

        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        [JsonProperty("ids")]
        public List<System.String>? Ids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExocomputeStorageAccountIds";
    }

    public ExocomputeStorageAccountIds Set(
        List<System.String>? Ids = null
    ) 
    {
        if ( Ids != null ) {
            this.Ids = Ids;
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
        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        if (this.Ids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ids\n" ;
            } else {
                s += ind + "ids\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        if (ec.Includes("ids",true))
        {
            if(this.Ids == null) {

                this.Ids = new List<System.String>();

            } else {


            }
        }
        else if (this.Ids != null && ec.Excludes("ids",true))
        {
            this.Ids = null;
        }
    }


    #endregion

    } // class ExocomputeStorageAccountIds
    
    #endregion

    public static class ListExocomputeStorageAccountIdsExtensions
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
            this List<ExocomputeStorageAccountIds> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExocomputeStorageAccountIds> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeStorageAccountIds> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeStorageAccountIds());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExocomputeStorageAccountIds> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types