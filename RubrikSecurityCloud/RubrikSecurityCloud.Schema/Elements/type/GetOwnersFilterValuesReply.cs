// GetOwnersFilterValuesReply.cs
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
    #region GetOwnersFilterValuesReply
    public class GetOwnersFilterValuesReply: BaseType
    {
        #region members

        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        [JsonProperty("owners")]
        public List<OwnerInfo>? Owners { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetOwnersFilterValuesReply";
    }

    public GetOwnersFilterValuesReply Set(
        List<OwnerInfo>? Owners = null
    ) 
    {
        if ( Owners != null ) {
            this.Owners = Owners;
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
        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        if (this.Owners != null) {
            var fspec = this.Owners.AsFieldSpec(conf.Child("owners"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owners" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        if (ec.Includes("owners",false))
        {
            if(this.Owners == null) {

                this.Owners = new List<OwnerInfo>();
                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            } else {

                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            }
        }
        else if (this.Owners != null && ec.Excludes("owners",false))
        {
            this.Owners = null;
        }
    }


    #endregion

    } // class GetOwnersFilterValuesReply
    
    #endregion

    public static class ListGetOwnersFilterValuesReplyExtensions
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
            this List<GetOwnersFilterValuesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetOwnersFilterValuesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetOwnersFilterValuesReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetOwnersFilterValuesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetOwnersFilterValuesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types