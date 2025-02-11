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


void GameIntro()
{
    Console.WriteLine(""); // Add Intro Story Here

}
