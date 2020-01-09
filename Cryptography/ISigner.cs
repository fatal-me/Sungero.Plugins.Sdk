using System.Security.Cryptography.X509Certificates;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Интерфейс класса подписания.
  /// </summary>
  public interface ISigner
  {
    /// <summary>
    /// Сертификат.
    /// </summary>
    X509Certificate2 Certificate { get; }

    /// <summary>
    /// Попытаться загрузить закрытый ключ сертификата.
    /// </summary>
    /// <returns>Признак успешности загрузки закрытого ключа.</returns>
    bool TryLoadPrivateKey();

    /// <summary>
    /// Выполнить инициализацию.
    /// </summary>
    /// <param name="certificate">Сертификат.</param>
    void Initialize(X509Certificate2 certificate);

    /// <summary>
    /// Подписать данные.
    /// </summary>
    /// <param name="data">Данные (массив байт).</param>
    /// <param name="hashAlgorithmWrapper">Обёртка над алгоритмом хэширования.</param>
    /// <returns>Подпись.</returns>
    byte[] SignData(byte[] data, HashAlgorithmWrapper hashAlgorithmWrapper);

    /// <summary>
    /// Проверить подпись данных.
    /// </summary>
    /// <param name="data">Данные (массив байт).</param>
    /// <param name="signature">Подписанные данные.</param>
    /// <param name="hashAlgorithmWrapper">Обёртка над алгоритмом хэширования.</param>
    /// <returns>True, если подпись верна.</returns>
    bool VerifySignature(byte[] data, byte[] signature, HashAlgorithmWrapper hashAlgorithmWrapper);

    /// <summary>
    /// Усилить подпись.
    /// </summary>
    /// <param name="signature">Подпись.</param>
    /// <returns>Усиленная подпись.</returns>
    byte[] EnhanceSignature(byte[] signature);
  }
}
