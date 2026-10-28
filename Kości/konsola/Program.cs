int count;
do
{
    Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10)");
} while (!int.TryParse(Console.ReadLine(), out count) || count < 3 || count > 10);

char answer;
do
{
    int[] dice = RollDice(count);
    for (int i = 0; i < dice.Length; i++)
    {
        Console.WriteLine($"Kostka {i + 1}: {dice[i]}");
    }
    Console.WriteLine($"Liczba uzyskanych punktów: {CountPoints(dice)}");

    Console.WriteLine("Jeszcze raz? (t/n)");
    string input = Console.ReadLine() ?? "";
    answer = input.Length > 0 ? char.ToLower(input[0]) : 'n';
} while (answer == 't');

static int[] RollDice(int count)
{
    int[] dice = new int[count];
    for (int i = 0; i < count; i++)
    {
        dice[i] = Random.Shared.Next(1, 7);
    }
    return dice;
}

/*
************************************************
  nazwa:     CountPoints
  opis:      liczy punkty za rzut kośćmi - sumę oczek tych kości, których liczba oczek
             wypadła co najmniej dwa razy
  parametry: dice - tablica z liczbami oczek wyrzuconymi na kolejnych kościach
  zwracany typ i opis: int - liczba punktów za rzut
  autor:     Bartosz Bryniarski
************************************************
*/
static int CountPoints(int[] dice)
{
    int points = 0;
    for (int i = 0; i < dice.Length; i++)
    {
        int repeats = 0;
        for (int j = 0; j < dice.Length; j++)
        {
            if (dice[j] == dice[i])
            {
                repeats++;
            }
        }
        if (repeats >= 2)
        {
            points += dice[i];
        }
    }
    return points;
}
