using HelloWorld.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    public class JsonCases
    {
        public void AddJsonProperty()
        {
            Pet pet = new Pet("Dog", "Chester", 15);

            // serialize to json and print Pet with json properties
            string jsonPet = JsonConvert.SerializeObject(pet, Formatting.Indented);
            Debug.WriteLine(jsonPet);

            // deserialize previously serialized object
            Pet petDeserialized = JsonConvert.DeserializeObject<Pet>(jsonPet);
            Debug.WriteLine(petDeserialized);
        }

        public void AddRequiredProperties()
        {
            Animal animal = new Animal ("Mole", "Tom", 0); // all fields are specified

            string jsonAnimal = JsonConvert.SerializeObject(animal, Formatting.Indented);
            Debug.WriteLine(jsonAnimal);

            Pet animalDeserialized = JsonConvert.DeserializeObject<Pet>(jsonAnimal);
            Debug.WriteLine(animalDeserialized);
        }

        public void DefaultAndDisallowNullNotSpecified() // Default property Name and DisallowNull property Age are not specified
        {
            Cat cat = new Cat();
            string jsonIncludeDefaultValues = JsonConvert.SerializeObject(cat);

            Cat cat2 = JsonConvert.DeserializeObject<Cat>(jsonIncludeDefaultValues);

            Debug.WriteLine(cat2.Name, cat2.Age);
        }

        public void RequiredAlwaysNotSpecified()
        {
            Animal animal = new Animal();
            animal.Type = "Elephant"; // Required.Always Alias is not specified

            string jsonAnimal = JsonConvert.SerializeObject(animal, Formatting.Indented); // Exception is thrown that property requires a value
            Debug.WriteLine(jsonAnimal);

        }

        public void DisallowNullIsNull()
        {
            Politician politician = new Politician(0, "Boris", null, 55, "President");

            string jsonPolitician = JsonConvert.SerializeObject(politician, Formatting.Indented); // Exception is thrown that property requires a non-null value
            Debug.WriteLine(jsonPolitician);

        }

        public void DeserializeStringWhereIntExpected()
        {
            Loan loan = new Loan();

            string json = @"{""id"":""four"", ""name"":""abc""}}";

            var loan2 = JsonConvert.DeserializeObject<Loan>(json); // Exception is thrown could not convert string to integer

            Debug.WriteLine(loan2);

        }
        

    }


}

