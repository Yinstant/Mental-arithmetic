namespace DataClasses
{
    public class Training
    {
        private int mode;
        private int complexity;
        private int timerTime;

        private int correctSolved;
        private int incorrectSolved;


        /*
        По значениям Mode:
        1 - Сложение
        2 - Вычитание
        3 - Умножение
        4 - Деление
        */

        public int Mode {
            get { return mode; }
            set {
                if (value < 5 && value > 0)
                    mode = value;
                else
                    throw new Exception("Значение вне промежутка от 1 до 4");
            }
        }

        /*
        По значениям Complexity:
        1 - Легко
        2 - Средне
        3 - Сложно
          */

        public int Complexity
        {
            get { return complexity; }
            set
            {
                if (value < 4 && value > 0)
                    complexity = value;
                else
                    throw new Exception("Значение вне промежутка от 1 до 3");
            }
        }

        /*
        По значениям TimerTime:
        0 - Без ограничений по времени
        1 - 1 минута
        3 - 3 минуты
        5 - 5 минут
        15 - 15 минут
         */

        public int TimerTime
        {
            get { return timerTime; }
            set
            {
                if (value == 0 || value == 1 || value == 3 || value == 5 || value == 15)
                    timerTime = value;
                else
                    throw new Exception("Неверное значение");
            }
        }

        public int CorrectSolved {
            get { return correctSolved; }
        }

        public int IncorrectSolved
        {
            get { return incorrectSolved; }
        }


        public Training() {
            Mode = 1;
            Complexity = 1;
            TimerTime = 1;
        }

        public Training(int mode, int complexity, int timerTime)
        {
            Mode = mode;
            Complexity = complexity;
            TimerTime = timerTime;
        }

        public void IfCorrect() {
            correctSolved++;
        }

        public void IfIncorrect() {
            incorrectSolved++;
        }

        public void Reset() {
            correctSolved = 0;
            incorrectSolved = 0;
        }
    }
}
