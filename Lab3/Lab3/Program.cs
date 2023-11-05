using Lab3;

/*
Osoba Osoba = new Osoba();
Osoba.Name = "Jan";
Console.WriteLine(Osoba.Name);
*/

/*
Student student = new Student("Jan", "Nowak", 23, "w12345");

Console.WriteLine(student.ToString());
*/

Person person = new Person("Adam", "Kowalski", 43);
person.View();

Book book = new Book("Harry Potter", person, "2012-12-12");
book.View();