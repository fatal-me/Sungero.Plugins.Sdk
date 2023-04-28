using System.Security.Cryptography.X509Certificates;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Плагин упрощенного подписания.
  /// </summary>
  public interface ISimpleCryptographyPlugin : ICryptographyPlugin
  {
    /// <summary>
    /// Подписать.
    /// </summary>
    /// <param name="dataProvider">Поставщик данных.</param>
    /// <param name="certificate">Сертификат.</param>
    /// <returns>Подпись.</returns>
    byte[] Sign(ICryptographyPluginDataProvider dataProvider, X509Certificate2 certificate);

    /// <summary>
    /// Проверить подпись данных.
    /// </summary>
    /// <param name="dataProvider">Поставщик данных.</param>
    /// <param name="signature">Подписанные данные.</param>
    /// <returns>True, если подпись верна.</returns>
    bool VerifySignature(ICryptographyPluginDataProvider dataProvider, byte[] signature);
  }
}
