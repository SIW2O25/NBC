namespace Player
{
    public class GameManager
    {
        public static void ErrorMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetPlayerInfo("보리스", "검사", 15, 1500, 850, 35, 450, 55, 750, 26, 50000);

            Inventory inventory = new Inventory();
            inventory.SetInventoryInfo("\\등급(노멀)\n\t\t\\내구도 30/100\n\t\t\\공격력 +5\n\t\t\\데미지 8~16", "\\등급(노멀)\n\t\t\\내구도 80/100\t\n\t\t\\방어력 +15", "\\등급(레어)\t\n\t\t\\내구도 100/100\t\n\t\t\\방어력 + 35", "\\100 회복력", "\\40 회복력");

            Shop shop = new Shop();
            shop.SetShopInfo("\\(소)\n\t1000 G", "\\(소)\n\t1200G ", "\\방어력 +5\n\t500G", "\\공격력 +3\\데미지 1~6\n\t800G");

            Menu menu = new Menu();
            menu.SetPlayer(player);
            menu.SetInventory(inventory);
            menu.SetShop(shop);
            menu.DisplayMenu();

        }
    }
   
}
