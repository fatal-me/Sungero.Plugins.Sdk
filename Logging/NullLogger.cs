using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Null-логгер.
  /// </summary>
  internal sealed class NullLogger : ILog
  {
    #region Поля и свойства

    private static readonly Lazy<ILog> instance = new Lazy<ILog>(() => new NullLogger());

    /// <summary>
    /// Единственный экземпляр null-логгера.
    /// </summary>
    public static ILog Instance => instance.Value;

    #endregion

    #region ILog

    public void Debug(object value) { }

    public void Debug(Exception exception, string message) { }

    public void Error(object value) { }

    public void Error(Exception exception, string message) { }

    public void Info(object value) { }

    public void Info(Exception exception, string message) { }

    public void Trace(object value) { }

    public void Trace(Exception exception, string message) { }

    public void Warn(object value) { }

    public void Warn(Exception exception, string message) { }

    #endregion
  }
}
