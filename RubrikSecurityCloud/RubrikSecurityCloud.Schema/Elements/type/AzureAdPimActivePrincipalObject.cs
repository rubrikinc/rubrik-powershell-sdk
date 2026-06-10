// AzureAdPimActivePrincipalObject.cs
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
    #region AzureAdPimActivePrincipalObject
    public class AzureAdPimActivePrincipalObject: BaseType
    {
        #region members

        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        [JsonProperty("azureAdDevice")]
        public AzureAdDevice? AzureAdDevice { get; set; }

        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        [JsonProperty("azureAdGroup")]
        public AzureAdGroup? AzureAdGroup { get; set; }

        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        [JsonProperty("azureAdServicePrincipal")]
        public AzureAdServicePrincipal? AzureAdServicePrincipal { get; set; }

        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        [JsonProperty("azureAdUser")]
        public AzureAdUser? AzureAdUser { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdPimActivePrincipalObject";
    }

    public AzureAdPimActivePrincipalObject Set(
        AzureAdDevice? AzureAdDevice = null,
        AzureAdGroup? AzureAdGroup = null,
        AzureAdServicePrincipal? AzureAdServicePrincipal = null,
        AzureAdUser? AzureAdUser = null
    ) 
    {
        if ( AzureAdDevice != null ) {
            this.AzureAdDevice = AzureAdDevice;
        }
        if ( AzureAdGroup != null ) {
            this.AzureAdGroup = AzureAdGroup;
        }
        if ( AzureAdServicePrincipal != null ) {
            this.AzureAdServicePrincipal = AzureAdServicePrincipal;
        }
        if ( AzureAdUser != null ) {
            this.AzureAdUser = AzureAdUser;
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
        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        if (this.AzureAdDevice != null) {
            var fspec = this.AzureAdDevice.AsFieldSpec(conf.Child("azureAdDevice"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdDevice" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (this.AzureAdGroup != null) {
            var fspec = this.AzureAdGroup.AsFieldSpec(conf.Child("azureAdGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        if (this.AzureAdServicePrincipal != null) {
            var fspec = this.AzureAdServicePrincipal.AsFieldSpec(conf.Child("azureAdServicePrincipal"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdServicePrincipal" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (this.AzureAdUser != null) {
            var fspec = this.AzureAdUser.AsFieldSpec(conf.Child("azureAdUser"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "azureAdUser" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureAdDevice? AzureAdDevice
        // GraphQL -> azureAdDevice: AzureAdDevice (type)
        if (ec.Includes("azureAdDevice",false))
        {
            if(this.AzureAdDevice == null) {

                this.AzureAdDevice = new AzureAdDevice();
                this.AzureAdDevice.ApplyExploratoryFieldSpec(ec.NewChild("azureAdDevice"));

            } else {

                this.AzureAdDevice.ApplyExploratoryFieldSpec(ec.NewChild("azureAdDevice"));

            }
        }
        else if (this.AzureAdDevice != null && ec.Excludes("azureAdDevice",false))
        {
            this.AzureAdDevice = null;
        }
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (ec.Includes("azureAdGroup",false))
        {
            if(this.AzureAdGroup == null) {

                this.AzureAdGroup = new AzureAdGroup();
                this.AzureAdGroup.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroup"));

            } else {

                this.AzureAdGroup.ApplyExploratoryFieldSpec(ec.NewChild("azureAdGroup"));

            }
        }
        else if (this.AzureAdGroup != null && ec.Excludes("azureAdGroup",false))
        {
            this.AzureAdGroup = null;
        }
        //      C# -> AzureAdServicePrincipal? AzureAdServicePrincipal
        // GraphQL -> azureAdServicePrincipal: AzureAdServicePrincipal (type)
        if (ec.Includes("azureAdServicePrincipal",false))
        {
            if(this.AzureAdServicePrincipal == null) {

                this.AzureAdServicePrincipal = new AzureAdServicePrincipal();
                this.AzureAdServicePrincipal.ApplyExploratoryFieldSpec(ec.NewChild("azureAdServicePrincipal"));

            } else {

                this.AzureAdServicePrincipal.ApplyExploratoryFieldSpec(ec.NewChild("azureAdServicePrincipal"));

            }
        }
        else if (this.AzureAdServicePrincipal != null && ec.Excludes("azureAdServicePrincipal",false))
        {
            this.AzureAdServicePrincipal = null;
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (ec.Includes("azureAdUser",false))
        {
            if(this.AzureAdUser == null) {

                this.AzureAdUser = new AzureAdUser();
                this.AzureAdUser.ApplyExploratoryFieldSpec(ec.NewChild("azureAdUser"));

            } else {

                this.AzureAdUser.ApplyExploratoryFieldSpec(ec.NewChild("azureAdUser"));

            }
        }
        else if (this.AzureAdUser != null && ec.Excludes("azureAdUser",false))
        {
            this.AzureAdUser = null;
        }
    }


    #endregion

    } // class AzureAdPimActivePrincipalObject
    
    #endregion

    public static class ListAzureAdPimActivePrincipalObjectExtensions
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
            this List<AzureAdPimActivePrincipalObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdPimActivePrincipalObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdPimActivePrincipalObject> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdPimActivePrincipalObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdPimActivePrincipalObject> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types