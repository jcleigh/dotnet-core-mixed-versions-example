namespace DotNetCoreTwoPointTwo.Lib
{
    public class DemoBoilerplate
    {
    	public string GetGreeting(string name)
    	{
    		return string.Format("Hello, {0}! Welcome to DotNetCoreTwoPointTwo.Lib.", name);
    	}

    	public int GetRandomNumber()
    	{
    		return new System.Random().Next(1, 100);
    	}

    	public void PrintDemo()
    	{
    		var greeting = GetGreeting("DemoUser");
    		var number = GetRandomNumber();
    		System.Console.WriteLine(greeting + " Your random number is: " + number);
    	}
    }
    }
}
