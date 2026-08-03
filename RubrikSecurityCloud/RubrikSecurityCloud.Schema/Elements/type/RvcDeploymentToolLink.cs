// RvcDeploymentToolLink.cs
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
    #region RvcDeploymentToolLink
    public class RvcDeploymentToolLink: BaseType
    {
        #region members

        //      C# -> System.String? LinuxDownloadLink
        // GraphQL -> linuxDownloadLink: String! (scalar)
        [JsonProperty("linuxDownloadLink")]
        public System.String? LinuxDownloadLink { get; set; }

        //      C# -> System.String? MacOsDownloadLink
        // GraphQL -> macOsDownloadLink: String! (scalar)
        [JsonProperty("macOsDownloadLink")]
        public System.String? MacOsDownloadLink { get; set; }

        //      C# -> System.String? WindowsDownloadLink
        // GraphQL -> windowsDownloadLink: String! (scalar)
        [JsonProperty("windowsDownloadLink")]
        public System.String? WindowsDownloadLink { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RvcDeploymentToolLink";
    }

    public RvcDeploymentToolLink Set(
        System.String? LinuxDownloadLink = null,
        System.String? MacOsDownloadLink = null,
        System.String? WindowsDownloadLink = null
    ) 
    {
        if ( LinuxDownloadLink != null ) {
            this.LinuxDownloadLink = LinuxDownloadLink;
        }
        if ( MacOsDownloadLink != null ) {
            this.MacOsDownloadLink = MacOsDownloadLink;
        }
        if ( WindowsDownloadLink != null ) {
            this.WindowsDownloadLink = WindowsDownloadLink;
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
        //      C# -> System.String? LinuxDownloadLink
        // GraphQL -> linuxDownloadLink: String! (scalar)
        if (this.LinuxDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "linuxDownloadLink\n" ;
            } else {
                s += ind + "linuxDownloadLink\n" ;
            }
        }
        //      C# -> System.String? MacOsDownloadLink
        // GraphQL -> macOsDownloadLink: String! (scalar)
        if (this.MacOsDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "macOsDownloadLink\n" ;
            } else {
                s += ind + "macOsDownloadLink\n" ;
            }
        }
        //      C# -> System.String? WindowsDownloadLink
        // GraphQL -> windowsDownloadLink: String! (scalar)
        if (this.WindowsDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "windowsDownloadLink\n" ;
            } else {
                s += ind + "windowsDownloadLink\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? LinuxDownloadLink
        // GraphQL -> linuxDownloadLink: String! (scalar)
        if (ec.Includes("linuxDownloadLink",true))
        {
            if(this.LinuxDownloadLink == null) {

                this.LinuxDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.LinuxDownloadLink != null && ec.Excludes("linuxDownloadLink",true))
        {
            this.LinuxDownloadLink = null;
        }
        //      C# -> System.String? MacOsDownloadLink
        // GraphQL -> macOsDownloadLink: String! (scalar)
        if (ec.Includes("macOsDownloadLink",true))
        {
            if(this.MacOsDownloadLink == null) {

                this.MacOsDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.MacOsDownloadLink != null && ec.Excludes("macOsDownloadLink",true))
        {
            this.MacOsDownloadLink = null;
        }
        //      C# -> System.String? WindowsDownloadLink
        // GraphQL -> windowsDownloadLink: String! (scalar)
        if (ec.Includes("windowsDownloadLink",true))
        {
            if(this.WindowsDownloadLink == null) {

                this.WindowsDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.WindowsDownloadLink != null && ec.Excludes("windowsDownloadLink",true))
        {
            this.WindowsDownloadLink = null;
        }
    }


    #endregion

    } // class RvcDeploymentToolLink
    
    #endregion

    public static class ListRvcDeploymentToolLinkExtensions
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
            this List<RvcDeploymentToolLink> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RvcDeploymentToolLink> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RvcDeploymentToolLink> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RvcDeploymentToolLink());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RvcDeploymentToolLink> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types