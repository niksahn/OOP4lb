using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP1lb.Data;
using OOP1lb.Data.Store;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace OOP1lb
{
    public partial class Form2 : Form
    {
        MyHashTable test = MyHashTable.Current;
        int N;
        Zheck[] testArr;
        ListViewItem hashItem = new ListViewItem("HashTable");
        ListViewItem arrayItem = new ListViewItem("Array");
        public Form2()
        {
            N = test.Count;
            testArr = new Zheck[N];
            InitializeComponent();
            listView1.Columns.Add("Коллекция");
            listView1.Columns.Add("Генерирование");
            listView1.Columns.Add("Последовательный выбор");
            listView1.Columns.Add("Случайный выбор");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            listView1.Items.Clear();
            hashItem = new ListViewItem("HashTable");
            arrayItem = new ListViewItem("Array");
            test = MyHashTable.Current;
            testArr = new Zheck[N];
            int startTime = Environment.TickCount;
            hashItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            generateMas();
            arrayItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            foreach (DictionaryEntry? b in test)
            {
                var testik = b;
            }
            hashItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            foreach (Zheck b in testArr)
            {
                var testik = b;
            }
            arrayItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            for (int i = 0; i < N; i++)
            {
                var testik = test[random.Next(0, N - 1).ToString()];
            }
            hashItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            for (int i = 0; i < N; i++)
            {
                var testik = testArr[random.Next(0, N - 1)];
            }
            arrayItem.SubItems.Add((Environment.TickCount - startTime).ToString());


            listView1.Items.Add(hashItem);
            listView1.Items.Add(arrayItem);
        }

        private void generate()
        {
            for (int i = 0; i < N; i++)
            {
                test.Add(new Zheck(i.ToString()));
            }
        }

        private void generateMas()
        {
            for (int i = 0; i < N; i++)
            {
                testArr[i] = new Zheck(i.ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
