// Creating course and student objects 

Course math = new Course("Matematik", 2);
Course programming = new Course("Programmering", 3);

Student anna = new Student("Anna");
Student erik = new Student("Erik");
Student sara = new Student("Sara");

// Registration from students side 
anna.Join(math);

// registration from courses side
math.Enroll(erik);

// try to double register Anna
anna.Join(math);

// Course only has two spots
// so Sara cannot join 
sara.Join(math);

Console.WriteLine();

math.RollCall();

Console.WriteLine();

// Add courses from both ways
anna.Join(programming);
programming.Enroll(sara);

anna.Schedule();

Console.WriteLine();

// Anna leaves math from students side
anna.Leave(math);

math.RollCall();

Console.WriteLine();
anna.Schedule();

Console.WriteLine();

// there is a free spot in math
sara.Join(math);

math.RollCall();

Console.WriteLine();
sara.Schedule();

// Will not crash
// Sara is not in programming after this 
sara.Leave(programming);
sara.Leave(programming);