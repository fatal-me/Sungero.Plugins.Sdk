using System.Security.Cryptography.X509Certificates;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Плагин пакетного облачного подписания.
  /// </summary>
  public interface ICloudBatchSignPlugin
  {
    /// <summary>
    /// Подписать.
    /// </summary>
    /// <param name="dataProviders">Массив поставщиков данных.</param>
    /// <param name="certificate">Сертификат.</param>
    /// <returns>Массив подписей.</returns>
    byte[][] Sign(ICryptographyPluginDataProvider[] dataProviders, X509Certificate2 certificate);
  }
}