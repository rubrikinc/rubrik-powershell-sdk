// AmiTypeForAwsNativeArchivedSnapshotExportReply.cs
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
    #region AmiTypeForAwsNativeArchivedSnapshotExportReply
    public class AmiTypeForAwsNativeArchivedSnapshotExportReply: BaseType
    {
        #region members

        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        [JsonProperty("amiType")]
        public AmiType? AmiType { get; set; }

        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        [JsonProperty("regionNativeId")]
        public AwsNativeRegion? RegionNativeId { get; set; }

        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        [JsonProperty("amiId")]
        public System.String? AmiId { get; set; }

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AmiTypeForAwsNativeArchivedSnapshotExportReply";
    }

    public AmiTypeForAwsNativeArchivedSnapshotExportReply Set(
        AmiType? AmiType = null,
        AwsNativeRegion? RegionNativeId = null,
        System.String? AmiId = null,
        System.String? AwsAccountRubrikId = null
    ) 
    {
        if ( AmiType != null ) {
            this.AmiType = AmiType;
        }
        if ( RegionNativeId != null ) {
            this.RegionNativeId = RegionNativeId;
        }
        if ( AmiId != null ) {
            this.AmiId = AmiId;
        }
        if ( AwsAccountRubrikId != null ) {
            this.AwsAccountRubrikId = AwsAccountRubrikId;
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
        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        if (this.AmiType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "amiType\n" ;
            } else {
                s += ind + "amiType\n" ;
            }
        }
        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        if (this.RegionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "regionNativeId\n" ;
            } else {
                s += ind + "regionNativeId\n" ;
            }
        }
        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        if (this.AmiId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "amiId\n" ;
            } else {
                s += ind + "amiId\n" ;
            }
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (this.AwsAccountRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awsAccountRubrikId\n" ;
            } else {
                s += ind + "awsAccountRubrikId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        if (ec.Includes("amiType",true))
        {
            if(this.AmiType == null) {

                this.AmiType = new AmiType();

            } else {


            }
        }
        else if (this.AmiType != null && ec.Excludes("amiType",true))
        {
            this.AmiType = null;
        }
        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        if (ec.Includes("regionNativeId",true))
        {
            if(this.RegionNativeId == null) {

                this.RegionNativeId = new AwsNativeRegion();

            } else {


            }
        }
        else if (this.RegionNativeId != null && ec.Excludes("regionNativeId",true))
        {
            this.RegionNativeId = null;
        }
        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        if (ec.Includes("amiId",true))
        {
            if(this.AmiId == null) {

                this.AmiId = "FETCH";

            } else {


            }
        }
        else if (this.AmiId != null && ec.Excludes("amiId",true))
        {
            this.AmiId = null;
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (ec.Includes("awsAccountRubrikId",true))
        {
            if(this.AwsAccountRubrikId == null) {

                this.AwsAccountRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.AwsAccountRubrikId != null && ec.Excludes("awsAccountRubrikId",true))
        {
            this.AwsAccountRubrikId = null;
        }
    }


    #endregion

    } // class AmiTypeForAwsNativeArchivedSnapshotExportReply
    
    #endregion

    public static class ListAmiTypeForAwsNativeArchivedSnapshotExportReplyExtensions
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
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AmiTypeForAwsNativeArchivedSnapshotExportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types