// GetCustomerFacingDownloadsReply.cs
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
    #region GetCustomerFacingDownloadsReply
    public class GetCustomerFacingDownloadsReply: BaseType
    {
        #region members

        //      C# -> List<CustomerFacingFile>? Downloads
        // GraphQL -> downloads: [CustomerFacingFile!]! (type)
        [JsonProperty("downloads")]
        public List<CustomerFacingFile>? Downloads { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetCustomerFacingDownloadsReply";
    }

    public GetCustomerFacingDownloadsReply Set(
        List<CustomerFacingFile>? Downloads = null
    ) 
    {
        if ( Downloads != null ) {
            this.Downloads = Downloads;
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
        //      C# -> List<CustomerFacingFile>? Downloads
        // GraphQL -> downloads: [CustomerFacingFile!]! (type)
        if (this.Downloads != null) {
            var fspec = this.Downloads.AsFieldSpec(conf.Child("downloads"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "downloads" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<CustomerFacingFile>? Downloads
        // GraphQL -> downloads: [CustomerFacingFile!]! (type)
        if (ec.Includes("downloads",false))
        {
            if(this.Downloads == null) {

                this.Downloads = new List<CustomerFacingFile>();
                this.Downloads.ApplyExploratoryFieldSpec(ec.NewChild("downloads"));

            } else {

                this.Downloads.ApplyExploratoryFieldSpec(ec.NewChild("downloads"));

            }
        }
        else if (this.Downloads != null && ec.Excludes("downloads",false))
        {
            this.Downloads = null;
        }
    }


    #endregion

    } // class GetCustomerFacingDownloadsReply
    
    #endregion

    public static class ListGetCustomerFacingDownloadsReplyExtensions
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
            this List<GetCustomerFacingDownloadsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetCustomerFacingDownloadsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetCustomerFacingDownloadsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetCustomerFacingDownloadsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetCustomerFacingDownloadsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types