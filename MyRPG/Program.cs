using MyRPG;


bool isRunning = true;

bool isPlayerTurn = true;

Random randomMaker = new Random();

Character player;


void SetupGame()
{
    Console.WriteLine("Setting up game...");

    player = new Character();

    player.name = "The Hero";

    Console.WriteLine($"Main character name: {player.name}\n");

    Console.WriteLine("Enter enemy amount:");

    string enemyAmount = Console.ReadLine();

    List<Enemy> enemyList = new List<Enemy>();

    for (int i = 0; i < Convert.ToInt32(enemyAmount); i++)
    {

        Enemy enemy = new Enemy();

        enemy.enemyID = i + 1;
        enemyList.Add(enemy);

    }
    foreach (Enemy enemy in enemyList)
    {
        Console.WriteLine(enemy.enemyID);
    }
}

SetupGame();

while (isRunning)
{
    if (isPlayerTurn)
    {
        Console.WriteLine("\n\n1. Attack!");
        Console.WriteLine("2. Level up attack power.");
        Console.WriteLine("3. Defend (evade chance bonus for one turn\n");
        Console.WriteLine("\tPick an action");
        int userAction = Convert.ToInt32(Console.ReadLine());

        switch (userAction)
        {
            case 1:
                AttackSelector();
                break;
            case 2:
                player.LevelUpAttack();
                break;
            case 3:
                player.name = "tktjtlk";
                break;
        }
    }
    else
    {

    }


    string userInput = Console.ReadLine();
}

void PlayerTurn()
{
    isRunning = false;

}