using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class Achievement
    {
        private int mode = 1;
        private int levelID;

        public int Mode {
            get => mode;
            set {
                if (value < 5 && value > 0) {
                    mode = value;
                }
                else
                    throw new Exception("Значение вне промежутка от 1 до 4");
            }
        }

        public string ModeString {
            get {
                if (Mode == 1) {
                    return "Addition";
                }
                else if (Mode == 2) {
                    return "Substraction";
                }
                else if (Mode == 3)
                {
                    return "Multiplication";
                }
                else
                {
                    return "Division";
                }
            }
        }

        public int LevelID {
            get => levelID;
            set {
                if (value < 5 && value >= 0)
                    levelID = value;
                else
                    throw new Exception("Значение вне промежутка от 0 до 4");
            }
        }

        public string Level {
            get
            {
                if (LevelID == 0)
                {
                    return "None";
                }
                else if (LevelID == 1)
                {
                    return "Bronze";
                }
                else if (LevelID == 2)
                {
                    return "Silver";
                }
                else if (LevelID == 3)
                {
                    return "Gold";
                }
                else {
                    return "Diamond";
                }
            }
        }

        public Achievement(int mode) {
            this.Mode = mode;
            this.LevelID = 0;
        }

        public Achievement(int mode, int levelID)
        {
            this.Mode = mode;
            this.LevelID = levelID;
        }
        public Image GetIcon()
        {
            string dir = Directory.GetCurrentDirectory();

            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;

            string path;

            if (Level == "None")
            {
                path = $"{dir}\\Resourses\\Achievements\\None.png";
            }
            else { 
                path = $"{dir}\\Resourses\\Achievements\\{ModeString}{Level}.png";
            }

            try
            {
                return Image.FromFile(path);
            }
            catch
            {
                throw new Exception($"Не найден файл {path}!");
            }
        }

        public int LeftPoint {
            get {
                if (Level == "None")
                {
                    return 0;
                }
                else if (Level == "Bronze")
                {
                    return 25;
                }
                else if (Level == "Silver")
                {
                    return 100;
                }
                else if (Level == "Gold")
                {
                    return 500;
                }
                else {
                    return 500;
                }
            }
        }

        public int RightPoint
        {
            get
            {
                if (Level == "None")
                {
                    return 25;
                }
                else if (Level == "Bronze")
                {
                    return 100;
                }
                else if (Level == "Silver")
                {
                    return 500;
                }
                else if (Level == "Gold")
                {
                    return 2500;
                }
                else
                {
                    return 2500;
                }
            }
        }

        public void GetLevel() {
            string dir = Directory.GetCurrentDirectory();

            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;

            string path = $"{dir}\\Levels\\{ModeString}.txt";
            if (!File.Exists(path))
            {
                throw new Exception($"Отсутствует файл {ModeString}.txt");
            }
            else
            {
                string fileText = File.ReadAllText(path);

                if (fileText == "Bronze")
                {
                    LevelID = 1;
                }
                else if (fileText == "Silver")
                {
                    LevelID = 2;
                }
                else if (fileText == "Gold")
                {
                    LevelID = 3;
                }
                else if (fileText == "Diamond")
                {
                    LevelID = 4;
                }
                else {
                    LevelID = 0;
                }
            }
        }

        public int CorrectCount {
            get {
                Statistics statistics = new();
                statistics.Get();

                int correctCount;

                if (Mode == 1)
                {
                    correctCount = statistics.correctCountAdd;
                }
                else if (Mode == 2)
                {
                    correctCount = statistics.correctCountSub;
                }
                else if (Mode == 3)
                {
                    correctCount = statistics.correctCountMult;
                }
                else {
                    correctCount = statistics.correctCountDiv;
                }

                return correctCount;
            }
        }

        public int Progress {
            get {
                int len = RightPoint - LeftPoint;
                int pos = CorrectCount - LeftPoint;

                return (int)Math.Round((double)pos * 100d / (double)len);
            }
        }

        public void SetLevel() {
            string dir = Directory.GetCurrentDirectory();

            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;

            string path = $"{dir}\\Levels\\{ModeString}.txt";

            File.WriteAllText(path, Level);
        }

        public bool IsChanged() {
            return CorrectCount > RightPoint;
        }

        public void IncreaseLevel() {
            LevelID = Math.Min(LevelID + 1, 4);
        }

        public static void Delete() {
            Achievement achievementAdd = new(1);
            Achievement achievementSub = new(2);
            Achievement achievementMult = new(3);
            Achievement achievementDiv = new(4);

            achievementAdd.SetLevel();
            achievementSub.SetLevel();
            achievementMult.SetLevel();
            achievementDiv.SetLevel();
        }
    }
}
