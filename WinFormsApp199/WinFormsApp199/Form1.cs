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
            var m1 = qwe.���������(a);
            var m2 = qwe.���������(b);
            switch (comboBox1.Text)
            {
                case "��������":
                    if (!qwe.����������(a) || !qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����!");
                    }
                    else
                    {
                        var s3 = new List<List<string>> { };
                        s3.AddRange(m1);
                        s3.AddRange(m2);
                        textBox3.Text = qwe.��������(s3);
                    }
                    break;
                case "���������(a-b)":
                    if (!qwe.����������(a) || !qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����!");
                    }
                    else
                    {
                        var v2 = qwe.���������(m2);
                        var v3 = new List<List<string>> { };
                        v3.AddRange(m1);
                        v3.AddRange(v2);
                        textBox3.Text = qwe.��������(v3);
                    }
                    break;
                case "���������(b-a)":
                    if (!qwe.����������(a) || !qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����!");
                    }
                    else
                    {
                        var v1 = qwe.���������(m1);
                        var v4 = new List<List<string>> { };
                        v4.AddRange(v1);
                        v4.AddRange(m2);
                        textBox3.Text = qwe.��������(v4);
                    }
                    break;
                case "���������":
                    if (!qwe.����������(a) || !qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����!");
                    }
                    else
                    {
                        var y3 = qwe.���������(m1, m2);
                        textBox3.Text = qwe.��������(y3);
                    }
                    break;
                case "��������� (�����, �� �����)":
                    if (!qwe.����������(a) || !qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����!");
                    }
                    else
                    {
                        var o1 = qwe.��������(m1);
                        var o2 = qwe.��������(m2);
                        if (o1 == o2)
                        {
                            textBox3.Text = "�����";
                        }
                        else
                        {
                            textBox3.Text = "�� �����";
                        }
                    }
                    break;
                case "���������� � ����������� ������� k (a)":
                    if (!qwe.����������(a)||!qwe.����������(c))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    else
                    {
                        var st1 = new List<List<string>>(m1);
                        if (qwe.�������(c))
                        {
                            for (var i = 1; i<Convert.ToInt32(c); i++)
                            {
                                st1 = qwe.���������(m1, st1);
                            }
                            textBox3.Text = qwe.��������(st1);
                        }
                        else
                        {
                            MessageBox.Show("������� k �������������");
                        }

                    }
                    break;
                case "���������� � ����������� ������� k (b)":
                    if (!qwe.����������(b)||!qwe.����������(c))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    else
                    {
                        var st1 = new List<List<string>>(m2);
                        if (qwe.�������(c))
                        {
                            for (var i = 1; i<Convert.ToInt32(c); i++)
                            {
                                st1 = qwe.���������(m2, st1);
                            }
                            textBox3.Text = qwe.��������(st1);
                        }
                        else
                        {
                            MessageBox.Show("������� k �������������");
                        }

                    }
                    break;
                case "����������� (a)":

                    if (!qwe.����������(a))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    else
                    {
                        var p1 = qwe.�����������(m1);
                        textBox3.Text=qwe.��������(p1);
                    }
                    break;
                case "����������� (b)":
                    if (!qwe.����������(a))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    else
                    {
                        var p2 = qwe.�����������(m2);
                        textBox3.Text=qwe.��������(p2);
                    }
                    break;
                case "�������� � ����� x (a)":
                    if (!qwe.����������(d))
                    {
                        MessageBox.Show("������������ ���� �������� x!");
                        break;
                    }
                    else if (!qwe.����������(a))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    if (Convert.ToInt32(d) == 0)
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox3.Text= qwe.��������(m1, d);
                    }
                    break;
                case "�������� � ����� x (b)":
                    if (!qwe.����������(d))
                    {
                        MessageBox.Show("������������ ���� �������� x!");
                        break;
                    }
                    else if (!qwe.����������(b))
                    {
                        MessageBox.Show("������������ ����");
                        break;
                    }
                    if (Convert.ToInt32(d) == 0)
                    {
                        textBox3.Text = "0";
                    }
                    else
                    {
                        textBox3.Text= qwe.��������(m2, d);
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