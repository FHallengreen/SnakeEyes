namespace Domain;

public class Game
{

    private Dice _dice1 = default!;
    private Dice _dice2 = default!;
    private List<int> _highscores = new();

    public int Eye1 => _dice1.Dots;
    public int Eye2 => _dice2.Dots;

    public bool HasSnakeEyes => Eye1 == 1 && Eye2 == 2;

    public IReadOnlyList<int> HighScores => _highscores.AsReadOnly();
    public int Total { get; set; }

    public Game()
    {
        Initialize();
    }

    public void Initialize()
    {
        _dice1 = new Dice();
        _dice2 = new Dice();
        Total = 0;
    }

    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();
        if (HasSnakeEyes)
        {
            _highscores.Add(Total);
            Total = 0;
        }
        Total += Eye1 + Eye2;

    }

    public void Restart() {
        Initialize();
    }


}
