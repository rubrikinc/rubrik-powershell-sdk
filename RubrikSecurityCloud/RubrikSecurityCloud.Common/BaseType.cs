using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public abstract class BaseType : IFieldSpec
    {
        // Composite field spec support:
        // _next is the pointer to next object in chain.
        // Used for building up a chain of objects
        // to represent a "composite field spec".
        internal BaseType? _next = null;
        public BaseType? GetNext() => _next;
        public void SetNext(BaseType? next) => _next = next;
        public bool IsComposite() => _next != null;
        public int CompositeLength()
        {
            int len = 1;
            BaseType? next = _next;
            while (next != null)
            {
                len++;
                next = next._next;
            }
            return len;
        }

        /// <summary>
        /// Convert the composite object to a list of objects.
        /// If the object is not composite, return a list with a single item.
        /// Objects are not copied: modifiying the list elements
        /// will modify the original object.
        /// </summary>
        public RscInterface<BaseType> AsList()
        {
            RscInterface<BaseType> list = new RscInterface<BaseType>();
            BaseType? next = this;
            while (next != null)
            {
                list.Add(next);
                next = next._next;
            }
            return list;
        }

        /// <summary>
        /// Filter the composite object by type.
        /// </summary>
        public RscInterface<BaseType> WhereType(Type type) => this.AsList().WhereType(type);

        /// <summary>
        /// Filter the composite object by type.
        /// </summary>
        public RscInterface<BaseType> WhereType(string typeName) => this.AsList().WhereType(typeName);

        /// <summary>
        /// Return the set of unique types in the list.
        /// </summary>
        public HashSet<Type> DistinctTypes() => this.AsList().DistinctTypes();

        // IFieldSpec interface:
        public abstract string AsFieldSpec(FieldSpecConfig? conf = null);

        public virtual List<string> SelectedFields()
        {
            return StringUtils.FieldSpecStringToList(
                this.AsFieldSpec(new FieldSpecConfig { Flat = true }));
                    
        }

        public virtual List<string> AllFields(int maxDepth = 0)
        {
            var fields = StringUtils.FlattenFieldToFieldSpecList(
                ReflectionUtils.FlattenFieldFull(this.GetType().FullName));
            if (maxDepth <= 0)
            {
                return fields;
            }
            else
            {
                return fields.Select(f => 
                    f.Split('.').Take(maxDepth).Aggregate((a, b) => a + "." + b)).Distinct().ToList();
            }
        }

        public List<string> UnselectedFields()
        {
            return StringUtils.BuildUnselectedList(
                this.AllFields(), this.SelectedFields());
        }


        public abstract void ApplyExploratoryFieldSpec(AutofieldContext ec);
        
        // Note: "SelectForRetrieval" could take for parmeter a HashSet<string>
        // to pass in what fields are to be selected for retrieval,
        // and if the hashset is empty or null, then AutoFieldSpec is used
        // instead.
        public void SelectForRetrieval()
        {
            // Note: this method will need to be overridden when
            // we implement native simple types with Rsc Types.
            // e.g. for RscString: this = "FETCH"
            this.ApplyExploratoryFieldSpec(new AutofieldContext());
        }

        public void UnselectFromRetrieval()
        {
            // Note: this method will need to be overridden when
            // we implement native simple types with Rsc Types.
            // e.g. for RscString: this = UnselectedStringSingleton ;

            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                property.SetValue(this, null);
            }
        }

        // Returns the name of the type as it would appear in a GraphQL schema.
        // Should be overridden if the GraphQL type name is different from 
        // the C# class name.
        public virtual string GetGqlTypeName()
        {
            return this.GetType().Name;
        }
    }

    public static class ListBaseTypeExtensions
    {
        public static string AsFieldSpec(this List<BaseType> list,
                                         FieldSpecConfig? conf = null)
        {
            conf = (conf == null) ? new FieldSpecConfig() : conf;
            string ind = conf.IndentStr();
            StringBuilder sb = new StringBuilder();
            foreach (BaseType item in list)
            {
                string fs = item.AsFieldSpec(conf.Child(ignoreComposition:true));
                if (conf.Flat)
                {
                    sb.Append(fs);
                }
                else
                {
                    var fragment = " ... on " + item.GetType().Name;
                    if (fs.Length > 0)
                    {
                        sb.Append(ind + fragment + " {\n" + fs + ind + "}\n");
                    }
                    else
                    {
                        sb.Append(ind + "#" + fragment + " {}\n");
                    }
                }
            }
            return sb.ToString();
        }

        public static List<string> SelectedFields(this List<BaseType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }

        // public static List<string> AllFields(this List<BaseType> list)
        // {
        //     return list.SelectMany(item => item.AllFields()).ToList()
        //         .Distinct().OrderBy(s => s).ToList();
        // }

        // public static List<string> UnselectedFields(this List<BaseType> list)
        // {
        //     return StringUtils.BuildUnselectedList(
        //         list.AllFields(), list.SelectedFields());
        // }

        public static void ApplyExploratoryFieldSpec(
            this List<BaseType> list,
            AutofieldContext ec)
        {
            foreach (BaseType item in list)
            {
                item.ApplyExploratoryFieldSpec(ec);
            }
        }

        public static void SelectForRetrieval(this List<BaseType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }

    public class RscInterface<T>: List<T>
    {
        public RscInterface(): base() { }
        public RscInterface(IEnumerable<T> collection): base(collection) { }

        // This would be great but PowerShell doesn't directly support
        // calling generic methods with type parameters, so you'd have to do:
        // $lType = $list.GetType()
        // $whereTypeMethodGeneric = $lType.GetMethod("WhereType").MakeGenericMethod([RubrikSecurityCloud.Types.GlobalSlaReply])
        // $result = $whereTypeMethodGeneric.Invoke($l, @())
        // which is pretty ugly.
        // public RscInterface<S> WhereType<S>()
        // {
        //     var filteredItems = this.Where(item => item is S).Cast<S>();
        //     return new RscInterface<S>(filteredItems);
        // }

        /// <summary>
        /// Filter the list by type.
        /// </summary>
        public RscInterface<T> WhereType(Type type) =>
            new RscInterface<T>(
                this.Where(item => item != null && item.GetType() == type));

        /// <summary>
        /// Filter the list by type.
        /// </summary>
        public RscInterface<T> WhereType(string typeName) =>
            new RscInterface<T>(
                this.Where(item => item != null && item.GetType().Name.ToLower() == typeName.ToLower()));

        /// <summary>
        /// Return the set of unique types in the list.
        /// </summary>
        public HashSet<Type> DistinctTypes() =>
            new HashSet<Type>(
                this.Select(item => item?.GetType()).Where(type => type != null).Cast<Type>());
        
        public T this[string typeName]
        {
            get
            {
                var filteredList = this.WhereType(typeName);
                return filteredList.FirstOrDefault();
            }
        }
    }
}
