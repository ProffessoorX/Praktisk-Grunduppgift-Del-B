public class Student

// Creating student class

{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        // Let Course.Enroll Controll both lists
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }

    public void Schedule()
    {
        Console.WriteLine($"{Name}s kurser:");

        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course}");
        }
    }

    public override string ToString() => Name;

}