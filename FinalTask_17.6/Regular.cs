namespace FinalTask_17._6
{
	/// <summary>
	/// Метод расчёта процентной ставки для счетов типа "Обычный" 
	/// </summary>
	class Regular : CalculatorNew
	{
		public override void CalculateInterest(Account account)
		{
			if (account.Type == "Обычный")
			{
				// логику расчета оставил прежней
				// расчет процентной ставки обычного аккаунта по правилам банка
				account.Interest = account.Balance * 0.4;

				if (account.Balance < 1000)
					account.Interest -= account.Balance * 0.2;

				if (account.Balance < 50000)
					account.Interest -= account.Balance * 0.4;
			}
			else if (NextChain != null)
			{
				NextChain.CalculateInterest(account);
			}
		}
	}
}
