using System;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Интерфейс получателя данных от пользователя.
  /// </summary>
  public interface IUserInteractor
  {
    /// <summary>
    /// Получить ПИН-код от пользователя.
    /// </summary>
    /// <param name="pluginId">ИД плагина.</param>
    /// <param name="thumbprint">Отпечаток сертификата.</param>
    /// <param name="isForced">Признак принудительного запроса у пользователя, без использования кеширования.</param> 
    /// <param name="showWrongPinHint">Показать хинт, что предыдущий введенный ПИН-код был неверен.</param>
    /// <param name="pin">Пин-код.</param>
    /// <param name="isCacheValueUsed">Использовано значение из кеша.</param>
    /// <returns>True, если ПИН-код успешно получен, иначе - false.</returns>
    bool GetPin(Guid pluginId, string thumbprint, bool isForced, bool showWrongPinHint, out string pin, out bool isCacheValueUsed);

    /// <summary>
    /// Получить одноразовый пароль от пользователя.
    /// </summary>
    /// <param name="message">Локализованное сообщение, отображаемое пользователю.</param>
    /// <param name="showTextEdit">Показать поле ввода одноразового пароля.</param>
    /// <param name="showWrongOtpHint">Показать хинт, что предыдущий введенный одноразовый пароль был неверен.</param>
    /// <param name="otp">Одноразовый пароль.</param>
    /// <returns>True, если одноразовый пароль успешно получен, иначе - false.</returns>
    bool GetOtp(string message, bool showTextEdit, bool showWrongOtpHint, out string otp);
  }
}
