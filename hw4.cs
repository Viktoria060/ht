
internal class Program
{
    class Answer
    {
        public bool IsCorrect;

        public Answer(bool isCorrect)
        {
            IsCorrect = isCorrect;
        }
    }

    class Question
    {
        public string Text ;
        public Answer[] Answers;
        public Question(string text, string[] answers, int correctAnswer)
        {
            Text = text;
            Answers = new Answer[answers.Length];
            for (int i = 0; i < answers.Length; i++)
            {
                Answers[i] = new Answer(i == correctAnswer);
            }
        }
    }

    private static void Main(string[] args)
    {
        Question[] questions = new Question[10];
        questions[0] = new Question("Сколько длится мгновение?", new string[] { "1 секунду", "60 секунд", "90 секунд", "120 секунд" }, 2);
        questions[1] = new Question("Как называется разновидность воды, в которой атом водорода замещён его изотопом дейтерием?",new string [] {"Тяжёлая", "Средняя", "Лёгкая", "Невесомая"}, 0);
        questions[2] = new Question("Какое растение существует на самом деле?",new string [] {"Лох чилийский","Лох индийский","Лох греческий","Лох русский"}, 1);
        questions[3] = new Question("Какого персонажа нет в известной считалке «На золотом крыльце сидели»?",new string [] {"Сапожника","Портного","Короля","Кузнеца"}, 3);
        questions[4] = new Question("Что такое десница?",new string [] {"Бровь","Глаз","Шея","Рука"}, 3);
        questions[5] = new Question("Одним из направлений какой религиозной философии является учение дзен?",new string [] {"Буддизм","Индуизм","Иудаизм","Даосизм"}, 0);
        questions[6] = new Question("Сколько морей омывают Балканский полуостров?",new string [] {"5","6","4","3"}, 1);
        questions[7] = new Question("В какой из этих столиц бывших союзных республик раньше других появилось метро?",new string [] {"Баку","Ереван","Минск","Тбилиси"}, 3);
        questions[8] = new Question("Как называется крепкий спиртной напиток из сока сахарного тростника?",new string [] {"Коньяк","Джин","Ром","Виски"}, 2);
        questions[9] = new Question("Какого цвета нет на флаге Армении?",new string [] {"Красный","Белый","Оранжевый","Синий"}, 1);

        for (int i = 0; i < questions.Length; i++)
        {
            ManageQuestion(questions[i]);
        }
    }

    static void ManageQuestion(Question question)
    {
        System.Console.WriteLine(question.Text);
        for (int j = 0; j < question.Answers.Length; j++)
        {
            System.Console.WriteLine($" {j + 1}. {question.Answers[j]}.");
        }
        System.Console.WriteLine("Впишите свой ответ:");
        int answer = int.Parse(System.Console.ReadLine());
        if (question.Answers[answer - 1].IsCorrect)
        {
            System.Console.WriteLine("Правильно!");
        }
        else
        {
            System.Console.WriteLine("Неправильно!");
            return;
        }
    }
}

