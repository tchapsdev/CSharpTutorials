namespace Csharp15;
public class Cell
{
    public bool IsBlocked { get; set; }
    public bool IsGoal { get; set; }
}

public class Grid
{
    private readonly Cell[,] cells;

    public int Height => cells.GetLength(0);
    public int Width => cells.GetLength(1);

    public Grid(int height, int width)
    {
        cells = new Cell[height, width];

        for (int r = 0; r < height; r++)
        {
            for (int c = 0; c < width; c++)
            {
                cells[r, c] = new Cell();
            }
        }
    }

    public Cell this[int row, int column]
    {
        get => cells[row, column];
    }
}
