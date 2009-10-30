using System.Collections.Generic;
using FluentNHibernate.Conventions.Inspections;

namespace FluentNHibernate.Conventions.Instances
{
    public interface IKeyInstance : IKeyInspector
    {
        void Column(string columnName);
        void ForeignKey(string constraint);
        void OnDelete(string value);
        new IEnumerable<IColumnInspector> Columns { get; }
    }
}