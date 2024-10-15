namespace WinFormsApp199
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text, b = textBox2.Text,c = textBox4.Text, d = textBox5.Text;
            var m1 = qwe.многочлен(a);
            var m2 = qwe.многочлен(b);
            switch (comboBox1.Text)
            {
                case "сложение":
                    if (!qwe.проверочка(a) || !qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод!");
                    }
                    else
                    {
                        var s3 = new List<List<string>> { };
                        s3.AddRange(m1);
                        s3.AddRange(m2);
                        textBox3.Text = qwe.сложение(s3);
                    }
                    break;
                case "вычитание(a-b)":
                    if (!qwe.проверочка(a) || !qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод!");
                    }
                    else
                    {
                        var v2 = qwe.отрицание(m2);
                        var v3 = new List<List<string>> { };
                        v3.AddRange(m1);
                        v3.AddRange(v2);
                        textBox3.Text = qwe.сложение(v3);
                    }
                    break;
                case "вычитание(b-a)":
                    if (!qwe.проверочка(a) || !qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод!");
                    }
                    else
                    {
                        var v1 = qwe.отрицание(m1);
                        var v4 = new List<List<string>> { };
                        v4.AddRange(v1);
                        v4.AddRange(m2);
                        textBox3.Text = qwe.сложение(v4);
                    }
                    break;
                case "умножение":
                    if (!qwe.проверочка(a) || !qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод!");
                    }
                    else
                    {
                        var y3 = qwe.умножение(m1, m2);
                        textBox3.Text = qwe.сложение(y3);
                    }
                    break;
                case "отношение (равно, не равно)":
                    if (!qwe.проверочка(a) || !qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод!");
                    }
                    else
                    {
                        var o1 = qwe.сложение(m1);
                        var o2 = qwe.сложение(m2);
                        if (o1 == o2)
                        {
                            textBox3.Text = "равно";
                        }
                        else
                        {
                            textBox3.Text = "не равно";
                        }
                    }
                    break;
                case "возведение в натуральную степень k (a)":
                    if (!qwe.проверочка(a)||!qwe.проверочка(c))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    else
                    {
                        var st1 = new List<List<string>>(m1);
                        if (qwe.натурал(c))
                        {
                            for (var i = 1; i<Convert.ToInt32(c); i++)
                            {
                                st1 = qwe.умножение(m1, st1);
                            }
                            textBox3.Text = qwe.сложение(st1);
                        }
                        else
                        {
                            MessageBox.Show("Степень k ненатуральная");
                        }

                    }
                    break;
                case "возведение в натуральную степень k (b)":
                    if (!qwe.проверочка(b)||!qwe.проверочка(c))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    else
                    {
                        var st1 = new List<List<string>>(m2);
                        if (qwe.натурал(c))
                        {
                            for (var i = 1; i<Convert.ToInt32(c); i++)
                            {
                                st1 = qwe.умножение(m2, st1);
                            }
                            textBox3.Text = qwe.сложение(st1);
                        }
                        else
                        {
                            MessageBox.Show("Степень k ненатуральная");
                        }

                    }
                    break;
                case "производная (a)":

                    if (!qwe.проверочка(a))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    else
                    {
                        var p1 = qwe.производная(m1);
                        textBox3.Text=qwe.сложение(p1);
                    }
                    break;
                case "производная (b)":
                    if (!qwe.проверочка(a))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    else
                    {
                        var p2 = qwe.производная(m2);
                        textBox3.Text=qwe.сложение(p2);
                    }
                    break;
                case "значение в точке x (a)":
                    if (!qwe.проверочка(d))
                    {
                        MessageBox.Show("Некорректный ввод значения x!");
                        break;
                    }
                    else if (!qwe.проверочка(a))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    if (Convert.ToInt32(d) == 0)
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox3.Text= qwe.значение(m1, d);
                    }
                    break;
                case "значение в точке x (b)":
                    if (!qwe.проверочка(d))
                    {
                        MessageBox.Show("Некорректный ввод значения x!");
                        break;
                    }
                    else if (!qwe.проверочка(b))
                    {
                        MessageBox.Show("Некорректный ввод");
                        break;
                    }
                    if (Convert.ToInt32(d) == 0)
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox3.Text= qwe.значение(m2, d);
                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}