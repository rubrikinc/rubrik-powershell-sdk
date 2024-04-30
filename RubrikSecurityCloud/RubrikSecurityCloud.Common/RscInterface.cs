using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RubrikSecurityCloud.Types
{
    public class RscInterface<T>: List<T>, IFieldSpec where T: IFieldSpec
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

        public string AsFieldSpec(FieldSpecConfig? conf = null)
        {
            conf = (conf == null) ? new FieldSpecConfig() : conf;
            string ind = conf.IndentStr();
            StringBuilder sb = new StringBuilder();
            foreach (IFieldSpec item in this)
            {
                string fs = item.AsFieldSpec(conf.Child(ignoreComposition: true));
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
        public List<string> SelectedFields()
        {
            return StringUtils.FieldSpecStringToList(
                this.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }
        public void ApplyExploratoryFieldSpec(ExplorationContext ec)
        {
            foreach (IFieldSpec item in this)
            {
                item.ApplyExploratoryFieldSpec(ec);
            }
        }
        public void SelectForRetrieval()
        {
            this.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }
}
