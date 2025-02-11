void TypeWriter(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

void RoomSay(int position, Dictionary<int, string> rooms)
{
    Console.WriteLine($"You are in the {rooms[position]}");
}

List<string> GivePlayer(string newItem, int manyItems, List<string> newInv)
{
    for (int i = manyItems; i >= 0; i--)
    {
        newInv.Add(newItem);
    }
    return newInv;
}

int turns = 0;
int oxygenLeft = 150; //i'm going to add the oxygen mechanic tmrw, after ~10 turns, you realise that you only have that much left.

Dictionary<string, string> communalArea = new Dictionary<string, string>()
{
    ["name"] = "Communal Area",
    ["north"] = "Sleeping Quarters",
    ["south"] = "Kitchen",
    ["east"] = "Command Centre",
    ["west"] = "Engine Room",
    ["description"] = "The smell of expired pizza fills the room. You never cleaned it very well."
};

Dictionary<string, string> CommandCentre = new Dictionary<string, string>()
{
    ["name"] = "Command Centre",
    ["east"] = "Communal Area",
    ["machine"] = "Pod Activator",
    ["description"] = "You enter the command centre. You see a red keycard slot."
}; //can we get jack to write all these out, also add the int value for location in the dictionary below. also switch out the strings for ints ig

Dictionary<int, string> gameboard = new Dictionary<int, string>
{
    [1] = "empty",
    [2] = "empty",
    [3] = "empty",
    [4] = "empty",
    [5] = "empty",
    [6] = "empty",
    [7] = "empty",
    [8] = "empty",
    [9] = "empty",
    [10] = "empty",
    [11] = "empty",
    [12] = "empty",
    [13] = "empty",
    [14] = "empty",
    [15] = "empty",
    [16] = "empty",
    [17] = "Sleeping Quarters",
    [18] = "empty",
    [19] = "empty",
    [20] = "empty",
    [21] = "empty",
    [22] = "empty",
    [23] = "empty",
    [24] = "empty",
    [25] = "empty"
};

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

while (true)
{
    Console.WriteLine("you play game");
}
int playerpos = 17; //start in the sleeping quarters
