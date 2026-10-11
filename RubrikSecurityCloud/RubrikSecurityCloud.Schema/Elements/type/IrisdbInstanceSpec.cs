// IrisdbInstanceSpec.cs
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
    #region IrisdbInstanceSpec
    public class IrisdbInstanceSpec: BaseType
    {
        #region members

        //      C# -> System.String? AltJournalDir
        // GraphQL -> altJournalDir: String! (scalar)
        [JsonProperty("altJournalDir")]
        public System.String? AltJournalDir { get; set; }

        //      C# -> System.String? DataDir
        // GraphQL -> dataDir: String! (scalar)
        [JsonProperty("dataDir")]
        public System.String? DataDir { get; set; }

        //      C# -> System.String? InstallDir
        // GraphQL -> installDir: String! (scalar)
        [JsonProperty("installDir")]
        public System.String? InstallDir { get; set; }

        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String! (scalar)
        [JsonProperty("instanceVersion")]
        public System.String? InstanceVersion { get; set; }

        //      C# -> System.String? JournalDir
        // GraphQL -> journalDir: String! (scalar)
        [JsonProperty("journalDir")]
        public System.String? JournalDir { get; set; }

        //      C# -> System.String? WijDir
        // GraphQL -> wijDir: String! (scalar)
        [JsonProperty("wijDir")]
        public System.String? WijDir { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IrisdbInstanceSpec";
    }

    public IrisdbInstanceSpec Set(
        System.String? AltJournalDir = null,
        System.String? DataDir = null,
        System.String? InstallDir = null,
        System.String? InstanceVersion = null,
        System.String? JournalDir = null,
        System.String? WijDir = null
    ) 
    {
        if ( AltJournalDir != null ) {
            this.AltJournalDir = AltJournalDir;
        }
        if ( DataDir != null ) {
            this.DataDir = DataDir;
        }
        if ( InstallDir != null ) {
            this.InstallDir = InstallDir;
        }
        if ( InstanceVersion != null ) {
            this.InstanceVersion = InstanceVersion;
        }
        if ( JournalDir != null ) {
            this.JournalDir = JournalDir;
        }
        if ( WijDir != null ) {
            this.WijDir = WijDir;
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
        //      C# -> System.String? AltJournalDir
        // GraphQL -> altJournalDir: String! (scalar)
        if (this.AltJournalDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "altJournalDir\n" ;
            } else {
                s += ind + "altJournalDir\n" ;
            }
        }
        //      C# -> System.String? DataDir
        // GraphQL -> dataDir: String! (scalar)
        if (this.DataDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataDir\n" ;
            } else {
                s += ind + "dataDir\n" ;
            }
        }
        //      C# -> System.String? InstallDir
        // GraphQL -> installDir: String! (scalar)
        if (this.InstallDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "installDir\n" ;
            } else {
                s += ind + "installDir\n" ;
            }
        }
        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String! (scalar)
        if (this.InstanceVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceVersion\n" ;
            } else {
                s += ind + "instanceVersion\n" ;
            }
        }
        //      C# -> System.String? JournalDir
        // GraphQL -> journalDir: String! (scalar)
        if (this.JournalDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "journalDir\n" ;
            } else {
                s += ind + "journalDir\n" ;
            }
        }
        //      C# -> System.String? WijDir
        // GraphQL -> wijDir: String! (scalar)
        if (this.WijDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "wijDir\n" ;
            } else {
                s += ind + "wijDir\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AltJournalDir
        // GraphQL -> altJournalDir: String! (scalar)
        if (ec.Includes("altJournalDir",true))
        {
            if(this.AltJournalDir == null) {

                this.AltJournalDir = "FETCH";

            } else {


            }
        }
        else if (this.AltJournalDir != null && ec.Excludes("altJournalDir",true))
        {
            this.AltJournalDir = null;
        }
        //      C# -> System.String? DataDir
        // GraphQL -> dataDir: String! (scalar)
        if (ec.Includes("dataDir",true))
        {
            if(this.DataDir == null) {

                this.DataDir = "FETCH";

            } else {


            }
        }
        else if (this.DataDir != null && ec.Excludes("dataDir",true))
        {
            this.DataDir = null;
        }
        //      C# -> System.String? InstallDir
        // GraphQL -> installDir: String! (scalar)
        if (ec.Includes("installDir",true))
        {
            if(this.InstallDir == null) {

                this.InstallDir = "FETCH";

            } else {


            }
        }
        else if (this.InstallDir != null && ec.Excludes("installDir",true))
        {
            this.InstallDir = null;
        }
        //      C# -> System.String? InstanceVersion
        // GraphQL -> instanceVersion: String! (scalar)
        if (ec.Includes("instanceVersion",true))
        {
            if(this.InstanceVersion == null) {

                this.InstanceVersion = "FETCH";

            } else {


            }
        }
        else if (this.InstanceVersion != null && ec.Excludes("instanceVersion",true))
        {
            this.InstanceVersion = null;
        }
        //      C# -> System.String? JournalDir
        // GraphQL -> journalDir: String! (scalar)
        if (ec.Includes("journalDir",true))
        {
            if(this.JournalDir == null) {

                this.JournalDir = "FETCH";

            } else {


            }
        }
        else if (this.JournalDir != null && ec.Excludes("journalDir",true))
        {
            this.JournalDir = null;
        }
        //      C# -> System.String? WijDir
        // GraphQL -> wijDir: String! (scalar)
        if (ec.Includes("wijDir",true))
        {
            if(this.WijDir == null) {

                this.WijDir = "FETCH";

            } else {


            }
        }
        else if (this.WijDir != null && ec.Excludes("wijDir",true))
        {
            this.WijDir = null;
        }
    }


    #endregion

    } // class IrisdbInstanceSpec
    
    #endregion

    public static class ListIrisdbInstanceSpecExtensions
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
            this List<IrisdbInstanceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IrisdbInstanceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IrisdbInstanceSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IrisdbInstanceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IrisdbInstanceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types