using System.Numerics;
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
            tasks.Items.AddRange(new object[] { "Методы. Задание 1", "Методы. Задание 3", "Методы. Задание 5", "Методы. Задание 7", "Методы. Задание 9", "Условия. Задание 1", "Условия. Задание 3", "Условия. Задание 5", "Условия. Задание 7", "Условия. Задание 9", "Циклы. Задание 1", "Циклы. Задание 3", "Циклы. Задание 5", "Циклы. Задание 7", "Циклы. Задание 9", "Массивы. Задание 1", "Массивы. Задание 3", "Массивы. Задание 5", "Массивы. Задание 7", "Массивы. Задание 9" });
            tasks.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            textTask.AutoSize = false;
            textTask.Size = new Size(600, 700);
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
            outputButton.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            answer.Text = "";
            switch (task)
            {
                case "Методы. Задание 1":
                    textTask.Text = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x); Необходимо реализовать метод таким образом, чтобы он возвращал только дробную часть числа х. Подсказка: вещественное число может быть преобразовано к целому путем отбрасывания дробной части.\r\n\r\nПример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Методы. Задание 3":
                    textTask.Text = "Букву в число.\r\nДана сигнатура метода: public int charToNum (char x); Метод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7 8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал символ в соответствующее число. Подсказка: код символа ‘0’ — это число 48.\r\n\r\nПример:\r\nx=’3’\r\nрезультат: 3\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Методы. Задание 5":
                    textTask.Text = "Двузначное.\r\nДана сигнатура метода: public bool is2Digits (int x); Необходимо реализовать метод таким образом, чтобы он принимал число x и возвращал true, если оно двузначное.\r\nПример 1:\r\nx=32\r\nрезультат: true\r\n\r\nПример 2:\r\nx=516\r\nрезультат: false";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Методы. Задание 7":
                    textTask.Text = "Диапазон.\r\nДана сигнатура метода: public bool isInRange (int a, int b, int num); Метод принимает левую и правую границу (a и b) некоторого числового диапазона. Необходимо реализовать метод таким образом, чтобы он возвращал true, если num входит в указанный диапазон (включая границы). Обратите внимание, что отношение a и b заранее неизвестно (неясно кто из них больше, а кто меньше)\r\n\r\nПример 1:\r\na=5 b=1 num=3\r\nрезультат: true\r\n\r\nПример 2:\r\na=2 b=15 num=33\r\nрезультат: false\r\n";
                    ValueText("a =", "b =", "num =");
                    VisibleValue(true, true, true);
                    ChangedTask();
                    break;
                case "Методы. Задание 9":
                    textTask.Text = "Равенство.\r\nДана сигнатура метода: public bool isEqual(int a, int b, int c); Необходимо реализовать метод таким образом, чтобы он возвращал true, если все три полученных методом числа равны\r\n\r\nПример 1:\r\na=3 b=3 с=3\r\nрезультат: true\r\n\r\nПример 2:\r\na=2 b=15 с=2\r\nрезультат: false";
                    ValueText("a =", "b =", "c =");
                    VisibleValue(true, true, true);
                    ChangedTask();
                    break;
                case "Условия. Задание 1":
                    textTask.Text = "Модуль числа.\r\nДана сигнатура метода: public int abs (int x); Необходимо реализовать метод таким образом, чтобы он возвращал модуль числа х (если оно было положительным, то таким и остается, если он было отрицательным – то необходимо вернуть его без знака минус).\r\n\r\nПример 1:\r\nx=5\r\nрезультат: 5\r\n\r\nПример 2:\r\nx=-3\r\nрезультат: 3";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Условия. Задание 3":
                    textTask.Text = "Тридцать пять.\r\nДана сигнатура метода: public bool is35 (int x); Необходимо реализовать метод таким образом, чтобы он возвращал true, если число x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то вернуть надо false. Подсказка: оператор % позволяет получить остаток от деления.\r\n\r\nПример 1:\r\nx=5\r\nрезультат: true\r\n\r\nПример 2:\r\nx=8\r\nрезультат: false\r\nПример 3:\r\nx=15\r\nрезультат: false";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Условия. Задание 5":
                    textTask.Text = "Тройной максимум.\r\nДана сигнатура метода: public int max3 (int x, int y, int z); Необходимо реализовать метод таким образом, чтобы он возвращал максимальное из трех полученных методом чисел. Подсказка: идеальное решение включает всего две инструкции if и не содержит вложенных if.\r\n\r\nПример 1:\r\nx=5 y=7 z=7\r\nрезультат: 7\r\n\r\nПример 2:\r\nx=8 y=-1 z=4\r\nрезультат: 8";
                    ValueText("x =", "y =", "z =");
                    VisibleValue(true, true, true);
                    ChangedTask();
                    break;
                case "Условия. Задание 7":
                    textTask.Text = "Двойная сумма.\r\nДана сигнатура метода: public int sum2 (int x, int y); Необходимо реализовать метод таким образом, чтобы он возвращал сумму чисел x и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо вернуть число 20.\r\n\r\nПример 1:\r\nx=5 y=7\r\nрезультат: 20\r\n\r\nПример 2:\r\nx=8 y=-1\r\nрезультат: 7";
                    ValueText("x =", "y =", "");
                    VisibleValue(true, true, false);
                    ChangedTask();
                    break;
                case "Условия. Задание 9":
                    textTask.Text = "День недели.\r\nДана сигнатура метода: public String day (int x); Метод принимает число x, обозначающее день недели. Необходимо реализовать метод таким образом, чтобы он возвращал строку, которая будет обозначать текущий день недели, где 1 - это понедельник, а 7 – воскресенье. Если число не от 1 до 7 то верните текст “это не день недели”. Вместо if в данной задаче используйте switch.\r\n\r\nПример:\r\nx=5\r\nрезультат: “пятница”\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Циклы. Задание 1":
                    textTask.Text = "Числа подряд.\r\nДана сигнатура метода: public String listNums (int x); Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все числа от 0 до x (включительно).\r\n\r\nПример:\r\nx=5\r\nрезультат: “0 1 2 3 4 5”";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Циклы. Задание 3":
                    textTask.Text = "Четные числа.\r\nДана сигнатура метода: public String chet (int x); Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все четные числа от 0 до x (включительно). Подсказа для обеспечения качества кода: инструкцию if использовать не следует.\r\n\r\nПример:\r\nx=9\r\nрезультат: “0 2 4 6 8”\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Циклы. Задание 5":
                    textTask.Text = "Длина числа.\r\nДана сигнатура метода: public int numLen (long x); Необходимо реализовать метод таким образом, чтобы он возвращал количество знаков в числе x. Подсказка:\r\nInt у=123/10; // у будет иметь значение 12\r\n\r\nПример:\r\nx=12567\r\nрезультат: 5\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Циклы. Задание 7":
                    textTask.Text = "Квадрат.\r\nДана сигнатура метода: public void square (int x); Необходимо реализовать метод таким образом, чтобы он выводил на экран квадрат из символов ‘*’ размером х, у которого х символов в ряд и х символов в высоту.\r\n\r\nПример 1:\r\nx=2\r\nрезультат:\r\n**\r\n**\r\n\r\nПример 2:\r\nx=4\r\nрезультат:\r\n****\r\n****\r\n****\r\n****\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Циклы. Задание 9":
                    textTask.Text = "Правый треугольник.\r\nДана сигнатура метода: public void rightTriangle (int x); Необходимо реализовать метод таким образом, чтобы он выводил на экран треугольник из символов ‘*’ у которого х символов в высоту, а количество символов в ряду совпадает с номером строки, при этом треугольник выровнен по правому краю. Подсказка: перед символами ‘*’ следует выводить необходимое количество пробелов.\r\n\r\nПример 1:\r\nx=3\r\nрезультат:\r\n  *\r\n **\r\n***\r\n\r\nПример 2:\r\nx=4\r\nрезультат:\r\n   *\r\n  **\r\n ***\r\n****";
                    ValueText("x =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Массивы. Задание 1":
                    textTask.Text = "Поиск первого значения.\r\nДана сигнатура метода: public int findFirst (int[] arr, int x); Необходимо реализовать метод таким образом, чтобы он возвращал индекс первого вхождения числа x в массив arr. Если число не входит в массив – возвращается -1.\r\n\r\nПример:\r\narr=[1,2,3,4,2,2,5]\r\nx=2\r\nрезультат: 1";
                    ValueText("arr =", "x =", "");
                    VisibleValue(true, true, false);
                    ChangedTask();
                    break;
                case "Массивы. Задание 3":
                    textTask.Text = "Поиск максимального.\r\nДана сигнатура метода: public int maxAbs (int[] arr); Необходимо реализовать метод таким образом, чтобы он возвращал наибольшее по модулю (то есть без учета знака) значение массива arr.\r\n\r\nПример:\r\narr=[1,-2,-7,4,2,2,5]\r\nрезультат: -7\r\n";
                    ValueText("arr =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Массивы. Задание 5":
                    textTask.Text = "Добавление массива в массив.\r\nДана сигнатура метода: public int[] add (int[] arr, int[] ins, int pos); Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, который будет содержать все элементы массива arr, однако в позицию pos будут вставлены значения массива ins.\r\n\r\nПример:\r\narr=[1,2,3,4,5]\r\nins=[7,8,9]\r\npos=3\r\nрезультат: [1,2,3,7,8,9,4,5]";
                    ValueText("arr =", "ins =", "pos =");
                    VisibleValue(true, true, true);
                    ChangedTask();
                    break;
                case "Массивы. Задание 7":
                    textTask.Text = "Возвратный реверс.\r\nДана сигнатура метода: public int[] reverseBack (int[] arr); Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, в котором значения массива arr записаны задом наперед.\r\n\r\nПример:\r\narr=[1,2,3,4,5]\r\nрезультат: [5,4,3,2,1]\r\n";
                    ValueText("arr =", "", "");
                    VisibleValue(true, false, false);
                    ChangedTask();
                    break;
                case "Массивы. Задание 9":
                    textTask.Text = "Все вхождения.\r\nДана сигнатура метода: public int[] findAll (int[] arr, int x); Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, в котором записаны индексы всех вхождений числа x в массив arr.\r\n\r\nПример:\r\narr=[1,2,3,8,2,2,9]\r\nx=2\r\nрезультат: [1,4,5]";
                    ValueText("arr =", "x =", "");
                    VisibleValue(true, true, false);
                    ChangedTask();
                    break;
                default:
                    break;
            }
        }

        public string InputIsCorrect(Func <bool> isCorrect, Func<string> resultFunc)
        {
            if (isCorrect())
            {
                return resultFunc();
            }
            else
            {
                return "Ввод не корректен";
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            switch (task)
            {
                case "Методы. Задание 1":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToDouble(value1.Text),
                        () => Tasks.fraction(double.Parse(value1.Text)).ToString());
                    break;
                case "Методы. Задание 3":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToChar(value1.Text),
                        () => Tasks.charToNum(char.Parse(value1.Text)).ToString());
                    break;
                case "Методы. Задание 5":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.is2Digits(int.Parse(value1.Text)).ToString());
                    break;
                case "Методы. Задание 7":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.isInRange(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Методы. Задание 9":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.isEqual(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Условия. Задание 1":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.abs(int.Parse(value1.Text)).ToString());
                    break;
                case "Условия. Задание 3":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.is35(int.Parse(value1.Text)).ToString());
                    break;
                case "Условия. Задание 5":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.max3(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Условия. Задание 7":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.sum2(int.Parse(value1.Text), int.Parse(value2.Text)).ToString());
                    break;
                case "Условия. Задание 9":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.day(int.Parse(value1.Text)).ToString());
                    break;
                case "Циклы. Задание 1":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.listNums(int.Parse(value1.Text)).ToString());
                    break;
                case "Циклы. Задание 3":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.chet(int.Parse(value1.Text)).ToString());
                    break;
                case "Циклы. Задание 5":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToLong(value1.Text),
                        () => Tasks.numLen(int.Parse(value1.Text)).ToString());
                    break;
                case "Циклы. Задание 7":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.square(int.Parse(value1.Text)).ToString());
                    break;
                case "Циклы. Задание 9":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.rightTriangle(int.Parse(value1.Text)).ToString());
                    break;
                case "Массивы. Задание 1":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.findFirst(Tasks.StringToIntArr(value1.Text.Split(' ')), int.Parse(value2.Text)).ToString());
                    break;
                case "Массивы. Задание 3":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')),
                        () => Tasks.maxAbs(Tasks.StringToIntArr(value1.Text.Split(' '))).ToString());
                    break;
                case "Массивы. Задание 5":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToIntArray(value2.Text.Split(' ')) && Tasks.IndexNotOutside(value1.Text.Split(' '), value3.Text),
                        () => Tasks.IntArrToString(Tasks.add(Tasks.StringToIntArr(value1.Text.Split(' ')), Tasks.StringToIntArr(value2.Text.Split(' ')), int.Parse(value3.Text))));
                    break;
                case "Массивы. Задание 7":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')),
                        () => Tasks.IntArrToString(Tasks.reverseBack(Tasks.StringToIntArr(value1.Text.Split(' ')))));
                    break;
                case "Массивы. Задание 9":
                    answer.Text = InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.IntArrToString(Tasks.findAll(Tasks.StringToIntArr(value1.Text.Split(' ')), int.Parse(value2.Text))));
                    break;
            }
        }

        private void InitLabel(Label label, int x, int y)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Controls.Add(label);
        }

        private void InitTextBox(TextBox textBox, int x, int y)
        {
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(131, 27);
            textBox.Visible = false;
            textBox.Font = new Font("Lucida Console", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Controls.Add(textBox);
        }

        private void ValueText(string v1, string v2, string v3)
        {
            value1.Text = "";
            value2.Text = "";
            value3.Text = "";
            valueText1.Text = v1;
            valueText2.Text = v2;
            valueText3.Text = v3;
        }

            private void VisibleValue(bool v1, bool v2, bool v3)
        {
            value1.Visible = v1;
            value2.Visible = v2;
            value3.Visible = v3;
            valueText1.Visible = v1;
            valueText2.Visible = v2;
            valueText3.Visible = v3;
        }

        private void ChangedTask()
        {
            inputValue.Visible = true;
            outputButton.Visible = true;
        }
    }
}
