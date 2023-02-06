using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Получатель информации о сертификате.
  /// </summary>    
  public interface ICertificateInfoGetter
  {
    /// <summary>
    /// Получить параметры сертификата.
    /// </summary>
    /// <returns>Параметры.</returns>
    IDictionary<string, string> GetParameters();
  }
}