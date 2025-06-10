namespace DataClasses
{
    public class Training
    {
        private int mode;
        private int complexity;
        private int timerTime;
        private int incrementTime;

        private int correctSolved;
        private int incorrectSolved;
        private int accuracy;
        private int solved;


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
        TimerTime = количество минут на тренировку
         */

        public int TimerTime
        {
            get { return timerTime; }
            set
            {
                if (value >= 0)
                    timerTime = value;
                else
                    throw new Exception("Неверное значение");
            }
        }

        /*
        IncrementTime = количество секунд добавления времени после правильного ответа
         */

        public int IncrementTime {
            get { return incrementTime; }
            set
            {
                if (value >= 0)
                    incrementTime = value;
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

        public int Accuracy {
            get {
                if (solved > 0)
                    return (int)Math.Round((double)correctSolved * 100d / (double)(solved));
                else
                    return 0;
            }
        }


        public Training() {
            Mode = 1;
            Complexity = 1;
            TimerTime = 0;
            IncrementTime = 0;
        }

        public Training(int mode, int complexity, int timerTime, int incrementTime)
        {
            Mode = mode;
            Complexity = complexity;
            TimerTime = timerTime;
            IncrementTime = incrementTime;
        }

        public void IfCorrect() {
            correctSolved++;
            solved++;
        }

        public void IfIncorrect() {
            incorrectSolved++;
            solved++;
        }

        public void Reset() {
            correctSolved = 0;
            incorrectSolved = 0;
            accuracy = 0;
        }

        public override string ToString()
        {
            string modeString = "",
                complexityString = "";

            if (Mode == 1) {
                modeString = "Сложение";
            }
            else if (Mode == 2) {
                modeString = "Вычитание";
            }
            else if (Mode == 3)
            {
                modeString = "Умножение";
            }
            else if (Mode == 4)
            {
                modeString = "Деление";
            }

            if (Complexity == 1) {
                complexityString = "Начальный";
            }
            else if (Complexity == 2)
            {
                complexityString = "Средний";
            }
            else if (Complexity == 3)
            {
                complexityString = "Продвинутый";
            }

            return $"{modeString}. {complexityString}. {TimerTime}+{IncrementTime}";
        }
    }
}
