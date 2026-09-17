// Creating courses 
// Fisrt we start with a list
public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        // No doubble registration
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är redan anmäld till {Name}.");
            return;
        }

        // Controll capacity 
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine($"Kursen {Name} är full.");
            return;
        }

        Students.Add(student);

        // Update students page
        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }
    }
    public void Remove(Student student)
    {
        // Remove kraschar inte om studenten saknas
        if (Students.Remove(student))
        {
            // Uppdatera även studentens sida
            student.Courses.Remove(this);
        }
    }

    public void RollCall()
    {
        Console.WriteLine($"Studerande i {Name}:");

        foreach (Student student in Students)
        {
            Console.WriteLine($"- {student}");
        }
    }

    public override string ToString() => $"{Name} ({Students.Count}/{MaxSeats} platser)";
}




