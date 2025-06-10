using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataClasses
{
    public class Statistics
    {
        public int trainingCountGeneral;
        public int trainingCountAdd, trainingCountSub, trainingCountMult, trainingCountDiv;

        public int correctCountGeneral;
        public int correctCountAdd, correctCountSub, correctCountMult, correctCountDiv;

        public int incorrectCountGeneral;
        public int incorrectCountAdd, incorrectCountSub, incorrectCountMult, incorrectCountDiv;

        public int accuracyGeneral;
        public int accuracyAdd, accuracySub, accuracyMult, accuracyDiv;

        public Statistics() {
            trainingCountGeneral = 0;
            trainingCountDiv = 0;
            trainingCountMult = 0;
            trainingCountSub = 0;
            trainingCountAdd = 0;

            correctCountGeneral = 0;
            correctCountAdd = 0;
            correctCountSub = 0;
            correctCountMult = 0;
            correctCountDiv = 0;

            incorrectCountGeneral = 0;
            incorrectCountAdd = 0;
            incorrectCountSub = 0;
            incorrectCountMult = 0;
            incorrectCountDiv = 0;

            accuracyGeneral = 0;
            accuracyAdd = 0;
            accuracySub = 0;
            accuracyMult = 0;
            accuracyDiv = 0;
        }

        public Statistics(
            int trainingCountGeneral = 0,
            int trainingCountAdd = 0,
            int trainingCountSub = 0,
            int trainingCountMult = 0,
            int trainingCountDiv = 0,

            int correctCountGeneral = 0,
            int correctCountAdd = 0,
            int correctCountSub = 0,
            int correctCountMult = 0,
            int correctCountDiv = 0,

            int incorrectCountGeneral = 0,
            int incorrectCountAdd = 0,
            int incorrectCountSub = 0,
            int incorrectCountMult = 0,
            int incorrectCountDiv = 0,

            int accuracyGeneral = 0,
            int accuracyAdd = 0,
            int accuracySub = 0,
            int accuracyMult = 0,
            int accuracyDiv = 0
            )
        {
            this.trainingCountGeneral = trainingCountGeneral;
            this.trainingCountAdd = trainingCountAdd;
            this.trainingCountSub = trainingCountSub;
            this.trainingCountMult = trainingCountMult;
            this.trainingCountDiv = trainingCountDiv;

            this.correctCountGeneral = correctCountGeneral;
            this.correctCountAdd = correctCountAdd;
            this.correctCountSub = correctCountSub;
            this.correctCountMult = correctCountMult;
            this.correctCountDiv = correctCountDiv;

            this.incorrectCountGeneral = incorrectCountGeneral;
            this.incorrectCountAdd = incorrectCountAdd;
            this.incorrectCountSub = incorrectCountSub;
            this.incorrectCountMult = incorrectCountMult;
            this.incorrectCountDiv = incorrectCountDiv;

            this.accuracyGeneral = accuracyGeneral;
            this.accuracyAdd = accuracyAdd;
            this.accuracySub = accuracySub;
            this.accuracyMult = accuracyMult;
            this.accuracyDiv = accuracyDiv;
        }

        private static int GetVar(string varName) {
            string dir = Directory.GetCurrentDirectory();
            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;
            string path = $"{dir}\\Statistics\\{varName}.txt";
            if (!File.Exists(path))
            {
                //throw new Exception($"Отсутствует файл {varName}.txt");
                return 0;
            }
            else {
                string fileText = File.ReadAllText(path);
                int numInfo;
                if (!int.TryParse(fileText, out numInfo))
                {
                    throw new Exception($"Данные файла {varName}.txt не поддаются преобразованию в число");
                }
                else {
                    return numInfo;
                }
            }
        }

        public void Get() {
            trainingCountGeneral = GetVar("trainingCountGeneral");
            trainingCountDiv = GetVar("trainingCountDiv");
            trainingCountMult = GetVar("trainingCountMult");
            trainingCountSub = GetVar("trainingCountSub");
            trainingCountAdd = GetVar("trainingCountAdd");

            correctCountGeneral = GetVar("correctCountGeneral");
            correctCountAdd = GetVar("correctCountAdd");
            correctCountSub = GetVar("correctCountSub");
            correctCountMult = GetVar("correctCountMult");
            correctCountDiv = GetVar("correctCountDiv");

            incorrectCountGeneral = GetVar("incorrectCountGeneral");
            incorrectCountAdd = GetVar("incorrectCountAdd");
            incorrectCountSub = GetVar("incorrectCountSub");
            incorrectCountMult = GetVar("incorrectCountMult");
            incorrectCountDiv = GetVar("incorrectCountDiv");

            accuracyGeneral = ToAccuracy(correctCountGeneral, incorrectCountGeneral);
            accuracyAdd = ToAccuracy(correctCountAdd, incorrectCountAdd);
            accuracySub = ToAccuracy(correctCountSub, incorrectCountSub);
            accuracyMult = ToAccuracy(correctCountMult, incorrectCountMult);
            accuracyDiv = ToAccuracy(correctCountDiv, incorrectCountDiv);
        }

        private static void SetVar(int var, string varName) {
            string dir = Directory.GetCurrentDirectory();
            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;
            string path = $"{dir}\\Statistics\\{varName}.txt";
            string dataText = var.ToString();
            File.WriteAllText(path, dataText);
        }

        public void Set() {
            SetVar(trainingCountGeneral, "trainingCountGeneral");
            SetVar(trainingCountDiv, "trainingCountDiv");
            SetVar(trainingCountMult, "trainingCountMult");
            SetVar(trainingCountSub, "trainingCountSub");
            SetVar(trainingCountAdd, "trainingCountAdd");

            SetVar(correctCountAdd, "correctCountAdd");
            SetVar(correctCountSub, "correctCountSub");
            SetVar(correctCountMult, "correctCountMult");
            SetVar(correctCountDiv, "correctCountDiv");
            SetVar(correctCountGeneral, "correctCountGeneral");

            SetVar(incorrectCountGeneral, "incorrectCountGeneral");
            SetVar(incorrectCountAdd, "incorrectCountAdd");
            SetVar(incorrectCountSub, "incorrectCountSub");
            SetVar(incorrectCountMult, "incorrectCountMult");
            SetVar(incorrectCountDiv, "incorrectCountDiv");
        }

        public static void SetTrainig(Training training) {
            Statistics statistics = new();
            statistics.Get();
            statistics.trainingCountGeneral++;
            statistics.correctCountGeneral += training.CorrectSolved;
            statistics.incorrectCountGeneral += training.IncorrectSolved;

            if (training.Mode == 1)
            {
                statistics.trainingCountAdd++;
                statistics.correctCountAdd += training.CorrectSolved;
                statistics.incorrectCountAdd += training.IncorrectSolved;
            }
            else if (training.Mode == 2)
            {
                statistics.trainingCountSub++;
                statistics.correctCountSub += training.CorrectSolved;
                statistics.incorrectCountSub += training.IncorrectSolved;

            }
            else if (training.Mode == 3)
            {
                statistics.trainingCountMult++;
                statistics.correctCountMult += training.CorrectSolved;
                statistics.incorrectCountMult += training.IncorrectSolved;
            }
            else if (training.Mode == 4)
            {
                statistics.trainingCountDiv++;
                statistics.correctCountDiv += training.CorrectSolved;
                statistics.incorrectCountDiv += training.IncorrectSolved;
            }
            statistics.Set();
        }

        public static void DeleteStat() {
            Statistics statistics = new();
            statistics.Set();
        }

        private int ToAccuracy(int corrects, int mistakes) {
            if (corrects + mistakes == 0)
                return 0;
            else
                return (int)Math.Round((double)corrects * 100d / (double)(corrects + mistakes));
        }
    }
}
