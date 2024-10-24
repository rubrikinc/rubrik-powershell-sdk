// ListIamPairsByCloudAccountAndLocationReply.cs
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
    #region ListIamPairsByCloudAccountAndLocationReply
    public class ListIamPairsByCloudAccountAndLocationReply: BaseType
    {
        #region members

        //      C# -> List<AwsIamPairsWithMissingPermission>? IamPairs
        // GraphQL -> iamPairs: [AwsIamPairsWithMissingPermission!]! (type)
        [JsonProperty("iamPairs")]
        public List<AwsIamPairsWithMissingPermission>? IamPairs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ListIamPairsByCloudAccountAndLocationReply";
    }

    public ListIamPairsByCloudAccountAndLocationReply Set(
        List<AwsIamPairsWithMissingPermission>? IamPairs = null
    ) 
    {
        if ( IamPairs != null ) {
            this.IamPairs = IamPairs;
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
        //      C# -> List<AwsIamPairsWithMissingPermission>? IamPairs
        // GraphQL -> iamPairs: [AwsIamPairsWithMissingPermission!]! (type)
        if (this.IamPairs != null) {
            var fspec = this.IamPairs.AsFieldSpec(conf.Child("iamPairs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "iamPairs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsIamPairsWithMissingPermission>? IamPairs
        // GraphQL -> iamPairs: [AwsIamPairsWithMissingPermission!]! (type)
        if (ec.Includes("iamPairs",false))
        {
            if(this.IamPairs == null) {

                this.IamPairs = new List<AwsIamPairsWithMissingPermission>();
                this.IamPairs.ApplyExploratoryFieldSpec(ec.NewChild("iamPairs"));

            } else {

                this.IamPairs.ApplyExploratoryFieldSpec(ec.NewChild("iamPairs"));

            }
        }
        else if (this.IamPairs != null && ec.Excludes("iamPairs",false))
        {
            this.IamPairs = null;
        }
    }


    #endregion

    } // class ListIamPairsByCloudAccountAndLocationReply
    
    #endregion

    public static class ListListIamPairsByCloudAccountAndLocationReplyExtensions
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
            this List<ListIamPairsByCloudAccountAndLocationReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ListIamPairsByCloudAccountAndLocationReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ListIamPairsByCloudAccountAndLocationReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ListIamPairsByCloudAccountAndLocationReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ListIamPairsByCloudAccountAndLocationReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types