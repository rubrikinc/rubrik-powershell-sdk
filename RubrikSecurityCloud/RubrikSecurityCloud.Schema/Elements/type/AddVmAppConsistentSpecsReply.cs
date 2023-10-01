// AddVmAppConsistentSpecsReply.cs
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
    #region AddVmAppConsistentSpecsReply
    public class AddVmAppConsistentSpecsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        [JsonProperty("failedSnappableIds")]
        public List<System.String>? FailedSnappableIds { get; set; }

        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        [JsonProperty("successSnappableIds")]
        public List<System.String>? SuccessSnappableIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddVmAppConsistentSpecsReply";
    }

    public AddVmAppConsistentSpecsReply Set(
        List<System.String>? FailedSnappableIds = null,
        List<System.String>? SuccessSnappableIds = null
    ) 
    {
        if ( FailedSnappableIds != null ) {
            this.FailedSnappableIds = FailedSnappableIds;
        }
        if ( SuccessSnappableIds != null ) {
            this.SuccessSnappableIds = SuccessSnappableIds;
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
        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        if (this.FailedSnappableIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedSnappableIds\n" ;
            } else {
                s += ind + "failedSnappableIds\n" ;
            }
        }
        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        if (this.SuccessSnappableIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successSnappableIds\n" ;
            } else {
                s += ind + "successSnappableIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? FailedSnappableIds
        // GraphQL -> failedSnappableIds: [String!]! (scalar)
        if (ec.Includes("failedSnappableIds",true))
        {
            if(this.FailedSnappableIds == null) {

                this.FailedSnappableIds = new List<System.String>();

            } else {


            }
        }
        else if (this.FailedSnappableIds != null && ec.Excludes("failedSnappableIds",true))
        {
            this.FailedSnappableIds = null;
        }
        //      C# -> List<System.String>? SuccessSnappableIds
        // GraphQL -> successSnappableIds: [String!]! (scalar)
        if (ec.Includes("successSnappableIds",true))
        {
            if(this.SuccessSnappableIds == null) {

                this.SuccessSnappableIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SuccessSnappableIds != null && ec.Excludes("successSnappableIds",true))
        {
            this.SuccessSnappableIds = null;
        }
    }


    #endregion

    } // class AddVmAppConsistentSpecsReply
    
    #endregion

    public static class ListAddVmAppConsistentSpecsReplyExtensions
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
            this List<AddVmAppConsistentSpecsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AddVmAppConsistentSpecsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddVmAppConsistentSpecsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddVmAppConsistentSpecsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddVmAppConsistentSpecsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types