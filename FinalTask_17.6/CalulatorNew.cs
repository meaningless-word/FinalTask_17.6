namespace FinalTask_17._6
{
	/// <summary>
	/// базовый класс калькулятора как стандарт звена цепи
	/// </summary>
	abstract class CalculatorNew
	{
		public CalculatorNew NextChain { get; set; }
		public abstract void CalculateInterest(Account account);
	}
}
