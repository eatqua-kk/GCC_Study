public class Person {

	private string name = "최윤혁";
	private	float tall;
	private int age = 20;

	public Person(string _name, float _tall, int _age)
	{
		this.name = _name;
		this.tall = _tall;
		this.age = _age;
	}

	public Person()
	{
		
	}

	public void SetAge(int age)
	{
		this.age = age;
	}
}