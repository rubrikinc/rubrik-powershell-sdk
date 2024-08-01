// AzureDiskDetails.cs
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
    #region AzureDiskDetails
    public class AzureDiskDetails: BaseType
    {
        #region members

        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        [JsonProperty("diskNativeName")]
        public System.String? DiskNativeName { get; set; }

        //      C# -> System.Int64? MountedDiskId
        // GraphQL -> mountedDiskId: Long! (scalar)
        [JsonProperty("mountedDiskId")]
        public System.Int64? MountedDiskId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureDiskDetails";
    }

    public AzureDiskDetails Set(
        System.String? DiskNativeName = null,
        System.Int64? MountedDiskId = null
    ) 
    {
        if ( DiskNativeName != null ) {
            this.DiskNativeName = DiskNativeName;
        }
        if ( MountedDiskId != null ) {
            this.MountedDiskId = MountedDiskId;
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
        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        if (this.DiskNativeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskNativeName\n" ;
            } else {
                s += ind + "diskNativeName\n" ;
            }
        }
        //      C# -> System.Int64? MountedDiskId
        // GraphQL -> mountedDiskId: Long! (scalar)
        if (this.MountedDiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDiskId\n" ;
            } else {
                s += ind + "mountedDiskId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DiskNativeName
        // GraphQL -> diskNativeName: String! (scalar)
        if (ec.Includes("diskNativeName",true))
        {
            if(this.DiskNativeName == null) {

                this.DiskNativeName = "FETCH";

            } else {


            }
        }
        else if (this.DiskNativeName != null && ec.Excludes("diskNativeName",true))
        {
            this.DiskNativeName = null;
        }
        //      C# -> System.Int64? MountedDiskId
        // GraphQL -> mountedDiskId: Long! (scalar)
        if (ec.Includes("mountedDiskId",true))
        {
            if(this.MountedDiskId == null) {

                this.MountedDiskId = new System.Int64();

            } else {


            }
        }
        else if (this.MountedDiskId != null && ec.Excludes("mountedDiskId",true))
        {
            this.MountedDiskId = null;
        }
    }


    #endregion

    } // class AzureDiskDetails
    
    #endregion

    public static class ListAzureDiskDetailsExtensions
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
            this List<AzureDiskDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureDiskDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureDiskDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureDiskDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureDiskDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types