// DlpConfigGenericNas.cs
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
    #region DlpConfigGenericNas
    public class DlpConfigGenericNas: BaseType
    {
        #region members

        //      C# -> DlpConfigShareType? ShareType
        // GraphQL -> shareType: DlpConfigShareType! (enum)
        [JsonProperty("shareType")]
        public DlpConfigShareType? ShareType { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String! (scalar)
        [JsonProperty("shareId")]
        public System.String? ShareId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DlpConfigGenericNas";
    }

    public DlpConfigGenericNas Set(
        DlpConfigShareType? ShareType = null,
        System.String? Path = null,
        System.String? ShareId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( ShareId != null ) {
            this.ShareId = ShareId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> DlpConfigShareType? ShareType
        // GraphQL -> shareType: DlpConfigShareType! (enum)
        if (this.ShareType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareType\n" ;
            } else {
                s += ind + "shareType\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String! (scalar)
        if (this.ShareId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareId\n" ;
            } else {
                s += ind + "shareId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DlpConfigShareType? ShareType
        // GraphQL -> shareType: DlpConfigShareType! (enum)
        if (ec.Includes("shareType",true))
        {
            if(this.ShareType == null) {

                this.ShareType = new DlpConfigShareType();

            } else {


            }
        }
        else if (this.ShareType != null && ec.Excludes("shareType",true))
        {
            this.ShareType = null;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String! (scalar)
        if (ec.Includes("shareId",true))
        {
            if(this.ShareId == null) {

                this.ShareId = "FETCH";

            } else {


            }
        }
        else if (this.ShareId != null && ec.Excludes("shareId",true))
        {
            this.ShareId = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
    }


    #endregion

    } // class DlpConfigGenericNas
    
    #endregion

    public static class ListDlpConfigGenericNasExtensions
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
            this List<DlpConfigGenericNas> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DlpConfigGenericNas> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DlpConfigGenericNas> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DlpConfigGenericNas());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DlpConfigGenericNas> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types