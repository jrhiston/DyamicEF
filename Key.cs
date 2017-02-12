using System;

namespace efexample
{
    public class Key : 
        IDocumentElement,
        IEquatable<Key>, 
        IDataElement<int>
    {
        public Key(int value)
        {
            if (value <= 0)
                throw new InvalidOperationException("Must provide key value greater than zero");

            Value = value;
        }

        public int Value { get; }
        
        public IDocumentVisitor Accept(IDocumentVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Key other)
            => other != null && Equals(Value, other.Value);

        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            return Equals (obj as Key);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(Key key1, Key key2) => Equals(key1, key2);
        public static bool operator !=(Key key1, Key key2) => Equals(key1, key2);  
    }
}