namespace ClassTutorial;

/*
    To define a new class, use the `class` keyword followed by the class name.
    By convention, a calss name is in the Pascal case.
 */
class Person
{
    /*
        Add fields to the class
     */
    private string firstName;
    private string lastName;
    private byte age;

    /*
        Access modifiers:
        - public - field and method can be accessed from both inside and outside the class
        - private - default access modifier. Only allows to be accessed inside the same class
        - protected
        - internal
        - protected internal
        - private protected
     */

    /*
        Property
        Declare a property like a field with a `get` and `set` blocks, which is so called **property accessors**.
        - get - executed when reading from a property
        - set - executed when assigning a value to a property
     */
    public string FirstName
    {
        get { return firstName; }
        set
        {
            /*
                Data validation
             */
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The first name must not be empty or null!");
            }

            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The last name must not be empty or null!");
            }

            lastName = value;
        }
    }
    public byte Age
    {
        get { return age; }
        set
        {
            if (value > 150)
            {
                throw new ArgumentException("The age must be between 0 and 150!");
            }

            age = value;
        }
    }

    /*
        Create a computed property by implement the `get` accessor.
        Aware that it is not allow to assign a value to a property without a `set` accessor.
     */
    public string FullName
    {
        get { return $"{firstName} {lastName}"; }
    }

    /*
        If there's no additional logic in the `set` or `get` accessors, you can use an auto-implemented property.
        In C# 9 or later, initializing a auto-implemented property by assign a value to it is available.
     */
    public sbyte Rating { get; set; } = 1;

    /*
        Define a constructor

        A constructor is a special method whose name is the same as the class name.
        The constructor is special because of the following reasons:

            - A constructor doesn't have the return type.
            - When creating a new object, the C# compiler automatically calls the constructor.

        Typically, you use a constructor to initialize the new object by assigning values to the object's properties.

        The C# compiler implicitly creates a constructor without any parameter when defining a class.
        A Constructor without a parameter is called a **parameterless constructor**.
     */
    public Person(string firstName, string lastName)
        : this()
    {
        SetFirstName(firstName).SetLastName(lastName);
    }

    /*
        Constructor overload
        C# allows you to define multiple constructors with different parameters for a class.
     */
    public Person() { }

    public Person(string firstName, string lastName, byte age)
        : this(firstName, lastName)
    {
        /*
            FirstName = firstName;
            LastName = lastName;
        
            The code in the constructors is duplicated in initializing properties.
            Calling a constructor (`this()`) in another constructor may reduce some repeated code.

            ex.
            public Person()
            public Person(string firstName, string lastName) : this()
            public Person(string firstName, string lastName, byte age) : this(firstName, lastName)
         */
        SetAge(age);
    }

    /*
        Add methods to a class
     */
    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }

    public void PrintFullName()
    {
        Console.WriteLine(GetFullName());
    }

    public Person SetFirstName(string firstName)
    {
        /*
            `this` can't be ignored when there is an duplicate name existed.
         */
        this.firstName = firstName;
        return this;
    }

    public Person SetLastName(string lastName)
    {
        this.lastName = lastName;
        return this;
    }

    public Person SetAge(byte age)
    {
        this.age = age;
        return this;
    }
}

class ClassClientCode
{
    public ClassClientCode()
    {
        /*
            Create objects from the class.
         */
        var p1 = new Person() { FirstName = "Yvonne", LastName = "Lin" }; // by object initializer
        // or
        Person p2 = new("Victor", "Hsu", 3); // by constructor function

        Person p3 = new();

        p3.SetFirstName("Steak").SetLastName("Lin").PrintFullName(); // method chaining

        p1.PrintFullName();
        p2.PrintFullName();
    }
}
