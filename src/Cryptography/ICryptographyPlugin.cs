using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Sungero.Plugins.Sdk;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Интерфейс плагина криптографии.
  /// </summary>
  public interface ICryptographyPlugin : IPlugin
  {
    /// <summary>
    /// Проверить поддерживается ли данный алгоритм подписания плагином.
    /// </summary>
    /// <param name="signAlgorithmId">Иденетификатор алгоритма подписания.</param>
    /// <returns>True, если алгоритм подписания поддерживается плагином.</returns>
    bool IsSignAlgorithmSupported(string signAlgorithmId);

    /// <summary>
    /// Проверить поддерживается ли данный алгоритм хеширования плагином.
    /// </summary>
    /// <param name="hashAlgorithmId">Иденетификатор алгоритма подписания.</param>
    /// <returns>True, если алгоритм хеширования поддерживается плагином.</returns>
    bool IsHashAlgorithmSupported(string hashAlgorithmId);

    /// <summary>
    /// Получить идентификатор алгоритма хэширования по идентификатору алгоритма подписания.
    /// </summary>
    /// <param name="signAlgorithmId">Иденетификатор алгоритма подписания.</param>
    /// <returns>Идентификатор алгоритма хэширования.</returns>
    string GetHashAlgorithmIdBySignAlgorithmId(string signAlgorithmId);

    /// <summary>
    /// Получить обертку над алгоритмом хэширования.
    /// </summary>
    /// <param name="hashAlgorithmId">Идентификатор алгоритма хэширования.</param>
    /// <returns>Обёртка над алгоритмом хэширования.</returns>
    HashAlgorithmWrapper GetHashAlgorithmWrapperByHashAlgorithmId(string hashAlgorithmId);

    /// <summary>
    /// Получить класс для подписания по идентификатору алгоритма подписания.
    /// </summary>
    /// <param name="signAlgorithmId">Иденетификатор алгоритма подписания.</param>
    /// <returns>Класс для подписания.</returns>
    ISigner GetSignerBySignAlgorithmId(string signAlgorithmId);

    /// <summary>
    /// Получить список дополнительных сертификатов для построения цепочки сертификатов.
    /// </summary>
    /// <param name="certificate">Сертификат.</param>
    /// <returns>Список дополнительных сертификатов для построения цепочки сертификатов.</returns>
    IEnumerable<X509Certificate2> GetAdditionalCertificates(X509Certificate2 certificate);

    /// <summary>
    /// Выполнить проверку сертификата.
    /// </summary>
    /// <param name="certificate">Сертификат.</param>
    /// <param name="verificationDateTime">Время на которое осуществляется проверка.</param>
    /// <returns>Список ошибок по итогам проверки сертификата.</returns>
    IEnumerable<string> ValidateCertificate(X509Certificate2 certificate, DateTime verificationDateTime);

    /// <summary>
    /// Выполнить проверку подписи.
    /// </summary>
    /// <param name="dataSignature">Подпись.</param>
    /// <returns>Список ошибок по итогам проверки подписи.</returns>
    IEnumerable<string> VerifySignature(byte[] dataSignature);
  }
}
