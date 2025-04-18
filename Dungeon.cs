using System.Xml.Linq;

namespace Player
{
    public class Dungeon
    {
        public string slimeField;
        public string wolfField;
        public string golemCave;

        public void SetDungeonInfo(string slimeField, string wolfField, string golemCave)
        {
            this.slimeField = slimeField;
            this.wolfField = wolfField;
            this.golemCave = golemCave;
        }

        public void ShowDungeonInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("입장 가능한 던전");

                string Input = Console.ReadLine();
                {
                    switch (Input)
                    {
                        case "1":
                            Console.WriteLine($"1. 슬라임 평원: {slimeField}");
                            isRunning = false;
                            break;
                        case "2":
                            Console.WriteLine($"2. 늑대 평원: {wolfField}");
                            isRunning = false;
                            break;
                        case "3":
                            Console.WriteLine($"3. 골렘 동굴: {golemCave}");
                            isRunning = false;
                            break;
                        case "0":
                            isRunning = false;
                            break;
                        default:
                            GameManager.ErrorMessage("잘못된 접근입니다. 이전으로 가려면 '0' 키를 눌러주세요.");
                            break;
                    }
                }
            } while (isRunning);
        }
    }

    
        
}
