void TypeWriter(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

// NEW CODE
List<string> GivePlayer(string newItem, int manyItems, List<string> newInv)
{
    for(int i = manyItems; i >= 0; i--)
    {
        newInv.Add(newItem);
    }
    return newInv;
}

// END OF NEW CODE


Console.WriteLine("╔═╗╔═╗    ╔╗               ╔╗            ╔═══╗                 \r\n║║╚╝║║    ║║              ╔╝╚╗           ║╔═╗║                 \r\n║╔╗╔╗║╔╗╔╗║║ ╔══╗╔══╗ ╔══╗╚╗╔╝╔══╗╔═╗    ║║ ╚╝╔══╗ ╔╗╔╗╔══╗╔══╗\r\n║║║║║║║║║║║║ ║╔═╝╚ ╗║ ║══╣ ║║ ║╔╗║║╔╝    ║║╔═╗╚ ╗║ ║╚╝║║╔╗║║══╣\r\n║║║║║║║╚╝║║╚╗║╚═╗║╚╝╚╗╠══║ ║╚╗║║═╣║║     ║╚╩═║║╚╝╚╗║║║║║║═╣╠══║\r\n╚╝╚╝╚╝╚══╝╚═╝╚══╝╚═══╝╚══╝ ╚═╝╚══╝╚╝     ╚═══╝╚═══╝╚╩╩╝╚══╝╚══╝\r\n                                                               \r\n                                                               ");


Dictionary<string, int> attributes = new Dictionary<string, int>
{
    ["Stamina"] = 100,
    ["Hunger"] = 100,
    ["Thirst"] = 100,
    ["Health"] = 100
};



List<string> inventory = new List<string>();


/*void TypeWriter(string text)
{
    foreach (char c in text)
    {

    }
}*/

Dictionary<string, int> attributes = new Dictionary<string, int>
{
    ["Stamina"] = 100,
    ["Hunger"] = 100,
    ["Thirst"] = 100,
    ["Health"] = 100
};
List<string> inventory = new List<string>();

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
