using UnityEngine;

public class PersonController : MonoBehaviour {

	private void Start()
	{
		Person person1 = new Person("한강", 180, 21);
		Person person2 = new Person ();

		Debug.Log (person1.name);
		Debug.Log (person2.name);

		person1.SetAge (30);
	}
}
