namespace ЯП2_Лаб1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitField();
        }

        private void InitField()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            text = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            int x = this.Size.Width;
            int y = this.Size.Height;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Задание 1", "Задание 2", "Задание 3" });
            comboBox1.Location = new Point(826, 52);
            //comboBox1.Location = new Point(x - 330, y - 505);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(826, 19);
            //label1.Location = new Point(x - 330, y - 530);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 1;
            label1.Text = "Выберите задание: ";
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(17, 18);
            text.Name = "text";
            text.Size = new Size(552, 180);
            text.TabIndex = 0;
            text.Text = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x);" +
                "\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал только\r\nдробную часть числа х. " +
                "Подсказка: вещественное число может быть\r\nпреобразовано к целому путем отбрасывания дробной части.\r\n\r\n" +
                "Пример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 19);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 0;
            label2.Text = "Вывод ответа:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(622, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 0;


            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(text);
            Controls.Add(label2);
            Controls.Add(textBox1);
        }
    }
}
