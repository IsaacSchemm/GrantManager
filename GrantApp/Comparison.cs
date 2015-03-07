using KellermanSoftware.CompareNetObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrantApp {
    public static class Comparison<T> where T : class, new() {
        public static string Compare(T oldObj, T newObj) {
            CompareObjects c = new CompareObjects {
                CompareChildren = false,
                MaxDifferences = int.MaxValue
            };
            if (c.Compare(oldObj ?? new T(), newObj)) {
                return "no change";
            } else {
                List<string> changes = new List<string>();
                string format = oldObj == null
                    ? "{0} ({2})"
                    : "{0} ({1} => {2})";
                foreach (var difference in c.Differences) {
                    if (difference.Object1.Target == null && difference.Object2Value == "") {
                        // skip
                    } else {
                        changes.Add(string.Format(format, difference.PropertyName, difference.Object1Value, difference.Object2Value));
                    }
                }
                return string.Join(", ", changes);
            }
        }
    }
}
