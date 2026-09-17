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

