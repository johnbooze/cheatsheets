class Person
{
    [string] $name
    hidden [ValidateRange(0,200)] [int] $age

    Person([string] $name, [int] $age)
    {
        $this.name = $name
        $this.age = $age
    }

    [void] HappyBirthday()
    {
        $this.age++
    }

    [string] Hello()
    {
        return "Hello $($this.name).  You are $($this.age) years old"
    }
}

[Person] $jack = [Person]::new('Jack', 25)
$jack.Hello()