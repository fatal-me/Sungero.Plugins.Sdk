using System;
using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс плагина.
  /// </summary>
  public interface IPlugin
  {
    /// <summary>
    /// Идентификатор.
    /// </summary>
    Guid Id { get; }

    /// <summary>
    /// Применить настройки.
    /// </summary>
    /// <param name="settings">Настройки плагина.</param>
    void ApplySettings(IReadOnlyDictionary<string, string> settings);
  }
}
