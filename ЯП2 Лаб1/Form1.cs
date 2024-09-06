using System.Threading.Tasks;

namespace ЯП2_Лаб1
{
    public partial class Form1 : Form
    {
        string task;

        public Form1()
        {
            InitializeComponent();
            InitField();
        }

        private void InitField()
        {
            tasks = new ComboBox();
            chooseTask = new Label();
            textTask = new Label();
            inputValue = new Label();
            value1 = new TextBox();
            value2 = new TextBox();
            value3 = new TextBox();
            outputButton = new Button();
            valueText1 = new Label();
            valueText2 = new Label();
            valueText3 = new Label();
            answer = new Label();
            int delta = 35;
            // 
            // tasks
            // 
            tasks.DropDownStyle = ComboBoxStyle.DropDownList;
            tasks.FormattingEnabled = true;
            tasks.Items.AddRange(new object[] { "Методы. Задание 1", "Методы. Задание 3", "Методы. Задание 5" });
            tasks.Location = new Point(20, 42);
            tasks.Cursor = Cursors.Hand;
            tasks.Name = "tasks";
            tasks.Size = new Size(200, 28);
            tasks.TabIndex = 0;
            tasks.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // chooseTask
            // 
            InitLabel(chooseTask, 25, 19);
            chooseTask.Text = "Выберите задание: ";
            // 
            // textTask
            // 
            InitLabel(textTask, 17, 80);
            textTask.Text = "Задание не выбрано";
            // 
            // inputValue
            // 
            InitLabel(inputValue, 625, 19);
            inputValue.Text = "Ввод значений:";
            inputValue.Visible = false;
            // 
            // value
            // 
            InitTextBox(value1, 667, 51);
            InitTextBox(value2, 667, 51 + delta);
            InitTextBox(value3, 667, 51 + delta * 2);
            // 
            // valueText
            //
            InitLabel(valueText1, 625, 52);
            valueText1.Text = "x =";
            InitLabel(valueText2, 625, 52 + delta);
            InitLabel(valueText3, 625, 52 + delta * 2);
            valueText1.Visible = false;
            valueText2.Visible = false;
            valueText3.Visible = false;
            // 
            // answer
            //
            InitLabel(answer, 625, 52 + delta * 3);
            // 
            // outputButton
            // 
            //outputButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputButton.AutoSize = true;
            outputButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            outputButton.BackgroundImageLayout = ImageLayout.None;
            outputButton.Cursor = Cursors.Hand;
            outputButton.Location = new Point(805, 50);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(148, 30);
            outputButton.TabIndex = 0;
            outputButton.Text = "Вывести результат";
            outputButton.UseVisualStyleBackColor = true;
            outputButton.Visible = false;
            outputButton.Click += outputButton_Click;


            Controls.Add(tasks);
            Controls.Add(outputButton);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            task = tasks.Text;
            switch (task)
            {
                case "Методы. Задание 1":
                    textTask.Text = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал только\r\nдробную часть числа х. Подсказка: вещественное число может быть\r\nпреобразовано к целому путем отбрасывания дробной части.\r\n\r\nПример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
                    ChangedTask();
                    break;
                case "Методы. Задание 3":
                    textTask.Text = "Букву в число.\r\nДана сигнатура метода: public int charToNum (char x);\r\nМетод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7\r\n8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал\r\nсимвол в соответствующее число. Подсказка: код символа ‘0’ — это число 48.\r\n\r\nПример:\r\nx=’3’\r\nрезультат: 3\r\n";
                    ChangedTask();
                    break;
                case "Методы. Задание 5":
                    textTask.Text = "Двузначное.\r\nДана сигнатура метода: public bool is2Digits (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он принимал число x и\r\nвозвращал true, если оно двузначное.\r\nПример 1:\r\nx=32\r\nрезультат: true\r\n\r\nПример 2:\r\nx=516\r\nрезультат: false";
                    ChangedTask();
                    break;
                default:
                    break;
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            switch (task)
            {
                case "Методы. Задание 1":
                    answer.Text = Tasks.fraction(double.Parse(value1.Text)).ToString();
                    break;
                case "Методы. Задание 3":
                    break;
                case "Методы. Задание 5":
                    break;
            }
        }

        private void InitLabel(Label label, int x, int y)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            Controls.Add(label);
        }

        private void InitTextBox(TextBox textBox, int x, int y)
        {
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(131, 27);
            textBox.Visible = false;
            Controls.Add(textBox);
        }

        private void ChangedTask()
        {
            inputValue.Visible = true;
            valueText1.Visible = true;
            value1.Visible = true;
            outputButton.Visible = true;
        }
    }
}
