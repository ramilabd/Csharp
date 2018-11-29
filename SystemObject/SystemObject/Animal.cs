using System;

namespace SystemObject
{
	class Animal
	{
		/*Метод Equals принимает в качестве параметр объект любого типа, который мы затем приводим к текущему, 
		 * если они являются объектами одного класса. Затем сравниваем по именам. Если имена равны, возвращаем true, 
		 * что будет говорить, что объекты равны.*/
		public string Name { get; set; }
		public override bool Equals(object obj)
		{
			if(obj.GetType() != this.GetType())
			{
				return false;

				Animal anim = (Animal)obj;
				return (this.Name == anim.Name);
			}
			else
			{
				return true; 
			}
		}
	}
}
