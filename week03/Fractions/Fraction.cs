// Fraction
// _top: int
// _bottom: int
// ========
// Fraction()
// Fraction(fullNum: int)
// Fraction(top: int, bottom: int)
// 
// GetTop()
// SetTop(top: int)
// GetBottom()
// SetBottom(bottom: int)
// 
// GetFractionString(): string
// GetDecimal(): double

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction (int top)
  {
    _top = top;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public int GetTop()
  {
    return _top;
  }

  public int SetTop(int top)
  {
    _top = top;
    return _top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public int SetBottom(int bottom)
  {
    _bottom = bottom;
    return _bottom;
  }

  public string GetFractionString()
  {
    return $"{_top}/{_bottom}";
  }

  public double GetDecimalValue()
  {
    return (double)_top / (double)_bottom;
  }
  
}