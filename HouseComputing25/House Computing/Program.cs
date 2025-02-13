using System.Runtime.CompilerServices;
using System.Text;
using System.Diagnostics;

Random gen = new Random();
void TypeWriter(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}

Dictionary<string, Dictionary<string, string>> roomDescriptions = new Dictionary<string, Dictionary<string, string>>
{
    ["Communal Area"] = new Dictionary<string, string>
    {
        ["coordinate"] = "12",
        ["name"] = "Communal Area",
        ["north"] = "Sleeping Quarters",
        ["south"] = "Kitchen",
        ["east"] = "Command Centre",
        ["west"] = "Corridor to Engine Room",
        ["Description"] = "The smell of expired pizza fills the room. You never cleaned it very well."
    },
    ["Command Centre"] = new Dictionary<string, string>
    {
        ["coordinate"] = "11",
        ["name"] = "Command Centre",
        ["east"] = "Communal Area",
        ["item"] = "Pod Activator",
        ["Description"] = "Buttons and switches are eveywhere under the monitor system. Flashing panels illuminate the room, and there is a small keyhole under a plexiglass cover."
    },
    ["Sleeping Quarters"] = new Dictionary<string, string>
    {
        ["coordinate"] = "17",
        ["name"] = "Sleeping Quarters",
        ["north"] = "Study",
        ["east"] = "Store Room",
        ["west"] = "Captain's Office",
        ["south"] = "Communal Area",
        ["Description"] = "The beds are neatly made, although covered in dust. A faint scent of old cologne can be smelt, with rubbish and banana peels scattered everywhere."
    },
    ["Captain's Quarters"] = new Dictionary<string, string>
    {
        ["coordinate"] = "16",
        ["name"] = "Captain's Quarters",
        ["east"] = "Communal Area",
        ["Description"] = "The desk is tidy, with a comfy leather chair tucked into it. A safe is neatly tucked under the desk."
    },
    ["Gym"] = new Dictionary<string, string>
    {
        ["coordinate"] = "6",
        ["name"] = "Gym",
        ["east"] = "Kitchen",
        ["Description"] = "The smell of sweat lingers around the room. Weight racks and treadmills are stacked neatly near the exit, with corpses lying over the sweaty gym machines."
    },
    ["Engine Room"] = new Dictionary<string, string>
    {
        ["coordinate"] = "14",
        ["name"] = "Engine Room",
        ["north"] = "Corridor to Escape Pods",
        ["south"] = "Corridor to Warp Core",
        ["west"] = "Corridor to Communal Area",
        ["Description"] = "The engines hum quietly but constantly. Goopy, viscous oil drips from the side of the fuel canisters, which are neatly stacked by the entrance."
    },
    ["Kitchen"] = new Dictionary<string, string>
    {
        ["coordinate"] = "7",
        ["name"] = "Kitchen",
        ["north"] = "Communal Area",
        ["Description"] = "The kitchen smells faintly of old food, though the counters are clean. A golden gun rests on one of the countertops, although it seems broken."
    },
    ["Study"] = new Dictionary<string, string>
    {
        ["coordinate"] = "22",
        ["name"] = "Study",
        ["south"] = "Sleeping Quarters",
        ["Description"] = "Bookshelves line the rooms, full of findings from other astronauts. An ocarina sits in the corner, although it looks eroded by time.",
    },
    ["Escape Pods"] = new Dictionary<string, string>
    {
        ["coordinate"] = "24",
        ["name"] = "Escape Pods",
        ["south"] = "Corridor to Engine Room",
        ["Description"] = "All the escape pods are gone, except for one. It seems to be locked but a sign reads 'UNLOCK FROM COMMAND CENTRE'."
    },
    ["Storeroom"] = new Dictionary<string, string>
    {
        ["coordinate"] = "18",
        ["name"] = "Storeroom",
        ["west"] = "Sleeping Quarters",
        ["item"] = "Keycard",
        ["Description"] = "The shelves look freshly stocked, and untouched. Most of the boxes seem pristine or untouched, although the box for whips, cowboy hats and small golden statues have been ransacked, where a keycard now lays."
    },
    ["Warp Core"] = new Dictionary<string, string>
    {
        ["coordinate"] = "4",
        ["name"] = "Warp Core",
        ["north"] = "Warp Core Corridor",
        ["Description"] = "The warp core pulses silently, with a faint glow in the dim room. The room is quite chilly, to store the core at the right temperature."
    },
    ["Warp Core Corridor"] = new Dictionary<string, string>
    {
        ["coordinate"] = "9",
        ["name"] = "Warp Core Corridor",
        ["north"] = "Engine Room",
        ["south"] = "Warp Core",
        ["Description"] = "It's a corridor."
    },
    ["Escape Pods Corridor"] = new Dictionary<string, string>
    {
        ["coordinate"] = "19",
        ["name"] = "Escape Pods Corridor",
        ["north"] = "Warp Core",
        ["south"] = "Engine Room",
        ["Description"] = "It's a corridor."
    },
    ["Engine Corridor"] = new Dictionary<string, string>
    {
        ["coordinate"] = "13",
        ["name"] = "Engine Corridor",
        ["left"] = "Communal Area",
        ["right"] = "Engine Room",
        ["Description"] = "It's a corridor."
    }
};

//can we get jack to write all these out, also add the int value for location in the dictionary below. also switch out the strings for ints ig

Dictionary<int, string> gameboard = new Dictionary<int, string>
{
    [4] = "Warp Core",
    [6] = "Gym",
    [7] = "Kitchen",
    [9] = "Warp Core Corridor",
    [11] = "Command Centre",
    [12] = "Communal Area",
    [13] = "Engine Corridor",
    [14] = "Engine Room",
    [16] = "Captain's Quarters",
    [17] = "Sleeping Quarters",
    [18] = "Storeroom",
    [19] = "Escape Pods Corridor",
    [22] = "Study",
    [24] = "Escape Pods",
};

Dictionary<string, int> player = new Dictionary<string, int>
{
    //["Stamina"] = 100,
    //["Hunger"] = 100,
    //["Thirst"] = 100,
    ["Health"] = 50,
    //["Oxygen"] = 150,
    ["Position"] = 0,
    ["Turn"] = 0,
};

string RoomSay(int position)
{
    string currentRoom = gameboard[position];
    return currentRoom;
}


List<string> inventory = new List<string>();

void GivePlayer(string newItem)
{   
    inventory.Add(newItem);
}

/*string[] GetMainInput(string prompt, string room)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < player["Health"]; i++)
    {
        Console.Write("#");
    }
    for (int i = 0; i < 50 - player["Health"]; i++)
    {
        Console.Write("-");
    }
    TypeWriter($"]HP       Location: {room}");
    TypeWriter($"{prompt}");
    if (roomDescriptions.ContainsKey(room["item"])) 
    {
        TypeWriter($"The room contains a {roomDescriptions[room]["item"]}.");
    }
    string inputog = null;
    while (inputog == null)
    {
        Console.Write("> ");
    }
    inputog = Console.ReadLine().ToLower();
    string[] input = inputog.Split(' ');
    return input;
}*/

string[] GetInput(string prompt, string room)
{
    TypeWriter($"{prompt}");
    string inputog = null;
    while (inputog == null)
    {
        Console.Write("> ");
    }
    inputog = Console.ReadLine().ToLower();
    string[] input = inputog.Split(' ');
    return input;
}

int MoveUp(int pos)
{
    pos += 5;
    return pos;
}

int MoveDown(int pos)
{
    pos -= 5;
    return pos;
}

int MoveRight(int pos)
{
    pos += 1;
    return pos;
}

int MoveLeft(int pos)
{
    pos -= 1;
    return pos;
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
    Console.WriteLine("Game Instructions: \n" +
        "- use move [up/down/left/right] to move around the map \n" +
        "- use get [object] to add an object to your inventory \n" +
        "- use the map command to look at a map of the spacecraft \n" +
        "- have fun!\n" +
        "Your spacecraft is stranded in space. Your communications array has been destroyed. Your crew has died to a virus. You, being a " +
        "doctor, have managed to find a temporary anecdote but need to get off the craft as soon as possible. You know that the captain " +
        "kept a hidden keycard in the storeroom to their safe, and that the safe contains the keycard which unlocks the escape pods from " +
        "the command centre. Oxygen is running out. Hurry, astronaut.");
    Thread.Sleep(1500);
    Console.WriteLine("Hurry, or die...");
    Console.WriteLine("Press enter to start...");
    Console.ReadLine();
    Console.Clear();
}

bool guessCode()
{
    bool isFixed = false;
    Console.WriteLine($"Guess the captain's code! Guess the 4 digit code.");
    int toGuess = gen.Next(1, 9999);
    string code = toGuess.ToString("D4"); // Ensures the code is always 4 digits.
    StringBuilder output = new StringBuilder("XXXX");

    while (!isFixed)
    {
        string guess = "";
        while (guess.Length != 4)
        {
            Console.WriteLine("Guess the number: ");
            guess = Console.ReadLine();
        }

        for (int i = 0; i < 4; i++)
        {
            if (code[i] == guess[i])
            {
                output[i] = code[i];
            }
        }

        if (output.ToString() == code)
        {
            isFixed = true;
        }
        else
        {
            Console.WriteLine($"You know {output}");
        }
    }
    TypeWriter($"You correctly guessed {output}");
    return isFixed;
}



GameIntro();
player["Position"] = 17; //start in the sleeping quarters
bool warpCoreWorking = true;
bool engineWorking = true;
int faultCountdown = 7;
int prevFaultCountdown = faultCountdown;
bool podsUnlocked = false;
int turns = 35;

string errorMessage(int countdown)
{
    string output = null;
    if (!warpCoreWorking)
    {
        output = $"The warp core is broken. Move towards it. You have {countdown} turns before the ship goes.";
    }
    else if (!engineWorking)
    {
        output = $"The engine is broken. Move towards it. You have {countdown} turns before the ship goes.";
    }
    else
    {
        output = "Everything seems to be working for now...";
    }
    return output;
}

while (player["Health"] > 0)
{
    int playerpos = player["Position"];
    string roomName = gameboard[playerpos];
    var room = roomDescriptions[roomName];
    string currentRoomDesc = room["Description"];
    bool validinput = false;
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < player["Health"]; i++)
    {
        Console.Write("#");
    }
    for (int i = 0; i < 30 - player["Health"]; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine($"]HP       Location: {roomName}       Time left: {turns - player["Turn"]}");
    if (!warpCoreWorking || !engineWorking)
    {
        if (faultCountdown <= prevFaultCountdown - 3)
        {
            if (gen.Next(1, 5) < 3)
            {
                int damage = gen.Next(1, 8) + 2;
                player["Health"] -= damage;
                TypeWriter($"The ship suddenly jolts. You take {damage} damage. You should fix it as soon as possible.");
            }
        }
        faultCountdown--;
    }
    else if (player["Turn"] > 3 && warpCoreWorking && engineWorking)
    {
        int disaster = gen.Next(1, 20);
        if (disaster < 5)
        {
            warpCoreWorking = false;
        }
        else if (disaster <= 9)
        {
            engineWorking = false;
        }
    }
    if (warpCoreWorking == false && roomName == "Warp Core")
    {
        TypeWriter("The warp core is pulsating with unbridled power. You need to fix this, quick.");
        int one = gen.Next(1, 100);
        int two = gen.Next(1, 100);
        TypeWriter($"Do some quick maths to fix the warp core. {one}x{two} = ");
        if (int.Parse(Console.ReadLine()) == one * two)
        {
            warpCoreWorking = true;
            faultCountdown = prevFaultCountdown;
        }
        else
        {
            TypeWriter("That's wrong, you'll need to try again next round.");
        }
    }
    else if (engineWorking == false && roomName == "Engine Room")
    {
        TypeWriter("The sublight engine is sputtering and slightly on fire. You need to fix this, quick.");
        int one = gen.Next(1, 100);
        int two = gen.Next(1, 100);
        TypeWriter($"Do some quick maths to fix the engine. {one}x{two} = ");
        if (int.Parse(Console.ReadLine()) == one * two)
        {
            warpCoreWorking = true;
            faultCountdown = prevFaultCountdown;
        }
        else
        {
            TypeWriter("That's wrong, you'll need to try again next round.");
        }
    }
    if (roomName == "Captain's Quarters" && inventory.Contains("Keycard"))
    {
        TypeWriter("You find the safe hidden under the captain's guess. You swipe the keycard and a combination lock comes out. You don't know the code, but you put your ear to the lock and begin guessing.");
        guessCode();
        TypeWriter("You hear a series of clicks and you find a little red key labelled ESCAPE PODS in the bottom of it. You pick it up.");
        GivePlayer("Podkey");
    }
    else if (roomName == "Command Centre" && inventory.Contains("Podkey"))
    {
        TypeWriter("You find the keyhole under a plexiglass wall that says FOR EMERGENCIES ONLY. You insert the key into the lock and turn it, and an automated sound says 'ESCAPE PODS ACTIVATED'.");
        podsUnlocked = true;
    }
    if (roomName == "Escape Pods" && podsUnlocked)
    {
        break;
    }
    TypeWriter(errorMessage(faultCountdown));
    TypeWriter($"{currentRoomDesc}");
    string inventoryString = "Your inventory contains: ";
    for (int i = 0; i < inventory.Count; i++)
    {
        inventoryString += $"{inventory[i].ToString()}, ";
    }
    if (inventoryString != "Your inventory contains: ")
    {
        TypeWriter(inventoryString.Substring(0, inventoryString.Length - 2));
    }
    if (roomDescriptions[roomName].ContainsKey("item"))
    {
        TypeWriter($"The room contains a {roomDescriptions[roomName]["item"]}.");
    }
    //string[] input = GetMainInput(currentRoomDesc, roomName);
    while (!validinput) //keeps going until we get a valid input
    {
        validinput = true;
        string inputog = null;
        while (inputog == null)
        {
            Console.Write("> ");
            inputog = Console.ReadLine().ToLower();
        }
        Debug.WriteLine("input got");
        string[] input = inputog.Split(' ');
        if (input[0] == "move")
        {
            if (input[1] == "up" && gameboard.ContainsKey(MoveUp(playerpos)) && room.TryGetValue("north", out string value))
            {
                playerpos = MoveUp(playerpos);
            }
            else if (input[1] == "down" && gameboard.ContainsKey(MoveDown(playerpos)) && room.TryGetValue("south", out string value2))
            {
                playerpos = MoveDown(playerpos);
            }
            else if (input[1] == "left" && gameboard.ContainsKey(MoveLeft(playerpos)) && room.TryGetValue("west", out string value3))
            {
                playerpos = MoveLeft(playerpos);
            }
            else if (input[1] == "right" && gameboard.ContainsKey(MoveRight(playerpos)) && room.TryGetValue("east", out string value4))
            {
                playerpos = MoveRight(playerpos);
            }
            else
            {
                TypeWriter("Not a valid move! Try again.");
                validinput = false;
            }
        }
        else if (input[0] == "get")
        {
            if (room["item"].ToLower() == input[1])
            {
                GivePlayer(roomDescriptions[roomName]["item"]);
            }
            else
            {
                validinput = false;
            }
        }
        else if (input[0] == "map")
        {
            Console.WriteLine("+-------------------------+-------------------------+-------------------------+-------------------------+\r\n" +
                "|                         |        Study            |                         |        Escape pods      |\r\n" +
                "|                         |                         |                         |        (escape)         |\r\n" +
                "+-------------------------+----------   ------------+-------------------------+----------   ------------+\r\n" +
                "|    Captain's Office     |       Sleeping          |        Store Room       |                         |\r\n" +
                "|   (command centre key)          Quarters               (find key to safe)   |                         |\r\n" +
                "+-------------------------+----------   ------------+-------------------------+----------   ------------+\r\n" +
                "|                         |      Communal area      |                         |      Engine room        |\r\n" +
                "|   Command centre                                                                                      |\r\n" +
                "| (unlock escape pods)    |                         |                         |                         |\r\n" +
                "+-------------------------+----------   ------------+-------------------------+----------   ------------+\r\n" +
                "|        Gym                       Kitchen          |                         |                         |\r\n" +
                "+-------------------------+-------------------------+-------------------------+----------   ------------+\r\n" +
                "|                         |                         |                         |      Warp core          |\r\n" +
                "+-------------------------+-------------------------+-------------------------+-------------------------+");
            TypeWriter($"Your location is: {roomName}");
            validinput = false;
        }
        else
        {
            validinput = false;
        }
    }
    player["Position"] = playerpos;
    player["Turn"]++;
    if (player["Turn"] >= turns || faultCountdown == 0)
    {
        player["Health"] = 0;
    }
    TypeWriter("Press enter to continue...");
    Console.ReadLine();
}
if (player["Health"] <= 0)
{
    Console.Clear();
    Console.WriteLine("  _____\r\n /     \\\r\n| () () |\r\n \\  ^  /\r\n  |||||\r\n  |||||");
    TypeWriter("You failed! This game will self-destruct in 5 seconds, LOSER...");
    Thread.Sleep(5000);
    Environment.Exit(0);
}
else
{
    TypeWriter("You clamber into an escape pod and close the door behind you. You strap yourself in and blast off. You take one last look at the spacecraft that had been your home, and still houses the corpses of your best friends. You sigh. Time to restore communications.");
    Thread.Sleep(10000);
    Console.Clear();
    TypeWriter("Well done! You escaped. You get a virtual chocolate.");
    Console.WriteLine("    __________________,.............,    \r\n   /_/_/_/_/_/_/_/_/,-',  ,. -,-,--/|\r\n  /_/_/_/_/_/_/_/,-' //  /-| / /--/ /\r\n /_/_/_/_/_/_/,-' `-''--'  `' '--/ /\r\n/_/_/_/_/_/_,:................../ /\r\n|________,'            chocolate|/\r\n         \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"'");
    Console.ReadLine();
}