using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class Settings
    {
        private string screenSize;
        public bool isTopPanel;

        public Settings() {
            ScreenSize = "Fixed";
            isTopPanel = true;
        }

        public string ScreenSize
        {
            get { return screenSize; }
            set {
                if (value == "Fixed" || value == "Full" || value == "Adaptive")
                {
                    screenSize = value;
                }
                else {
                    throw new Exception("Неверное значение размера экрана!");
                }
            }
        }

        private static string GetVar(string varName)
        {
            string dir = Directory.GetCurrentDirectory();
            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;
            string path = $"{dir}\\Settings\\{varName}.txt";
            if (!File.Exists(path))
            {
                throw new Exception($"Отсутствует файл {varName}.txt");
            }
            else
            {
                string fileText = File.ReadAllText(path);
                return fileText;
            }
        }

        public void Get() {
            ScreenSize = GetVar("screenSize");
            isTopPanel = (GetVar("isTopPanel") == "True") ? true : false;
        }

        private static void SetVar(string var, string varName)
        {
            string dir = Directory.GetCurrentDirectory();
            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;
            string path = $"{dir}\\Settings\\{varName}.txt";
            string dataText = var;
            File.WriteAllText(path, dataText);
        }

        public void Set()
        {
            SetVar(screenSize, "screenSize");
            SetVar(isTopPanel.ToString(), "isTopPanel");
        }
    }
}
