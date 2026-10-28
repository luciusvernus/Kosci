namespace Kosci;

public partial class MainPage : ContentPage
{
    private readonly Image[] diceImages;
    private int gameScore = 0;

    public MainPage()
    {
        InitializeComponent();
        diceImages = [Die1, Die2, Die3, Die4, Die5];
    }

    private void OnRollClicked(object? sender, EventArgs e)
    {
        int[] dice = new int[diceImages.Length];
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = Random.Shared.Next(1, 7);
            diceImages[i].Source = $"k{dice[i]}.jpg";
        }

        int points = CountPoints(dice);
        gameScore += points;
        RollResultLabel.Text = $"Wynik tego losowania: {points}";
        GameResultLabel.Text = $"Wynik gry: {gameScore}";
    }

    private void OnResetClicked(object? sender, EventArgs e)
    {
        foreach (Image image in diceImages)
        {
            image.Source = "question.jpg";
        }
        gameScore = 0;
        RollResultLabel.Text = "Wynik tego losowania: 0";
        GameResultLabel.Text = "Wynik gry: 0";
    }

    private static int CountPoints(int[] dice)
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
}
