

static async Task<string> FetchDataAsync()
{
    Console.Out.WriteLineAsync("Fetching Data from Server, wait...");

    await Task.Delay(3000);

    return "This is the data";
}

string data  = await FetchDataAsync();
Console.Out.WriteLine(data);