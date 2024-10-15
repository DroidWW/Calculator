namespace WinFormsApp199
{
    class qwe
    {
        public static List<List<string>> многочлен(string s)
        {
            var koeffi = new List<string> { };
            var stepen = new List<string> { };
            string a = "", f = "";
            bool l = true;
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] =='x')
                {
                    if (a==""||a=="-")
                    {
                        koeffi.Add(a+"1");
                    }
                    else
                    {
                        koeffi.Add(a);
                    }
                    a = "";
                    l=false;
                }
                else if (s[i]=='+'||s[i]=='-')
                {
                    if (!l)
                    {
                        if (s[i-1]=='x')
                        {
                            stepen.Add("1");
                        }
                        else if (s[i-1] >='0' &&s[i-1]<='9' && a.Length==0)
                        {
                            stepen.Add("0");
                        }
                        else
                        {
                            stepen.Add(a);
                        }
                        a="";
                        l = true;
                    }
                    else
                    {
                        if (a.Length!=0)
                        {
                            koeffi.Add(a);
                            stepen.Add("0");
                        }
                    }
                    if (s[i]=='-')
                    {
                        a = "-";
                    }
                    else
                    {
                        a= "";
                    }
                }
                else if (s[i]>='0' && s[i]<='9' ||s[i]==',')
                {
                    a+=Convert.ToString(s[i]);
                }
                else
                {
                    a="";
                }

            }
            if (l)
            {
                koeffi.Add(a);
                stepen.Add("0");
            }
            else
            {
                if (a.Length==0)
                {
                    stepen.Add("1");
                }
                else
                {
                    stepen.Add(a);
                }
            }
            var last = new List<List<string>> { };
            for (int i = 0; i<koeffi.Count(); i++)
            {
                var temp = new List<string> { };
                temp.Add(stepen[i]);
                temp.Add(koeffi[i]);
                last.Add(temp);
            }

            return last;
        }
        public static bool проверочка(string s)
        {
            bool l = true;
            if (s.Length == 0)
            {
                l = false;
            }
            else
            {
                foreach (var i in s)
                {
                    if (i>='0' && i<='9' || i=='^'||i=='+'||i=='-'||i=='x')
                    {
                        l=true;
                    }
                    else
                    {
                        l = false;
                        break;
                    }
                }
            }
            return l;
        }
        public static string сложение(List<List<string>> m3)
        {
            var m41 = new List<int> { };
            var m51 = new List<int> { };
            foreach (var i in m3)
            {
                if (!m41.Contains(Convert.ToInt32(i[0])))
                {
                    m41.Add(Convert.ToInt32(i[0]));
                }
            }
            string f = "";
            m41.Sort();
            m41.Reverse();
            foreach (var i in m41)
            {
                int kef = 0;
                foreach (var j in m3)
                {
                    if (Convert.ToInt32(j[0])==i)
                    {
                        kef+=Convert.ToInt32(j[1]);
                    }
                }
                m51.Add(kef);
            }
            var m5 = new List<int>();
            var m4 = new List<int> { };
            for (var i = 0; i<m51.Count(); i++)
            {
                if (m51[i]!=0)
                {
                    m5.Add(m51[i]);
                    m4.Add(m41[i]);
                }
            }
            for (var i = 0; i<m4.Count(); i++)
            {
                if (i!=0)
                {
                    if (m4[i]==1)
                    {
                        if (m5[i]>1)
                        {
                            f+="+"+Convert.ToString(m5[i])+"x";
                        }
                        else if (m5[i]==1)
                        {
                            f+="+x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i])+"x";
                        }
                    }
                    else if (m4[i]==0)
                    {
                        if (m5[i]>1)
                        {
                            f+="+"+Convert.ToString(m5[i]);
                        }
                        else if (m5[i]==1)
                        {
                            f+="+x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i]);
                        }
                    }
                    else
                    {
                        if (m5[i]>1)
                        {
                            f+="+"+Convert.ToString(m5[i])+"x^"+Convert.ToString(m4[i]);
                        }
                        else if (m5[i]==1)
                        {
                            f+="+x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i])+"x^"+Convert.ToString(m4[i]);
                        }
                    }
                }
                else
                {
                    if (m4[i]==1)
                    {
                        if (m5[i]>1)
                        {
                            f+=Convert.ToString(m5[i])+"x";
                        }
                        else if (m5[i]==1)
                        {
                            f+="x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i])+"x";
                        }
                    }
                    else if (m4[i]==0)
                    {
                        if (m5[i]>1)
                        {
                            f+=Convert.ToString(m5[i]);
                        }
                        else if (m5[i]==1)
                        {
                            f+="x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i]);
                        }
                    }
                    else
                    {
                        if (m5[i]>1)
                        {
                            f+=Convert.ToString(m5[i])+"x^"+Convert.ToString(m4[i]);
                        }
                        else if (m5[i]==1)
                        {
                            f+="x";
                        }
                        else if (m5[i]==-1)
                        {
                            f+="-x";
                        }
                        else
                        {
                            f+=Convert.ToString(m5[i])+"x^"+Convert.ToString(m4[i]);
                        }
                    }
                }
            }
            if (f=="")
            {
                f="0";
            }
            return f;
        }
        public static List<List<string>> отрицание(List<List<string>> l)
        {
            var list = new List<List<string>>();
            foreach (var i in l)
            {
                var t = new List<string> { };
                t.Add(i[0]);
                t.Add(Convert.ToString((-1)*Convert.ToInt32(i[1])));
                list.Add(t);
            }
            return list;
        }
        public static List<List<string>> умножение(List<List<string>> m1, List<List<string>> m2)
        {
            var list = new List<List<string>> { };
            foreach (var i in m1)
            {
                foreach (var j in m2)
                {
                    var t = new List<string> { };
                    t.Add(Convert.ToString(Convert.ToInt32(i[0])+Convert.ToInt32(j[0])));
                    t.Add(Convert.ToString(Convert.ToInt32(i[1])*Convert.ToInt32(j[1])));
                    list.Add(t);
                }
            }
            return list;
        }
        public static List<List<string>> производная(List<List<string>> m3)
        {
            var list = new List<List<string>> { };
            foreach (var i in m3)
            {
                var t = new List<string> { };
                if (i[0]=="0")
                {
                    t.Add("0");
                    t.Add("0");
                }
                else if (i[0]=="1")
                {
                    t.Add("0");
                    t.Add(i[1]);
                }
                else
                {
                    t.Add(Convert.ToString(Convert.ToInt32(i[0])-1));
                    t.Add(Convert.ToString((Convert.ToInt32(i[0])-1)*Convert.ToInt32(i[1])));
                }
                list.Add(t);
            }
            return list;
        }
        public static bool натурал(string c)
        {
            int a = Convert.ToInt32(c);
            bool l = true;
            for (int i = 2; i<=a/2; i++)
            {
                if (a%i==0)
                {
                    l = false;
                    break;
                }
            }
            return l;
        }
        public static string значение(List<List<string>> m, string c)
        {
            int s = 0, t;
            foreach (var i in m)
            {
                t = 1;
                for (var j = 0; j<Convert.ToInt32(i[0]); j++)
                {
                    t *= Convert.ToInt32(c);
                }
                t*=Convert.ToInt32(i[1]);
                s+=t;
            }
            return Convert.ToString(s);
        }
    }
}
