void TypeWriter(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(50);
    }
    Console.WriteLine();
}
Console.WriteLine("╔═╗╔═╗    ╔╗               ╔╗            ╔═══╗                 \r\n║║╚╝║║    ║║              ╔╝╚╗           ║╔═╗║                 \r\n║╔╗╔╗║╔╗╔╗║║ ╔══╗╔══╗ ╔══╗╚╗╔╝╔══╗╔═╗    ║║ ╚╝╔══╗ ╔╗╔╗╔══╗╔══╗\r\n║║║║║║║║║║║║ ║╔═╝╚ ╗║ ║══╣ ║║ ║╔╗║║╔╝    ║║╔═╗╚ ╗║ ║╚╝║║╔╗║║══╣\r\n║║║║║║║╚╝║║╚╗║╚═╗║╚╝╚╗╠══║ ║╚╗║║═╣║║     ║╚╩═║║╚╝╚╗║║║║║║═╣╠══║\r\n╚╝╚╝╚╝╚══╝╚═╝╚══╝╚═══╝╚══╝ ╚═╝╚══╝╚╝     ╚═══╝╚═══╝╚╩╩╝╚══╝╚══╝\r\n                                                               \r\n                                                               ");
Dictionary<string, int> attributes = new Dictionary<string, int>
{
    ["Stamina"] = 100,
    ["Hunger"] = 100,
    ["Thirst"] = 100,
    ["Health"] = 100
};
List<string> inventory = new List<string>();
