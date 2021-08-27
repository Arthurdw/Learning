using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCs
{
    public class Advanced
    {
        private string token;
        private string host = "http://localhost";

        public Advanced(string token)  => new Advanced(token, null);

        public Advanced(string token, string host)
        {
            this.token = token;
            this.host = host ?? this.host;
        }
    }

    public class AdvancedList<T> : List<T>
    {
        public T this[int i]
        {
            get
            {
                this.FillUntil(i);
                return base[i];
            }
            set
            {
                this.FillUntil(i);
                base[i] = value;
            }
        }

        private void FillUntil(int index)
        {
            for (int i = 0; i < index; i++)
                this.Add(default(T));
        }
    }

    public static class AdvancedListExtensions
    {
        public static AdvancedList<T> ToAdvancedList<T>(this List<T> source)
        {
            AdvancedList<T> list = new AdvancedList<T>();
            foreach (T item in source) list.Add(item);
            return list;
        }
    }
}
