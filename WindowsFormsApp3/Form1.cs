using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Init()
        {
            Action TextBoxCreation = delegate
            {
                textBox1 = new TextBox();
                textBox1.Location = new Point(20, 34);
                textBox1.Name = "textBox1";
                textBox1.Size = new Size(97, 20);
                textBox1.TabIndex = 0;
                Controls.Add(textBox1);

                textBox2 = new TextBox();
                textBox2.Location = new Point(123, 34);
                textBox2.Name = "textBox2";
                textBox2.Size = new Size(218, 20);
                textBox2.TabIndex = 1;
                Controls.Add(textBox2);

                textBox3 = new TextBox();
                textBox3.Location = new Point(347, 34);
                textBox3.Name = "textBox3";
                textBox3.Size = new Size(73, 20);
                textBox3.TabIndex = 2;
                Controls.Add(textBox3);
            };
            Action ButtonCreation = delegate
            {
                button2 = new Button();
                button2.Location = new Point(426, 33);
                button2.Name = "button1";
                button2.Size = new Size(63, 22);
                button2.TabIndex = 3;
                button2.Text = "Найти";
                button2.UseVisualStyleBackColor = true;
                Controls.Add(button2);

                button3= new Button();
                button3.Location = new Point(495, 33);
                button3.Name = "button2";
                button3.Size = new Size(75, 22);
                button3.TabIndex = 4;
                button3.Text = "Остановить";
                button3.UseVisualStyleBackColor = true;
                Controls.Add(button3);

                checkBox1 = new CheckBox();
                checkBox1.AutoSize = true;
                checkBox1.Location = new Point(576, 36);
                checkBox1.Name = "checkBox1";
                checkBox1.Size = new Size(80, 17);
                checkBox1.TabIndex = 5;
                checkBox1.Text = "Подкаталоги";
                checkBox1.UseVisualStyleBackColor = true;
                Controls.Add(checkBox1);

            };
            Action LabelCreation = delegate
            {
                label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new Point(51, 18);
                label1.Name = "label1";
                label1.Size = new Size(35, 13);
                label1.TabIndex = 6;
                label1.Text = "Файл";
                Controls.Add(label1);

                label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new Point(168, 18);
                label2.Name = "label2";
                label2.Size = new Size(35, 13);
                label2.TabIndex = 7;
                label2.Text = "Слово или фраза в файле";
                Controls.Add(label2);

                label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new Point(367, 18);
                label3.Name = "label3";
                label3.Size = new Size(35, 13);
                label3.TabIndex = 8;
                label3.Text = "Диск";
                Controls.Add(label3);

                label4 = new Label();
                label4.AutoSize = true;
                label4.Location = new Point(297, 85);
                label4.Name = "label4";
                label4.Size = new Size(35, 13);
                label4.TabIndex = 9;
                label4.Text = "Результаты поиска";
                Controls.Add(label4);
            };
            Action ListViewCreation = delegate
            {
                listView1 = new ListView();
                listView1.HideSelection = false;
                listView1.Location = new System.Drawing.Point(20, 109);
                listView1.Name = "listView1";
                listView1.Size = new System.Drawing.Size(640, 320);
                listView1.TabIndex = 10;
                listView1.UseCompatibleStateImageBehavior = false;
                Controls.Add(listView1);

            };

            Invoke(TextBoxCreation);
            Thread.Sleep(1000);
            Invoke(ButtonCreation);
            Thread.Sleep(1000);
            Invoke(LabelCreation);
            Thread.Sleep(1000);
            Invoke(ListViewCreation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            thread = new Thread(Init);
            thread.Start();
        }
    }
}
