using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace efexample
{
    public class Document : IEnumerable<IDocumentElement>, IDocumentElement
    {
        private readonly IEnumerable<IDocumentElement> _entries;

        public Document(params IDocumentElement[] entries)
        {
            _entries = entries;
        }

        public IDocumentVisitor Accept(IDocumentVisitor visitor)
        {
            return _entries.Aggregate(visitor, (v, e) => e.Accept(v));
        }

        public IEnumerator<IDocumentElement> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}