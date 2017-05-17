using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEquality
{
    public sealed class CookedFood : Food, IEquatable<CookedFood>
    {
        private string _cookingMethod;

        public string CookingMethod { get { return _cookingMethod; } }

        public CookedFood(string cookingMethod, string name, FoodGroup group) : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return string.Format($"{_cookingMethod} {Name} ({Group})");
        }

        #region equality implementation
        public override bool Equals(object obj)
        {
            //if (ReferenceEquals(obj, this)) return true;
            if (!base.Equals(obj))
                return false;
            CookedFood rhs = (CookedFood)obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        public bool Equals(CookedFood other)//Can imlement IEquatable<T> with CookedFood because it is Sealed, without inheritance.
        {
            if (!base.Equals(other)) return false;
            return this._cookingMethod == other._cookingMethod;
        }

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y); //remember the Static oject.Equals() method does null-checking then calls Virtual Equals().
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }
        #endregion
    }
}
