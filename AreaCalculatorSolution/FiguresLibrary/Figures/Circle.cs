using System;

namespace FiguresLibrary
{
	/// <summary>
	/// Круг.
	/// </summary>
	class Circle : IFigure
	{
		#region Свойства
		/// <summary>
		/// Радиус круга.
		/// </summary>
		public double Radius
		{
			get
			{
				return radius;
			}
			set
			{
				if (value < 0)
				{
					throw new Exception("Значение радиуса не может быть меньше 0.");
				}

				radius = value;
				CalculateArea();
			}
		}

		/// <summary>
		/// Площадь круга.
		/// </summary>
		public double Area
		{
			get
			{
				return area;
			}
		}
		#endregion

		#region Поля
		/// <summary>
		/// Радиус круга.
		/// </summary>
		private double radius;

		/// <summary>
		/// Площадь круга.
		/// </summary>
		private double area;
		#endregion

		#region Методы
		/// <summary>
		/// Вычисление площади круга.
		/// </summary>
		public void CalculateArea()
		{
			area = Math.PI * radius * radius;
		}
		#endregion

		#region Конструкторы
		/// <summary>
		/// Инициалиация объекта.
		/// </summary>
		/// <param name="radius"> Значение радиуса. </param>
		public Circle(double radius)
		{
			try
			{
				Radius = radius;
			}
			catch (Exception e)
			{
				throw new ArgumentException("Неправильное значение радиуса.", e);
			}
		}
		#endregion
	}
}
