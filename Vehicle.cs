// Hello 
namespace Animesh-Vehicle
{
	class Vehicle
{
	private Engine engine;
	private Wheel[] wheels;

	public Vehicle()
	{
		engine = new Engine();
		wheels = new Wheel[4]; 
		for (int i = 0; i < 4; i++)
		{
			wheels[i] = new Wheel();
		}
	}

	public void Start()
	{
		engine.Start();
		foreach (var wheel in wheels)
		{
			wheel.Rotate();
		}
		Console.WriteLine("The vehicle is starting.");
	}

}