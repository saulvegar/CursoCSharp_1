using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsMetods {
    public static class MyExtensions {
        public static int WordCount(this string str) {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
