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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<AddVmAppConsistentSpecsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddVmAppConsistentSpecsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddVmAppConsistentSpecsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddVmAppConsistentSpecsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddVmAppConsistentSpecsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types