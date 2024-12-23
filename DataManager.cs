using UnityEngine;

public class PersonData
{
    public string Name;
    public int Age;
    public string Gender;
    public string Job;
}


public class DataManager : MonoBehaviour
{
    PersonData person1 = new PersonData() { Name = "안녕", Age = 28, Gender = "남성", Job = "회사원" };
    PersonData person2 = new PersonData() { Name = "백숙", Age = 29, Gender = "남성", Job = "공무원" };
        
    void Start()
    {
        string jsonTest = JsonUtility.ToJson(person1);
        string jsonTest2 = JsonUtility.ToJson(person2);

        PersonData person3 = JsonUtility.FromJson<PersonData> (jsonTest);
        print(person3.Name);
        print(person3.Age);
        print(person3.Gender);
        print(person3.Job);




    }

    // Update is called once per frame
    void Update()
    {

    }
}
