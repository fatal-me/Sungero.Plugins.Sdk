using System;
using System.Security.Cryptography;

namespace Sungero.Cryptography.Shared
{
  /// <summary>
  /// Обёртка над алгоритмом хэширования.
  /// </summary>
  public sealed class HashAlgorithmWrapper
  {
    #region Поля и свойства

    /// <summary>
    /// Метод получения алгоритма хеширования.
    /// </summary>
    private readonly Func<HashAlgorithm> hashAlgorithmGetter;

    /// <summary>
    /// Идентификатор алгоритма хеширования.
    /// </summary>
    public string AlgorithmId { get; }

    #endregion

    #region Методы

    /// <summary>
    /// Посчитать хеш данных.
    /// </summary>
    /// <param name="source">Данные.</param>
    /// <returns>Хеш данных.</returns>
    public byte[] ComputeHash(byte[] source)
    {
      using (var hashAlgorithm = this.GetHashAlgorithm())
        return hashAlgorithm.ComputeHash(source);
    }

    /// <summary>
    /// Получить алгоритм хеширования.
    /// </summary>
    /// <returns>Алгоритм хеширования.</returns>
    public HashAlgorithm GetHashAlgorithm()
    {
      return this.hashAlgorithmGetter();
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="algorithmId">Идентификатор алгоритма хеширования.</param>
    /// <param name="hashAlgorithmGetter">Метод получения алгоритма хеширования.</param>
    public HashAlgorithmWrapper(string algorithmId, Func<HashAlgorithm> hashAlgorithmGetter)
    {
      this.AlgorithmId = algorithmId;
      this.hashAlgorithmGetter = hashAlgorithmGetter;
    }

    #endregion
  }
}
