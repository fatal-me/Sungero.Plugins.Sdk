using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс логгера.
  /// </summary>
  public interface ILog
  {
    /// <summary>
    /// Info.
    /// </summary>
    /// <param name="value">Значение.</param>
    void Info(object value);

    /// <summary>
    /// Info.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    /// <param name="message">Сообщение.</param>
    void Info(Exception exception, string message);

    /// <summary>
    /// Debug.
    /// </summary>
    /// <param name="value">Значение.</param>
    void Debug(object value);

    /// <summary>
    /// Debug.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    /// <param name="message">Сообщение.</param>
    void Debug(Exception exception, string message);

    /// <summary>
    /// Trace.
    /// </summary>
    /// <param name="value">Значение.</param>
    void Trace(object value);

    /// <summary>
    /// Trace.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    /// <param name="message">Сообщение.</param>
    void Trace(Exception exception, string message);

    /// <summary>
    /// Warn.
    /// </summary>
    /// <param name="value">Значение.</param>
    void Warn(object value);

    /// <summary>
    /// Warn.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    /// <param name="message">Сообщение.</param>
    void Warn(Exception exception, string message);

    /// <summary>
    /// Error.
    /// </summary>
    /// <param name="value">Значение.</param>
    void Error(object value);

    /// <summary>
    /// Error.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    /// <param name="message">Сообщение.</param>
    void Error(Exception exception, string message);
  }
}
