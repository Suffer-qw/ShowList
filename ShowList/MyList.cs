using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList
{
    public class MyList
    {
        List<string> m = new List<string>();
        int cur = -1;
        int m_count = 0;


        public void Append(string s)//добовление в конец
        {
            m.Add(s);
            if (cur == -1)
                cur++;
        }
        public void upend(string s)//добовление в начало
        {
            m.Insert(0,s);
            if (cur == -1)
                cur++;
        }
        public void next(string s)//добовление в начало
        {
            m.Insert(cur+1, s);
            cur++;
        }
        public void prev(string s)//добовление в начало
        {
            if(cur > 0) 
            {
                m.Insert(cur, s);
                cur++;
            }
            
        }
        public int Q()
        {
            return m.Count;
        }
        public void delete()//добовление в начало
        {
            if (cur != -1)
            {
                int b = cur;
                m.Remove(m[b]);
                cur--;
            }
        }

        public bool ToStart()//текущее в начало
        {
            if (m.Count < 0)
                return false;
            cur = 0;
            return true;

        }
        public bool ToEnd()//текущее в конец
        {
            if (m.Count < 0)
                return false;
            cur = m.Count - 1;
            return true;
        }
        public bool ToNext()//текущее следующие
        {
            if (m.Count == 0|| cur+1 >= m.Count)
                return false;
            cur++;
            return true;
        }

        public bool ToPrev()//текущее предыдущие
        {
            if (m.Count == 0 || cur-1 == -1)
                return false;
            cur--;
            return true;
        }

        public void ShowList(ListBox list)//вывод
        {
            list.Items.Clear();

            for (int i = 0; i < m.Count; i++)
            {
                list.Items.Add(m[i]);
            }
            if (m.Count > 0 && cur >= 0 && cur < m.Count)
            {
                list.SelectedIndex = cur;
            }

        }
        public string GetCur()//текущий
        {
            if (cur == -1 || cur >= m.Count)
                throw new Exception("get cur error");
            return m[cur];
        }
    }
}
