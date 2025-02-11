void TypeWriter(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

Dictionary<string, int> player = new Dictionary<string, int>
{
    ["Stamina"] = 100,
    ["Hunger"] = 100,
    ["Thirst"] = 100,
    ["Health"] = 50
};
List<string> inventory = new List<string>();

string[] GetInput(string prompt)
{
    Console.Clear();
    Console.Write("[");
    for(int i =0; i < player["Health"]; i++)
    {
        Console.Write("#");
    } for(int i = 0; i < 50 - player["Health"]; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine("]");
    TypeWriter($"{prompt}");
    Console.Write("> ");
    string inputog = Console.ReadLine();
    string[] input = inputog.Split(' ');
    return input;
}

void GameIntro()
{
    Console.WriteLine("╔═╗╔═╗    ╔╗               ╔╗            ╔═══╗                 \r\n" +
        "║║╚╝║║    ║║              ╔╝╚╗           ║╔═╗║                 \r\n" +
        "║╔╗╔╗║╔╗╔╗║║ ╔══╗╔══╗ ╔══╗╚╗╔╝╔══╗╔═╗    ║║ ╚╝╔══╗ ╔╗╔╗╔══╗╔══╗\r\n" +
        "║║║║║║║║║║║║ ║╔═╝╚ ╗║ ║══╣ ║║ ║╔╗║║╔╝    ║║╔═╗╚ ╗║ ║╚╝║║╔╗║║══╣\r\n" +
        "║║║║║║║╚╝║║╚╗║╚═╗║╚╝╚╗╠══║ ║╚╗║║═╣║║     ║╚╩═║║╚╝╚╗║║║║║║═╣╠══║\r\n" +
        "╚╝╚╝╚╝╚══╝╚═╝╚══╝╚═══╝╚══╝ ╚═╝╚══╝╚╝     ╚═══╝╚═══╝╚╩╩╝╚══╝╚══╝");
    Console.WriteLine("PRESENTS");
    Console.WriteLine(" _______  _______  _______  _______  _______          \r\n" +
        "(  ____ \\(  ____ )(  ___  )(  ____ \\(  ____ \\         \r\n" +
        "| (    \\/| (    )|| (   ) || (    \\/| (    \\/         \r\n" +
        "| (_____ | (____)|| (___) || |      | (__             \r\n" +
        "(_____  )|  _____)|  ___  || |      |  __)            \r\n" +
        "      ) || (      | (   ) || |      | (               \r\n" +
        "/\\____) || )      | )   ( || (____/\\| (____/\\         \r\n" +
        "\\_______)|/       |/     \\|(_______/(_______/         \r\n" +
        "                                                      \r\n" +
        "_________ _______  _______           _______  _______ \r\n" +
        "\\__   __/(  ____ \\(  ____ \\|\\     /|(  ____ \\(  ____ \\\r\n" +
        "   ) (   | (    \\/| (    \\/| )   ( || (    \\/| (    \\/\r\n" +
        "   | |   | (_____ | (_____ | |   | || (__    | (_____ \r\n" +
        "   | |   (_____  )(_____  )| |   | ||  __)   (_____  )\r\n" +
        "   | |         ) |      ) || |   | || (            ) |\r\n" +
        "___) (___/\\____) |/\\____) || (___) || (____/\\/\\____) |\r\n" +
        "\\_______/\\_______)\\_______)(_______)(_______/\\_______)");
    Console.WriteLine("(c) Chaitya Jain, William Buckley & Jack Baker, 2025");
    Console.WriteLine("Press any key to start...");
    Console.ReadLine();
    Console.Clear();
}

GameIntro();
