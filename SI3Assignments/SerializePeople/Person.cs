using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializePeople
{
    [Serializable]
    class Person : IDeserializationCallback, ISerializable
    {
        private string _name;
        public string NameValue
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _birthDate;
        public DateTime BirthDateValue
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private Genders _gender;
        public Genders GenderValue
        {
            get { return _gender; }
            set { _gender = value; }
        }


        [NonSerialized]
        private int _age;
        public int AgeValue
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person()
        {
             
        }

        public Person(string name, DateTime birthDate, Genders gender)
        {
            NameValue = name;
            BirthDateValue = birthDate;
            GenderValue = gender;

            CalculateAge();
        }

        public void CalculateAge()
        {
            AgeValue = Math.Abs(DateTime.Today.Year - BirthDateValue.Year);
        }

        public void Serialize(string output)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }
        }

        public static Person Deserialize(string input)
        {
            Person deserializedPerson;

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                deserializedPerson = (Person)formatter.Deserialize(stream);
            }

            return deserializedPerson;
        }

        public override string ToString()
        {
            return $"Person Name = {NameValue}, BirthDate = {BirthDateValue}, Gender = {GenderValue}, Age = {AgeValue}";
        }

        public void OnDeserialization(object sender)
        {
            CalculateAge();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
