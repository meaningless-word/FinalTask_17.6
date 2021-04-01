namespace FinalTask_17._6
{
	/// <summary>
	/// Метод расчёта процентной ставки для счетов типа "Зарплатный" 
	/// </summary>
	class Salary : CalculatorNew
	{
		public override void CalculateInterest(Account account)
		{
			if (account.Type == "Зарплатный")
			{
				// логику расчета оставил прежней
				// расчет процентной ставк зарплатного аккаунта по правилам банка
				account.Interest = account.Balance * 0.5;
			}
			else if (NextChain != null)
			{
				NextChain.CalculateInterest(account);
			}
		}
	}
}
