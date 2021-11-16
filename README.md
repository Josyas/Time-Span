# Time Span

<br/>• Representa uma DURAÇÃO
<br/>• É um tipo valor (struct)

Representação interna

<br/>Um objeto TimeSpan internamente armazena uma duração na forma 
<br/>de ticks (100 nanosegundos)
<br/>TimeSpan t1 = new TimeSpan(0, 1, 30);
<br/>Console.WriteLine(t1);
<br/>Console.WriteLine(t1.Ticks);

Link de referência: 
<br/>https://docs.microsoft.com/en-us/dotnet/api/system.timespan?redirectedfrom=MSDN&view=net-5.0
