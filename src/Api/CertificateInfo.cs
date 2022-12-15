using System;
using System.Collections.Generic;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Класс для получения информации о сертификате.
  /// </summary>  
  public static class CertificateInfo
  {
    /// <summary>
    /// Получатель информации о сертификате.
    /// </summary>
    private static Lazy<ICertificateInfoGetter> certificateInfoGetter;
    
    /// <summary>
    /// Установить объект для получения информации о сертификате.
    /// </summary>
    /// <param name="certificateInfoGetter">Ленивый объект для получения информации о сертификате.</param>
    public static void SetCertificateInfoGetter(Lazy<ICertificateInfoGetter> certificateInfoGetter)
    {
      CertificateInfo.certificateInfoGetter = certificateInfoGetter;
    }

    /// <summary>
    /// Получить параметры сертификата.
    /// </summary>
    /// <returns>Параметры.</returns>  
    public static IDictionary<string, string> GetParameters()
    {
      CheckCertificateInfoGetter();

      return certificateInfoGetter.Value.GetParameters();
    }
    
    /// <summary>
    /// Проверить наличие объекта для получения информации о сертификате.
    /// </summary>
    private static void CheckCertificateInfoGetter()
    {
      if (certificateInfoGetter?.Value == null)
        throw new NullReferenceException("CertificateInfoGetter has no implementation.");
    }        
  }
}