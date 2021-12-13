using Microsoft.Extensions.Logging;

namespace Northwind.Common.DataContext.Sqlite
{
	public class ConsoleLoggerFactory : ILoggerFactory
	{
		public void AddProvider(ILoggerProvider provider){}

		public ILogger CreateLogger(string categoryName)
		{
			return new ConsoleLogger();
		}

		public void Dispose(){}
	}

	public class ConsoleLogger : ILogger
	{
		public IDisposable BeginScope<TState>(TState state)
		{
			return null;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return logLevel switch
			{
				LogLevel.Trace or LogLevel.Information or LogLevel.None => false,
				_ => true,
			};
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
		{
			if (eventId.Id == 20100)
			{
				Console.Write($"Level: {logLevel}, Event Id: {eventId.Id}");

				if (state != null)
				{
					Console.Write($", State: {state}");
				}

				if (exception != null)
				{
					Console.Write($", Exception: {exception}");
				}

				Console.WriteLine();
			}
		}
	}
}
