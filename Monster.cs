using System.Xml.Linq;

namespace Player
{
    public class Monster
    {
        public string monster;
        public string greenSlime;
        public string redSlime;
        public string blueSlime;
        public string grayWolf;
        public string blackWolf;
        public string whiteWolf;
        public string angryGolem;

        public void SetMonsterInfo(string monster , string greenSlime, string redSlime, string blueSlime, string grayWolf, string blackWolf, string whiteWolf, string angryGolem)
        {
            //2. 그룸형 변수
            string[] monster = { "그린 슬라임", "레드 슬라임", "블루 슬라임", "그레이 울프", "블랙 울프", "화난 골렘" };
            //3. 배열
            int[] monsterLevel = new int[6];
            monsterLevel[0] = 1;
            monsterLevel[1] = 2;
            monsterLevel[2] = 3;
            monsterLevel[3] = 4;
            monsterLevel[4] = 5;
            monsterLevel[5] = 8;
            monsterLevel[6] = 11;
        }

        public void ShowMonsterInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("몬스터가 출현했다!");

                Console.WriteLine();
                switch (monster[1])
                {
                    case "그린 슬라임":
                    case "레드 슬라임":
                    case "블루 슬라임":
                        Console.WriteLine("소형 몬스터 출현!");
                        break;
                    case "그레이 울프":
                    case "블랙 울프":
                    case "화이트 울프":
                        Console.WriteLine("중형 몬스터 출현!");
                        break;
                    case "화난 골렘":
                        Console.WriteLine("대형 몬스터 출현!");
                        break;
                    case "0":
                        isRunning = false;
                        break;
                    default:
                        GameManager.ErrorMessage("잘못된 접근입니다. 이전으로 가려면 '0' 키를 눌러주세요.");
                        break;
                } 
            } while (isRunning);
        }
    }
}
