
namespace Player
{
    public class Player
    {
        public string name;
        public string job;
        public int level;
        public int Hp;
        public int Mp;
        public int strength;
        public long demege;
        public float magicStength;
        public long magicdemege;
        public int defensive;
        public int money;

        public void SetPlayerInfo(string name, string job, int level, int Hp, int Mp, int strength, long demege, float magicStength, long magicdemege, int defensive, int money)
        {
            this.name = name;
            this.job = job;
            this.level = level;
            this.Hp = Hp;
            this.Mp = Mp;
            this.strength = strength;
            this.demege = demege;
            this.magicStength = magicStength;
            this.magicdemege = magicdemege;
            this.defensive = defensive;
            this.money = money;
        }

        public void showPlayerInfo()
        {
            bool isRunning = true;

            do
            {
                Console.Clear();
                Console.WriteLine("캐릭터 정보");
                Console.WriteLine($"이름: {name}");
                Console.WriteLine($"직업: {job}");
                Console.WriteLine($"레벨: {level}");
                Console.WriteLine($"체력: {Hp}");
                Console.WriteLine($"마력: {Mp}");
                Console.WriteLine($"공격력: {strength}");
                Console.WriteLine($"데미지: {demege}");
                Console.WriteLine($"마법공격력: {magicStength}");
                Console.WriteLine($"마법데미지: {magicdemege}");
                Console.WriteLine($"방어력: {defensive}");
                Console.WriteLine($"골드: {money}");

                Console.WriteLine();
                Console.WriteLine("p: 나가기(방향키 또는 단축키 입력)");
                Console.Write(">>> ");

                string Input = Console.ReadLine();
                {
                    switch (Input)
                    {
                        case "p":
                            isRunning = false;
                            break;
                        default:
                            GameManager.ErrorMessage("잘못된 접근입니다. 이전으로 가러면 '0' 키를 눌러주세요.");
                            break;
                    }
                }

            } while (isRunning);

        }
    }
}