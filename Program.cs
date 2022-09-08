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

do {
    Console.Clear();
    Console.WriteLine($"Current Score: {playerScore.Value}");
    playerScore.Value++;
}while(Console.ReadKey().Key != ConsoleKey.Enter);

File.WriteAllText(playerScore.Name + ".txt", playerScore.Value.ToString());

// class record uses get/init properties, struct record uses get/set properties
public record struct Score(string Name, int Value = 0);