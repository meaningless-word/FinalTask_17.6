using System;
using System.Collections.Generic;

namespace FinalTask_17._6
{
	class Program
	{
		static void Main(string[] args)
		{
			// допустим, есть у нас несколько счетов
			List<Account> accounts = new List<Account>() { 
				new Account() { Balance = 800, Type = "Обычный" },
				new Account() { Balance = 13800, Type = "Обычный" },
				new Account() { Balance = 51800, Type = "Обычный" },
				new Account() { Balance = 60000, Type = "Зарплатный" }
			};

			// расчёт старым способом
			foreach(Account account in accounts)
			{
				Calculator.CalculateInterest(account);
				Console.WriteLine(account.Interest);
			}

			Console.WriteLine();

			// из метода калькулятора можно выделить два звена и реализовать паттерн "Цепочка обязанностей"
			// для начала создадим абстрактный базовый класс калькулятора CalculatorNew
			// затем наследованием от базового калькулятора создаются независимые обработчики для обыного и зарплатного типов счетов: Regular и Salary
			// теперь создаюся экземпляры калькуляторов - звеньев цепочки
			CalculatorNew regular = new Regular();
			CalculatorNew salary = new Salary();
			// сцепляем звенья в цепь
			regular.NextChain = salary;
			// далее, снова рассчитываем процентную ставку для каждого счёта, передавая его в первое из звеньев цепи
			foreach (Account account in accounts)
			{
				regular.CalculateInterest(account);
				Console.WriteLine(account.Interest);
			}
			// зато теперь можно добавить метод расчёта для нового типа счёта, не затрагивая методы для имеющихся
		}
	}
}
