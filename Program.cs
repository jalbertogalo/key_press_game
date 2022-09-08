// main method
Console.WriteLine("*** Key Press Game ***");
Console.Write("Enter you name: ");

string playerName = "";
while (playerName == "" && playerName != "*") {
    playerName = Console.ReadLine();
}

Score playerScore = new Score(playerName, 0);
if (!File.Exists(playerScore.Name + ".txt")) {
    File.WriteAllText(playerScore.Name + ".txt", playerScore.Value.ToString());
}
else {
    playerScore.Value = Convert.ToInt32(File.ReadAllText(playerName + ".txt"));
}

while(true) {
    Console.Clear();
    Console.WriteLine($"Current Score: {playerScore.Value}");
    if (Console.ReadKey().Key == ConsoleKey.Enter) break;
    playerScore.Value++;
}

File.WriteAllText(playerScore.Name + ".txt", playerScore.Value.ToString());

// class record uses get/init properties, struct record uses get/set properties
public record struct Score(string Name, int Value = 0);