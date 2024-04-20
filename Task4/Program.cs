//------------------Events Handling-----------------

using Task4;

EventManager eventManager = new EventManager();

eventManager.AddEventHandler(Method1);
eventManager.AddEventHandler(Method2);

Console.WriteLine("Method Triggered ");
eventManager.TriggerEvent();

eventManager.RemoveEventHandler(Method2);

Console.WriteLine("After remove Method2");
eventManager.TriggerEvent();


static void Method1()
{
    Console.WriteLine("Method 1");
}
static void Method2()
{
    Console.WriteLine("Method 2");
}