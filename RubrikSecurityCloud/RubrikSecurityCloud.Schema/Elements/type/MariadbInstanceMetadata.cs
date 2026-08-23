// MariadbInstanceMetadata.cs
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
    #region MariadbInstanceMetadata
    public class MariadbInstanceMetadata: BaseType
    {
        #region members

        //      C# -> DateTime? LastSuccessfulRefreshTime
        // GraphQL -> lastSuccessfulRefreshTime: DateTime (scalar)
        [JsonProperty("lastSuccessfulRefreshTime")]
        public DateTime? LastSuccessfulRefreshTime { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MariadbInstanceMetadata";
    }

    public MariadbInstanceMetadata Set(
        DateTime? LastSuccessfulRefreshTime = null,
        DateTime? ProtectionDate = null,
        System.String? Version = null
    ) 
    {
        if ( LastSuccessfulRefreshTime != null ) {
            this.LastSuccessfulRefreshTime = LastSuccessfulRefreshTime;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( Version != null ) {
            this.Version = Version;
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
        //      C# -> DateTime? LastSuccessfulRefreshTime
        // GraphQL -> lastSuccessfulRefreshTime: DateTime (scalar)
        if (this.LastSuccessfulRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSuccessfulRefreshTime\n" ;
            } else {
                s += ind + "lastSuccessfulRefreshTime\n" ;
            }
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionDate\n" ;
            } else {
                s += ind + "protectionDate\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? LastSuccessfulRefreshTime
        // GraphQL -> lastSuccessfulRefreshTime: DateTime (scalar)
        if (ec.Includes("lastSuccessfulRefreshTime",true))
        {
            if(this.LastSuccessfulRefreshTime == null) {

                this.LastSuccessfulRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSuccessfulRefreshTime != null && ec.Excludes("lastSuccessfulRefreshTime",true))
        {
            this.LastSuccessfulRefreshTime = null;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (ec.Includes("protectionDate",true))
        {
            if(this.ProtectionDate == null) {

                this.ProtectionDate = new DateTime();

            } else {


            }
        }
        else if (this.ProtectionDate != null && ec.Excludes("protectionDate",true))
        {
            this.ProtectionDate = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class MariadbInstanceMetadata
    
    #endregion

    public static class ListMariadbInstanceMetadataExtensions
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
            this List<MariadbInstanceMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MariadbInstanceMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MariadbInstanceMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MariadbInstanceMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MariadbInstanceMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types