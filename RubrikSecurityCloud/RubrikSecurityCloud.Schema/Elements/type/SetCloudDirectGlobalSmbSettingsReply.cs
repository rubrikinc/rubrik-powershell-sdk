// SetCloudDirectGlobalSmbSettingsReply.cs
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
    #region SetCloudDirectGlobalSmbSettingsReply
    public class SetCloudDirectGlobalSmbSettingsReply: BaseType
    {
        #region members

        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        [JsonProperty("offlineFilesBehaviour")]
        public CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour { get; set; }

        //      C# -> System.Boolean? ShouldSupportSystemFiles
        // GraphQL -> shouldSupportSystemFiles: Boolean! (scalar)
        [JsonProperty("shouldSupportSystemFiles")]
        public System.Boolean? ShouldSupportSystemFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SetCloudDirectGlobalSmbSettingsReply";
    }

    public SetCloudDirectGlobalSmbSettingsReply Set(
        CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour = null,
        System.Boolean? ShouldSupportSystemFiles = null
    ) 
    {
        if ( OfflineFilesBehaviour != null ) {
            this.OfflineFilesBehaviour = OfflineFilesBehaviour;
        }
        if ( ShouldSupportSystemFiles != null ) {
            this.ShouldSupportSystemFiles = ShouldSupportSystemFiles;
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
        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        if (this.OfflineFilesBehaviour != null) {
            if (conf.Flat) {
                s += conf.Prefix + "offlineFilesBehaviour\n" ;
            } else {
                s += ind + "offlineFilesBehaviour\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldSupportSystemFiles
        // GraphQL -> shouldSupportSystemFiles: Boolean! (scalar)
        if (this.ShouldSupportSystemFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldSupportSystemFiles\n" ;
            } else {
                s += ind + "shouldSupportSystemFiles\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudDirectOfflineFilesBehaviour? OfflineFilesBehaviour
        // GraphQL -> offlineFilesBehaviour: CloudDirectOfflineFilesBehaviour! (enum)
        if (ec.Includes("offlineFilesBehaviour",true))
        {
            if(this.OfflineFilesBehaviour == null) {

                this.OfflineFilesBehaviour = new CloudDirectOfflineFilesBehaviour();

            } else {


            }
        }
        else if (this.OfflineFilesBehaviour != null && ec.Excludes("offlineFilesBehaviour",true))
        {
            this.OfflineFilesBehaviour = null;
        }
        //      C# -> System.Boolean? ShouldSupportSystemFiles
        // GraphQL -> shouldSupportSystemFiles: Boolean! (scalar)
        if (ec.Includes("shouldSupportSystemFiles",true))
        {
            if(this.ShouldSupportSystemFiles == null) {

                this.ShouldSupportSystemFiles = true;

            } else {


            }
        }
        else if (this.ShouldSupportSystemFiles != null && ec.Excludes("shouldSupportSystemFiles",true))
        {
            this.ShouldSupportSystemFiles = null;
        }
    }


    #endregion

    } // class SetCloudDirectGlobalSmbSettingsReply
    
    #endregion

    public static class ListSetCloudDirectGlobalSmbSettingsReplyExtensions
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
            this List<SetCloudDirectGlobalSmbSettingsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SetCloudDirectGlobalSmbSettingsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SetCloudDirectGlobalSmbSettingsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SetCloudDirectGlobalSmbSettingsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SetCloudDirectGlobalSmbSettingsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types