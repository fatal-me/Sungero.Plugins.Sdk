using System;
using System.Runtime.Serialization;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Исключение плагина облачного подписания, текст которого показывается пользователю.
  /// </summary>
  [Serializable]
  public sealed class CloudSignPluginUserException : Exception
  {
    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="message">Сообщение.</param>
    public CloudSignPluginUserException(string message) : base(message)
    {
    }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="info">Сериализованные данные об исключении.</param>
    /// <param name="context">Информация о контексте.</param>
    private CloudSignPluginUserException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
